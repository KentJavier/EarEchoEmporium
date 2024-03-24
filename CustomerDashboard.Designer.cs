namespace EarEchoEmporium
{
    partial class frmCustDashboard
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
            this.grpOrder = new System.Windows.Forms.GroupBox();
            this.lblSearch = new System.Windows.Forms.Label();
            this.txtDFirstName = new System.Windows.Forms.TextBox();
            this.lblDFirstName = new System.Windows.Forms.Label();
            this.pbProdPic = new System.Windows.Forms.PictureBox();
            this.txtDLastName = new System.Windows.Forms.TextBox();
            this.lblDLastName = new System.Windows.Forms.Label();
            this.txtDEmail = new System.Windows.Forms.TextBox();
            this.lblDEmail = new System.Windows.Forms.Label();
            this.txtDConNum = new System.Windows.Forms.TextBox();
            this.lblDConNum = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.dtgProductList = new System.Windows.Forms.DataGridView();
            this.dtgOrderList = new System.Windows.Forms.DataGridView();
            this.lblCreateOrder = new System.Windows.Forms.Label();
            this.txtDAddress = new System.Windows.Forms.TextBox();
            this.lblDAddress = new System.Windows.Forms.Label();
            this.btnAddOrder = new System.Windows.Forms.Button();
            this.btnUpdOrder = new System.Windows.Forms.Button();
            this.btnDelOrder = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpCustInfo = new System.Windows.Forms.GroupBox();
            this.grpOrder.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProdPic)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductList)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderList)).BeginInit();
            this.grpCustInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // grpOrder
            // 
            this.grpOrder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.grpOrder.Controls.Add(this.dtgProductList);
            this.grpOrder.Controls.Add(this.txtSearch);
            this.grpOrder.Controls.Add(this.lblSearch);
            this.grpOrder.Controls.Add(this.pbProdPic);
            this.grpOrder.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.grpOrder.Location = new System.Drawing.Point(12, 12);
            this.grpOrder.Name = "grpOrder";
            this.grpOrder.Size = new System.Drawing.Size(1009, 359);
            this.grpOrder.TabIndex = 0;
            this.grpOrder.TabStop = false;
            // 
            // lblSearch
            // 
            this.lblSearch.AutoSize = true;
            this.lblSearch.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic);
            this.lblSearch.Location = new System.Drawing.Point(19, 18);
            this.lblSearch.Name = "lblSearch";
            this.lblSearch.Size = new System.Drawing.Size(219, 26);
            this.lblSearch.TabIndex = 16;
            this.lblSearch.Text = "Search an product:";
            // 
            // txtDFirstName
            // 
            this.txtDFirstName.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic);
            this.txtDFirstName.Location = new System.Drawing.Point(169, 39);
            this.txtDFirstName.Name = "txtDFirstName";
            this.txtDFirstName.Size = new System.Drawing.Size(234, 34);
            this.txtDFirstName.TabIndex = 2;
            // 
            // lblDFirstName
            // 
            this.lblDFirstName.AutoSize = true;
            this.lblDFirstName.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic);
            this.lblDFirstName.Location = new System.Drawing.Point(19, 42);
            this.lblDFirstName.Name = "lblDFirstName";
            this.lblDFirstName.Size = new System.Drawing.Size(140, 26);
            this.lblDFirstName.TabIndex = 1;
            this.lblDFirstName.Text = "First Name:";
            // 
            // pbProdPic
            // 
            this.pbProdPic.Location = new System.Drawing.Point(723, 58);
            this.pbProdPic.Name = "pbProdPic";
            this.pbProdPic.Size = new System.Drawing.Size(245, 211);
            this.pbProdPic.TabIndex = 0;
            this.pbProdPic.TabStop = false;
            // 
            // txtDLastName
            // 
            this.txtDLastName.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic);
            this.txtDLastName.Location = new System.Drawing.Point(169, 93);
            this.txtDLastName.Name = "txtDLastName";
            this.txtDLastName.Size = new System.Drawing.Size(234, 34);
            this.txtDLastName.TabIndex = 18;
            // 
            // lblDLastName
            // 
            this.lblDLastName.AutoSize = true;
            this.lblDLastName.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic);
            this.lblDLastName.Location = new System.Drawing.Point(19, 96);
            this.lblDLastName.Name = "lblDLastName";
            this.lblDLastName.Size = new System.Drawing.Size(144, 26);
            this.lblDLastName.TabIndex = 17;
            this.lblDLastName.Text = "Last Name: ";
            // 
            // txtDEmail
            // 
            this.txtDEmail.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic);
            this.txtDEmail.Location = new System.Drawing.Point(169, 145);
            this.txtDEmail.Name = "txtDEmail";
            this.txtDEmail.Size = new System.Drawing.Size(234, 34);
            this.txtDEmail.TabIndex = 22;
            // 
            // lblDEmail
            // 
            this.lblDEmail.AutoSize = true;
            this.lblDEmail.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic);
            this.lblDEmail.Location = new System.Drawing.Point(18, 153);
            this.lblDEmail.Name = "lblDEmail";
            this.lblDEmail.Size = new System.Drawing.Size(83, 26);
            this.lblDEmail.TabIndex = 21;
            this.lblDEmail.Text = "Email:";
            // 
            // txtDConNum
            // 
            this.txtDConNum.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic);
            this.txtDConNum.Location = new System.Drawing.Point(169, 200);
            this.txtDConNum.Name = "txtDConNum";
            this.txtDConNum.Size = new System.Drawing.Size(234, 34);
            this.txtDConNum.TabIndex = 24;
            // 
            // lblDConNum
            // 
            this.lblDConNum.AutoSize = true;
            this.lblDConNum.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic);
            this.lblDConNum.Location = new System.Drawing.Point(18, 203);
            this.lblDConNum.Name = "lblDConNum";
            this.lblDConNum.Size = new System.Drawing.Size(125, 26);
            this.lblDConNum.TabIndex = 23;
            this.lblDConNum.Text = "Contact #:";
            // 
            // txtSearch
            // 
            this.txtSearch.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic);
            this.txtSearch.Location = new System.Drawing.Point(244, 15);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(245, 34);
            this.txtSearch.TabIndex = 25;
            // 
            // dtgProductList
            // 
            this.dtgProductList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProductList.Location = new System.Drawing.Point(39, 58);
            this.dtgProductList.Name = "dtgProductList";
            this.dtgProductList.RowHeadersWidth = 51;
            this.dtgProductList.RowTemplate.Height = 24;
            this.dtgProductList.Size = new System.Drawing.Size(625, 285);
            this.dtgProductList.TabIndex = 26;
            // 
            // dtgOrderList
            // 
            this.dtgOrderList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrderList.Location = new System.Drawing.Point(20, 428);
            this.dtgOrderList.Name = "dtgOrderList";
            this.dtgOrderList.RowHeadersWidth = 51;
            this.dtgOrderList.RowTemplate.Height = 24;
            this.dtgOrderList.Size = new System.Drawing.Size(572, 315);
            this.dtgOrderList.TabIndex = 27;
            // 
            // lblCreateOrder
            // 
            this.lblCreateOrder.AutoSize = true;
            this.lblCreateOrder.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic);
            this.lblCreateOrder.Location = new System.Drawing.Point(15, 388);
            this.lblCreateOrder.Name = "lblCreateOrder";
            this.lblCreateOrder.Size = new System.Drawing.Size(190, 26);
            this.lblCreateOrder.TabIndex = 27;
            this.lblCreateOrder.Text = "Create an order:";
            // 
            // txtDAddress
            // 
            this.txtDAddress.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic);
            this.txtDAddress.Location = new System.Drawing.Point(169, 254);
            this.txtDAddress.Multiline = true;
            this.txtDAddress.Name = "txtDAddress";
            this.txtDAddress.Size = new System.Drawing.Size(234, 139);
            this.txtDAddress.TabIndex = 29;
            // 
            // lblDAddress
            // 
            this.lblDAddress.AutoSize = true;
            this.lblDAddress.Font = new System.Drawing.Font("Bookman Old Style", 13.8F, System.Drawing.FontStyle.Italic);
            this.lblDAddress.Location = new System.Drawing.Point(18, 257);
            this.lblDAddress.Name = "lblDAddress";
            this.lblDAddress.Size = new System.Drawing.Size(112, 26);
            this.lblDAddress.TabIndex = 28;
            this.lblDAddress.Text = "Address:";
            // 
            // btnAddOrder
            // 
            this.btnAddOrder.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic);
            this.btnAddOrder.Location = new System.Drawing.Point(20, 767);
            this.btnAddOrder.Name = "btnAddOrder";
            this.btnAddOrder.Size = new System.Drawing.Size(128, 36);
            this.btnAddOrder.TabIndex = 30;
            this.btnAddOrder.Text = "Add Order";
            this.btnAddOrder.UseVisualStyleBackColor = true;
            // 
            // btnUpdOrder
            // 
            this.btnUpdOrder.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic);
            this.btnUpdOrder.Location = new System.Drawing.Point(154, 767);
            this.btnUpdOrder.Name = "btnUpdOrder";
            this.btnUpdOrder.Size = new System.Drawing.Size(156, 36);
            this.btnUpdOrder.TabIndex = 31;
            this.btnUpdOrder.Text = "Update Order";
            this.btnUpdOrder.UseVisualStyleBackColor = true;
            // 
            // btnDelOrder
            // 
            this.btnDelOrder.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic);
            this.btnDelOrder.Location = new System.Drawing.Point(316, 767);
            this.btnDelOrder.Name = "btnDelOrder";
            this.btnDelOrder.Size = new System.Drawing.Size(156, 36);
            this.btnDelOrder.TabIndex = 32;
            this.btnDelOrder.Text = "Delete Order";
            this.btnDelOrder.UseVisualStyleBackColor = true;
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Bookman Old Style", 12F, System.Drawing.FontStyle.Italic);
            this.btnReset.Location = new System.Drawing.Point(478, 767);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(114, 36);
            this.btnReset.TabIndex = 33;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // grpCustInfo
            // 
            this.grpCustInfo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(238)))), ((int)(((byte)(238)))), ((int)(((byte)(238)))));
            this.grpCustInfo.Controls.Add(this.txtDAddress);
            this.grpCustInfo.Controls.Add(this.lblDAddress);
            this.grpCustInfo.Controls.Add(this.txtDConNum);
            this.grpCustInfo.Controls.Add(this.txtDFirstName);
            this.grpCustInfo.Controls.Add(this.lblDConNum);
            this.grpCustInfo.Controls.Add(this.lblDFirstName);
            this.grpCustInfo.Controls.Add(this.txtDEmail);
            this.grpCustInfo.Controls.Add(this.lblDLastName);
            this.grpCustInfo.Controls.Add(this.lblDEmail);
            this.grpCustInfo.Controls.Add(this.txtDLastName);
            this.grpCustInfo.Font = new System.Drawing.Font("Bookman Old Style", 10F, System.Drawing.FontStyle.Italic);
            this.grpCustInfo.Location = new System.Drawing.Point(611, 388);
            this.grpCustInfo.Name = "grpCustInfo";
            this.grpCustInfo.Size = new System.Drawing.Size(414, 413);
            this.grpCustInfo.TabIndex = 34;
            this.grpCustInfo.TabStop = false;
            this.grpCustInfo.Text = "Customer Info:";
            // 
            // frmCustDashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(118)))), ((int)(((byte)(171)))), ((int)(((byte)(174)))));
            this.ClientSize = new System.Drawing.Size(1047, 815);
            this.Controls.Add(this.grpCustInfo);
            this.Controls.Add(this.btnReset);
            this.Controls.Add(this.btnDelOrder);
            this.Controls.Add(this.btnUpdOrder);
            this.Controls.Add(this.btnAddOrder);
            this.Controls.Add(this.lblCreateOrder);
            this.Controls.Add(this.dtgOrderList);
            this.Controls.Add(this.grpOrder);
            this.Name = "frmCustDashboard";
            this.Text = "Customer Dashboard";
            this.grpOrder.ResumeLayout(false);
            this.grpOrder.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pbProdPic)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProductList)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderList)).EndInit();
            this.grpCustInfo.ResumeLayout(false);
            this.grpCustInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox grpOrder;
        private System.Windows.Forms.TextBox txtDFirstName;
        private System.Windows.Forms.Label lblDFirstName;
        private System.Windows.Forms.PictureBox pbProdPic;
        private System.Windows.Forms.Label lblSearch;
        private System.Windows.Forms.TextBox txtDConNum;
        private System.Windows.Forms.Label lblDConNum;
        private System.Windows.Forms.TextBox txtDEmail;
        private System.Windows.Forms.Label lblDEmail;
        private System.Windows.Forms.TextBox txtDLastName;
        private System.Windows.Forms.Label lblDLastName;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.DataGridView dtgProductList;
        private System.Windows.Forms.DataGridView dtgOrderList;
        private System.Windows.Forms.Label lblCreateOrder;
        private System.Windows.Forms.TextBox txtDAddress;
        private System.Windows.Forms.Label lblDAddress;
        private System.Windows.Forms.Button btnAddOrder;
        private System.Windows.Forms.Button btnUpdOrder;
        private System.Windows.Forms.Button btnDelOrder;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpCustInfo;
    }
}