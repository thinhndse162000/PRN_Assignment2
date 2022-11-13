using Microsoft.EntityFrameworkCore.Metadata.Internal;
using SaleManagement.repo.Models;
using SaleManagement.repo.Repository;
using SaleManagement.repo.Service;
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
    public partial class frmProductsObject : Form
    {
        BindingSource _bindingSource;
        IProductRepository _repository;
        Product _product;
        ProductService _productService;
        public frmProductsObject()
        {
            InitializeComponent();
            _repository = new ProductRepository();
            _productService = ProductService.Instance;
        }

        private void frmProductsObject_Load(object sender, EventArgs e)
        {
            LoadDataToDgv();
        }
        private void LoadDataToDgv()
        {
            dvgProduct.DataSource = null;
            _bindingSource = new BindingSource();
            _bindingSource.DataSource = _repository.GetAllProduct();
            dvgProduct.DataSource = _bindingSource;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            frmProductObjectDetails frmProductObjectDetails = new frmProductObjectDetails {
                InsertOrUpdate = false,
                productRepository = _repository
            };
            if (frmProductObjectDetails.ShowDialog() == DialogResult.OK)
            {
                LoadDataToDgv();
                _bindingSource.Position = _bindingSource.Count - 1;
            }
        }

        private void dvgProduct_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var rowData = dvgProduct.Rows[e.RowIndex];
            Product product = GetProduct(e.RowIndex);
            frmProductObjectDetails frmProductObjectDetails = new frmProductObjectDetails {
                InsertOrUpdate = true,
                product = product,
                productRepository = _repository
            };
            if (frmProductObjectDetails.ShowDialog() == DialogResult.OK)
            {
                LoadDataToDgv();
                _bindingSource.Position = _bindingSource.Count - 1;
            }

        }
        private Product GetProduct(int rowIndex)
        {
            return new Product
            {
                ProductId = int.Parse(dvgProduct.Rows[rowIndex].Cells[0].Value.ToString()),
                Category = int.Parse(dvgProduct.Rows[rowIndex].Cells[1].Value.ToString()),
                ProductName = dvgProduct.Rows[rowIndex].Cells[2].Value.ToString(),
                Weight = dvgProduct.Rows[rowIndex].Cells[3].Value.ToString(),
                UnitPrice = decimal.Parse(dvgProduct.Rows[rowIndex].Cells[4].Value.ToString()),
                UnitsInStock = int.Parse(dvgProduct.Rows[rowIndex].Cells[5].Value.ToString()),
            };
        }

        private void dvgProduct_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                _product= GetProduct(e.RowIndex);
            }
        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to Delete this record ?", "Delete Operator", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                if (_product != null)
                {
                    bool check = _repository.Delete(_product.ProductId);
                    if (check)
                    {
                        LoadDataToDgv();
                        MessageBox.Show("Delete successfully");
                    }
                }
                else
                {
                    MessageBox.Show("You need to click on record you wanto delete");
                }
            }
        }

        private void flowLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void Filter() {
            int id = (int)txtId.Value;
            string name = txtProductName.Text;
            decimal price = txtUnitPrice.Value;
            int UnitsInStock = (int)txtUnitInStock.Value;

            _bindingSource.DataSource = _productService.Filter(id, name, price, UnitsInStock);

        }

        private void txtId_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void txtProductName_TextChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void txtUnitPrice_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }

        private void txtUnitInStock_ValueChanged(object sender, EventArgs e)
        {
            Filter();
        }
    }
}
