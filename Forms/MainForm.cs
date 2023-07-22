using Microsoft.EntityFrameworkCore;

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

        private void btnAdd_Click(object sender, EventArgs e)
        {
            AddEditForm addEditForm = new AddEditForm(dbContext);
            if (addEditForm.ShowDialog() == DialogResult.OK)
            {
                LoadData();
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (treeView.SelectedNode == null)
                return;

            int objectId = (int)treeView.SelectedNode.Tag;

            var obj = dbContext.Objects
                .FirstOrDefault(o => o.Id == objectId);

            if (obj != null)
            {
                dbContext.Objects.Remove(obj);
                dbContext.SaveChanges();
                LoadData();
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            dbContext.SaveChanges();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {

        }
    }
}