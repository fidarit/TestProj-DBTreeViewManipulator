namespace DBTreeView
{
    public partial class LinksEditForm : Form
    {
        private readonly ApplicationContext dbContext;

        public LinksEditForm(ApplicationContext dbContext)
        {
            InitializeComponent();

            this.dbContext = dbContext;

            foreach (var link in dbContext.Links)
            {
                var row = new DataGridViewRow()
                {
                    Tag = link.Id
                };
                row.CreateCells(gridView, link.IdParent, link.IdChild, link.LinkName);

                gridView.Rows.Add(row);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Удаляем лишние
            var allIds = gridView.Rows
                .OfType<DataGridViewRow>()
                .Select(row => row.Tag as int?)
                .ToHashSet();

            dbContext.Links
                .Where(link => allIds.Contains(link.Id) == false)
                .ToList()
                .ForEach(link => dbContext.Links.Remove(link));

            //Применяем новые данные
            foreach (DataGridViewRow row in gridView.Rows)
            {
                var id = row.Tag as int?;
                var parentItem = row.Cells[0].Value?.ToString();
                var childItem = row.Cells[1].Value?.ToString();
                var name = row.Cells[2].Value?.ToString();

                Models.Link link;
                if (id.HasValue)
                    link = dbContext.Links.First(a => a.Id == id);
                else
                {
                    link = new Models.Link();
                    dbContext.Links.Add(link);
                }

                if (int.TryParse(parentItem, out int parentId) && int.TryParse(childItem, out int childId) && name?.Length > 0)
                {
                    link.IdParent = parentId;
                    link.IdChild = childId;
                    link.LinkName = name;
                }
                else
                    dbContext.Links.Remove(link);
            }

            dbContext.SaveChanges();
            DialogResult = DialogResult.OK;
            Close();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.Cancel;
            Close();
        }
    }
}
