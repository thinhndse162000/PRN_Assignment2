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
            this.txtFreight = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.dgvSearchProductResult = new System.Windows.Forms.DataGridView();
            this.label7 = new System.Windows.Forms.Label();
            this.txtSearchProduct = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.btnSearchProduct = new System.Windows.Forms.Button();
            this.txtAddProduct = new System.Windows.Forms.Button();
            this.label9 = new System.Windows.Forms.Label();
            this.dgvOrderDetail = new System.Windows.Forms.DataGridView();
            this.txtSave = new System.Windows.Forms.Button();
            this.txtClose = new System.Windows.Forms.Button();
            this.dteRequiredDate = new System.Windows.Forms.DateTimePicker();
            this.dteOrderDate = new System.Windows.Forms.DateTimePicker();
            this.dteShippedDate = new System.Windows.Forms.DateTimePicker();
            this.cboMemberName = new System.Windows.Forms.ComboBox();
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProductResult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(51, 52);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(109, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Member Name";
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
            // txtFreight
            // 
            this.txtFreight.Location = new System.Drawing.Point(597, 144);
            this.txtFreight.Name = "txtFreight";
            this.txtFreight.Size = new System.Drawing.Size(250, 27);
            this.txtFreight.TabIndex = 11;
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
            this.dgvSearchProductResult.RowHeadersWidth = 51;
            this.dgvSearchProductResult.RowTemplate.Height = 29;
            this.dgvSearchProductResult.Size = new System.Drawing.Size(380, 159);
            this.dgvSearchProductResult.TabIndex = 12;
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
            this.btnSearchProduct.Location = new System.Drawing.Point(753, 211);
            this.btnSearchProduct.Name = "btnSearchProduct";
            this.btnSearchProduct.Size = new System.Drawing.Size(94, 29);
            this.btnSearchProduct.TabIndex = 16;
            this.btnSearchProduct.Text = "Search";
            this.btnSearchProduct.UseVisualStyleBackColor = true;
            // 
            // txtAddProduct
            // 
            this.txtAddProduct.Location = new System.Drawing.Point(442, 343);
            this.txtAddProduct.Name = "txtAddProduct";
            this.txtAddProduct.Size = new System.Drawing.Size(23, 29);
            this.txtAddProduct.TabIndex = 17;
            this.txtAddProduct.Text = ">";
            this.txtAddProduct.UseVisualStyleBackColor = true;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(471, 258);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(91, 20);
            this.label9.TabIndex = 19;
            this.label9.Text = "Order Detail";
            // 
            // dgvOrderDetail
            // 
            this.dgvOrderDetail.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvOrderDetail.Location = new System.Drawing.Point(471, 281);
            this.dgvOrderDetail.Name = "dgvOrderDetail";
            this.dgvOrderDetail.RowHeadersWidth = 51;
            this.dgvOrderDetail.RowTemplate.Height = 29;
            this.dgvOrderDetail.Size = new System.Drawing.Size(376, 159);
            this.dgvOrderDetail.TabIndex = 18;
            // 
            // txtSave
            // 
            this.txtSave.Location = new System.Drawing.Point(308, 480);
            this.txtSave.Name = "txtSave";
            this.txtSave.Size = new System.Drawing.Size(94, 29);
            this.txtSave.TabIndex = 20;
            this.txtSave.Text = "Save";
            this.txtSave.UseVisualStyleBackColor = true;
            // 
            // txtClose
            // 
            this.txtClose.Location = new System.Drawing.Point(508, 480);
            this.txtClose.Name = "txtClose";
            this.txtClose.Size = new System.Drawing.Size(94, 29);
            this.txtClose.TabIndex = 21;
            this.txtClose.Text = "Close";
            this.txtClose.UseVisualStyleBackColor = true;
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
            // cboMemberName
            // 
            this.cboMemberName.FormattingEnabled = true;
            this.cboMemberName.Location = new System.Drawing.Point(186, 52);
            this.cboMemberName.Name = "cboMemberName";
            this.cboMemberName.Size = new System.Drawing.Size(661, 28);
            this.cboMemberName.TabIndex = 25;
            // 
            // frmOrderObjectDetail
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(901, 535);
            this.Controls.Add(this.cboMemberName);
            this.Controls.Add(this.dteShippedDate);
            this.Controls.Add(this.dteOrderDate);
            this.Controls.Add(this.dteRequiredDate);
            this.Controls.Add(this.txtClose);
            this.Controls.Add(this.txtSave);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.dgvOrderDetail);
            this.Controls.Add(this.txtAddProduct);
            this.Controls.Add(this.btnSearchProduct);
            this.Controls.Add(this.txtSearchProduct);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.dgvSearchProductResult);
            this.Controls.Add(this.txtFreight);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "frmOrderObjectDetail";
            this.Text = "frmOrderObjectDetail";
            ((System.ComponentModel.ISupportInitialize)(this.dgvSearchProductResult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvOrderDetail)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label5;
        private TextBox txtFreight;
        private Label label6;
        private DataGridView dgvSearchProductResult;
        private Label label7;
        private TextBox txtSearchProduct;
        private Label label8;
        private Button btnSearchProduct;
        private Button txtAddProduct;
        private Label label9;
        private DataGridView dgvOrderDetail;
        private Button txtSave;
        private Button txtClose;
        private DateTimePicker dteRequiredDate;
        private DateTimePicker dteOrderDate;
        private DateTimePicker dteShippedDate;
        private ComboBox cboMemberName;
    }
}