namespace PBL.View
{
    partial class ucManageService
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
            this.panelDetail = new System.Windows.Forms.Panel();
            this.dgvAdditions = new System.Windows.Forms.DataGridView();
            this.labelTotalAddition = new System.Windows.Forms.Label();
            this.labelAdditions = new System.Windows.Forms.Label();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtPrice = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.labelTotalService = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListServices = new System.Windows.Forms.DataGridView();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditions)).BeginInit();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListServices)).BeginInit();
            this.SuspendLayout();
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.dgvAdditions);
            this.panelDetail.Controls.Add(this.labelTotalAddition);
            this.panelDetail.Controls.Add(this.labelAdditions);
            this.panelDetail.Controls.Add(this.btnCancel);
            this.panelDetail.Controls.Add(this.btnConfirm);
            this.panelDetail.Controls.Add(this.txtPrice);
            this.panelDetail.Controls.Add(this.txtName);
            this.panelDetail.Controls.Add(this.label6);
            this.panelDetail.Controls.Add(this.label4);
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1430, 818);
            this.panelDetail.TabIndex = 0;
            // 
            // dgvAdditions
            // 
            this.dgvAdditions.AllowUserToAddRows = false;
            this.dgvAdditions.AllowUserToDeleteRows = false;
            this.dgvAdditions.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvAdditions.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAdditions.Location = new System.Drawing.Point(687, 120);
            this.dgvAdditions.Name = "dgvAdditions";
            this.dgvAdditions.ReadOnly = true;
            this.dgvAdditions.RowHeadersWidth = 50;
            this.dgvAdditions.RowTemplate.Height = 24;
            this.dgvAdditions.Size = new System.Drawing.Size(661, 559);
            this.dgvAdditions.TabIndex = 0;
            // 
            // labelTotalAddition
            // 
            this.labelTotalAddition.AutoSize = true;
            this.labelTotalAddition.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAddition.Location = new System.Drawing.Point(693, 682);
            this.labelTotalAddition.Name = "labelTotalAddition";
            this.labelTotalAddition.Size = new System.Drawing.Size(132, 45);
            this.labelTotalAddition.TabIndex = 1;
            this.labelTotalAddition.Text = "Total : 0";
            // 
            // labelAdditions
            // 
            this.labelAdditions.AutoSize = true;
            this.labelAdditions.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAdditions.Location = new System.Drawing.Point(949, 46);
            this.labelAdditions.Name = "labelAdditions";
            this.labelAdditions.Size = new System.Drawing.Size(169, 45);
            this.labelAdditions.TabIndex = 2;
            this.labelAdditions.Text = "Additions";
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(64, 474);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(185, 70);
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // btnConfirm
            // 
            this.btnConfirm.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirm.Location = new System.Drawing.Point(378, 474);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(185, 70);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "Confirm";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.BtnConfirm_Click);
            // 
            // txtPrice
            // 
            this.txtPrice.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPrice.Location = new System.Drawing.Point(326, 328);
            this.txtPrice.Name = "txtPrice";
            this.txtPrice.Size = new System.Drawing.Size(272, 51);
            this.txtPrice.TabIndex = 5;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(326, 192);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(272, 51);
            this.txtName.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 328);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(231, 45);
            this.label6.TabIndex = 8;
            this.label6.Text = "Price (K VND) :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 192);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 45);
            this.label4.TabIndex = 10;
            this.label4.Text = "Name :";
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.labelTotalService);
            this.panelGeneral.Controls.Add(this.label2);
            this.panelGeneral.Controls.Add(this.txtSearch);
            this.panelGeneral.Controls.Add(this.btnDelete);
            this.panelGeneral.Controls.Add(this.btnUpdate);
            this.panelGeneral.Controls.Add(this.btnListAll);
            this.panelGeneral.Controls.Add(this.btnSearch);
            this.panelGeneral.Controls.Add(this.btnAdd);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Controls.Add(this.dgvListServices);
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1430, 818);
            this.panelGeneral.TabIndex = 1;
            // 
            // labelTotalService
            // 
            this.labelTotalService.AutoSize = true;
            this.labelTotalService.Location = new System.Drawing.Point(90, 225);
            this.labelTotalService.Name = "labelTotalService";
            this.labelTotalService.Size = new System.Drawing.Size(79, 28);
            this.labelTotalService.TabIndex = 0;
            this.labelTotalService.Text = "Total : 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(100, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "ServiceId :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(196, 133);
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
            this.btnSearch.Location = new System.Drawing.Point(375, 133);
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
            this.label1.Location = new System.Drawing.Point(612, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(147, 45);
            this.label1.TabIndex = 7;
            this.label1.Text = "Services";
            // 
            // dgvListServices
            // 
            this.dgvListServices.AllowUserToAddRows = false;
            this.dgvListServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListServices.Location = new System.Drawing.Point(90, 256);
            this.dgvListServices.Name = "dgvListServices";
            this.dgvListServices.ReadOnly = true;
            this.dgvListServices.RowHeadersWidth = 80;
            this.dgvListServices.RowTemplate.Height = 24;
            this.dgvListServices.Size = new System.Drawing.Size(1216, 423);
            this.dgvListServices.TabIndex = 8;
            // 
            // ucManageService
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelGeneral);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucManageService";
            this.Size = new System.Drawing.Size(1430, 818);
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAdditions)).EndInit();
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListServices)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtPrice;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListServices;
        private System.Windows.Forms.DataGridView dgvAdditions;
        private System.Windows.Forms.Label labelAdditions;
        private System.Windows.Forms.Label labelTotalAddition;
        private System.Windows.Forms.Label labelTotalService;
    }
}
