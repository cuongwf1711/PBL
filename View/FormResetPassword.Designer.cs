namespace PBL.View
{
    partial class FormResetPassword
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
            this.panelGeneral = new System.Windows.Forms.Panel();
            this.dateTimePickerBirthday = new System.Windows.Forms.DateTimePicker();
            this.btnConfirmAndSendcode = new System.Windows.Forms.Button();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPhoneNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtCCCD = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.panelDetail = new System.Windows.Forms.Panel();
            this.btnBack = new System.Windows.Forms.Button();
            this.btnResend = new System.Windows.Forms.Button();
            this.btnConfirmcode = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.txtCode = new System.Windows.Forms.TextBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panelGeneral.SuspendLayout();
            this.panelDetail.SuspendLayout();
            this.SuspendLayout();
            // 
            // panelGeneral
            // 
            this.panelGeneral.Controls.Add(this.dateTimePickerBirthday);
            this.panelGeneral.Controls.Add(this.btnConfirmAndSendcode);
            this.panelGeneral.Controls.Add(this.txtEmail);
            this.panelGeneral.Controls.Add(this.txtPhoneNumber);
            this.panelGeneral.Controls.Add(this.txtName);
            this.panelGeneral.Controls.Add(this.txtCCCD);
            this.panelGeneral.Controls.Add(this.label5);
            this.panelGeneral.Controls.Add(this.label4);
            this.panelGeneral.Controls.Add(this.label3);
            this.panelGeneral.Controls.Add(this.label6);
            this.panelGeneral.Controls.Add(this.label2);
            this.panelGeneral.Controls.Add(this.label1);
            this.panelGeneral.Location = new System.Drawing.Point(12, 12);
            this.panelGeneral.Name = "panelGeneral";
            this.panelGeneral.Size = new System.Drawing.Size(1508, 818);
            this.panelGeneral.TabIndex = 0;
            // 
            // dateTimePickerBirthday
            // 
            this.dateTimePickerBirthday.CustomFormat = "dd/MM/yyyy";
            this.dateTimePickerBirthday.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerBirthday.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.dateTimePickerBirthday.Location = new System.Drawing.Point(624, 213);
            this.dateTimePickerBirthday.Name = "dateTimePickerBirthday";
            this.dateTimePickerBirthday.Size = new System.Drawing.Size(500, 43);
            this.dateTimePickerBirthday.TabIndex = 3;
            // 
            // btnConfirmAndSendcode
            // 
            this.btnConfirmAndSendcode.Location = new System.Drawing.Point(381, 568);
            this.btnConfirmAndSendcode.Name = "btnConfirmAndSendcode";
            this.btnConfirmAndSendcode.Size = new System.Drawing.Size(743, 101);
            this.btnConfirmAndSendcode.TabIndex = 2;
            this.btnConfirmAndSendcode.Text = "Confirm information and send recovery code to email";
            this.btnConfirmAndSendcode.UseVisualStyleBackColor = true;
            this.btnConfirmAndSendcode.Click += new System.EventHandler(this.BtnConfirmAndSendcode_Click);
            // 
            // txtEmail
            // 
            this.txtEmail.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtEmail.Location = new System.Drawing.Point(624, 443);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(500, 43);
            this.txtEmail.TabIndex = 1;
            // 
            // txtPhoneNumber
            // 
            this.txtPhoneNumber.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtPhoneNumber.Location = new System.Drawing.Point(624, 359);
            this.txtPhoneNumber.Name = "txtPhoneNumber";
            this.txtPhoneNumber.Size = new System.Drawing.Size(500, 43);
            this.txtPhoneNumber.TabIndex = 1;
            // 
            // txtName
            // 
            this.txtName.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtName.Location = new System.Drawing.Point(624, 279);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(500, 43);
            this.txtName.TabIndex = 1;
            // 
            // txtCCCD
            // 
            this.txtCCCD.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCCCD.Location = new System.Drawing.Point(624, 147);
            this.txtCCCD.Name = "txtCCCD";
            this.txtCCCD.Size = new System.Drawing.Size(500, 43);
            this.txtCCCD.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(406, 446);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(97, 38);
            this.label5.TabIndex = 0;
            this.label5.Text = "Email :";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(406, 362);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(212, 38);
            this.label4.TabIndex = 0;
            this.label4.Text = "PhoneNumber :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(406, 282);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(105, 38);
            this.label3.TabIndex = 0;
            this.label3.Text = "Name :";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(406, 150);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(100, 38);
            this.label6.TabIndex = 0;
            this.label6.Text = "CCCD :";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(406, 213);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(133, 38);
            this.label2.TabIndex = 0;
            this.label2.Text = "Birthday :";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(564, 38);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(236, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Reset password";
            // 
            // panelDetail
            // 
            this.panelDetail.Controls.Add(this.btnBack);
            this.panelDetail.Controls.Add(this.btnResend);
            this.panelDetail.Controls.Add(this.btnConfirmcode);
            this.panelDetail.Controls.Add(this.label7);
            this.panelDetail.Controls.Add(this.txtCode);
            this.panelDetail.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panelDetail.Location = new System.Drawing.Point(12, 12);
            this.panelDetail.Name = "panelDetail";
            this.panelDetail.Size = new System.Drawing.Size(1508, 818);
            this.panelDetail.TabIndex = 0;
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(215, 359);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(319, 97);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Back";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.BtnBack_Click);
            // 
            // btnResend
            // 
            this.btnResend.Location = new System.Drawing.Point(540, 359);
            this.btnResend.Name = "btnResend";
            this.btnResend.Size = new System.Drawing.Size(319, 97);
            this.btnResend.TabIndex = 2;
            this.btnResend.Text = "Resend";
            this.btnResend.UseVisualStyleBackColor = true;
            this.btnResend.Click += new System.EventHandler(this.BtnResend_Click);
            // 
            // btnConfirmcode
            // 
            this.btnConfirmcode.Location = new System.Drawing.Point(865, 359);
            this.btnConfirmcode.Name = "btnConfirmcode";
            this.btnConfirmcode.Size = new System.Drawing.Size(319, 97);
            this.btnConfirmcode.TabIndex = 2;
            this.btnConfirmcode.Text = "Confirm";
            this.btnConfirmcode.UseVisualStyleBackColor = true;
            this.btnConfirmcode.Click += new System.EventHandler(this.BtnConfirmcode_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(222, 207);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(364, 50);
            this.label7.TabIndex = 1;
            this.label7.Text = "Enter recovery code :";
            // 
            // txtCode
            // 
            this.txtCode.Font = new System.Drawing.Font("Segoe UI", 22.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCode.Location = new System.Drawing.Point(604, 204);
            this.txtCode.Name = "txtCode";
            this.txtCode.Size = new System.Drawing.Size(580, 57);
            this.txtCode.TabIndex = 0;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // FormResetPassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 28F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1532, 841);
            this.Controls.Add(this.panelGeneral);
            this.Controls.Add(this.panelDetail);
            this.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.Name = "FormResetPassword";
            this.Text = "FormResetPassword";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.panelGeneral.ResumeLayout(false);
            this.panelGeneral.PerformLayout();
            this.panelDetail.ResumeLayout(false);
            this.panelDetail.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panelGeneral;
        private System.Windows.Forms.Panel panelDetail;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DateTimePicker dateTimePickerBirthday;
        private System.Windows.Forms.Button btnConfirmAndSendcode;
        private System.Windows.Forms.TextBox txtCCCD;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPhoneNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnConfirmcode;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtCode;
        private System.Windows.Forms.Button btnResend;
        private System.Windows.Forms.Button btnBack;
        private System.Windows.Forms.Timer timer1;
    }
}