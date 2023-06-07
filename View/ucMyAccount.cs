using PBL.BLL;
using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class ucMyAccount : UserControl
    {
        public int AccountId { get; set; }
        public ucMyAccount()
        {
            InitializeComponent();
        }

        private void UcMyAccount_Load(object sender, EventArgs e)
        {
            btnWelcome.Text = AccountId.ToString();
            btnWelcome.BringToFront();
        }

        private void BtnWelcome_Click(object sender, EventArgs e)
        {
            AccountBLL accountBLL = new AccountBLL();
            Account account = accountBLL.Get(AccountId);
            txtCCCD.Text = account.PersonId.ToString();
            txtName.Text = account.Name;
            txtEmail.Text = account.Email;
            dateTimePickerBirthday.Text = account.Birthday.ToString();
            txtPhoneNumber.Text = account.PhoneNumber;
            txtRole.Text = accountBLL.GetNameRole(AccountId);
            dgvPayments.DataSource = StaticFunc.ToDataTable(accountBLL.GetPayments(account.PersonId));
            dgvPayments.Columns["PersonId"].Visible = false;
            labelTotal.Text = $"Total : {dgvPayments.Rows.Count}";
            panelGeneral.BringToFront();
        }

        private void BtnChangePass_Click(object sender, EventArgs e)
        {
            txtOldPass.Text = string.Empty;
            txtNewPass.Text = string.Empty;
            txtNewPassAgain.Text = string.Empty;
            panelChangePassword.BringToFront();
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            AccountBLL accountBLL = new AccountBLL();
            Account account = accountBLL.Get(AccountId);
            account.Name = txtName.Text;
            account.Birthday = dateTimePickerBirthday.Value;
            account.PhoneNumber = txtPhoneNumber.Text;
            if (!accountBLL.Update(account))
            {
                MessageBox.Show("Wrong information and update customer failed", "ERROR", 0, MessageBoxIcon.Error);
                return;
            }
            btnWelcome.BringToFront();
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            panelGeneral.BringToFront();
        }

        private void BtnSaveChangePass_Click(object sender, EventArgs e)
        {
            AccountBLL accountBLL = new AccountBLL();
            if (!accountBLL.ChangePassword(AccountId, txtOldPass.Text, txtNewPass.Text, txtNewPassAgain.Text))
            {
                MessageBox.Show("Wrong information and change password failed", "ERROR", 0, MessageBoxIcon.Error);
                return;
            }
            panelGeneral.BringToFront();
        }

        private void BtnChangeEmail_Click(object sender, EventArgs e)
        {
            txtNewEmail.Text = string.Empty;
            txtCode.Text = string.Empty;
            btnConfirmEmail.Enabled = false;
            panelChangeEmail.BringToFront();
        }
        const int TIME_TO_RESEND = 10;
        int timeToResend = TIME_TO_RESEND;
        string code;
        private void BtnSendCode_Click(object sender, EventArgs e)
        {
            code = StaticFunc.RandomString(10);
            if(StaticFunc.SendEmail(txtNewEmail.Text, "Code new email", code))
            {
                timer1.Start();
                btnSendCode.Enabled = false;
                btnConfirmEmail.Enabled = true;
            }
            else
            {
                btnConfirmEmail.Enabled = true;
                MessageBox.Show("Invalid email", "ERROR", 0, MessageBoxIcon.Error);
            }
        }

        private void BtnConfirmEmail_Click(object sender, EventArgs e)
        {
            if (code == txtCode.Text)
            {
                AccountBLL accountBLL = new AccountBLL();
                Account account = accountBLL.Get(AccountId);
                account.Email = txtNewEmail.Text;
                if (!accountBLL.Update(account))
                {
                    MessageBox.Show("Wrong information and update customer failed", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
                txtEmail.Text = txtNewEmail.Text;
                panelGeneral.BringToFront();
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            btnSendCode.Text = timeToResend--.ToString();
            if (timeToResend < 0)
            {
                timer1.Stop();
                btnSendCode.Enabled = true;
                btnSendCode.Text = "Send code";
                timeToResend = TIME_TO_RESEND;
            }
        }
    }
}
