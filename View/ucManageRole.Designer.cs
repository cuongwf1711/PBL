namespace PBL.View
{
    partial class ucManageRole
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
            this.labelTotalRole = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListRoles = new System.Windows.Forms.DataGridView();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.dgvAccounts = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lb = new System.Windows.Forms.Label();
            this.labelTotalAccount = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBoxPermission = new System.Windows.Forms.GroupBox();
            this.checkBoxTypeRoom = new System.Windows.Forms.CheckBox();
            this.checkBoxRoom = new System.Windows.Forms.CheckBox();
            this.checkBoxService = new System.Windows.Forms.CheckBox();
            this.checkBoxCustomer = new System.Windows.Forms.CheckBox();
            this.checkBoxLate = new System.Windows.Forms.CheckBox();
            this.checkBoxVoucher = new System.Windows.Forms.CheckBox();
            this.checkBoxPayment = new System.Windows.Forms.CheckBox();
            this.checkBoxBookRoom = new System.Windows.Forms.CheckBox();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRoles)).BeginInit();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).BeginInit();
            this.groupBoxPermission.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.labelTotalRole);
            this.panelGeneral.Controls.Add(this.label2);
            this.panelGeneral.Controls.Add(this.txtSearch);
            this.panelGeneral.Controls.Add(this.btnDelete);
            this.panelGeneral.Controls.Add(this.btnUpdate);
            this.panelGeneral.Controls.Add(this.btnListAll);
            this.panelGeneral.Controls.Add(this.btnSearch);
            this.panelGeneral.Controls.Add(this.btnAdd);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Controls.Add(this.dgvListRoles);
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1430, 818);
            this.panelGeneral.TabIndex = 1;
            // 
            // labelTotalRole
            // 
            this.labelTotalRole.AutoSize = true;
            this.labelTotalRole.Location = new System.Drawing.Point(90, 225);
            this.labelTotalRole.Name = "labelTotalRole";
            this.labelTotalRole.Size = new System.Drawing.Size(79, 28);
            this.labelTotalRole.TabIndex = 0;
            this.labelTotalRole.Text = "Total : 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(76, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "RoleId :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(172, 133);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(169, 34);
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
            this.btnUpdate.Location = new System.Drawing.Point(986, 133);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 53);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(589, 133);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(128, 53);
            this.btnListAll.TabIndex = 4;
            this.btnListAll.Text = "ListAll";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.BtnListAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(361, 133);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 53);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(790, 133);
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
            this.label1.Size = new System.Drawing.Size(88, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Role";
            // 
            // dgvListRoles
            // 
            this.dgvListRoles.AllowUserToAddRows = false;
            this.dgvListRoles.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListRoles.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListRoles.Location = new System.Drawing.Point(90, 256);
            this.dgvListRoles.Name = "dgvListRoles";
            this.dgvListRoles.ReadOnly = true;
            this.dgvListRoles.RowHeadersWidth = 80;
            this.dgvListRoles.RowTemplate.Height = 24;
            this.dgvListRoles.Size = new System.Drawing.Size(1216, 423);
            this.dgvListRoles.TabIndex = 8;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.groupBoxPermission);
            this.panelDetail.Controls.Add(this.dgvAccounts);
            this.panelDetail.Controls.Add(this.btnCancel);
            this.panelDetail.Controls.Add(this.btnConfirm);
            this.panelDetail.Controls.Add(this.txtName);
            this.panelDetail.Controls.Add(this.lb);
            this.panelDetail.Controls.Add(this.labelTotalAccount);
            this.panelDetail.Controls.Add(this.label4);
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1430, 818);
            this.panelDetail.TabIndex = 0;
            // 
            // dgvAccounts
            // 
            this.dgvAccounts.AllowUserToAddRows = false;
            this.dgvAccounts.AllowUserToDeleteRows = false;
            this.dgvAccounts.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAccounts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAccounts.Location = new System.Drawing.Point(790, 108);
            this.dgvAccounts.Name = "dgvAccounts";
            this.dgvAccounts.ReadOnly = true;
            this.dgvAccounts.RowHeadersWidth = 80;
            this.dgvAccounts.RowTemplate.Height = 24;
            this.dgvAccounts.Size = new System.Drawing.Size(618, 523);
            this.dgvAccounts.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(128, 685);
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
            this.btnConfirm.Location = new System.Drawing.Point(442, 685);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(185, 70);
            this.btnConfirm.TabIndex = 2;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(227, 108);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(460, 51);
            this.txtName.TabIndex = 3;
            // 
            // lb
            // 
            this.lb.AutoSize = true;
            this.lb.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb.Location = new System.Drawing.Point(1045, 46);
            this.lb.Name = "lb";
            this.lb.Size = new System.Drawing.Size(163, 45);
            this.lb.TabIndex = 4;
            this.lb.Text = "Accounts";
            // 
            // labelTotalAccount
            // 
            this.labelTotalAccount.AutoSize = true;
            this.labelTotalAccount.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAccount.Location = new System.Drawing.Point(806, 634);
            this.labelTotalAccount.Name = "labelTotalAccount";
            this.labelTotalAccount.Size = new System.Drawing.Size(132, 45);
            this.labelTotalAccount.TabIndex = 5;
            this.labelTotalAccount.Text = "Total : 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 108);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(187, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name role :";
            // 
            // groupBoxPermission
            // 
            this.groupBoxPermission.Controls.Add(this.checkBoxVoucher);
            this.groupBoxPermission.Controls.Add(this.checkBoxCustomer);
            this.groupBoxPermission.Controls.Add(this.checkBoxRoom);
            this.groupBoxPermission.Controls.Add(this.checkBoxBookRoom);
            this.groupBoxPermission.Controls.Add(this.checkBoxPayment);
            this.groupBoxPermission.Controls.Add(this.checkBoxLate);
            this.groupBoxPermission.Controls.Add(this.checkBoxService);
            this.groupBoxPermission.Controls.Add(this.checkBoxTypeRoom);
            this.groupBoxPermission.Location = new System.Drawing.Point(42, 192);
            this.groupBoxPermission.Name = "groupBoxPermission";
            this.groupBoxPermission.Size = new System.Drawing.Size(709, 439);
            this.groupBoxPermission.TabIndex = 7;
            this.groupBoxPermission.TabStop = false;
            this.groupBoxPermission.Text = "Permissions";
            // 
            // checkBoxTypeRoom
            // 
            this.checkBoxTypeRoom.AutoSize = true;
            this.checkBoxTypeRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxTypeRoom.Location = new System.Drawing.Point(75, 71);
            this.checkBoxTypeRoom.Name = "checkBoxTypeRoom";
            this.checkBoxTypeRoom.Size = new System.Drawing.Size(127, 32);
            this.checkBoxTypeRoom.TabIndex = 0;
            this.checkBoxTypeRoom.Text = "TypeRoom";
            this.checkBoxTypeRoom.UseVisualStyleBackColor = true;
            // 
            // checkBoxRoom
            // 
            this.checkBoxRoom.AutoSize = true;
            this.checkBoxRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxRoom.Location = new System.Drawing.Point(426, 71);
            this.checkBoxRoom.Name = "checkBoxRoom";
            this.checkBoxRoom.Size = new System.Drawing.Size(86, 32);
            this.checkBoxRoom.TabIndex = 0;
            this.checkBoxRoom.Text = "Room";
            this.checkBoxRoom.UseVisualStyleBackColor = true;
            // 
            // checkBoxService
            // 
            this.checkBoxService.AutoSize = true;
            this.checkBoxService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxService.Location = new System.Drawing.Point(75, 159);
            this.checkBoxService.Name = "checkBoxService";
            this.checkBoxService.Size = new System.Drawing.Size(96, 32);
            this.checkBoxService.TabIndex = 0;
            this.checkBoxService.Text = "Service";
            this.checkBoxService.UseVisualStyleBackColor = true;
            // 
            // checkBoxCustomer
            // 
            this.checkBoxCustomer.AutoSize = true;
            this.checkBoxCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxCustomer.Location = new System.Drawing.Point(426, 159);
            this.checkBoxCustomer.Name = "checkBoxCustomer";
            this.checkBoxCustomer.Size = new System.Drawing.Size(118, 32);
            this.checkBoxCustomer.TabIndex = 0;
            this.checkBoxCustomer.Text = "Customer";
            this.checkBoxCustomer.UseVisualStyleBackColor = true;
            // 
            // checkBoxLate
            // 
            this.checkBoxLate.AutoSize = true;
            this.checkBoxLate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxLate.Location = new System.Drawing.Point(75, 246);
            this.checkBoxLate.Name = "checkBoxLate";
            this.checkBoxLate.Size = new System.Drawing.Size(70, 32);
            this.checkBoxLate.TabIndex = 0;
            this.checkBoxLate.Text = "Late";
            this.checkBoxLate.UseVisualStyleBackColor = true;
            // 
            // checkBoxVoucher
            // 
            this.checkBoxVoucher.AutoSize = true;
            this.checkBoxVoucher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxVoucher.Location = new System.Drawing.Point(426, 246);
            this.checkBoxVoucher.Name = "checkBoxVoucher";
            this.checkBoxVoucher.Size = new System.Drawing.Size(105, 32);
            this.checkBoxVoucher.TabIndex = 0;
            this.checkBoxVoucher.Text = "Voucher";
            this.checkBoxVoucher.UseVisualStyleBackColor = true;
            // 
            // checkBoxPayment
            // 
            this.checkBoxPayment.AutoSize = true;
            this.checkBoxPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxPayment.Location = new System.Drawing.Point(75, 335);
            this.checkBoxPayment.Name = "checkBoxPayment";
            this.checkBoxPayment.Size = new System.Drawing.Size(109, 32);
            this.checkBoxPayment.TabIndex = 0;
            this.checkBoxPayment.Text = "Payment";
            this.checkBoxPayment.UseVisualStyleBackColor = true;
            // 
            // checkBoxBookRoom
            // 
            this.checkBoxBookRoom.AutoSize = true;
            this.checkBoxBookRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxBookRoom.Location = new System.Drawing.Point(426, 335);
            this.checkBoxBookRoom.Name = "checkBoxBookRoom";
            this.checkBoxBookRoom.Size = new System.Drawing.Size(131, 32);
            this.checkBoxBookRoom.TabIndex = 0;
            this.checkBoxBookRoom.Text = "BookRoom";
            this.checkBoxBookRoom.UseVisualStyleBackColor = true;
            // 
            // ucManageRole
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelGeneral);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucManageRole";
            this.Size = new System.Drawing.Size(1430, 818);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListRoles)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAccounts)).EndInit();
            this.groupBoxPermission.ResumeLayout(false);
            this.groupBoxPermission.PerformLayout();
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
        private System.Windows.Forms.DataGridView dgvListRoles;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridView dgvAccounts;
        private System.Windows.Forms.Label lb;
        private System.Windows.Forms.Label labelTotalAccount;
        private System.Windows.Forms.Label labelTotalRole;
        private System.Windows.Forms.GroupBox groupBoxPermission;
        private System.Windows.Forms.CheckBox checkBoxTypeRoom;
        private System.Windows.Forms.CheckBox checkBoxRoom;
        private System.Windows.Forms.CheckBox checkBoxVoucher;
        private System.Windows.Forms.CheckBox checkBoxCustomer;
        private System.Windows.Forms.CheckBox checkBoxPayment;
        private System.Windows.Forms.CheckBox checkBoxLate;
        private System.Windows.Forms.CheckBox checkBoxService;
        private System.Windows.Forms.CheckBox checkBoxBookRoom;
    }
}
