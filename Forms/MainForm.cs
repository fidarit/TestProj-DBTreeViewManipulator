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
            LoadData();
        }

        private void LoadData()
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
                .Include(o => o.Attributes)
                .ToList();

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
            var obj = GetSelectedObject(true);

            AddEditForm addEditForm = new AddEditForm(dbContext, obj);

            if (addEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            var obj = GetSelectedObject();

            if (obj != null)
            {
                dbContext.Objects.Remove(obj);
                LoadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            SaveFileDialog saveFileDialog = new SaveFileDialog()
            {
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
    }
}