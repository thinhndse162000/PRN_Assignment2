using Microsoft.Identity.Client;
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
    public partial class frmOrderObjectDetailCreate : Form
    {
        private IMemberRepository memberRepository;
        private IProductRepository productRepository;
        private IOrderRepository orderRepository;
        private BindingSource? productSource;
        private BindingSource? orderDetailSource;

        private Order order;
        private int selectedProductId;

        public frmOrderObjectDetailCreate()
        {
            InitializeComponent();
            memberRepository = new MemberRepository();
            productRepository = new ProductRepository();
            orderRepository = new OrderRepository();
            order = new Order();
        }

        private void frmOrderObjectDetailCreate_Load(object sender, EventArgs e)
        {
            var memberEmail = memberRepository.GetMembers().Select(m => m.Email).ToArray();
            cboMemberEmail.Items.AddRange(memberEmail);
            cboMemberEmail.SelectedIndex = 0;

            LoadProductDgv();
            try
            {
                selectedProductId = Int32.Parse(dgvSearchProductResult.Rows[0].Cells[0].Value.ToString());
            }catch (Exception)
            {

            }

            LoadOrderDetailDgv();
        }

        private void LoadProductDgv()
        {
            string productName = txtSearchProduct.Text;
            dgvSearchProductResult.DataSource = null;
            productSource = new BindingSource();

            var products = productRepository.GetAllProduct().Where(p => p.ProductName.ToLower().Contains(productName.ToLower())).ToArray();
            productSource.DataSource = products;
            dgvSearchProductResult.DataSource = productSource;

            dgvSearchProductResult.Columns["OrderDetails"].Visible = false;
        }

        private void LoadOrderDetailDgv()
        {
            dgvOrderDetail.DataSource = null;
            dgvOrderDetail.Columns.Clear();
            orderDetailSource = new BindingSource();

            orderDetailSource.DataSource = order.OrderDetails;

            dgvOrderDetail.DataSource = orderDetailSource;

            dgvOrderDetail.Columns["OrderId"].Visible = false;
            dgvOrderDetail.Columns["Order"].Visible = false;
            dgvOrderDetail.Columns["Product"].Visible = false;

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

        private void btnSearchProduct_Click(object sender, EventArgs e)
        {
            LoadProductDgv();
        }

        private void txtClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtAddProduct_Click(object sender, EventArgs e)
        {
            var orderDetail = order.OrderDetails.FirstOrDefault(o => o.ProductId == selectedProductId);
            var productNum = (int) numProduct.Value;
            var product = productRepository.GetProductById(selectedProductId);
            var discount = Convert.ToDouble(numDiscount.Value);

            // Check if product already in order detail
            if (orderDetail == null)
            {   
                if (productNum == 0)
                {
                    MessageBox.Show("Product number must be larger than 0");
                    return;
                }
                orderDetail = new OrderDetail
                {
                    ProductId = selectedProductId,
                    UnitPrice = product.UnitPrice,
                    Discount = discount,
                    Quantity = productNum,
                    Order = order,
                };

                order.OrderDetails.Add(orderDetail);
            } else
            {
                if (productNum == 0)
                {
                    order.OrderDetails.Remove(orderDetail);
                } else
                {
                    orderDetail.Quantity = productNum;
                    orderDetail.Discount = discount;
                }
            }

            LoadProductDgv();
            LoadOrderDetailDgv();

            ClearLabel();
        }

        private void SetTotalLabel()
        {
            var productNum = (int) numProduct.Value;
            var product = productRepository.GetProductById(selectedProductId);
            var discount = Convert.ToDouble(numDiscount.Value);

            if (product != null)
            {
                decimal total = ((decimal) productNum) * product.UnitPrice * (100 - ((decimal) discount)) / 100;
                labTotal.Text = total.ToString();
            }
        }

        private void ClearLabel()
        {
            labTotal.Text = "";
            numProduct.Value = 0;
            numDiscount.Value = 0;
        }

        private void numProduct_ValueChanged(object sender, EventArgs e)
        {
            SetTotalLabel();
        }

        private void numDiscount_ValueChanged(object sender, EventArgs e)
        {
            SetTotalLabel();
        }

        private void dgvSearchProductResult_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // set numProduct max to unit in stock
            var rowProductSelect = dgvSearchProductResult.CurrentCell.RowIndex;
            var productId = Convert.ToInt32(dgvSearchProductResult.Rows[rowProductSelect].Cells[0].Value);
            var product = productRepository.GetProductById(productId);
            selectedProductId = productId;

            numProduct.Maximum = product.UnitsInStock;

            // Get from order detail
            OrderDetail orderDetail = order.OrderDetails.Where(o => o.ProductId == productId).FirstOrDefault();
            if (orderDetail != null)
            {
                numProduct.Value = orderDetail.Quantity;
                numDiscount.Value = (decimal)orderDetail.Discount;
                SetTotalLabel();
                btnAddProduct.Text = "Update";
            } else
            {
                ClearLabel();
                btnAddProduct.Text = "Add";
            }
        }

        private void dgvOrderDetail_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            // set numProduct max to unit in stock
            var rowOrderDetailSelect = dgvOrderDetail.CurrentCell.RowIndex;
            var productId = Convert.ToInt32(dgvOrderDetail.Rows[rowOrderDetailSelect].Cells[0].Value);
            var product = productRepository.GetProductById(productId);
            selectedProductId = productId;

            numProduct.Maximum = product.UnitsInStock;

            // Get from order detail
            OrderDetail orderDetail = order.OrderDetails.Where(o => o.ProductId == productId).FirstOrDefault();
            if (orderDetail != null)
            {
                numProduct.Value = orderDetail.Quantity;
                numDiscount.Value = (decimal)orderDetail.Discount;
                SetTotalLabel();
                btnAddProduct.Text = "Update";
            }
        }

        private void txtSave_Click(object sender, EventArgs e)
        {
            if (order.OrderDetails.Count == 0)
            {
                MessageBox.Show("Please select product");
                return;
            }

            var member = memberRepository.GetMemberByEmail(cboMemberEmail.Text);

            order.OrderId = (int)numOrderId.Value;
            order.MemberId = member.MemberId;
            order.OrderDate = dteOrderDate.Value;
            order.RequiredDate = dteRequiredDate.Value;
            order.ShippedDate = dteShippedDate.Value;
            order.Freight = numFreight.Value;

            try
            {
                orderRepository.Create(order);
            } catch (Exception)
            {
                MessageBox.Show("Order ID already exist");
                return;
            }

            this.DialogResult = DialogResult.OK;
        }
    }
}
