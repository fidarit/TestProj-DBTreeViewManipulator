namespace DBTreeView
{
    public partial class AddEditForm : Form
    {
        private readonly ApplicationContext dbContext;
        private readonly Models.Object? selectedObject;

        public AddEditForm(ApplicationContext dbContext, Models.Object? selectedObject = null)
        {
            InitializeComponent();

            this.dbContext = dbContext;
            this.selectedObject = selectedObject;

            if (selectedObject != null)
            {
                txtProduct.Text = selectedObject.Product;
                foreach (var attribute in selectedObject.Attributes)
                {
                    dgvAttributes.Rows.Add(attribute.Name, attribute.Value);
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (selectedObject == null)
            {
                var newObj = new Models.Object
                {
                    Product = txtProduct.Text
                };

                foreach (DataGridViewRow row in dgvAttributes.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        newObj.Attributes.Add(new Models.Attribute
                        {
                            Name = row.Cells[0].Value.ToString(),
                            Value = row.Cells[1].Value.ToString()
                        });
                    }
                }

                dbContext.Objects.Add(newObj);
            }
            else
            {
                selectedObject.Product = txtProduct.Text;
                selectedObject.Attributes.Clear();

                foreach (DataGridViewRow row in dgvAttributes.Rows)
                {
                    if (row.Cells[0].Value != null && row.Cells[1].Value != null)
                    {
                        selectedObject.Attributes.Add(new Models.Attribute
                        {
                            Name = row.Cells[0].Value.ToString(),
                            Value = row.Cells[1].Value.ToString()
                        });
                    }
                }
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

        private void btnAddAttribute_Click(object sender, EventArgs e)
        {
            dgvAttributes.Rows.Add();
        }

        private void btnRemoveAttribute_Click(object sender, EventArgs e)
        {
            if (dgvAttributes.SelectedRows.Count > 0)
            {
                dgvAttributes.Rows.RemoveAt(dgvAttributes.SelectedRows[0].Index);
            }
        }
    }
}
