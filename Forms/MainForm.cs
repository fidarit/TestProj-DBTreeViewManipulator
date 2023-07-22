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

            var objects = dbContext.Objects
                .Include(o => o.Attributes)
                .ToList();

            foreach (var obj in objects)
            {
                TreeNode node = new TreeNode(obj.Product);
                node.Tag = obj.Id;

                foreach (var attribute in obj.Attributes)
                {
                    TreeNode attributeNode = new TreeNode($"{attribute.Name}: {attribute.Value}");
                    node.Nodes.Add(attributeNode);
                }

                treeView.Nodes.Add(node);
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
                .Include(o => o.Attributes)
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