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
            btnSave = new Button();
            btnExport = new Button();
            SuspendLayout();
            // 
            // treeView
            // 
            treeView.Dock = DockStyle.Top;
            treeView.Location = new Point(0, 0);
            treeView.Name = "treeView";
            treeView.Size = new Size(800, 392);
            treeView.TabIndex = 0;
            // 
            // btnAdd
            // 
            btnAdd.Location = new Point(12, 398);
            btnAdd.Name = "btnAdd";
            btnAdd.Size = new Size(75, 23);
            btnAdd.TabIndex = 1;
            btnAdd.Text = "Добавить";
            btnAdd.UseVisualStyleBackColor = true;
            btnAdd.Click += btnAdd_Click;
            // 
            // btnDelete
            // 
            btnDelete.Location = new Point(93, 398);
            btnDelete.Name = "btnDelete";
            btnDelete.Size = new Size(75, 23);
            btnDelete.TabIndex = 2;
            btnDelete.Text = "Удалить";
            btnDelete.UseVisualStyleBackColor = true;
            btnDelete.Click += btnDelete_Click;
            // 
            // btnSave
            // 
            btnSave.Location = new Point(174, 398);
            btnSave.Name = "btnSave";
            btnSave.Size = new Size(75, 23);
            btnSave.TabIndex = 3;
            btnSave.Text = "Сохранить";
            btnSave.UseVisualStyleBackColor = true;
            btnSave.Click += btnSave_Click;
            // 
            // btnExport
            // 
            btnExport.Location = new Point(255, 398);
            btnExport.Name = "btnExport";
            btnExport.Size = new Size(118, 23);
            btnExport.TabIndex = 4;
            btnExport.Text = "Выгрузить в XML";
            btnExport.UseVisualStyleBackColor = true;
            btnExport.Click += btnExport_Click;
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 436);
            Controls.Add(btnExport);
            Controls.Add(btnSave);
            Controls.Add(btnDelete);
            Controls.Add(btnAdd);
            Controls.Add(treeView);
            Name = "MainForm";
            Text = "DBTreeView";
            Load += MainForm_Load;
            ResumeLayout(false);
        }

        #endregion

        private TreeView treeView;
        private Button btnAdd;
        private Button btnDelete;
        private Button btnSave;
        private Button btnExport;
    }
}