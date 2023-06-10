using PBL.BLL;
using PBL.DTO;
using System;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            AccountBLL accountBLL = new AccountBLL();
            Account account = accountBLL.GetByLogin(txtEmail.Text, txtPassword.Text);
            if (account != null)
            {
                FormMain fm = new FormMain(account.PersonId, account.RoleId, accountBLL.GetPermission(account.PersonId));
                fm.ShowDialog();
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void BtnForgotPass_Click(object sender, EventArgs e)
        {
            FormResetPassword formResetPassword = new FormResetPassword();
            formResetPassword.ShowDialog();
        }

        private void PictureBoxEye_Click(object sender, EventArgs e)
        {
            if(txtPassword.UseSystemPasswordChar)
            {
                pictureBoxShow.Hide();
                pictureBoxHide.Show();
                txtPassword.UseSystemPasswordChar = false;
            }
            else
            {
                pictureBoxHide.Hide();
                pictureBoxShow.Show();
                txtPassword.UseSystemPasswordChar = true;
            }
        }
    }
}
