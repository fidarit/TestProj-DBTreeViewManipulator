namespace DBTreeView
{
    public partial class ObjectEditForm : Form
    {
        private readonly ApplicationContext dbContext;
        private Models.Object? selectedObject;

        public ObjectEditForm(ApplicationContext dbContext, Models.Object? selectedObject = null)
        {
            InitializeComponent();

            this.dbContext = dbContext;
            this.selectedObject = selectedObject;

            if (selectedObject != null)
            {
                typeInput.Text = selectedObject.Type;
                productInput.Text = selectedObject.Product;

                foreach (var attribute in selectedObject.Attributes)
                {
                    var row = new DataGridViewRow()
                    {
                        Tag = attribute.Id
                    };
                    row.CreateCells(dgvAttributes, attribute.Name, attribute.Value);

                    dgvAttributes.Rows.Add(row);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedObject == null)
            {
                selectedObject = new Models.Object();
                dbContext.Objects.Add(selectedObject);
            }

            selectedObject.Type = typeInput.Text;
            selectedObject.Product = productInput.Text;

            //Удаляем лишние атрибуты
            var allIds = dgvAttributes.Rows
                .OfType<DataGridViewRow>()
                .Select(row => row.Tag as int?)
                .ToHashSet();

            selectedObject.Attributes.RemoveAll(x => allIds.Contains(x.Id) == false);

            //Применяем новые данные
            foreach (DataGridViewRow row in dgvAttributes.Rows)
            {
                var id = row.Tag as int?;
                var name = row.Cells[0].Value?.ToString();
                var value = row.Cells[1].Value?.ToString();

                Models.Attribute attrib;
                if (id.HasValue)
                    attrib = selectedObject.Attributes.First(a => a.Id == id);
                else
                {
                    attrib = new Models.Attribute();
                    selectedObject.Attributes.Add(attrib);
                }

                if (name?.Length > 0 && value?.Length > 0)
                {
                    attrib.Name = name;
                    attrib.Value = value;
                }
                else
                    selectedObject.Attributes.Remove(attrib);
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
