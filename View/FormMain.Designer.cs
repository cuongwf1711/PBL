namespace PBL.View
{
    partial class FormMain
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormMain));
            this.flowLayoutPanelSidebar = new System.Windows.Forms.FlowLayoutPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBoxMenu = new System.Windows.Forms.PictureBox();
            this.btnBookRoom = new System.Windows.Forms.Button();
            this.btnCustomer = new System.Windows.Forms.Button();
            this.btnMyAccount = new System.Windows.Forms.Button();
            this.btnPayment = new System.Windows.Forms.Button();
            this.btnRoom = new System.Windows.Forms.Button();
            this.btnService = new System.Windows.Forms.Button();
            this.btnEmployee = new System.Windows.Forms.Button();
            this.btnRole = new System.Windows.Forms.Button();
            this.btnTypeRoom = new System.Windows.Forms.Button();
            this.btnVoucher = new System.Windows.Forms.Button();
            this.btnLate = new System.Windows.Forms.Button();
            this.btnLogout = new System.Windows.Forms.Button();
            this.timerSidebar = new System.Windows.Forms.Timer(this.components);
            this.pictureBoxHome = new System.Windows.Forms.PictureBox();
            this.ucManageRole1 = new PBL.View.ucManageRole();
            this.ucManageEmployee1 = new PBL.View.ucManageEmployee();
            this.ucManageCustomer1 = new PBL.View.ucManageCustomer();
            this.ucBookRoom1 = new PBL.View.ucBookRoom();
            this.ucManageRoom1 = new PBL.View.ucManageRoom();
            this.ucMyAccount1 = new PBL.View.ucMyAccount();
            this.ucManageTypeRoom1 = new PBL.View.ucManageTypeRoom();
            this.ucManagePayment1 = new PBL.View.ucManagePayment();
            this.ucManageService1 = new PBL.View.ucManageService();
            this.ucManageLate1 = new PBL.View.ucManageLate();
            this.ucManageVoucher1 = new PBL.View.ucManageVoucher();
            this.flowLayoutPanelSidebar.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).BeginInit();
            this.SuspendLayout();
            // 
            // flowLayoutPanelSidebar
            // 
            this.flowLayoutPanelSidebar.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.flowLayoutPanelSidebar.Controls.Add(this.panel1);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnBookRoom);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnCustomer);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnMyAccount);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnPayment);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnRoom);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnService);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnEmployee);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnRole);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnTypeRoom);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnVoucher);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnLate);
            this.flowLayoutPanelSidebar.Controls.Add(this.btnLogout);
            this.flowLayoutPanelSidebar.Dock = System.Windows.Forms.DockStyle.Left;
            this.flowLayoutPanelSidebar.Location = new System.Drawing.Point(0, 0);
            this.flowLayoutPanelSidebar.MaximumSize = new System.Drawing.Size(500, 0);
            this.flowLayoutPanelSidebar.MinimumSize = new System.Drawing.Size(80, 0);
            this.flowLayoutPanelSidebar.Name = "flowLayoutPanelSidebar";
            this.flowLayoutPanelSidebar.Size = new System.Drawing.Size(80, 841);
            this.flowLayoutPanelSidebar.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.pictureBoxMenu);
            this.panel1.Location = new System.Drawing.Point(3, 3);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(497, 80);
            this.panel1.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 28.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(222, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(153, 62);
            this.label1.TabIndex = 0;
            this.label1.Text = "Menu";
            // 
            // pictureBoxMenu
            // 
            this.pictureBoxMenu.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBoxMenu.Cursor = System.Windows.Forms.Cursors.Hand;
            this.pictureBoxMenu.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxMenu.Image")));
            this.pictureBoxMenu.Location = new System.Drawing.Point(5, 8);
            this.pictureBoxMenu.Name = "pictureBoxMenu";
            this.pictureBoxMenu.Size = new System.Drawing.Size(64, 64);
            this.pictureBoxMenu.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxMenu.TabIndex = 1;
            this.pictureBoxMenu.TabStop = false;
            this.pictureBoxMenu.Click += new System.EventHandler(this.PictureBoxMenu_Click);
            // 
            // btnBookRoom
            // 
            this.btnBookRoom.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.btnBookRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnBookRoom.FlatAppearance.BorderSize = 0;
            this.btnBookRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnBookRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBookRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnBookRoom.Image")));
            this.btnBookRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBookRoom.Location = new System.Drawing.Point(3, 89);
            this.btnBookRoom.Name = "btnBookRoom";
            this.btnBookRoom.Size = new System.Drawing.Size(237, 75);
            this.btnBookRoom.TabIndex = 1;
            this.btnBookRoom.Text = "Book room";
            this.btnBookRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnBookRoom.UseVisualStyleBackColor = false;
            this.btnBookRoom.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnCustomer
            // 
            this.btnCustomer.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCustomer.FlatAppearance.BorderSize = 0;
            this.btnCustomer.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnCustomer.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCustomer.Image = ((System.Drawing.Image)(resources.GetObject("btnCustomer.Image")));
            this.btnCustomer.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnCustomer.Location = new System.Drawing.Point(3, 170);
            this.btnCustomer.Name = "btnCustomer";
            this.btnCustomer.Size = new System.Drawing.Size(237, 75);
            this.btnCustomer.TabIndex = 2;
            this.btnCustomer.Text = "Customer";
            this.btnCustomer.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnCustomer.UseVisualStyleBackColor = true;
            this.btnCustomer.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnMyAccount
            // 
            this.btnMyAccount.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMyAccount.FlatAppearance.BorderSize = 0;
            this.btnMyAccount.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnMyAccount.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMyAccount.Image = ((System.Drawing.Image)(resources.GetObject("btnMyAccount.Image")));
            this.btnMyAccount.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnMyAccount.Location = new System.Drawing.Point(3, 251);
            this.btnMyAccount.Name = "btnMyAccount";
            this.btnMyAccount.Size = new System.Drawing.Size(237, 75);
            this.btnMyAccount.TabIndex = 3;
            this.btnMyAccount.Text = "My Account";
            this.btnMyAccount.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnMyAccount.UseVisualStyleBackColor = true;
            this.btnMyAccount.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnPayment
            // 
            this.btnPayment.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnPayment.FlatAppearance.BorderSize = 0;
            this.btnPayment.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnPayment.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnPayment.Image = ((System.Drawing.Image)(resources.GetObject("btnPayment.Image")));
            this.btnPayment.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnPayment.Location = new System.Drawing.Point(3, 332);
            this.btnPayment.Name = "btnPayment";
            this.btnPayment.Size = new System.Drawing.Size(237, 75);
            this.btnPayment.TabIndex = 4;
            this.btnPayment.Text = "Payment";
            this.btnPayment.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnPayment.UseVisualStyleBackColor = true;
            this.btnPayment.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnRoom
            // 
            this.btnRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRoom.FlatAppearance.BorderSize = 0;
            this.btnRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnRoom.Image")));
            this.btnRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRoom.Location = new System.Drawing.Point(3, 413);
            this.btnRoom.Name = "btnRoom";
            this.btnRoom.Size = new System.Drawing.Size(237, 75);
            this.btnRoom.TabIndex = 5;
            this.btnRoom.Text = "Room";
            this.btnRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRoom.UseVisualStyleBackColor = true;
            this.btnRoom.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnService
            // 
            this.btnService.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnService.FlatAppearance.BorderSize = 0;
            this.btnService.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnService.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnService.Image = ((System.Drawing.Image)(resources.GetObject("btnService.Image")));
            this.btnService.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnService.Location = new System.Drawing.Point(3, 494);
            this.btnService.Name = "btnService";
            this.btnService.Size = new System.Drawing.Size(237, 75);
            this.btnService.TabIndex = 6;
            this.btnService.Text = "Service";
            this.btnService.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnService.UseVisualStyleBackColor = true;
            this.btnService.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnEmployee
            // 
            this.btnEmployee.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEmployee.FlatAppearance.BorderSize = 0;
            this.btnEmployee.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnEmployee.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEmployee.Image = ((System.Drawing.Image)(resources.GetObject("btnEmployee.Image")));
            this.btnEmployee.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnEmployee.Location = new System.Drawing.Point(3, 575);
            this.btnEmployee.Name = "btnEmployee";
            this.btnEmployee.Size = new System.Drawing.Size(237, 75);
            this.btnEmployee.TabIndex = 7;
            this.btnEmployee.Text = "Employee";
            this.btnEmployee.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnEmployee.UseVisualStyleBackColor = true;
            this.btnEmployee.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnRole
            // 
            this.btnRole.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRole.FlatAppearance.BorderSize = 0;
            this.btnRole.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnRole.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRole.Image = ((System.Drawing.Image)(resources.GetObject("btnRole.Image")));
            this.btnRole.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRole.Location = new System.Drawing.Point(3, 656);
            this.btnRole.Name = "btnRole";
            this.btnRole.Size = new System.Drawing.Size(237, 75);
            this.btnRole.TabIndex = 8;
            this.btnRole.Text = "Role";
            this.btnRole.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnRole.UseVisualStyleBackColor = true;
            this.btnRole.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnTypeRoom
            // 
            this.btnTypeRoom.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnTypeRoom.FlatAppearance.BorderSize = 0;
            this.btnTypeRoom.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnTypeRoom.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnTypeRoom.Image = ((System.Drawing.Image)(resources.GetObject("btnTypeRoom.Image")));
            this.btnTypeRoom.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnTypeRoom.Location = new System.Drawing.Point(3, 737);
            this.btnTypeRoom.Name = "btnTypeRoom";
            this.btnTypeRoom.Size = new System.Drawing.Size(237, 75);
            this.btnTypeRoom.TabIndex = 9;
            this.btnTypeRoom.Text = "Type room";
            this.btnTypeRoom.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnTypeRoom.UseVisualStyleBackColor = true;
            this.btnTypeRoom.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnVoucher
            // 
            this.btnVoucher.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnVoucher.FlatAppearance.BorderSize = 0;
            this.btnVoucher.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnVoucher.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnVoucher.Image = ((System.Drawing.Image)(resources.GetObject("btnVoucher.Image")));
            this.btnVoucher.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnVoucher.Location = new System.Drawing.Point(3, 818);
            this.btnVoucher.Name = "btnVoucher";
            this.btnVoucher.Size = new System.Drawing.Size(237, 75);
            this.btnVoucher.TabIndex = 10;
            this.btnVoucher.Text = "Voucher";
            this.btnVoucher.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnVoucher.UseVisualStyleBackColor = true;
            this.btnVoucher.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnLate
            // 
            this.btnLate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLate.FlatAppearance.BorderSize = 0;
            this.btnLate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLate.Image = ((System.Drawing.Image)(resources.GetObject("btnLate.Image")));
            this.btnLate.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLate.Location = new System.Drawing.Point(3, 899);
            this.btnLate.Name = "btnLate";
            this.btnLate.Size = new System.Drawing.Size(237, 75);
            this.btnLate.TabIndex = 11;
            this.btnLate.Text = "Late";
            this.btnLate.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLate.UseVisualStyleBackColor = true;
            this.btnLate.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // btnLogout
            // 
            this.btnLogout.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnLogout.FlatAppearance.BorderSize = 0;
            this.btnLogout.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnLogout.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLogout.Image = ((System.Drawing.Image)(resources.GetObject("btnLogout.Image")));
            this.btnLogout.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnLogout.Location = new System.Drawing.Point(3, 980);
            this.btnLogout.Name = "btnLogout";
            this.btnLogout.Size = new System.Drawing.Size(237, 75);
            this.btnLogout.TabIndex = 12;
            this.btnLogout.Text = "Logout";
            this.btnLogout.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnLogout.UseVisualStyleBackColor = true;
            this.btnLogout.Click += new System.EventHandler(this.SidebarButton_Click);
            // 
            // timerSidebar
            // 
            this.timerSidebar.Interval = 5;
            this.timerSidebar.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // pictureBoxHome
            // 
            this.pictureBoxHome.Image = ((System.Drawing.Image)(resources.GetObject("pictureBoxHome.Image")));
            this.pictureBoxHome.Location = new System.Drawing.Point(88, 12);
            this.pictureBoxHome.Name = "pictureBoxHome";
            this.pictureBoxHome.Size = new System.Drawing.Size(1430, 818);
            this.pictureBoxHome.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBoxHome.TabIndex = 1;
            this.pictureBoxHome.TabStop = false;
            // 
            // ucManageRole1
            // 
            this.ucManageRole1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucManageRole1.Location = new System.Drawing.Point(88, 12);
            this.ucManageRole1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucManageRole1.MaximumSize = new System.Drawing.Size(1430, 818);
            this.ucManageRole1.MinimumSize = new System.Drawing.Size(200, 200);
            this.ucManageRole1.Name = "ucManageRole1";
            this.ucManageRole1.Size = new System.Drawing.Size(1430, 818);
            this.ucManageRole1.TabIndex = 0;
            // 
            // ucManageEmployee1
            // 
            this.ucManageEmployee1.AccountId = 0;
            this.ucManageEmployee1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucManageEmployee1.Location = new System.Drawing.Point(88, 12);
            this.ucManageEmployee1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucManageEmployee1.MaximumSize = new System.Drawing.Size(1430, 818);
            this.ucManageEmployee1.MinimumSize = new System.Drawing.Size(200, 200);
            this.ucManageEmployee1.Name = "ucManageEmployee1";
            this.ucManageEmployee1.Size = new System.Drawing.Size(1430, 818);
            this.ucManageEmployee1.TabIndex = 5;
            // 
            // ucManageCustomer1
            // 
            this.ucManageCustomer1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucManageCustomer1.Location = new System.Drawing.Point(88, 12);
            this.ucManageCustomer1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucManageCustomer1.MaximumSize = new System.Drawing.Size(1430, 818);
            this.ucManageCustomer1.MinimumSize = new System.Drawing.Size(200, 200);
            this.ucManageCustomer1.Name = "ucManageCustomer1";
            this.ucManageCustomer1.Size = new System.Drawing.Size(1430, 818);
            this.ucManageCustomer1.TabIndex = 6;
            // 
            // ucBookRoom1
            // 
            this.ucBookRoom1.AccountId = 0;
            this.ucBookRoom1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucBookRoom1.Location = new System.Drawing.Point(88, 12);
            this.ucBookRoom1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucBookRoom1.MaximumSize = new System.Drawing.Size(1430, 818);
            this.ucBookRoom1.MinimumSize = new System.Drawing.Size(200, 200);
            this.ucBookRoom1.Name = "ucBookRoom1";
            this.ucBookRoom1.Size = new System.Drawing.Size(1430, 818);
            this.ucBookRoom1.TabIndex = 7;
            // 
            // ucManageRoom1
            // 
            this.ucManageRoom1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucManageRoom1.Location = new System.Drawing.Point(88, 12);
            this.ucManageRoom1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucManageRoom1.MaximumSize = new System.Drawing.Size(1430, 818);
            this.ucManageRoom1.MinimumSize = new System.Drawing.Size(200, 200);
            this.ucManageRoom1.Name = "ucManageRoom1";
            this.ucManageRoom1.Size = new System.Drawing.Size(1430, 818);
            this.ucManageRoom1.TabIndex = 8;
            // 
            // ucMyAccount1
            // 
            this.ucMyAccount1.AccountId = 0;
            this.ucMyAccount1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucMyAccount1.Location = new System.Drawing.Point(88, 12);
            this.ucMyAccount1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucMyAccount1.MaximumSize = new System.Drawing.Size(1430, 818);
            this.ucMyAccount1.MinimumSize = new System.Drawing.Size(200, 200);
            this.ucMyAccount1.Name = "ucMyAccount1";
            this.ucMyAccount1.Size = new System.Drawing.Size(1430, 818);
            this.ucMyAccount1.TabIndex = 9;
            // 
            // ucManageTypeRoom1
            // 
            this.ucManageTypeRoom1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucManageTypeRoom1.Location = new System.Drawing.Point(88, 12);
            this.ucManageTypeRoom1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucManageTypeRoom1.Name = "ucManageTypeRoom1";
            this.ucManageTypeRoom1.Size = new System.Drawing.Size(1430, 818);
            this.ucManageTypeRoom1.TabIndex = 11;
            // 
            // ucManagePayment1
            // 
            this.ucManagePayment1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucManagePayment1.Location = new System.Drawing.Point(88, 12);
            this.ucManagePayment1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucManagePayment1.Name = "ucManagePayment1";
            this.ucManagePayment1.Size = new System.Drawing.Size(1430, 818);
            this.ucManagePayment1.TabIndex = 12;
            // 
            // ucManageService1
            // 
            this.ucManageService1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucManageService1.Location = new System.Drawing.Point(88, 12);
            this.ucManageService1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucManageService1.Name = "ucManageService1";
            this.ucManageService1.Size = new System.Drawing.Size(1430, 818);
            this.ucManageService1.TabIndex = 13;
            // 
            // ucManageLate1
            // 
            this.ucManageLate1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucManageLate1.Location = new System.Drawing.Point(88, 12);
            this.ucManageLate1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucManageLate1.Name = "ucManageLate1";
            this.ucManageLate1.Size = new System.Drawing.Size(1430, 818);
            this.ucManageLate1.TabIndex = 14;
            // 
            // ucManageVoucher1
            // 
            this.ucManageVoucher1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ucManageVoucher1.Location = new System.Drawing.Point(88, 12);
            this.ucManageVoucher1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.ucManageVoucher1.Name = "ucManageVoucher1";
            this.ucManageVoucher1.Size = new System.Drawing.Size(1430, 818);
            this.ucManageVoucher1.TabIndex = 15;
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1532, 841);
            this.Controls.Add(this.flowLayoutPanelSidebar);
            this.Controls.Add(this.ucManageVoucher1);
            this.Controls.Add(this.ucManageLate1);
            this.Controls.Add(this.ucManagePayment1);
            this.Controls.Add(this.pictureBoxHome);
            this.Controls.Add(this.ucManageRole1);
            this.Controls.Add(this.ucManageEmployee1);
            this.Controls.Add(this.ucManageCustomer1);
            this.Controls.Add(this.ucBookRoom1);
            this.Controls.Add(this.ucManageRoom1);
            this.Controls.Add(this.ucMyAccount1);
            this.Controls.Add(this.ucManageTypeRoom1);
            this.Controls.Add(this.ucManageService1);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormMain";
            this.Text = "FormMain";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.flowLayoutPanelSidebar.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxMenu)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBoxHome)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPanelSidebar;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBoxMenu;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBookRoom;
        private System.Windows.Forms.Button btnRoom;
        private System.Windows.Forms.Button btnCustomer;
        private System.Windows.Forms.Button btnEmployee;
        private System.Windows.Forms.Timer timerSidebar;
        private System.Windows.Forms.Button btnRole;
        private ucBookRoom ucBookRoom1;
        private ucManageCustomer ucManageCustomer1;
        private ucManageEmployee ucManageEmployee1;
        private ucManageRole ucManageRole1;
        private ucManageRoom ucManageRoom1;
        private System.Windows.Forms.PictureBox pictureBoxHome;
        private System.Windows.Forms.Button btnMyAccount;
        private System.Windows.Forms.Button btnLogout;
        private ucMyAccount ucMyAccount1;
        private System.Windows.Forms.Button btnTypeRoom;
        private ucManageTypeRoom ucManageTypeRoom1;
        private System.Windows.Forms.Button btnPayment;
        private System.Windows.Forms.Button btnLate;
        private System.Windows.Forms.Button btnVoucher;
        private System.Windows.Forms.Button btnService;
        private ucManagePayment ucManagePayment1;
        private ucManageService ucManageService1;
        private ucManageLate ucManageLate1;
        private ucManageVoucher ucManageVoucher1;
    }
}