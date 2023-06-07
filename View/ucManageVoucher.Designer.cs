namespace PBL.View
{
    partial class ucManageVoucher
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.labelTotalVoucher = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnListOld = new System.Windows.Forms.Button();
            this.btnListNow = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListVouchers = new System.Windows.Forms.DataGridView();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtDiscount = new System.Windows.Forms.TextBox();
            this.txtQuantity = new System.Windows.Forms.TextBox();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.labelTotalPayment = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVouchers)).BeginInit();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.labelTotalVoucher);
            this.panelGeneral.Controls.Add(this.label2);
            this.panelGeneral.Controls.Add(this.txtSearch);
            this.panelGeneral.Controls.Add(this.btnDelete);
            this.panelGeneral.Controls.Add(this.btnUpdate);
            this.panelGeneral.Controls.Add(this.btnListOld);
            this.panelGeneral.Controls.Add(this.btnListNow);
            this.panelGeneral.Controls.Add(this.btnListAll);
            this.panelGeneral.Controls.Add(this.btnSearch);
            this.panelGeneral.Controls.Add(this.btnAdd);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Controls.Add(this.dgvListVouchers);
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1430, 818);
            this.panelGeneral.TabIndex = 2;
            // 
            // labelTotalVoucher
            // 
            this.labelTotalVoucher.AutoSize = true;
            this.labelTotalVoucher.Location = new System.Drawing.Point(90, 215);
            this.labelTotalVoucher.Name = "labelTotalVoucher";
            this.labelTotalVoucher.Size = new System.Drawing.Size(79, 28);
            this.labelTotalVoucher.TabIndex = 0;
            this.labelTotalVoucher.Text = "Total : 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(109, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "VoucherId :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(205, 133);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(163, 34);
            this.txtSearch.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1178, 133);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(128, 53);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(1044, 133);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 53);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnListOld
            // 
            this.btnListOld.Location = new System.Drawing.Point(776, 133);
            this.btnListOld.Name = "btnListOld";
            this.btnListOld.Size = new System.Drawing.Size(128, 53);
            this.btnListOld.TabIndex = 4;
            this.btnListOld.Text = "List Old";
            this.btnListOld.UseVisualStyleBackColor = true;
            this.btnListOld.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // btnListNow
            // 
            this.btnListNow.Location = new System.Drawing.Point(642, 133);
            this.btnListNow.Name = "btnListNow";
            this.btnListNow.Size = new System.Drawing.Size(128, 53);
            this.btnListNow.TabIndex = 4;
            this.btnListNow.Text = "List Now";
            this.btnListNow.UseVisualStyleBackColor = true;
            this.btnListNow.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(508, 133);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(128, 53);
            this.btnListAll.TabIndex = 4;
            this.btnListAll.Text = "List All";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(374, 133);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 53);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(910, 133);
            this.btnAdd.Name = "btnAdd";
            this.btnAdd.Size = new System.Drawing.Size(128, 53);
            this.btnAdd.TabIndex = 6;
            this.btnAdd.Text = "Add";
            this.btnAdd.UseVisualStyleBackColor = true;
            this.btnAdd.Click += new System.EventHandler(this.BtnAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(598, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Voucher";
            // 
            // dgvListVouchers
            // 
            this.dgvListVouchers.AllowUserToAddRows = false;
            this.dgvListVouchers.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListVouchers.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListVouchers.Location = new System.Drawing.Point(90, 246);
            this.dgvListVouchers.Name = "dgvListVouchers";
            this.dgvListVouchers.ReadOnly = true;
            this.dgvListVouchers.RowHeadersWidth = 80;
            this.dgvListVouchers.RowTemplate.Height = 24;
            this.dgvListVouchers.Size = new System.Drawing.Size(1216, 455);
            this.dgvListVouchers.TabIndex = 8;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.dgvPayments);
            this.panelDetail.Controls.Add(this.btnCancel);
            this.panelDetail.Controls.Add(this.btnConfirm);
            this.panelDetail.Controls.Add(this.txtDiscount);
            this.panelDetail.Controls.Add(this.txtQuantity);
            this.panelDetail.Controls.Add(this.txtCode);
            this.panelDetail.Controls.Add(this.label);
            this.panelDetail.Controls.Add(this.labelTotalPayment);
            this.panelDetail.Controls.Add(this.label5);
            this.panelDetail.Controls.Add(this.label3);
            this.panelDetail.Controls.Add(this.label4);
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1430, 818);
            this.panelDetail.TabIndex = 9;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(122, 106);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersWidth = 80;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.Size = new System.Drawing.Size(1161, 329);
            this.dgvPayments.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(495, 707);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 70);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(809, 707);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(185, 70);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // txtDiscount
            // 
            this.txtDiscount.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDiscount.Location = new System.Drawing.Point(986, 527);
            this.txtDiscount.Name = "txtDiscount";
            this.txtDiscount.Size = new System.Drawing.Size(297, 51);
            this.txtDiscount.TabIndex = 3;
            // 
            // txtQuantity
            // 
            this.txtQuantity.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtQuantity.Location = new System.Drawing.Point(302, 613);
            this.txtQuantity.Name = "txtQuantity";
            this.txtQuantity.Size = new System.Drawing.Size(159, 51);
            this.txtQuantity.TabIndex = 3;
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(302, 524);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(443, 51);
            this.txtCode.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(642, 36);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(171, 45);
            this.label.TabIndex = 4;
            this.label.Text = "Payments";
            // 
            // labelTotalPayment
            // 
            this.labelTotalPayment.AutoSize = true;
            this.labelTotalPayment.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalPayment.Location = new System.Drawing.Point(131, 438);
            this.labelTotalPayment.Name = "labelTotalPayment";
            this.labelTotalPayment.Size = new System.Drawing.Size(132, 45);
            this.labelTotalPayment.TabIndex = 5;
            this.labelTotalPayment.Text = "Total : 0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(134, 613);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(162, 45);
            this.label5.TabIndex = 6;
            this.label5.Text = "Quantity :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(760, 527);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(220, 45);
            this.label3.TabIndex = 6;
            this.label3.Text = "Discount (%) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(134, 524);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(111, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "Code :";
            // 
            // ucManageVoucher
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelGeneral);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucManageVoucher";
            this.Size = new System.Drawing.Size(1430, 818);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListVouchers)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListVouchers;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelTotalPayment;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtDiscount;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtQuantity;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button btnListOld;
        private System.Windows.Forms.Button btnListNow;
        private System.Windows.Forms.Label labelTotalVoucher;
    }
}
