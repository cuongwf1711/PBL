using PBL.BLL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class FormResetPassword : Form
    {
        const int TIME_TO_RESEND = 5;
        int timeToResend = TIME_TO_RESEND;
        string code;
        public FormResetPassword()
        {
            InitializeComponent();
            panelGeneral.BringToFront();
        }
        private void BtnConfirmAndSendcode_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCCCD.Text, out int cccd))
            {
                MessageBox.Show("ERROR");
                return;
            }
            AccountBLL accountBLL = new AccountBLL();
            code = accountBLL.CheckInfoAndSendCode(cccd, dateTimePickerBirthday.Value, txtName.Text, txtPhoneNumber.Text, txtEmail.Text);
            if(code == null)
            {
                MessageBox.Show("ERROR");
                return;
            }
            panelDetail.BringToFront();
            timer1.Start();
            btnConfirmAndSendcode.Enabled = false;
            btnResend.Enabled = false;
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            btnResend.Text = timeToResend--.ToString();
            if (timeToResend < 0)
            {
                timer1.Stop();
                btnConfirmAndSendcode.Enabled = true;
                btnResend.Enabled = true;
                btnResend.Text = "Resend";
                timeToResend = TIME_TO_RESEND;
            }
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            panelGeneral.BringToFront();
        }

        private void BtnResend_Click(object sender, EventArgs e)
        {
            AccountBLL accountBLL = new AccountBLL();
            code = accountBLL.CheckInfoAndSendCode(Convert.ToInt32(txtCCCD.Text), dateTimePickerBirthday.Value, txtName.Text, txtPhoneNumber.Text, txtEmail.Text);
            if (code == null)
            {
                MessageBox.Show("ERROR");
                return;
            }
            timer1.Start();
            btnConfirmAndSendcode.Enabled = false;
            btnResend.Enabled = false;
        }

        private void BtnConfirmcode_Click(object sender, EventArgs e)
        {
            if(code == txtCode.Text)
            {
                AccountBLL accountBLL = new AccountBLL();
                if(accountBLL.ResetPassword(Convert.ToInt32(txtCCCD.Text)))
                {
                    MessageBox.Show("Password is reseted same cccd");
                    Dispose();
                    return;
                }
            }
            MessageBox.Show("ERROR");
        }
    }
}
