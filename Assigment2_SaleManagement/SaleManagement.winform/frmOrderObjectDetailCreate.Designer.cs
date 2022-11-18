namespace SaleManagement.winform
{
    partial class frmOrderObjectDetailCreate
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSearchProductResult = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.txtSave = new System.Windows.Forms.Button();
            this.txtClose = new System.Windows.Forms.Button();
            this.dteRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dteOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dteShippedDate = new System.Windows.Forms.DateTimePicker();
            this.cboMemberEmail = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.numProduct = new System.Windows.Forms.NumericUpDown();
            this.numDiscount = new System.Windows.Forms.NumericUpDown();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.labTotal = new System.Windows.Forms.Label();
            this.numFreight = new System.Windows.Forms.NumericUpDown();
            this.label12 = new System.Windows.Forms.Label();
            this.numOrderId = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProductResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProduct)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFreight)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderId)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(471, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Email";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(51, 96);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(83, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "Order Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(51, 150);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(100, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Shipped Date";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(471, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(105, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Required Date";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(471, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(55, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Freight";
            // 
            // dgvSearchProductResult
            // 
            this.dgvSearchProductResult.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvSearchProductResult.Location = new System.Drawing.Point(56, 281);
            this.dgvSearchProductResult.Name = "dgvSearchProductResult";
            this.dgvSearchProductResult.RowHeadersWidthSizeMode = System.Windows.Forms.DataGridViewRowHeadersWidthSizeMode.AutoSizeToAllHeaders;
            this.dgvSearchProductResult.RowTemplate.Height = 29;
            this.dgvSearchProductResult.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvSearchProductResult.Size = new System.Drawing.Size(791, 166);
            this.dgvSearchProductResult.TabIndex = 12;
            this.dgvSearchProductResult.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvSearchProductResult_CellClick);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(56, 258);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(97, 20);
            this.label7.TabIndex = 13;
            this.label7.Text = "Search Result";
            // 
            // txtSearchProduct
            // 
            this.txtSearchProduct.Location = new System.Drawing.Point(186, 215);
            this.txtSearchProduct.Name = "txtSearchProduct";
            this.txtSearchProduct.Size = new System.Drawing.Size(531, 27);
            this.txtSearchProduct.TabIndex = 15;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(51, 215);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(104, 20);
            this.label8.TabIndex = 14;
            this.label8.Text = "Product Name";
            // 
            // btnSearchProduct
            // 
            this.btnSearchProduct.Location = new System.Drawing.Point(753, 215);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(94, 29);
            this.btnSearchProduct.TabIndex = 16;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            this.btnSearchProduct.Click += new System.EventHandler(this.btnSearchProduct_Click);
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(746, 473);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(101, 29);
            this.btnAddProduct.TabIndex = 17;
            this.btnAddProduct.Text = "Add product";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.txtAddProduct_Click);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(56, 584);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Order Detail";
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.AllowUserToAddRows = false;
            this.dgvOrderDetail.AllowUserToDeleteRows = false;
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(56, 607);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.ReadOnly = true;
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 29;
            this.dgvOrderDetail.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvOrderDetail.Size = new System.Drawing.Size(791, 159);
            this.dgvOrderDetail.TabIndex = 18;
            this.dgvOrderDetail.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvOrderDetail_CellClick);
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(266, 801);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(94, 29);
            this.txtSave.TabIndex = 20;
            this.txtSave.Text = "Save";
            this.txtSave.UseVisualStyleBackColor = true;
            this.txtSave.Click += new System.EventHandler(this.txtSave_Click);
            // 
            // txtClose
            // 
            this.txtClose.Location = new System.Drawing.Point(515, 801);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(94, 29);
            this.txtClose.TabIndex = 21;
            this.txtClose.Text = "Close";
            this.txtClose.UseVisualStyleBackColor = true;
            this.txtClose.Click += new System.EventHandler(this.txtClose_Click);
            // 
            // dteRequiredDate
            // 
            this.dteRequiredDate.Location = new System.Drawing.Point(597, 96);
            this.dteRequiredDate.Name = "dteRequiredDate";
            this.dteRequiredDate.Size = new System.Drawing.Size(250, 27);
            this.dteRequiredDate.TabIndex = 22;
            // 
            // dteOrderDate
            // 
            this.dteOrderDate.Location = new System.Drawing.Point(186, 96);
            this.dteOrderDate.Name = "dteOrderDate";
            this.dteOrderDate.Size = new System.Drawing.Size(250, 27);
            this.dteOrderDate.TabIndex = 23;
            // 
            // dteShippedDate
            // 
            this.dteShippedDate.Location = new System.Drawing.Point(186, 150);
            this.dteShippedDate.Name = "dteShippedDate";
            this.dteShippedDate.Size = new System.Drawing.Size(250, 27);
            this.dteShippedDate.TabIndex = 24;
            // 
            // cboMemberEmail
            // 
            this.cboMemberEmail.FormattingEnabled = true;
            this.cboMemberEmail.Location = new System.Drawing.Point(597, 48);
            this.cboMemberEmail.Name = "cboMemberEmail";
            this.cboMemberEmail.Size = new System.Drawing.Size(250, 28);
            this.cboMemberEmail.TabIndex = 25;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(51, 475);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(137, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Number of product";
            // 
            // numProduct
            // 
            this.numProduct.Location = new System.Drawing.Point(194, 473);
            this.numProduct.Name = "numProduct";
            this.numProduct.Size = new System.Drawing.Size(523, 27);
            this.numProduct.TabIndex = 27;
            this.numProduct.ValueChanged += new System.EventHandler(this.numProduct_ValueChanged);
            // 
            // numDiscount
            // 
            this.numDiscount.Location = new System.Drawing.Point(194, 506);
            this.numDiscount.Name = "numDiscount";
            this.numDiscount.Size = new System.Drawing.Size(523, 27);
            this.numDiscount.TabIndex = 29;
            this.numDiscount.ValueChanged += new System.EventHandler(this.numDiscount_ValueChanged);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(51, 508);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(67, 20);
            this.label10.TabIndex = 28;
            this.label10.Text = "Discount";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(56, 544);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(42, 20);
            this.label11.TabIndex = 30;
            this.label11.Text = "Total";
            // 
            // labTotal
            // 
            this.labTotal.AutoSize = true;
            this.labTotal.Location = new System.Drawing.Point(194, 544);
            this.labTotal.Name = "labTotal";
            this.labTotal.Size = new System.Drawing.Size(17, 20);
            this.labTotal.TabIndex = 31;
            this.labTotal.Text = "0";
            // 
            // numFreight
            // 
            this.numFreight.Location = new System.Drawing.Point(597, 148);
            this.numFreight.Name = "numFreight";
            this.numFreight.Size = new System.Drawing.Size(250, 27);
            this.numFreight.TabIndex = 32;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(56, 56);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(64, 20);
            this.label12.TabIndex = 33;
            this.label12.Text = "Order Id";
            // 
            // numOrderId
            // 
            this.numOrderId.Location = new System.Drawing.Point(186, 54);
            this.numOrderId.Name = "numOrderId";
            this.numOrderId.Size = new System.Drawing.Size(250, 27);
            this.numOrderId.TabIndex = 34;
            // 
            // frmOrderObjectDetailCreate
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(890, 853);
            this.Controls.Add(this.numOrderId);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.numFreight);
            this.Controls.Add(this.labTotal);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.numDiscount);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.numProduct);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cboMemberEmail);
            this.Controls.Add(this.dteShippedDate);
            this.Controls.Add(this.dteOrderDate);
            this.Controls.Add(this.dteRequiredDate);
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvSearchProductResult);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOrderObjectDetailCreate";
            this.Text = "frmOrderObjectDetail";
            this.Load += new System.EventHandler(this.frmOrderObjectDetailCreate_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProductResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numProduct)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDiscount)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numFreight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numOrderId)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private Label label6;
        private DataGridView dgvSearchProductResult;
        private Label label7;
        private TextBox txtSearchProduct;
        private Label label8;
        private Button btnSearchProduct;
        private Button btnAddProduct;
        private Label label9;
        private DataGridView dgvOrderDetail;
        private Button txtSave;
        private Button txtClose;
        private DateTimePicker dteRequiredDate;
        private DateTimePicker dteOrderDate;
        private DateTimePicker dteShippedDate;
        private ComboBox cboMemberEmail;
        private Label label4;
        private NumericUpDown numProduct;
        private NumericUpDown numDiscount;
        private Label label10;
        private Label label11;
        private Label labTotal;
        private NumericUpDown numFreight;
        private Label label12;
        private NumericUpDown numOrderId;
    }
}