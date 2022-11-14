using SaleManagement.repo.Repository;
using SaleManagement.repo.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics.Metrics;

namespace SaleManagement.winform
{
    public partial class frmProductObjectDetails : Form
    {
        public bool InsertOrUpdate { get; set; }
        public IProductRepository productRepository { get; set; }
        public Product product { get; set; }
        public frmProductObjectDetails()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            var c = new Product
            {
                ProductId = int.Parse( txtProductId.Text),
                ProductName = txtProductName.Text,
                Category = int.Parse(txtCategory.Text),
                Weight = txtWeight.Text,
                UnitPrice = Convert.ToDecimal(txtUnitPrice.Text),
                UnitsInStock = int.Parse(txtUnitInStock.Text),
            };
            //save to database
            if (InsertOrUpdate)
            {
                productRepository.Update(c);
            }
            else
            {
                productRepository.CreateMember(c);
            }
            // load lai 
            this.DialogResult = DialogResult.OK;
        }

        private void frmProductObjectDetails_Load(object sender, EventArgs e)
        {
            if (InsertOrUpdate)
            {
                txtProductId.Enabled = false;
                txtProductId.Text = product.ProductId.ToString();
                txtProductName.Text = product.ProductName;
                txtCategory.Text = product.Category.ToString();
                txtUnitInStock.Text = product.UnitsInStock.ToString();
                txtUnitPrice.Text = product.UnitPrice.ToString();
                txtWeight.Text = product.Weight.ToString();
            }
        }

    }
}
