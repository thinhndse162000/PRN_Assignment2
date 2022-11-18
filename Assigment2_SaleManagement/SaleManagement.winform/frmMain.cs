using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SaleManagement.winform
{
    public partial class frmMain : Form
    {
        frmMembers frmMembers;
        frmOrdersObjectAdmin frmOrdersObject;
        frmProductsObject frmProductsObject;
        public frmMain()
        {
            InitializeComponent();
        }

        private void mMemberManagement_Click(object sender, EventArgs e)
        {
            if (this.frmMembers is null || this.frmMembers.IsDisposed)
            {
                this.frmMembers = new frmMembers();
                this.frmMembers.MdiParent = this;
                this.frmMembers.Show();
            }
            else {
                this.frmMembers.Select();
            }
        }

        private void mProductManagement_Click(object sender, EventArgs e)
        {
            if (this.frmProductsObject is null || this.frmProductsObject.IsDisposed)
            {
                this.frmProductsObject = new frmProductsObject();
                this.frmProductsObject.MdiParent = this;
                this.frmProductsObject.Show();
            }
            else
            {
                this.frmProductsObject.Select();
            }
        }

        private void mOrderManagement_Click(object sender, EventArgs e)
        {
            if (this.frmOrdersObject is null || this.frmOrdersObject.IsDisposed)
            {
                this.frmOrdersObject = new frmOrdersObjectAdmin();
                this.frmOrdersObject.MdiParent = this;
                this.frmOrdersObject.Show();
            }
            else
            {
                this.frmOrdersObject.Select();
            }
        }

        private void frmMain_MdiChildActivate(object sender, EventArgs e)
        {
            if (this.ActiveMdiChild == null) {
                return;
            }
            this.ActiveMdiChild.WindowState = FormWindowState.Maximized;
            if (this.ActiveMdiChild.Tag == null) { 
                TabPage tabPage = new TabPage(this.ActiveMdiChild.Text);
                tabPage.Tag = this.ActiveMdiChild;
                tabPage.Parent = this.tabMain;
                this.tabMain.SelectedTab = tabPage;
                this.ActiveMdiChild.Tag = tabPage;
                this.ActiveMdiChild.FormClosed += frmMain_FormClosed;
            }
        }

        private void tabMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (this.tabMain.SelectedTab != null && this.tabMain.SelectedTab.Tag != null) {
                (this.tabMain.SelectedTab.Tag as Form).Select();
            }
        }

        private void frmMain_FormClosed(object sender, FormClosedEventArgs e)
        {
            ((sender as Form).Tag as TabPage).Dispose();
        }
    }
}
