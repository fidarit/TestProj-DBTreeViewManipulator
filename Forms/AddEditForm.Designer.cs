namespace DBTreeView
{
    partial class AddEditForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            btnSave = new Button();
            labelProduct = new Label();
            txtProduct = new TextBox();
            dgvAttributes = new DataGridView();
            btnCancel = new Button();
            ((System.ComponentModel.ISupportInitialize)dgvAttributes).BeginInit();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Location = new Point(120, 250);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 0;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // labelProduct
            // 
            labelProduct.AutoSize = true;
            labelProduct.Location = new Point(10, 10);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(93, 15);
            labelProduct.TabIndex = 1;
            labelProduct.Text = "Наименование:";
            // 
            // txtProduct
            // 
            txtProduct.Location = new Point(120, 10);
            txtProduct.Name = "txtProduct";
            txtProduct.Size = new Size(200, 23);
            txtProduct.TabIndex = 2;
            // 
            // dgvAttributes
            // 
            dgvAttributes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttributes.Location = new Point(10, 40);
            dgvAttributes.Name = "dgvAttributes";
            dgvAttributes.RowTemplate.Height = 25;
            dgvAttributes.Size = new Size(400, 200);
            dgvAttributes.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Location = new Point(240, 250);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(75, 23);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // AddEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(434, 281);
            Controls.Add(btnCancel);
            Controls.Add(dgvAttributes);
            Controls.Add(txtProduct);
            Controls.Add(labelProduct);
            Controls.Add(btnSave);
            Name = "AddEditForm";
            Text = "AddEditForm";
            Click += btnCancel_Click;
            ((System.ComponentModel.ISupportInitialize)dgvAttributes).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btnSave;
        private Label labelProduct;
        private TextBox txtProduct;
        private DataGridView dgvAttributes;
        private Button btnCancel;
    }
}