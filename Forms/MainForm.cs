using Microsoft.EntityFrameworkCore;
using System.Xml.Serialization;

namespace DBTreeView
{
    public partial class MainForm : Form
    {
        private readonly ApplicationContext dbContext;

        public MainForm(ApplicationContext dbContext)
        {
            InitializeComponent();
            this.dbContext = dbContext;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadObjectsTree();
            splitContainer.Panel2Collapsed = true;
        }

        private void LoadObjectsTree()
        {
            treeView.Nodes.Clear();

            var links = dbContext.Links
                .Include(o => o.Child)
                .GroupBy(x => x.IdParent)
                .ToDictionary(keySelector: x => x.Key, elementSelector: x => x.Select(link => link.Child).ToList());

            var allChilds = links
                .SelectMany(x => x.Value)
                .Select(x => x.Id)
                .ToHashSet();

            var rootObjects = dbContext.Objects
                .Where(x => allChilds.Contains(x.Id) == false)
                .Include(o => o.Attributes);

            var queue = new Queue<(TreeNodeCollection root, Models.Object obj)>();

            foreach (var obj in rootObjects)
                queue.Enqueue((treeView.Nodes, obj));

            while (queue.Count > 0)
            {
                var pair = queue.Dequeue();
                var node = new TreeNode($"{pair.obj.Id}: {pair.obj.Product}");
                node.Tag = pair.obj.Id;

                pair.root.Add(node);

                if (links.TryGetValue(pair.obj.Id, out var children))
                {
                    foreach (var obj in children)
                    {
                        if (obj != null)
                            queue.Enqueue((node.Nodes, obj));
                    }
                }
            }
        }

        private void LoadObjectInfo()
        {
            descriptionOutput.Clear();

            var obj = GetSelectedObject(true);

            splitContainer.Panel2Collapsed = obj == null;

            if (obj != null)
            {
                var lines = new List<string>
                {
                    $"ID: {obj.Id}",
                    $"Type: {obj.Type}",
                    $"Product: {obj.Product}",
                };

                foreach (var item in obj.Attributes)
                    lines.Add($"{item.Name}: {item.Value}");

                var links = dbContext.Links
                    .Where(x => x.IdParent == obj.Id || x.IdChild == obj.Id)
                    .OrderBy(x => x.IdParent)
                    .ThenBy(x => x.IdChild)
                    .Include(x => x.Parent)
                    .Include(x => x.Child);

                foreach (var link in links)
                    lines.Add($"{link.Parent.Product} {link.LinkName} {link.Child.Product}");

                descriptionOutput.Items.AddRange(lines.Select(x => new ListViewItem(x)).ToArray());
            }
        }

        private Models.Object? GetSelectedObject(bool includeAttributes = false)
        {
            if (treeView.SelectedNode == null)
                return null;

            int objectId = (int)treeView.SelectedNode.Tag;

            if (includeAttributes)
                return dbContext.Objects
                    .Include(o => o.Attributes)
                    .FirstOrDefault(o => o.Id == objectId);
            else
                return dbContext.Objects
                    .FirstOrDefault(o => o.Id == objectId);
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            var form = new ObjectEditForm(dbContext);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadObjectsTree();
                LoadObjectInfo();
            }
        }

        private void btnEdit_Click(object sender, EventArgs e)
        {
            var obj = GetSelectedObject(true);
            var form = new ObjectEditForm(dbContext, obj);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadObjectsTree();
                LoadObjectInfo();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var obj = GetSelectedObject();

            if (obj != null)
            {
                dbContext.Objects.Remove(obj);
                dbContext.SaveChanges();
                LoadObjectsTree();

                splitContainer.Panel2Collapsed = true;
            }
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
                FileName = "backup",
                Filter = "XML file(*.xml)|*.xml",
                Title = "Ёкспорт в XML"
            };

            if (saveFileDialog.ShowDialog() == DialogResult.OK)
            {
                var data = new Models.Serialized.SerializedData(dbContext);
                var xmlSerializer = new XmlSerializer(typeof(Models.Serialized.SerializedData));

                using (FileStream fs = new FileStream(saveFileDialog.FileName, FileMode.OpenOrCreate))
                {
                    xmlSerializer.Serialize(fs, data);
                }
            }
        }

        private void btnEditLinks_Click(object sender, EventArgs e)
        {
            var form = new LinksEditForm(dbContext);

            if (form.ShowDialog() == DialogResult.OK)
            {
                LoadObjectsTree();
                LoadObjectInfo();
            }
        }

        private void treeView_AfterSelect(object sender, TreeViewEventArgs e)
        {
            LoadObjectInfo();
        }
    }
}