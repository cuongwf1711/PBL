namespace PBL.View
{
    partial class ucMyAccount
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ucMyAccount));
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.dgvPayments = new System.Windows.Forms.DataGridView();
            this.labelTotal = new System.Windows.Forms.Label();
            this.labelPayments = new System.Windows.Forms.Label();
            this.btnChangePass = new System.Windows.Forms.Button();
            this.btnChangeEmail = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtRole = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.panelChangePassword = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnSaveChangePass = new System.Windows.Forms.Button();
            this.txtNewPassAgain = new System.Windows.Forms.TextBox();
            this.txtNewPass = new System.Windows.Forms.TextBox();
            this.txtOldPass = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnWelcome = new System.Windows.Forms.Button();
            this.panelChangeEmail = new System.Windows.Forms.Panel();
            this.btnBackEmail = new System.Windows.Forms.Button();
            this.btnConfirmEmail = new System.Windows.Forms.Button();
            this.btnSendCode = new System.Windows.Forms.Button();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtNewEmail = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelGeneral.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).BeginInit();
            this.panelChangePassword.SuspendLayout();
            this.panelChangeEmail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.dateTimePickerBirthday);
            this.panelGeneral.Controls.Add(this.dgvPayments);
            this.panelGeneral.Controls.Add(this.labelTotal);
            this.panelGeneral.Controls.Add(this.labelPayments);
            this.panelGeneral.Controls.Add(this.btnChangePass);
            this.panelGeneral.Controls.Add(this.btnChangeEmail);
            this.panelGeneral.Controls.Add(this.btnSave);
            this.panelGeneral.Controls.Add(this.txtRole);
            this.panelGeneral.Controls.Add(this.txtEmail);
            this.panelGeneral.Controls.Add(this.txtPhoneNumber);
            this.panelGeneral.Controls.Add(this.txtName);
            this.panelGeneral.Controls.Add(this.txtCCCD);
            this.panelGeneral.Controls.Add(this.label8);
            this.panelGeneral.Controls.Add(this.label10);
            this.panelGeneral.Controls.Add(this.label6);
            this.panelGeneral.Controls.Add(this.label5);
            this.panelGeneral.Controls.Add(this.label4);
            this.panelGeneral.Controls.Add(this.label3);
            this.panelGeneral.Location = new System.Drawing.Point(0, 0);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1430, 818);
            this.panelGeneral.TabIndex = 1;
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(287, 259);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(392, 34);
            this.dateTimePickerBirthday.TabIndex = 15;
            // 
            // dgvPayments
            // 
            this.dgvPayments.AllowUserToAddRows = false;
            this.dgvPayments.AllowUserToDeleteRows = false;
            this.dgvPayments.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgvPayments.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvPayments.Location = new System.Drawing.Point(735, 122);
            this.dgvPayments.Name = "dgvPayments";
            this.dgvPayments.ReadOnly = true;
            this.dgvPayments.RowHeadersWidth = 50;
            this.dgvPayments.RowTemplate.Height = 24;
            this.dgvPayments.Size = new System.Drawing.Size(661, 569);
            this.dgvPayments.TabIndex = 0;
            // 
            // labelTotal
            // 
            this.labelTotal.AutoSize = true;
            this.labelTotal.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTotal.Location = new System.Drawing.Point(750, 703);
            this.labelTotal.Name = "labelTotal";
            this.labelTotal.Size = new System.Drawing.Size(132, 45);
            this.labelTotal.TabIndex = 1;
            this.labelTotal.Text = "Total : 0";
            // 
            // labelPayments
            // 
            this.labelPayments.AutoSize = true;
            this.labelPayments.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelPayments.Location = new System.Drawing.Point(997, 48);
            this.labelPayments.Name = "labelPayments";
            this.labelPayments.Size = new System.Drawing.Size(171, 45);
            this.labelPayments.TabIndex = 2;
            this.labelPayments.Text = "Payments";
            // 
            // btnChangePass
            // 
            this.btnChangePass.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangePass.Location = new System.Drawing.Point(387, 678);
            this.btnChangePass.Name = "btnChangePass";
            this.btnChangePass.Size = new System.Drawing.Size(292, 70);
            this.btnChangePass.TabIndex = 3;
            this.btnChangePass.Text = "Change Password";
            this.btnChangePass.UseVisualStyleBackColor = true;
            this.btnChangePass.Click += new System.EventHandler(this.BtnChangePass_Click);
            // 
            // btnChangeEmail
            // 
            this.btnChangeEmail.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnChangeEmail.Location = new System.Drawing.Point(42, 678);
            this.btnChangeEmail.Name = "btnChangeEmail";
            this.btnChangeEmail.Size = new System.Drawing.Size(229, 70);
            this.btnChangeEmail.TabIndex = 4;
            this.btnChangeEmail.Text = "Change email";
            this.btnChangeEmail.UseVisualStyleBackColor = true;
            this.btnChangeEmail.Click += new System.EventHandler(this.BtnChangeEmail_Click);
            // 
            // btnSave
            // 
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSave.Location = new System.Drawing.Point(277, 678);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(104, 70);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // txtRole
            // 
            this.txtRole.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtRole.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtRole.Location = new System.Drawing.Point(287, 561);
            this.txtRole.Name = "txtRole";
            this.txtRole.ReadOnly = true;
            this.txtRole.Size = new System.Drawing.Size(392, 51);
            this.txtRole.TabIndex = 5;
            // 
            // txtEmail
            // 
            this.txtEmail.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(287, 464);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.ReadOnly = true;
            this.txtEmail.Size = new System.Drawing.Size(392, 51);
            this.txtEmail.TabIndex = 6;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(287, 357);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(392, 51);
            this.txtPhoneNumber.TabIndex = 6;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(287, 144);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(392, 51);
            this.txtName.TabIndex = 8;
            // 
            // txtCCCD
            // 
            this.txtCCCD.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtCCCD.Enabled = false;
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(287, 42);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.ReadOnly = true;
            this.txtCCCD.Size = new System.Drawing.Size(392, 51);
            this.txtCCCD.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(34, 567);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(99, 45);
            this.label8.TabIndex = 10;
            this.label8.Text = "Role :";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(34, 464);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(114, 45);
            this.label10.TabIndex = 11;
            this.label10.Text = "Email :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(34, 357);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(247, 45);
            this.label6.TabIndex = 11;
            this.label6.Text = "PhoneNumber :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(34, 248);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(156, 45);
            this.label5.TabIndex = 12;
            this.label5.Text = "Birthday :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(34, 144);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(123, 45);
            this.label4.TabIndex = 13;
            this.label4.Text = "Name :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(34, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(117, 45);
            this.label3.TabIndex = 14;
            this.label3.Text = "CCCD :";
            // 
            // panelChangePassword
            // 
            this.panelChangePassword.Controls.Add(this.btnBack);
            this.panelChangePassword.Controls.Add(this.btnSaveChangePass);
            this.panelChangePassword.Controls.Add(this.txtNewPassAgain);
            this.panelChangePassword.Controls.Add(this.txtNewPass);
            this.panelChangePassword.Controls.Add(this.txtOldPass);
            this.panelChangePassword.Controls.Add(this.label7);
            this.panelChangePassword.Controls.Add(this.label2);
            this.panelChangePassword.Controls.Add(this.label9);
            this.panelChangePassword.Controls.Add(this.label1);
            this.panelChangePassword.Location = new System.Drawing.Point(0, 0);
            this.panelChangePassword.Name = "panelChangePassword";
            this.panelChangePassword.Size = new System.Drawing.Size(1430, 818);
            this.panelChangePassword.TabIndex = 2;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(511, 527);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(113, 62);
            this.btnBack.TabIndex = 0;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnSaveChangePass
            // 
            this.btnSaveChangePass.Location = new System.Drawing.Point(758, 527);
            this.btnSaveChangePass.Name = "btnSaveChangePass";
            this.btnSaveChangePass.Size = new System.Drawing.Size(117, 62);
            this.btnSaveChangePass.TabIndex = 1;
            this.btnSaveChangePass.Text = "Save";
            this.btnSaveChangePass.UseVisualStyleBackColor = true;
            this.btnSaveChangePass.Click += new System.EventHandler(this.BtnSaveChangePass_Click);
            // 
            // txtNewPassAgain
            // 
            this.txtNewPassAgain.Location = new System.Drawing.Point(511, 390);
            this.txtNewPassAgain.Name = "txtNewPassAgain";
            this.txtNewPassAgain.Size = new System.Drawing.Size(507, 34);
            this.txtNewPassAgain.TabIndex = 2;
            this.txtNewPassAgain.UseSystemPasswordChar = true;
            // 
            // txtNewPass
            // 
            this.txtNewPass.Location = new System.Drawing.Point(511, 271);
            this.txtNewPass.Name = "txtNewPass";
            this.txtNewPass.Size = new System.Drawing.Size(507, 34);
            this.txtNewPass.TabIndex = 3;
            this.txtNewPass.UseSystemPasswordChar = true;
            // 
            // txtOldPass
            // 
            this.txtOldPass.Location = new System.Drawing.Point(511, 144);
            this.txtOldPass.Name = "txtOldPass";
            this.txtOldPass.Size = new System.Drawing.Size(507, 34);
            this.txtOldPass.TabIndex = 4;
            this.txtOldPass.UseSystemPasswordChar = true;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 390);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(202, 28);
            this.label7.TabIndex = 5;
            this.label7.Text = "New Password Again :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(303, 271);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 28);
            this.label2.TabIndex = 6;
            this.label2.Text = "New Password :";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Segoe UI", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(602, 27);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(292, 45);
            this.label9.TabIndex = 7;
            this.label9.Text = "Change Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(303, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 8;
            this.label1.Text = "Old Password :";
            // 
            // btnWelcome
            // 
            this.btnWelcome.BackColor = System.Drawing.SystemColors.Control;
            this.btnWelcome.FlatAppearance.BorderSize = 0;
            this.btnWelcome.FlatAppearance.MouseOverBackColor = System.Drawing.SystemColors.Control;
            this.btnWelcome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWelcome.Font = new System.Drawing.Font("Segoe UI", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnWelcome.Image = ((System.Drawing.Image)(resources.GetObject("btnWelcome.Image")));
            this.btnWelcome.Location = new System.Drawing.Point(0, 0);
            this.btnWelcome.Name = "btnWelcome";
            this.btnWelcome.Size = new System.Drawing.Size(1430, 818);
            this.btnWelcome.TabIndex = 0;
            this.btnWelcome.Text = "0";
            this.btnWelcome.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.btnWelcome.UseVisualStyleBackColor = false;
            this.btnWelcome.Click += new System.EventHandler(this.BtnWelcome_Click);
            // 
            // panelChangeEmail
            // 
            this.panelChangeEmail.Controls.Add(this.btnBackEmail);
            this.panelChangeEmail.Controls.Add(this.btnConfirmEmail);
            this.panelChangeEmail.Controls.Add(this.btnSendCode);
            this.panelChangeEmail.Controls.Add(this.txtCode);
            this.panelChangeEmail.Controls.Add(this.label12);
            this.panelChangeEmail.Controls.Add(this.txtNewEmail);
            this.panelChangeEmail.Controls.Add(this.label13);
            this.panelChangeEmail.Controls.Add(this.label11);
            this.panelChangeEmail.Location = new System.Drawing.Point(0, 0);
            this.panelChangeEmail.Name = "panelChangeEmail";
            this.panelChangeEmail.Size = new System.Drawing.Size(1430, 818);
            this.panelChangeEmail.TabIndex = 16;
            // 
            // btnBackEmail
            // 
            this.btnBackEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBackEmail.Location = new System.Drawing.Point(421, 542);
            this.btnBackEmail.Name = "btnBackEmail";
            this.btnBackEmail.Size = new System.Drawing.Size(193, 47);
            this.btnBackEmail.TabIndex = 2;
            this.btnBackEmail.Text = "Back";
            this.btnBackEmail.UseVisualStyleBackColor = true;
            this.btnBackEmail.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnConfirmEmail
            // 
            this.btnConfirmEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConfirmEmail.Location = new System.Drawing.Point(758, 542);
            this.btnConfirmEmail.Name = "btnConfirmEmail";
            this.btnConfirmEmail.Size = new System.Drawing.Size(193, 47);
            this.btnConfirmEmail.TabIndex = 2;
            this.btnConfirmEmail.Text = "Confirm";
            this.btnConfirmEmail.UseVisualStyleBackColor = true;
            this.btnConfirmEmail.Click += new System.EventHandler(this.BtnConfirmEmail_Click);
            // 
            // btnSendCode
            // 
            this.btnSendCode.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSendCode.Location = new System.Drawing.Point(998, 238);
            this.btnSendCode.Name = "btnSendCode";
            this.btnSendCode.Size = new System.Drawing.Size(193, 47);
            this.btnSendCode.TabIndex = 2;
            this.btnSendCode.Text = "Send code";
            this.btnSendCode.UseVisualStyleBackColor = true;
            this.btnSendCode.Click += new System.EventHandler(this.BtnSendCode_Click);
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(401, 380);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(790, 47);
            this.txtCode.TabIndex = 1;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(220, 383);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(175, 41);
            this.label12.TabIndex = 0;
            this.label12.Text = "Enter code :";
            // 
            // txtNewEmail
            // 
            this.txtNewEmail.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNewEmail.Location = new System.Drawing.Point(401, 238);
            this.txtNewEmail.Name = "txtNewEmail";
            this.txtNewEmail.Size = new System.Drawing.Size(591, 47);
            this.txtNewEmail.TabIndex = 1;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(582, 52);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(209, 41);
            this.label13.TabIndex = 0;
            this.label13.Text = "Change email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(223, 241);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(172, 41);
            this.label11.TabIndex = 0;
            this.label11.Text = "New email :";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // ucMyAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.panelChangeEmail);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelChangePassword);
            this.Controls.Add(this.btnWelcome);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximumSize = new System.Drawing.Size(1430, 818);
            this.MinimumSize = new System.Drawing.Size(200, 200);
            this.Name = "ucMyAccount";
            this.Size = new System.Drawing.Size(1430, 818);
            this.Load += new System.EventHandler(this.UcMyAccount_Load);
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvPayments)).EndInit();
            this.panelChangePassword.ResumeLayout(false);
            this.panelChangePassword.PerformLayout();
            this.panelChangeEmail.ResumeLayout(false);
            this.panelChangeEmail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Panel panelChangePassword;
        private System.Windows.Forms.DataGridView dgvPayments;
        private System.Windows.Forms.Label labelPayments;
        private System.Windows.Forms.Button btnChangePass;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtOldPass;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtNewPassAgain;
        private System.Windows.Forms.TextBox txtNewPass;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Button btnSaveChangePass;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtRole;
        private System.Windows.Forms.Button btnWelcome;
        private System.Windows.Forms.Label labelTotal;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Button btnChangeEmail;
        private System.Windows.Forms.Panel panelChangeEmail;
        private System.Windows.Forms.TextBox txtNewEmail;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button btnSendCode;
        private System.Windows.Forms.Button btnConfirmEmail;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Button btnBackEmail;
    }
}
