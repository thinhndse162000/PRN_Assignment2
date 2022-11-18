using SaleManagement.repo.Models;
using SaleManagement.repo.Repository;
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
    public partial class frmOrderObjectDetailUpdate : Form
    {
        public Order order { get; set; }
        private BindingSource source;
        private IOrderRepository orderRepository;
        private IProductRepository productRepository;
        public frmOrderObjectDetailUpdate()
        {
            InitializeComponent();
            orderRepository = new OrderRepository();
            productRepository = new ProductRepository();
        }

        private void frmOrderObjectDetailUpdate_Load(object sender, EventArgs e)
        {
            txtOrderId.Text = order.OrderId.ToString();
            txtMemberEmail.Text = order.Member.Email;
            dteOrderDate.Value = order.OrderDate;
            dteShippedDate.Value = (DateTime)order.ShippedDate;
            dteRequiredDate.Value = (DateTime)order.RequiredDate;
            numFreight.Value = (decimal)order.Freight;

            dgvOrderDetail.DataSource = null;
            source = new BindingSource();

            source.DataSource = order.OrderDetails;

            dgvOrderDetail.DataSource = source;
            dgvOrderDetail.Columns["Product"].Visible = false;
            dgvOrderDetail.Columns["Order"].Visible = false;
            dgvOrderDetail.Columns["OrderId"].Visible = false;

            // Add product name column
            DataGridViewColumn productNameColumn = new DataGridViewTextBoxColumn();
            productNameColumn.Name = "ProductName";
            productNameColumn.HeaderText = "ProductName";
            dgvOrderDetail.Columns.Insert(2, productNameColumn);

            // Add product name
            foreach (DataGridViewRow row in dgvOrderDetail.Rows)
            {
                Product product = productRepository.GetProductById(Int32.Parse(row.Cells["ProductId"].Value.ToString()));
                row.Cells["ProductName"].Value = product.ProductName;
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            if (order.OrderDate > dteRequiredDate.Value)
            {
                MessageBox.Show("Required date must be after order date");
            } else if (order.OrderDate > dteShippedDate.Value)
            {
                MessageBox.Show("Shipped date must be after order date");
            } else
            {
                order.RequiredDate = dteRequiredDate.Value;
                order.ShippedDate = dteShippedDate.Value;
                order.Freight = numFreight.Value;

                orderRepository.Update(order);

                this.DialogResult = DialogResult.OK;
            }
        }
    }
}
