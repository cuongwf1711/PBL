using PBL.BLL;
using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class ucManageRole : UserControl
    {
        public ucManageRole()
        {
            InitializeComponent();
            panelGeneral.BringToFront();
        }
        void RefreshPanelGeneral(RoleBLL roleBLL)
        {
            dgvListRoles.DataSource = StaticFunc.ToDataTable(roleBLL.GetAll());
            labelTotalRole.Text = $"Total : {dgvListRoles.Rows.Count}";
        }
        private void BtnListAll_Click(object sender, EventArgs e)
        {
            RoleBLL roleBLL = new RoleBLL();
            RefreshPanelGeneral(roleBLL);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int id))
            {
                RoleBLL roleBLL = new RoleBLL();
                dgvListRoles.DataSource = new Role[] { roleBLL.Get(id) };
                dgvListRoles.Columns["Accounts"].Visible = false;
            }
            else
            {
                MessageBox.Show("RoleId must be numberic", "ERROR", 0, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListRoles.SelectedRows.Count > 0)
            {
                List<int> ids = new List<int>();
                foreach (DataGridViewRow r in dgvListRoles.SelectedRows)
                {
                    ids.Add(Convert.ToInt32(r.Cells["RoleId"].Value));
                }
                RoleBLL roleBLL = new RoleBLL();
                if (!roleBLL.Delete(ids.ToArray()))
                {
                    MessageBox.Show("Delete failed", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
                RefreshPanelGeneral(roleBLL);
            }
        }
        int upd;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            upd = -1;
            txtName.Text = string.Empty;
            foreach (CheckBox cb in groupBoxPermission.Controls)
            {
                cb.Checked = false;
            }
            labelTotalAccount.Text = "Total : 0";
            dgvAccounts.Columns?.Clear();
            panelDetail.BringToFront();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvListRoles.SelectedRows.Count == 1)
            {
                upd = Convert.ToInt32(dgvListRoles.SelectedRows[0].Cells["RoleId"].Value);
                RoleBLL roleBLL = new RoleBLL();
                Role role = roleBLL.Get(upd);
                txtName.Text = role.Name;
                string permission = role.Permisssion;
                foreach (CheckBox cb in groupBoxPermission.Controls)
                {
                    if(permission.Contains(cb.Text))
                    {
                        cb.Checked = true;
                    }
                }
                dgvAccounts.DataSource = StaticFunc.ToDataTable(roleBLL.GetAccounts(upd));
                labelTotalAccount.Text = $"Total : {dgvAccounts.Rows.Count}";
                panelDetail.BringToFront();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            panelGeneral.BringToFront();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            List<string> permission = new List<string>();
            foreach (CheckBox cb in groupBoxPermission.Controls)
            {
                if (cb.Checked)
                {
                    permission.Add(cb.Text);
                }
            }
            RoleBLL roleBLL = new RoleBLL();
            Role role = new Role { RoleId = upd, Name = txtName.Text, Permisssion = string.Join(",", permission) };
            if (upd == -1)
            {
                if (!roleBLL.Create(role))
                {
                    MessageBox.Show("Wrong information and create customer failed", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (!roleBLL.Update(role))
                {
                    MessageBox.Show("Wrong information and update customer failed", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
            }
            RefreshPanelGeneral(roleBLL);
            panelGeneral.BringToFront();
        }
    }
}
