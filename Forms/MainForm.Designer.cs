namespace DBTreeView
{
    partial class MainForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            treeView = new TreeView();
            btnAdd = new Button();
            btnDelete = new Button();
            bottomLayoutPanel = new TableLayoutPanel();
            btnExport = new Button();
            splitContainer = new SplitContainer();
            rightLayoutPanel = new TableLayoutPanel();
            btnEdit = new Button();
            descriptionOutput = new ListView();
            bottomLayoutPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)splitContainer).BeginInit();
            splitContainer.Panel1.SuspendLayout();
            splitContainer.Panel2.SuspendLayout();
            splitContainer.SuspendLayout();
            rightLayoutPanel.SuspendLayout();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Dock = DockStyle.Fill;
            treeView.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point);
            treeView.Indent = 24;
            treeView.Location = new Point(0, 0);
            treeView.Name = "treeView";
            treeView.Size = new Size(512, 364);
            treeView.TabIndex = 0;
            treeView.AfterSelect += treeView_AfterSelect;
            // 
            // btnAdd
            // 
            btnAdd.Dock = DockStyle.Fill;
            btnAdd.Location = new Point(8, 8);
            btnAdd.Margin = new Padding(8);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(154, 48);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Dock = DockStyle.Fill;
            btnDelete.Location = new Point(178, 8);
            btnDelete.Margin = new Padding(8);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(154, 48);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // bottomLayoutPanel
            // 
            bottomLayoutPanel.ColumnCount = 3;
            bottomLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            bottomLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            bottomLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 20F));
            bottomLayoutPanel.Controls.Add(btnAdd, 0, 0);
            bottomLayoutPanel.Controls.Add(btnDelete, 1, 0);
            bottomLayoutPanel.Controls.Add(btnExport, 2, 0);
            bottomLayoutPanel.Dock = DockStyle.Bottom;
            bottomLayoutPanel.Location = new Point(0, 364);
            bottomLayoutPanel.Name = "bottomLayoutPanel";
            bottomLayoutPanel.RowCount = 1;
            bottomLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Percent, 100F));
            bottomLayoutPanel.Size = new Size(512, 64);
            bottomLayoutPanel.TabIndex = 5;
            // 
            // btnExport
            // 
            btnExport.Dock = DockStyle.Fill;
            btnExport.Location = new Point(348, 8);
            btnExport.Margin = new Padding(8);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(156, 48);
            btnExport.TabIndex = 4;
            btnExport.Text = "Выгрузить в XML";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // splitContainer
            // 
            splitContainer.Dock = DockStyle.Fill;
            splitContainer.Location = new Point(4, 4);
            splitContainer.Name = "splitContainer";
            // 
            // splitContainer.Panel1
            // 
            splitContainer.Panel1.Controls.Add(treeView);
            splitContainer.Panel1.Controls.Add(bottomLayoutPanel);
            splitContainer.Panel1MinSize = 128;
            // 
            // splitContainer.Panel2
            // 
            splitContainer.Panel2.Controls.Add(rightLayoutPanel);
            splitContainer.Panel2.Padding = new Padding(8);
            splitContainer.Panel2MinSize = 128;
            splitContainer.Size = new Size(792, 428);
            splitContainer.SplitterDistance = 512;
            splitContainer.TabIndex = 6;
            // 
            // rightLayoutPanel
            // 
            rightLayoutPanel.ColumnCount = 1;
            rightLayoutPanel.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 100F));
            rightLayoutPanel.Controls.Add(btnEdit, 0, 0);
            rightLayoutPanel.Controls.Add(descriptionOutput, 0, 2);
            rightLayoutPanel.Dock = DockStyle.Fill;
            rightLayoutPanel.Location = new Point(8, 8);
            rightLayoutPanel.Name = "rightLayoutPanel";
            rightLayoutPanel.RowCount = 3;
            rightLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 35F));
            rightLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 15F));
            rightLayoutPanel.RowStyles.Add(new RowStyle());
            rightLayoutPanel.RowStyles.Add(new RowStyle(SizeType.Absolute, 20F));
            rightLayoutPanel.Size = new Size(260, 412);
            rightLayoutPanel.TabIndex = 2;
            // 
            // btnEdit
            // 
            btnEdit.Dock = DockStyle.Fill;
            btnEdit.Location = new Point(3, 3);
            btnEdit.Name = "btnEdit";
            btnEdit.Size = new Size(254, 29);
            btnEdit.TabIndex = 0;
            btnEdit.Text = "Редактировать";
            btnEdit.UseVisualStyleBackColor = true;
            btnEdit.Click += btnEdit_Click;
            // 
            // descriptionOutput
            // 
            descriptionOutput.BackColor = SystemColors.Control;
            descriptionOutput.Dock = DockStyle.Fill;
            descriptionOutput.HeaderStyle = ColumnHeaderStyle.None;
            descriptionOutput.Location = new Point(3, 53);
            descriptionOutput.MultiSelect = false;
            descriptionOutput.Name = "descriptionOutput";
            descriptionOutput.Size = new Size(254, 356);
            descriptionOutput.TabIndex = 1;
            descriptionOutput.UseCompatibleStateImageBehavior = false;
            descriptionOutput.View = View.List;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 436);
            Controls.Add(splitContainer);
            MinimumSize = new Size(384, 192);
            Name = "MainForm";
            Padding = new Padding(4);
            Text = "DBTreeView";
            Load += MainForm_Load;
            bottomLayoutPanel.ResumeLayout(false);
            splitContainer.Panel1.ResumeLayout(false);
            splitContainer.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)splitContainer).EndInit();
            splitContainer.ResumeLayout(false);
            rightLayoutPanel.ResumeLayout(false);
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView;
        private Button btnAdd;
        private Button btnDelete;
        private TableLayoutPanel bottomLayoutPanel;
        private Button btnExport;
        private SplitContainer splitContainer;
        private Button btnEdit;
        private TableLayoutPanel rightLayoutPanel;
        private ListView descriptionOutput;
    }
}