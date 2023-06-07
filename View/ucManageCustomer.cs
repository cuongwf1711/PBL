using PBL.BLL;
using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class ucManageCustomer : UserControl
    {
        public ucManageCustomer()
        {
            InitializeComponent();
            panelGeneral.BringToFront();
        }
        void RefreshPanelGeneral(CustomerBLL customerBLL)
        {
            dgvListCustomers.DataSource = StaticFunc.ToDataTable(customerBLL.GetAll());
            labelTotalCustomer.Text = $"Total : {dgvListCustomers.Rows.Count}";
        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            CustomerBLL customerBLL = new CustomerBLL();
            if(sender == btnListAll)
            {
                dgvListCustomers.DataSource = StaticFunc.ToDataTable(customerBLL.GetAll());
            }
            else if(sender == btnListNow)
            {
                dgvListCustomers.DataSource = StaticFunc.ToDataTable(customerBLL.GetNow());
            }
            else if(sender == btnListOld)
            {
                dgvListCustomers.DataSource = StaticFunc.ToDataTable(customerBLL.GetOld());
            }
            labelTotalCustomer.Text = $"Total : {dgvListCustomers.Rows.Count}";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int customerId))
            {
                CustomerBLL customerBLL = new CustomerBLL();
                dgvListCustomers.DataSource = new Customer[] { customerBLL.Get(customerId) };
                dgvListCustomers.Columns["Reservations"].Visible = false;
                labelTotalCustomer.Text = $"Total : {dgvListCustomers.Rows.Count}";
            }
            else
            {
                MessageBox.Show("CCCD must be numberic", "ERROR", 0, MessageBoxIcon.Error);
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListCustomers.SelectedRows.Count > 0)
            {
                List<int> ids = new List<int>();
                foreach (DataGridViewRow r in dgvListCustomers.SelectedRows)
                {
                    ids.Add(Convert.ToInt32(r.Cells["PersonId"].Value));
                }
                CustomerBLL customerBLL = new CustomerBLL();
                if (!customerBLL.Delete(ids.ToArray()))
                {
                    MessageBox.Show("Delete failed", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
                RefreshPanelGeneral(customerBLL);
            }
        }

        void ClearPanelDetail()
        {
            txtCCCD.Text = string.Empty;
            txtCCCD.Enabled = true;
            txtName.Text = string.Empty;
            txtPhoneNumber.Text = string.Empty;
            cbbCountry.SelectedIndex = -1;
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
            if (dgvListCustomers.SelectedRows.Count == 1)
            {
                CustomerBLL customerBLL = new CustomerBLL();
                Customer customer = customerBLL.Get(Convert.ToInt32(dgvListCustomers.SelectedRows[0].Cells["PersonId"].Value));
                txtCCCD.Text = customer.PersonId.ToString();
                txtCCCD.Enabled = false;
                txtName.Text = customer.Name;
                dateTimePickerBirthday.Value = customer.Birthday;
                txtPhoneNumber.Text = customer.PhoneNumber;
                cbbCountry.SelectedIndex = cbbCountry.FindString(customer.Country);
                dgvPayments.DataSource = StaticFunc.ToDataTable(customerBLL.GetPayments(customer.PersonId));
                labelTotalCustomer.Text = $"Total : {dgvPayments.Rows.Count}";
                panelDetail.BringToFront();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            panelGeneral.BringToFront();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (!int.TryParse(txtCCCD.Text, out int customerId))
            {
                MessageBox.Show("CCCD must be numberic", "ERROR", 0, MessageBoxIcon.Error);
                return;
            }
            Customer customer = new Customer
            {
                PersonId = customerId,
                Birthday = dateTimePickerBirthday.Value,
                Name = txtName.Text,
                PhoneNumber = txtPhoneNumber.Text,
                Country = cbbCountry.SelectedItem.ToString(),
            };
            CustomerBLL customerBLL = new CustomerBLL();
            if (txtCCCD.Enabled)
            {
                if (!customerBLL.Create(customer))
                {
                    MessageBox.Show("Wrong information and create customer failed", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (!customerBLL.Update(customer))
                {
                    MessageBox.Show("Wrong information and update customer failed", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
            }
            panelGeneral.BringToFront();
            RefreshPanelGeneral(customerBLL);        
        }
    }
}
