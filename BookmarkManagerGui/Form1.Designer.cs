namespace BookmarkManagerGui
{
    partial class BookmarkManagerForm
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
            this.listView1 = new System.Windows.Forms.ListView();
            this.ChName = new System.Windows.Forms.ColumnHeader();
            this.ChAddress = new System.Windows.Forms.ColumnHeader();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MiFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MiRefresh = new System.Windows.Forms.ToolStripMenuItem();
            this.MiExit = new System.Windows.Forms.ToolStripMenuItem();
            this.itemToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.MiEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MiOpen = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.CboFilter = new System.Windows.Forms.ComboBox();
            this.LblFilter = new System.Windows.Forms.Label();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.TsLblStatus = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // listView1
            // 
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ChName,
            this.ChAddress});
            this.listView1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.listView1.FullRowSelect = true;
            this.listView1.Location = new System.Drawing.Point(0, 58);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(800, 370);
            this.listView1.TabIndex = 0;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.DoubleClick += new System.EventHandler(this.listView1_DoubleClick);
            // 
            // ChName
            // 
            this.ChName.Text = "Name";
            // 
            // ChAddress
            // 
            this.ChAddress.Text = "Address";
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiFile,
            this.itemToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // MiFile
            // 
            this.MiFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiRefresh,
            this.MiExit});
            this.MiFile.Name = "MiFile";
            this.MiFile.Size = new System.Drawing.Size(37, 20);
            this.MiFile.Text = "File";
            // 
            // MiRefresh
            // 
            this.MiRefresh.Name = "MiRefresh";
            this.MiRefresh.ShortcutKeys = System.Windows.Forms.Keys.F5;
            this.MiRefresh.Size = new System.Drawing.Size(135, 22);
            this.MiRefresh.Text = "Refresh";
            this.MiRefresh.Click += new System.EventHandler(this.MiRefresh_Click);
            // 
            // MiExit
            // 
            this.MiExit.Name = "MiExit";
            this.MiExit.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
            this.MiExit.Size = new System.Drawing.Size(135, 22);
            this.MiExit.Text = "Exit";
            this.MiExit.Click += new System.EventHandler(this.MiExit_Click);
            // 
            // itemToolStripMenuItem
            // 
            this.itemToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MiEdit,
            this.MiOpen});
            this.itemToolStripMenuItem.Name = "itemToolStripMenuItem";
            this.itemToolStripMenuItem.Size = new System.Drawing.Size(43, 20);
            this.itemToolStripMenuItem.Text = "Item";
            // 
            // MiEdit
            // 
            this.MiEdit.Enabled = false;
            this.MiEdit.Name = "MiEdit";
            this.MiEdit.ShortcutKeys = System.Windows.Forms.Keys.F2;
            this.MiEdit.Size = new System.Drawing.Size(122, 22);
            this.MiEdit.Text = "Edit";
            // 
            // MiOpen
            // 
            this.MiOpen.Name = "MiOpen";
            this.MiOpen.ShortcutKeys = System.Windows.Forms.Keys.F6;
            this.MiOpen.Size = new System.Drawing.Size(122, 22);
            this.MiOpen.Text = "Open";
            this.MiOpen.Click += new System.EventHandler(this.MiOpen_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CboFilter);
            this.panel1.Controls.Add(this.LblFilter);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(800, 34);
            this.panel1.TabIndex = 2;
            // 
            // CboFilter
            // 
            this.CboFilter.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CboFilter.FormattingEnabled = true;
            this.CboFilter.Location = new System.Drawing.Point(51, 3);
            this.CboFilter.Name = "CboFilter";
            this.CboFilter.Size = new System.Drawing.Size(737, 23);
            this.CboFilter.TabIndex = 1;
            this.CboFilter.SelectedIndexChanged += new System.EventHandler(this.CboFilter_SelectedIndexChanged);
            this.CboFilter.TextChanged += new System.EventHandler(this.CboFilter_TextChanged);
            this.CboFilter.KeyDown += new System.Windows.Forms.KeyEventHandler(this.CboFilter_KeyDown);
            // 
            // LblFilter
            // 
            this.LblFilter.AutoSize = true;
            this.LblFilter.Location = new System.Drawing.Point(12, 6);
            this.LblFilter.Name = "LblFilter";
            this.LblFilter.Size = new System.Drawing.Size(33, 15);
            this.LblFilter.TabIndex = 0;
            this.LblFilter.Text = "Filter";
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TsLblStatus});
            this.statusStrip1.Location = new System.Drawing.Point(0, 428);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(800, 22);
            this.statusStrip1.TabIndex = 3;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // TsLblStatus
            // 
            this.TsLblStatus.Name = "TsLblStatus";
            this.TsLblStatus.Size = new System.Drawing.Size(59, 17);
            this.TsLblStatus.Text = "Loading...";
            // 
            // BookmarkManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.statusStrip1);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "BookmarkManagerForm";
            this.Text = "Bookmark Manager";
            this.Load += new System.EventHandler(this.BookmarkManagerForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private ListView listView1;
        private ColumnHeader ChName;
        private ColumnHeader ChAddress;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem MiFile;
        private ToolStripMenuItem MiRefresh;
        private ToolStripMenuItem MiExit;
        private ToolStripMenuItem itemToolStripMenuItem;
        private ToolStripMenuItem MiEdit;
        private ToolStripMenuItem MiOpen;
        private Panel panel1;
        private ComboBox CboFilter;
        private Label LblFilter;
        private StatusStrip statusStrip1;
        private ToolStripStatusLabel TsLblStatus;
    }
}