namespace miniTC
{
    partial class TCPanel
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.ListViewItem listViewItem1 = new System.Windows.Forms.ListViewItem(new string[] {
            ""}, -1, System.Drawing.Color.Black, System.Drawing.Color.White, null);
            this.label_Path = new System.Windows.Forms.Label();
            this.button_Backwards = new System.Windows.Forms.Button();
            this.comboBoxDrives = new System.Windows.Forms.ComboBox();
            this.label_PathInfo = new System.Windows.Forms.Label();
            this.fileSystemWatcher1 = new System.IO.FileSystemWatcher();
            this.listView_Items = new System.Windows.Forms.ListView();
            this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).BeginInit();
            this.SuspendLayout();
            // 
            // label_Path
            // 
            this.label_Path.Location = new System.Drawing.Point(0, 0);
            this.label_Path.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_Path.Name = "label_Path";
            this.label_Path.Size = new System.Drawing.Size(451, 36);
            this.label_Path.TabIndex = 0;
            this.label_Path.Text = " ";
            this.label_Path.TextChanged += new System.EventHandler(this.label_Path_TextChanged);
            // 
            // button_Backwards
            // 
            this.button_Backwards.Location = new System.Drawing.Point(347, 39);
            this.button_Backwards.Margin = new System.Windows.Forms.Padding(4);
            this.button_Backwards.Name = "button_Backwards";
            this.button_Backwards.Size = new System.Drawing.Size(100, 26);
            this.button_Backwards.TabIndex = 1;
            this.button_Backwards.Text = "<<";
            this.button_Backwards.UseVisualStyleBackColor = true;
            this.button_Backwards.Click += new System.EventHandler(this.button_Backwards_Click);
            // 
            // comboBoxDrives
            // 
            this.comboBoxDrives.FormattingEnabled = true;
            this.comboBoxDrives.Location = new System.Drawing.Point(169, 39);
            this.comboBoxDrives.Margin = new System.Windows.Forms.Padding(4);
            this.comboBoxDrives.Name = "comboBoxDrives";
            this.comboBoxDrives.Size = new System.Drawing.Size(109, 24);
            this.comboBoxDrives.TabIndex = 2;
            this.comboBoxDrives.SelectedIndexChanged += new System.EventHandler(this.ComboBoxDrives_SelectedIndexChanged);
            this.comboBoxDrives.Click += new System.EventHandler(this.comboBoxDrives_Click);
            // 
            // label_PathInfo
            // 
            this.label_PathInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_PathInfo.Location = new System.Drawing.Point(97, 42);
            this.label_PathInfo.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label_PathInfo.Name = "label_PathInfo";
            this.label_PathInfo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.label_PathInfo.Size = new System.Drawing.Size(64, 23);
            this.label_PathInfo.TabIndex = 3;
            this.label_PathInfo.Text = "Path";
            // 
            // fileSystemWatcher1
            // 
            this.fileSystemWatcher1.EnableRaisingEvents = true;
            this.fileSystemWatcher1.SynchronizingObject = this;
            // 
            // listView_Items
            // 
            this.listView_Items.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader1});
            this.listView_Items.FullRowSelect = true;
            this.listView_Items.GridLines = true;
            this.listView_Items.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem1});
            this.listView_Items.Location = new System.Drawing.Point(4, 69);
            this.listView_Items.Margin = new System.Windows.Forms.Padding(4);
            this.listView_Items.Name = "listView_Items";
            this.listView_Items.Size = new System.Drawing.Size(441, 485);
            this.listView_Items.TabIndex = 1;
            this.listView_Items.UseCompatibleStateImageBehavior = false;
            this.listView_Items.View = System.Windows.Forms.View.List;
            this.listView_Items.MouseDoubleClick += new System.Windows.Forms.MouseEventHandler(this.listView_Items_MouseDoubleClick);
            // 
            // columnHeader1
            // 
            this.columnHeader1.Width = 310;
            // 
            // TCPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.Controls.Add(this.listView_Items);
            this.Controls.Add(this.label_PathInfo);
            this.Controls.Add(this.comboBoxDrives);
            this.Controls.Add(this.button_Backwards);
            this.Controls.Add(this.label_Path);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "TCPanel";
            this.Size = new System.Drawing.Size(451, 559);
            ((System.ComponentModel.ISupportInitialize)(this.fileSystemWatcher1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label_Path;
        private System.Windows.Forms.Button button_Backwards;
        private System.Windows.Forms.ComboBox comboBoxDrives;
        private System.Windows.Forms.Label label_PathInfo;
        private System.IO.FileSystemWatcher fileSystemWatcher1;
        private System.Windows.Forms.ListView listView_Items;
        private System.Windows.Forms.ColumnHeader columnHeader1;
    }
}
