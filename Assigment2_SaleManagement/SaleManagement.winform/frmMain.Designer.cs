namespace SaleManagement.winform
{
    partial class frmMain
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
            this.tabMain = new System.Windows.Forms.TabControl();
            this.mFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.mMemberManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mProductManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.mOrderManagement = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabMain
            // 
            this.tabMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabMain.Location = new System.Drawing.Point(0, 24);
            this.tabMain.Name = "tabMain";
            this.tabMain.SelectedIndex = 0;
            this.tabMain.Size = new System.Drawing.Size(800, 38);
            this.tabMain.TabIndex = 2;
            this.tabMain.SelectedIndexChanged += new System.EventHandler(this.tabMain_SelectedIndexChanged);
            // 
            // mFunction
            // 
            this.mFunction.Checked = true;
            this.mFunction.CheckState = System.Windows.Forms.CheckState.Checked;
            this.mFunction.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mMemberManagement,
            this.mProductManagement,
            this.mOrderManagement});
            this.mFunction.Name = "mFunction";
            this.mFunction.Size = new System.Drawing.Size(50, 20);
            this.mFunction.Text = "&Menu";
            // 
            // mMemberManagement
            // 
            this.mMemberManagement.Name = "mMemberManagement";
            this.mMemberManagement.Size = new System.Drawing.Size(193, 22);
            this.mMemberManagement.Text = "&Member Management";
            this.mMemberManagement.Click += new System.EventHandler(this.mMemberManagement_Click);
            // 
            // mProductManagement
            // 
            this.mProductManagement.Name = "mProductManagement";
            this.mProductManagement.Size = new System.Drawing.Size(193, 22);
            this.mProductManagement.Text = "&Product Management";
            this.mProductManagement.Click += new System.EventHandler(this.mProductManagement_Click);
            // 
            // mOrderManagement
            // 
            this.mOrderManagement.Name = "mOrderManagement";
            this.mOrderManagement.Size = new System.Drawing.Size(193, 22);
            this.mOrderManagement.Text = "&Order Management";
            this.mOrderManagement.Click += new System.EventHandler(this.mOrderManagement_Click);
            // 
            // menuStrip2
            // 
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mFunction});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(800, 24);
            this.menuStrip2.TabIndex = 1;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // frmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabMain);
            this.Controls.Add(this.menuStrip2);
            this.IsMdiContainer = true;
            this.Name = "frmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.frmMain_FormClosed);
            this.MdiChildActivate += new System.EventHandler(this.frmMain_MdiChildActivate);
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private TabControl tabMain;
        private ToolStripMenuItem mFunction;
        private ToolStripMenuItem mMemberManagement;
        private ToolStripMenuItem mProductManagement;
        private ToolStripMenuItem mOrderManagement;
        private MenuStrip menuStrip2;
    }
}