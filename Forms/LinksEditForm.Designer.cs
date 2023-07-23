namespace DBTreeView
{
    partial class LinksEditForm
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
            gridView = new DataGridView();
            btnCancel = new Button();
            mainLayoutPanel = new TableLayoutPanel();
            Parent = new DataGridViewTextBoxColumn();
            ChildColumn = new DataGridViewTextBoxColumn();
            NameColumn = new DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)gridView).BeginInit();
            mainLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // btnSave
            // 
            btnSave.Dock = DockStyle.Fill;
            btnSave.Location = new Point(12, 309);
            btnSave.Margin = new Padding(8);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(237, 24);
            btnSave.TabIndex = 0;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // gridView
            // 
            gridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            gridView.Columns.AddRange(new DataGridViewColumn[] { Parent, ChildColumn, NameColumn });
            mainLayoutPanel.SetColumnSpan(gridView, 2);
            gridView.Dock = DockStyle.Fill;
            gridView.Location = new Point(12, 12);
            gridView.Margin = new Padding(8);
            gridView.Name = "gridView";
            gridView.RowTemplate.Height = 25;
            gridView.Size = new Size(490, 281);
            gridView.TabIndex = 3;
            // 
            // btnCancel
            // 
            btnCancel.Dock = DockStyle.Fill;
            btnCancel.Location = new Point(265, 309);
            btnCancel.Margin = new Padding(8);
            btnCancel.Name = "btnCancel";
            btnCancel.Size = new Size(237, 24);
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
            mainLayoutPanel.Controls.Add(gridView, 0, 0);
            mainLayoutPanel.Controls.Add(btnSave, 0, 1);
            mainLayoutPanel.Controls.Add(btnCancel, 1, 1);
            mainLayoutPanel.Dock = DockStyle.Fill;
            mainLayoutPanel.Location = new Point(0, 0);
            mainLayoutPanel.Name = "mainLayoutPanel";
            mainLayoutPanel.Padding = new Padding(4);
            mainLayoutPanel.RowCount = 2;
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 40F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            mainLayoutPanel.Size = new Size(514, 345);
            mainLayoutPanel.TabIndex = 5;
            // 
            // Parent
            // 
            Parent.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            Parent.HeaderText = "Parent";
            Parent.Name = "Parent";
            Parent.Resizable = DataGridViewTriState.True;
            Parent.SortMode = DataGridViewColumnSortMode.NotSortable;
            // 
            // ChildColumn
            // 
            ChildColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            ChildColumn.HeaderText = "Child";
            ChildColumn.Name = "ChildColumn";
            ChildColumn.Resizable = DataGridViewTriState.True;
            // 
            // NameColumn
            // 
            NameColumn.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
            NameColumn.HeaderText = "Название";
            NameColumn.Name = "NameColumn";
            // 
            // LinksEditForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(514, 345);
            Controls.Add(mainLayoutPanel);
            MinimumSize = new Size(384, 384);
            Name = "LinksEditForm";
            Text = "LinksEditForm";
            Click += btnCancel_Click;
            ((System.ComponentModel.ISupportInitialize)gridView).EndInit();
            mainLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private Button btnSave;
        private DataGridView gridView;
        private Button btnCancel;
        private TableLayoutPanel mainLayoutPanel;
        private DataGridViewTextBoxColumn Parent;
        private DataGridViewTextBoxColumn ChildColumn;
        private DataGridViewTextBoxColumn NameColumn;
    }
}