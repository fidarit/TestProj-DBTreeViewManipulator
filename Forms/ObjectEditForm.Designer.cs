namespace DBTreeView
{
    partial class ObjectEditForm
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
            productInput = new TextBox();
            dgvAttributes = new DataGridView();
            NameColumn = new DataGridViewTextBoxColumn();
            ValueColumn = new DataGridViewTextBoxColumn();
            btnCancel = new Button();
            mainLayoutPanel = new TableLayoutPanel();
            typeInput = new TextBox();
            label = new Label();
            typeLabel = new Label();
            ((System.ComponentModel.ISupportInitialize)dgvAttributes).BeginInit();
            mainLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(12, 289);
            btnSave.Margin = new Padding(8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(237, 44);
            btnSave.TabIndex = 0;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // labelProduct
            // 
            labelProduct.Anchor = AnchorStyles.Right;
            labelProduct.AutoSize = true;
            labelProduct.Location = new Point(161, 41);
            labelProduct.Name = "labelProduct";
            labelProduct.Size = new Size(93, 15);
            labelProduct.TabIndex = 1;
            labelProduct.Text = "Наименование:";
            // 
            // productInput
            // 
            productInput.Dock = DockStyle.Fill;
            productInput.Location = new Point(260, 37);
            productInput.Name = "productInput";
            productInput.Size = new Size(247, 23);
            productInput.TabIndex = 2;
            // 
            // dgvAttributes
            // 
            dgvAttributes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgvAttributes.Columns.AddRange(new DataGridViewColumn[] { NameColumn, ValueColumn });
            mainLayoutPanel.SetColumnSpan(dgvAttributes, 2);
            dgvAttributes.Dock = DockStyle.Fill;
            dgvAttributes.Location = new Point(12, 102);
            dgvAttributes.Margin = new Padding(8);
            dgvAttributes.Name = "dgvAttributes";
            dgvAttributes.RowTemplate.Height = 25;
            dgvAttributes.Size = new Size(490, 171);
            dgvAttributes.TabIndex = 3;
            // 
            // NameColumn
            // 
            NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NameColumn.HeaderText = "Название";
            NameColumn.Name = "NameColumn";
            // 
            // ValueColumn
            // 
            ValueColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ValueColumn.HeaderText = "Значение";
            ValueColumn.Name = "ValueColumn";
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Location = new Point(265, 289);
            btnCancel.Margin = new Padding(8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(237, 44);
            btnCancel.TabIndex = 4;
            btnCancel.Text = "Отмена";
            btnCancel.UseVisualStyleBackColor = true;
            btnCancel.Click += btnCancel_Click;
            // 
            // mainLayoutPanel
            // 
            mainLayoutPanel.ColumnCount = 2;
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 50F));
            mainLayoutPanel.Controls.Add(typeInput, 1, 0);
            mainLayoutPanel.Controls.Add(btnSave, 0, 4);
            mainLayoutPanel.Controls.Add(btnCancel, 1, 4);
            mainLayoutPanel.Controls.Add(dgvAttributes, 0, 3);
            mainLayoutPanel.Controls.Add(label, 0, 2);
            mainLayoutPanel.Controls.Add(typeLabel, 0, 0);
            mainLayoutPanel.Controls.Add(labelProduct, 0, 1);
            mainLayoutPanel.Controls.Add(productInput, 1, 1);
            mainLayoutPanel.Dock = DockStyle.Fill;
            mainLayoutPanel.Location = new Point(0, 0);
            mainLayoutPanel.Name = "mainLayoutPanel";
            mainLayoutPanel.Padding = new Padding(4);
            mainLayoutPanel.RowCount = 5;
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 30F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 60F));
            mainLayoutPanel.Size = new Size(514, 345);
            mainLayoutPanel.TabIndex = 5;
            // 
            // typeInput
            // 
            typeInput.Dock = DockStyle.Fill;
            typeInput.Location = new Point(260, 7);
            typeInput.Name = "typeInput";
            typeInput.Size = new Size(247, 23);
            typeInput.TabIndex = 7;
            // 
            // label
            // 
            label.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
            label.AutoSize = true;
            label.Location = new Point(7, 79);
            label.Name = "label";
            label.Size = new Size(64, 15);
            label.TabIndex = 5;
            label.Text = "Атрибуты:";
            // 
            // typeLabel
            // 
            typeLabel.Anchor = AnchorStyles.Right;
            typeLabel.AutoSize = true;
            typeLabel.Location = new Point(221, 11);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new Size(33, 15);
            typeLabel.TabIndex = 6;
            typeLabel.Text = "Тип: ";
            // 
            // AddEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 345);
            Controls.Add(mainLayoutPanel);
            MinimumSize = new Size(384, 384);
            Name = "AddEditForm";
            Text = "AddEditForm";
            Click += btnCancel_Click;
            ((System.ComponentModel.ISupportInitialize)dgvAttributes).EndInit();
            mainLayoutPanel.ResumeLayout(false);
            mainLayoutPanel.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private Label labelProduct;
        private TextBox productInput;
        private DataGridView dgvAttributes;
        private Button btnCancel;
        private DataGridViewTextBoxColumn NameColumn;
        private DataGridViewTextBoxColumn ValueColumn;
        private TableLayoutPanel mainLayoutPanel;
        private Label label;
        private Label typeLabel;
        private TextBox typeInput;
    }
}