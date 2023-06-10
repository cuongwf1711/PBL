using PBL.BLL;
using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class ucManageEmployee : UserControl
    {
        public int AccountId { get; set; }
        public ucManageEmployee()
        {
            InitializeComponent();
            panelGeneral.BringToFront();
        }

        void RefreshPanelGeneral(AccountBLL accountBLL)
        {
            dgvListEmployees.DataSource = StaticFunc.ToDataTable(accountBLL.GetAllEmployeeExceptMe(AccountId));
            labelTotalAccount.Text = $"Total : {dgvListEmployees.Rows.Count}";
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            AccountBLL accountBLL = new AccountBLL();
            RefreshPanelGeneral(accountBLL);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int SearchId))
            {
                AccountBLL accountBLL = new AccountBLL();
                dgvListEmployees.DataSource = new Account[] { accountBLL.Search(SearchId, AccountId) };
                dgvListEmployees.Columns["Payments"].Visible = false;
                dgvListEmployees.Columns["Role"].Visible = false;
                labelTotalAccount.Text = $"Total : {dgvListEmployees.Rows.Count}";
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListEmployees.SelectedRows.Count > 0)
            {
                List<int> ids = new List<int>();
                foreach (DataGridViewRow r in dgvListEmployees.SelectedRows)
                {
                    ids.Add(Convert.ToInt32(r.Cells["PersonId"].Value));
                }
                AccountBLL accountBLL = new AccountBLL();
                if(!accountBLL.Delete(ids.ToArray()))
                {
                    MessageBox.Show("ERROR");
                    return;
                }
                RefreshPanelGeneral(accountBLL);
            }
        }
        void SetCBBRole(int roleId)
        {
            cbbRole.Items?.Clear();
            cbbRole.Text = string.Empty;
            cbbRole.Enabled = true;
            string name = null;
            RoleBLL roleBLL = new RoleBLL();
            foreach (Role role in roleBLL.GetAll())
            {
                if(role.RoleId == 1)
                {
                    continue;
                }
                else if (roleId == role.RoleId)
                {
                    cbbRole.Enabled = false;
                    name = role.Name;
                }
                cbbRole.Items.Add(new CbbItem { Id = role.RoleId, Name = role.Name });
            }
            cbbRole.SelectedIndex = cbbRole.FindString(name);
        }
        void ClearPanelDetail()
        {
            txtCCCD.Text = string.Empty;
            txtCCCD.Enabled = true;
            txtName.Text = string.Empty;
            txtEmail.Text = string.Empty;
            txtEmail.Enabled = true;
            txtPhoneNumber.Text = string.Empty;
            SetCBBRole(-1);
            labelTotalPayment.Text = "Total : 0";
            dgvPayments.Columns?.Clear();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClearPanelDetail();
            panelDetail.BringToFront();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvListEmployees.SelectedRows.Count == 1)
            {
                AccountBLL accountBLL = new AccountBLL();
                Account account = accountBLL.Get(Convert.ToInt32(dgvListEmployees.SelectedRows[0].Cells["PersonId"].Value));
                txtCCCD.Text = account.PersonId.ToString();
                txtCCCD.Enabled = false;
                txtName.Text = account.Name;
                txtEmail.Text = account.Email;
                txtEmail.Enabled = false;
                dateTimePickerBirthday.Value = account.Birthday;
                txtPhoneNumber.Text = account.PhoneNumber;
                SetCBBRole(account.RoleId);
                dgvPayments.DataSource = StaticFunc.ToDataTable(accountBLL.GetPayments(account.PersonId));
                dgvPayments.Columns["PersonId"].Visible = false;
                labelTotalPayment.Text = $"Total : {dgvPayments.Rows.Count}";
                panelDetail.BringToFront();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            panelGeneral.BringToFront();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCCCD.Text, out int accountId))
            {
                MessageBox.Show("ERROR");
                return;
            }
            string password = StaticFunc.RandomString(10);
            if(!StaticFunc.SendEmail(txtEmail.Text, "Password for new account", password))
            {
                MessageBox.Show("ERROR");
                return;
            }
            Account account = new Account
            {
                PersonId = accountId,
                Birthday = dateTimePickerBirthday.Value,
                Name = txtName.Text,
                Email = txtEmail.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Password = password,
                RoleId = ((CbbItem)cbbRole.SelectedItem).Id,
            };
            AccountBLL accountBLL = new AccountBLL();
            if (txtCCCD.Enabled)
            {
                if (!accountBLL.Create(account))
                {
                    MessageBox.Show("ERROR");
                    return;
                }
            }
            else
            {
                if (!accountBLL.Update(account))
                {
                    MessageBox.Show("ERROR");
                    return;
                }
            }
            MessageBox.Show("Create new account success and password is sent to your email");
            panelGeneral.BringToFront();
            RefreshPanelGeneral(accountBLL);
        }

        private void BtnActivate_Click(object sender, EventArgs e)
        {
            if (dgvListEmployees.SelectedRows.Count > 0)
            {
                List<int> ids = new List<int>();
                foreach (DataGridViewRow r in dgvListEmployees.SelectedRows)
                {
                    ids.Add(Convert.ToInt32(r.Cells["PersonId"].Value));
                }
                AccountBLL accountBLL = new AccountBLL();
                if (sender == btnActivate)
                {
                    if (!accountBLL.ActivateAccount(ids.ToArray()))
                    {
                        MessageBox.Show("ERROR");
                        return;
                    }
                }
                else if (sender == btnDeactivate)
                {
                    if (!accountBLL.DeactivateAccount(ids.ToArray()))
                    {
                        MessageBox.Show("ERROR");
                        return;
                    }
                }
                RefreshPanelGeneral(accountBLL);
            }
        }
    }
}
