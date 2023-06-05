namespace PBL.View
{
    partial class ucManagePayment
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
            this.cbbDate = new System.Windows.Forms.ComboBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.labelTotalPriceAllPayment = new System.Windows.Forms.Label();
            this.labelTotalPayment = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtSearch = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDetail = new System.Windows.Forms.Button();
            this.btnListAll = new System.Windows.Forms.Button();
            this.btnListNow = new System.Windows.Forms.Button();
            this.btnListOld = new System.Windows.Forms.Button();
            this.btnSearch = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dgvListPayments = new System.Windows.Forms.DataGridView();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.groupBoxLate = new System.Windows.Forms.GroupBox();
            this.labelTotalPriceOnePayment = new System.Windows.Forms.Label();
            this.labelTotalInGroupBoxLate = new System.Windows.Forms.Label();
            this.dgvLate = new System.Windows.Forms.DataGridView();
            this.cbbDeposit = new System.Windows.Forms.ComboBox();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnOk = new System.Windows.Forms.Button();
            this.dgvServices = new System.Windows.Forms.DataGridView();
            this.dgvVoucher = new System.Windows.Forms.DataGridView();
            this.dgvReservations = new System.Windows.Forms.DataGridView();
            this.checkBoxDeposit = new System.Windows.Forms.CheckBox();
            this.checkBoxStatus = new System.Windows.Forms.CheckBox();
            this.dateTimePickerDateCreate = new System.Windows.Forms.DateTimePicker();
            this.labelAccountId = new System.Windows.Forms.Label();
            this.labelPriceServices = new System.Windows.Forms.Label();
            this.lb4 = new System.Windows.Forms.Label();
            this.labelTotalAddition = new System.Windows.Forms.Label();
            this.labelTotalReservation = new System.Windows.Forms.Label();
            this.labelPriceReservations = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.lb3 = new System.Windows.Forms.Label();
            this.labelDeposit = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.labelCustomerId = new System.Windows.Forms.Label();
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPayments)).BeginInit();
            this.panelDetail.SuspendLayout();
            this.groupBoxLate.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).BeginInit();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.cbbDate);
            this.panelGeneral.Controls.Add(this.btnFilter);
            this.panelGeneral.Controls.Add(this.dateTimePickerEnd);
            this.panelGeneral.Controls.Add(this.dateTimePickerStart);
            this.panelGeneral.Controls.Add(this.labelTotalPriceAllPayment);
            this.panelGeneral.Controls.Add(this.labelTotalPayment);
            this.panelGeneral.Controls.Add(this.label2);
            this.panelGeneral.Controls.Add(this.txtSearch);
            this.panelGeneral.Controls.Add(this.btnDelete);
            this.panelGeneral.Controls.Add(this.btnUpdate);
            this.panelGeneral.Controls.Add(this.btnDetail);
            this.panelGeneral.Controls.Add(this.btnListAll);
            this.panelGeneral.Controls.Add(this.btnListNow);
            this.panelGeneral.Controls.Add(this.btnListOld);
            this.panelGeneral.Controls.Add(this.btnSearch);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Controls.Add(this.dgvListPayments);
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1430, 818);
            this.panelGeneral.TabIndex = 1;
            // 
            // cbbDate
            // 
            this.cbbDate.FormattingEnabled = true;
            this.cbbDate.Location = new System.Drawing.Point(90, 727);
            this.cbbDate.Name = "cbbDate";
            this.cbbDate.Size = new System.Drawing.Size(253, 36);
            this.cbbDate.TabIndex = 13;
            // 
            // btnFilter
            // 
            this.btnFilter.Location = new System.Drawing.Point(1173, 729);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(155, 34);
            this.btnFilter.TabIndex = 12;
            this.btnFilter.Text = "Filter";
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Location = new System.Drawing.Point(785, 729);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(345, 34);
            this.dateTimePickerEnd.TabIndex = 10;
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Location = new System.Drawing.Point(388, 727);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(345, 34);
            this.dateTimePickerStart.TabIndex = 10;
            this.dateTimePickerStart.ValueChanged += new System.EventHandler(this.DateTimePickerStart_ValueChanged);
            // 
            // labelTotalPriceAllPayment
            // 
            this.labelTotalPriceAllPayment.AutoSize = true;
            this.labelTotalPriceAllPayment.Location = new System.Drawing.Point(89, 677);
            this.labelTotalPriceAllPayment.Name = "labelTotalPriceAllPayment";
            this.labelTotalPriceAllPayment.Size = new System.Drawing.Size(127, 28);
            this.labelTotalPriceAllPayment.TabIndex = 0;
            this.labelTotalPriceAllPayment.Text = "Total price : 0";
            // 
            // labelTotalPayment
            // 
            this.labelTotalPayment.AutoSize = true;
            this.labelTotalPayment.Location = new System.Drawing.Point(89, 149);
            this.labelTotalPayment.Name = "labelTotalPayment";
            this.labelTotalPayment.Size = new System.Drawing.Size(79, 28);
            this.labelTotalPayment.TabIndex = 0;
            this.labelTotalPayment.Text = "Total : 0";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(89, 88);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(113, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "PaymentId :";
            // 
            // txtSearch
            // 
            this.txtSearch.Location = new System.Drawing.Point(208, 88);
            this.txtSearch.Name = "txtSearch";
            this.txtSearch.Size = new System.Drawing.Size(174, 34);
            this.txtSearch.TabIndex = 1;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(1177, 88);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(151, 53);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.BtnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(909, 88);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(128, 53);
            this.btnUpdate.TabIndex = 3;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.BtnUpdate_Click);
            // 
            // btnDetail
            // 
            this.btnDetail.Location = new System.Drawing.Point(1043, 88);
            this.btnDetail.Name = "btnDetail";
            this.btnDetail.Size = new System.Drawing.Size(128, 53);
            this.btnDetail.TabIndex = 4;
            this.btnDetail.Text = "Detail";
            this.btnDetail.UseVisualStyleBackColor = true;
            this.btnDetail.Click += new System.EventHandler(this.BtnDetail_Click);
            // 
            // btnListAll
            // 
            this.btnListAll.Location = new System.Drawing.Point(527, 88);
            this.btnListAll.Name = "btnListAll";
            this.btnListAll.Size = new System.Drawing.Size(123, 53);
            this.btnListAll.TabIndex = 5;
            this.btnListAll.Text = "List All";
            this.btnListAll.UseVisualStyleBackColor = true;
            this.btnListAll.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // btnListNow
            // 
            this.btnListNow.Location = new System.Drawing.Point(656, 88);
            this.btnListNow.Name = "btnListNow";
            this.btnListNow.Size = new System.Drawing.Size(123, 53);
            this.btnListNow.TabIndex = 5;
            this.btnListNow.Text = "List Now";
            this.btnListNow.UseVisualStyleBackColor = true;
            this.btnListNow.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // btnListOld
            // 
            this.btnListOld.Location = new System.Drawing.Point(785, 88);
            this.btnListOld.Name = "btnListOld";
            this.btnListOld.Size = new System.Drawing.Size(118, 53);
            this.btnListOld.TabIndex = 6;
            this.btnListOld.Text = "List Old";
            this.btnListOld.UseVisualStyleBackColor = true;
            this.btnListOld.Click += new System.EventHandler(this.BtnList_Click);
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(388, 88);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(128, 53);
            this.btnSearch.TabIndex = 7;
            this.btnSearch.Text = "Search";
            this.btnSearch.UseVisualStyleBackColor = true;
            this.btnSearch.Click += new System.EventHandler(this.BtnSearch_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(620, 12);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 45);
            this.label1.TabIndex = 8;
            this.label1.Text = "Payments";
            // 
            // dgvListPayments
            // 
            this.dgvListPayments.AllowUserToAddRows = false;
            this.dgvListPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvListPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvListPayments.Location = new System.Drawing.Point(90, 180);
            this.dgvListPayments.Name = "dgvListPayments";
            this.dgvListPayments.ReadOnly = true;
            this.dgvListPayments.RowHeadersWidth = 80;
            this.dgvListPayments.RowTemplate.Height = 24;
            this.dgvListPayments.Size = new System.Drawing.Size(1239, 494);
            this.dgvListPayments.TabIndex = 9;
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.groupBoxLate);
            this.panelDetail.Controls.Add(this.cbbDeposit);
            this.panelDetail.Controls.Add(this.btnBack);
            this.panelDetail.Controls.Add(this.btnOk);
            this.panelDetail.Controls.Add(this.dgvServices);
            this.panelDetail.Controls.Add(this.dgvVoucher);
            this.panelDetail.Controls.Add(this.dgvReservations);
            this.panelDetail.Controls.Add(this.checkBoxDeposit);
            this.panelDetail.Controls.Add(this.checkBoxStatus);
            this.panelDetail.Controls.Add(this.dateTimePickerDateCreate);
            this.panelDetail.Controls.Add(this.labelCustomerId);
            this.panelDetail.Controls.Add(this.labelAccountId);
            this.panelDetail.Controls.Add(this.labelPriceServices);
            this.panelDetail.Controls.Add(this.lb4);
            this.panelDetail.Controls.Add(this.labelTotalAddition);
            this.panelDetail.Controls.Add(this.labelTotalReservation);
            this.panelDetail.Controls.Add(this.labelPriceReservations);
            this.panelDetail.Controls.Add(this.label5);
            this.panelDetail.Controls.Add(this.lb3);
            this.panelDetail.Controls.Add(this.labelDeposit);
            this.panelDetail.Controls.Add(this.label3);
            this.panelDetail.Location = new System.Drawing.Point(0, 0);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1430, 815);
            this.panelDetail.TabIndex = 0;
            // 
            // groupBoxLate
            // 
            this.groupBoxLate.Controls.Add(this.labelTotalPriceOnePayment);
            this.groupBoxLate.Controls.Add(this.labelTotalInGroupBoxLate);
            this.groupBoxLate.Controls.Add(this.dgvLate);
            this.groupBoxLate.Location = new System.Drawing.Point(24, 442);
            this.groupBoxLate.Name = "groupBoxLate";
            this.groupBoxLate.Size = new System.Drawing.Size(688, 373);
            this.groupBoxLate.TabIndex = 18;
            this.groupBoxLate.TabStop = false;
            this.groupBoxLate.Text = "Late";
            // 
            // labelTotalPriceOnePayment
            // 
            this.labelTotalPriceOnePayment.AutoSize = true;
            this.labelTotalPriceOnePayment.Location = new System.Drawing.Point(184, 314);
            this.labelTotalPriceOnePayment.Name = "labelTotalPriceOnePayment";
            this.labelTotalPriceOnePayment.Size = new System.Drawing.Size(23, 28);
            this.labelTotalPriceOnePayment.TabIndex = 7;
            this.labelTotalPriceOnePayment.Text = "0";
            // 
            // labelTotalInGroupBoxLate
            // 
            this.labelTotalInGroupBoxLate.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalInGroupBoxLate.Location = new System.Drawing.Point(81, 307);
            this.labelTotalInGroupBoxLate.Name = "labelTotalInGroupBoxLate";
            this.labelTotalInGroupBoxLate.Size = new System.Drawing.Size(97, 44);
            this.labelTotalInGroupBoxLate.TabIndex = 0;
            this.labelTotalInGroupBoxLate.Text = "Total :";
            // 
            // dgvLate
            // 
            this.dgvLate.AllowUserToAddRows = false;
            this.dgvLate.AllowUserToDeleteRows = false;
            this.dgvLate.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvLate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvLate.Location = new System.Drawing.Point(6, 33);
            this.dgvLate.MultiSelect = false;
            this.dgvLate.Name = "dgvLate";
            this.dgvLate.ReadOnly = true;
            this.dgvLate.RowHeadersWidth = 50;
            this.dgvLate.RowTemplate.Height = 24;
            this.dgvLate.Size = new System.Drawing.Size(674, 246);
            this.dgvLate.TabIndex = 6;
            this.dgvLate.RowHeaderMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.DgvLate_RowHeaderMouseClick);
            // 
            // cbbDeposit
            // 
            this.cbbDeposit.FormattingEnabled = true;
            this.cbbDeposit.Items.AddRange(new object[] {
            "0.00",
            "0.50",
            "1.00"});
            this.cbbDeposit.Location = new System.Drawing.Point(857, 674);
            this.cbbDeposit.Name = "cbbDeposit";
            this.cbbDeposit.Size = new System.Drawing.Size(158, 36);
            this.cbbDeposit.TabIndex = 1;
            this.cbbDeposit.SelectedIndexChanged += new System.EventHandler(this.CbbDeposit_SelectedIndexChanged);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(730, 745);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(149, 50);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnOk
            // 
            this.btnOk.Location = new System.Drawing.Point(885, 745);
            this.btnOk.Name = "btnOk";
            this.btnOk.Size = new System.Drawing.Size(519, 50);
            this.btnOk.TabIndex = 4;
            this.btnOk.Text = "OK";
            this.btnOk.UseVisualStyleBackColor = true;
            this.btnOk.Click += new System.EventHandler(this.BtnOk_Click);
            // 
            // dgvServices
            // 
            this.dgvServices.AllowUserToAddRows = false;
            this.dgvServices.AllowUserToDeleteRows = false;
            this.dgvServices.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvServices.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvServices.Location = new System.Drawing.Point(730, 126);
            this.dgvServices.Name = "dgvServices";
            this.dgvServices.ReadOnly = true;
            this.dgvServices.RowHeadersWidth = 50;
            this.dgvServices.RowTemplate.Height = 24;
            this.dgvServices.Size = new System.Drawing.Size(674, 313);
            this.dgvServices.TabIndex = 6;
            // 
            // dgvVoucher
            // 
            this.dgvVoucher.AllowUserToAddRows = false;
            this.dgvVoucher.AllowUserToDeleteRows = false;
            this.dgvVoucher.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvVoucher.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvVoucher.Location = new System.Drawing.Point(730, 473);
            this.dgvVoucher.Name = "dgvVoucher";
            this.dgvVoucher.ReadOnly = true;
            this.dgvVoucher.RowHeadersWidth = 50;
            this.dgvVoucher.RowTemplate.Height = 24;
            this.dgvVoucher.Size = new System.Drawing.Size(674, 183);
            this.dgvVoucher.TabIndex = 6;
            // 
            // dgvReservations
            // 
            this.dgvReservations.AllowUserToAddRows = false;
            this.dgvReservations.AllowUserToDeleteRows = false;
            this.dgvReservations.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvReservations.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvReservations.Location = new System.Drawing.Point(24, 126);
            this.dgvReservations.Name = "dgvReservations";
            this.dgvReservations.ReadOnly = true;
            this.dgvReservations.RowHeadersWidth = 50;
            this.dgvReservations.RowTemplate.Height = 24;
            this.dgvReservations.Size = new System.Drawing.Size(674, 313);
            this.dgvReservations.TabIndex = 6;
            // 
            // checkBoxDeposit
            // 
            this.checkBoxDeposit.AutoSize = true;
            this.checkBoxDeposit.Enabled = false;
            this.checkBoxDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxDeposit.Location = new System.Drawing.Point(744, 674);
            this.checkBoxDeposit.Name = "checkBoxDeposit";
            this.checkBoxDeposit.Size = new System.Drawing.Size(107, 32);
            this.checkBoxDeposit.TabIndex = 7;
            this.checkBoxDeposit.Text = "Deposit";
            this.checkBoxDeposit.UseVisualStyleBackColor = true;
            // 
            // checkBoxStatus
            // 
            this.checkBoxStatus.AutoSize = true;
            this.checkBoxStatus.Enabled = false;
            this.checkBoxStatus.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBoxStatus.Location = new System.Drawing.Point(558, 28);
            this.checkBoxStatus.Name = "checkBoxStatus";
            this.checkBoxStatus.Size = new System.Drawing.Size(120, 42);
            this.checkBoxStatus.TabIndex = 8;
            this.checkBoxStatus.Text = "Status";
            this.checkBoxStatus.UseVisualStyleBackColor = true;
            // 
            // dateTimePickerDateCreate
            // 
            this.dateTimePickerDateCreate.CustomFormat = "dd/MM/yyyy - HH:mm";
            this.dateTimePickerDateCreate.Enabled = false;
            this.dateTimePickerDateCreate.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerDateCreate.Location = new System.Drawing.Point(207, 32);
            this.dateTimePickerDateCreate.Name = "dateTimePickerDateCreate";
            this.dateTimePickerDateCreate.Size = new System.Drawing.Size(265, 34);
            this.dateTimePickerDateCreate.TabIndex = 9;
            // 
            // labelAccountId
            // 
            this.labelAccountId.AutoSize = true;
            this.labelAccountId.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelAccountId.Location = new System.Drawing.Point(739, 30);
            this.labelAccountId.Name = "labelAccountId";
            this.labelAccountId.Size = new System.Drawing.Size(178, 38);
            this.labelAccountId.TabIndex = 11;
            this.labelAccountId.Text = "AccountId : 0";
            // 
            // labelPriceServices
            // 
            this.labelPriceServices.AutoSize = true;
            this.labelPriceServices.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceServices.Location = new System.Drawing.Point(838, 95);
            this.labelPriceServices.Name = "labelPriceServices";
            this.labelPriceServices.Size = new System.Drawing.Size(23, 28);
            this.labelPriceServices.TabIndex = 12;
            this.labelPriceServices.Text = "0";
            // 
            // lb4
            // 
            this.lb4.AutoSize = true;
            this.lb4.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb4.Location = new System.Drawing.Point(741, 95);
            this.lb4.Name = "lb4";
            this.lb4.Size = new System.Drawing.Size(91, 28);
            this.lb4.TabIndex = 13;
            this.lb4.Text = "Services :";
            // 
            // labelTotalAddition
            // 
            this.labelTotalAddition.AutoSize = true;
            this.labelTotalAddition.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalAddition.Location = new System.Drawing.Point(1177, 95);
            this.labelTotalAddition.Name = "labelTotalAddition";
            this.labelTotalAddition.Size = new System.Drawing.Size(79, 28);
            this.labelTotalAddition.TabIndex = 14;
            this.labelTotalAddition.Text = "Total : 0";
            // 
            // labelTotalReservation
            // 
            this.labelTotalReservation.AutoSize = true;
            this.labelTotalReservation.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotalReservation.Location = new System.Drawing.Point(442, 95);
            this.labelTotalReservation.Name = "labelTotalReservation";
            this.labelTotalReservation.Size = new System.Drawing.Size(79, 28);
            this.labelTotalReservation.TabIndex = 14;
            this.labelTotalReservation.Text = "Total : 0";
            // 
            // labelPriceReservations
            // 
            this.labelPriceReservations.AutoSize = true;
            this.labelPriceReservations.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPriceReservations.Location = new System.Drawing.Point(161, 95);
            this.labelPriceReservations.Name = "labelPriceReservations";
            this.labelPriceReservations.Size = new System.Drawing.Size(23, 28);
            this.labelPriceReservations.TabIndex = 14;
            this.labelPriceReservations.Text = "0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(741, 442);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(92, 28);
            this.label5.TabIndex = 15;
            this.label5.Text = "Voucher :";
            // 
            // lb3
            // 
            this.lb3.AutoSize = true;
            this.lb3.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb3.Location = new System.Drawing.Point(25, 95);
            this.lb3.Name = "lb3";
            this.lb3.Size = new System.Drawing.Size(130, 28);
            this.lb3.TabIndex = 15;
            this.lb3.Text = "Reservations :";
            // 
            // labelDeposit
            // 
            this.labelDeposit.AutoSize = true;
            this.labelDeposit.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelDeposit.Location = new System.Drawing.Point(1023, 675);
            this.labelDeposit.Name = "labelDeposit";
            this.labelDeposit.Size = new System.Drawing.Size(23, 28);
            this.labelDeposit.TabIndex = 16;
            this.labelDeposit.Text = "0";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(32, 28);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(169, 38);
            this.label3.TabIndex = 17;
            this.label3.Text = "DateCreate :";
            // 
            // labelCustomerId
            // 
            this.labelCustomerId.AutoSize = true;
            this.labelCustomerId.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelCustomerId.Location = new System.Drawing.Point(1078, 28);
            this.labelCustomerId.Name = "labelCustomerId";
            this.labelCustomerId.Size = new System.Drawing.Size(196, 38);
            this.labelCustomerId.TabIndex = 11;
            this.labelCustomerId.Text = "CustomerId : 0";
            // 
            // ucManagePayment
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelDetail);
            this.Controls.Add(this.panelGeneral);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "ucManagePayment";
            this.Size = new System.Drawing.Size(1430, 818);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvListPayments)).EndInit();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.groupBoxLate.ResumeLayout(false);
            this.groupBoxLate.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvLate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvServices)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvVoucher)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvReservations)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtSearch;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnListOld;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dgvListPayments;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label labelAccountId;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnListNow;
        private System.Windows.Forms.CheckBox checkBoxStatus;
        private System.Windows.Forms.DateTimePicker dateTimePickerDateCreate;
        private System.Windows.Forms.DataGridView dgvReservations;
        private System.Windows.Forms.Label lb4;
        private System.Windows.Forms.Label lb3;
        private System.Windows.Forms.Button btnOk;
        private System.Windows.Forms.Label labelDeposit;
        private System.Windows.Forms.ComboBox cbbDeposit;
        private System.Windows.Forms.CheckBox checkBoxDeposit;
        private System.Windows.Forms.Button btnDetail;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Label labelPriceServices;
        private System.Windows.Forms.Label labelPriceReservations;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnListAll;
        private System.Windows.Forms.Button btnFilter;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DataGridView dgvServices;
        private System.Windows.Forms.ComboBox cbbDate;
        private System.Windows.Forms.DataGridView dgvVoucher;
        private System.Windows.Forms.DataGridView dgvLate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.GroupBox groupBoxLate;
        private System.Windows.Forms.Label labelTotalInGroupBoxLate;
        private System.Windows.Forms.Label labelTotalPayment;
        private System.Windows.Forms.Label labelTotalAddition;
        private System.Windows.Forms.Label labelTotalReservation;
        private System.Windows.Forms.Label labelTotalPriceAllPayment;
        private System.Windows.Forms.Label labelTotalPriceOnePayment;
        private System.Windows.Forms.Label labelCustomerId;
    }
}
