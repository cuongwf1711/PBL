namespace PBL.View
{
    partial class ucManageTypeRoom
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
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListTypeRooms = new System.Windows.Forms.DataGridView();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.dgvRooms = new System.Windows.Forms.DataGridView();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.label = new System.Windows.Forms.Label();
            this.labelTotalRoom = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.labelTotalTypeRoom = new System.Windows.Forms.Label();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTypeRooms)).BeginInit();
            this.panelDetail.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.labelTotalTypeRoom);
            this.panelGeneral.Controls.Add(this.label2);
            this.panelGeneral.Controls.Add(this.txtSearch);
            this.panelGeneral.Controls.Add(this.btnDelete);
            this.panelGeneral.Controls.Add(this.btnUpdate);
            this.panelGeneral.Controls.Add(this.btnListAll);
            this.panelGeneral.Controls.Add(this.btnSearch);
            this.panelGeneral.Controls.Add(this.btnAdd);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Controls.Add(this.dgvListTypeRooms);
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1430, 818);
            this.panelGeneral.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(90, 133);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "TypeRoomId :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(227, 133);
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
            this.btnUpdate.Location = new System.Drawing.Point(993, 133);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 53);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(606, 133);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(128, 53);
            this.btnListAll.TabIndex = 4;
            this.btnListAll.Text = "ListAll";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.BtnListAll_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(416, 133);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 53);
            this.btnSearch.TabIndex = 5;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // btnAdd
            // 
            this.btnAdd.Location = new System.Drawing.Point(802, 133);
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
            this.label1.Size = new System.Drawing.Size(189, 46);
            this.label1.TabIndex = 7;
            this.label1.Text = "TypeRoom";
            // 
            // dgvListTypeRooms
            // 
            this.dgvListTypeRooms.AllowUserToAddRows = false;
            this.dgvListTypeRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListTypeRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListTypeRooms.Location = new System.Drawing.Point(90, 256);
            this.dgvListTypeRooms.Name = "dgvListTypeRooms";
            this.dgvListTypeRooms.ReadOnly = true;
            this.dgvListTypeRooms.RowHeadersWidth = 80;
            this.dgvListTypeRooms.RowTemplate.Height = 24;
            this.dgvListTypeRooms.Size = new System.Drawing.Size(1216, 423);
            this.dgvListTypeRooms.TabIndex = 8;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.dgvRooms);
            this.panelDetail.Controls.Add(this.btnCancel);
            this.panelDetail.Controls.Add(this.btnConfirm);
            this.panelDetail.Controls.Add(this.txtName);
            this.panelDetail.Controls.Add(this.label);
            this.panelDetail.Controls.Add(this.labelTotalRoom);
            this.panelDetail.Controls.Add(this.label4);
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1430, 818);
            this.panelDetail.TabIndex = 3;
            // 
            // dgvRooms
            // 
            this.dgvRooms.AllowUserToAddRows = false;
            this.dgvRooms.AllowUserToDeleteRows = false;
            this.dgvRooms.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvRooms.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvRooms.Location = new System.Drawing.Point(122, 106);
            this.dgvRooms.Name = "dgvRooms";
            this.dgvRooms.ReadOnly = true;
            this.dgvRooms.RowHeadersWidth = 80;
            this.dgvRooms.RowTemplate.Height = 24;
            this.dgvRooms.Size = new System.Drawing.Size(1161, 329);
            this.dgvRooms.TabIndex = 0;
            // 
            // btnCancel
            // 
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancel.Location = new System.Drawing.Point(419, 675);
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
            this.btnConfirm.Location = new System.Drawing.Point(733, 675);
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
            this.txtName.Location = new System.Drawing.Point(610, 554);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(460, 51);
            this.txtName.TabIndex = 3;
            // 
            // label
            // 
            this.label.AutoSize = true;
            this.label.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label.Location = new System.Drawing.Point(641, 28);
            this.label.Name = "label";
            this.label.Size = new System.Drawing.Size(129, 46);
            this.label.TabIndex = 4;
            this.label.Text = "Rooms";
            // 
            // labelTotalRoom
            // 
            this.labelTotalRoom.AutoSize = true;
            this.labelTotalRoom.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalRoom.Location = new System.Drawing.Point(128, 438);
            this.labelTotalRoom.Name = "labelTotalRoom";
            this.labelTotalRoom.Size = new System.Drawing.Size(132, 45);
            this.labelTotalRoom.TabIndex = 5;
            this.labelTotalRoom.Text = "Total : 0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(323, 554);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(281, 45);
            this.label4.TabIndex = 6;
            this.label4.Text = "Name type room :";
            // 
            // labelTotalTypeRoom
            // 
            this.labelTotalTypeRoom.AutoSize = true;
            this.labelTotalTypeRoom.Location = new System.Drawing.Point(90, 225);
            this.labelTotalTypeRoom.Name = "labelTotalTypeRoom";
            this.labelTotalTypeRoom.Size = new System.Drawing.Size(79, 28);
            this.labelTotalTypeRoom.TabIndex = 0;
            this.labelTotalTypeRoom.Text = "Total : 0";
            // 
            // ucManageTypeRoom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelGeneral);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucManageTypeRoom";
            this.Size = new System.Drawing.Size(1430, 818);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListTypeRooms)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvRooms)).EndInit();
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
        private System.Windows.Forms.DataGridView dgvListTypeRooms;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.DataGridView dgvRooms;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btnConfirm;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label;
        private System.Windows.Forms.Label labelTotalRoom;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label labelTotalTypeRoom;
    }
}
