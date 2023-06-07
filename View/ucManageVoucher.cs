using PBL.BLL;
using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class ucManageVoucher : UserControl
    {
        public ucManageVoucher()
        {
            InitializeComponent();
            panelGeneral.BringToFront();
        }

        private void BtnList_Click(object sender, EventArgs e)
        {
            VoucherBLL voucherBLL = new VoucherBLL();
            if (sender == btnListAll)
            {
                dgvListVouchers.DataSource = StaticFunc.ToDataTable(voucherBLL.GetAll());
            }
            else if (sender == btnListNow)
            {
                dgvListVouchers.DataSource = StaticFunc.ToDataTable(voucherBLL.GetNow());
            }
            else if (sender == btnListOld)
            {
                dgvListVouchers.DataSource = StaticFunc.ToDataTable(voucherBLL.GetOld());
            }
            labelTotalVoucher.Text = $"Total : {dgvListVouchers.Rows.Count}";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int id))
            {
                VoucherBLL voucherBLL = new VoucherBLL();
                dgvListVouchers.DataSource = new Voucher[] { voucherBLL.Get(id) };
                dgvListVouchers.Columns["Payments"].Visible = false;
                labelTotalVoucher.Text = $"Total : {dgvListVouchers.Rows.Count}";
            }
            else
            {
                MessageBox.Show("VoucherId must be numberic", "ERROR", 0, MessageBoxIcon.Error);
            }
        }
        void RefreshPanelGeneral(VoucherBLL voucherBLL)
        {
            dgvListVouchers.DataSource = StaticFunc.ToDataTable(voucherBLL.GetAll());
            labelTotalVoucher.Text = $"Total : {dgvListVouchers.Rows.Count}";
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListVouchers.SelectedRows.Count > 0)
            {
                List<int> ids = new List<int>();
                foreach (DataGridViewRow r in dgvListVouchers.SelectedRows)
                {
                    ids.Add(Convert.ToInt32(r.Cells["VoucherId"].Value));
                }
                VoucherBLL voucherBLL = new VoucherBLL();
                if (!voucherBLL.Delete(ids.ToArray()))
                {
                    MessageBox.Show("Delete failed", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
                RefreshPanelGeneral(voucherBLL);
            }
        }
        int upd;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            upd = -1;
            txtCode.Text = string.Empty;
            txtDiscount.Text = string.Empty;
            txtQuantity.Text = string.Empty;
            labelTotalPayment.Text = "Total : 0";
            dgvPayments.Columns?.Clear();
            panelDetail.BringToFront();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvListVouchers.SelectedRows.Count == 1)
            {
                upd = Convert.ToInt32(dgvListVouchers.SelectedRows[0].Cells["VoucherId"].Value);
                VoucherBLL voucherBLL = new VoucherBLL();
                Voucher voucher = voucherBLL.Get(upd);
                txtCode.Text = voucher.Code;
                txtDiscount.Text = voucher.Discount.ToString();
                txtQuantity.Text = voucher.Quantity.ToString();
                dgvPayments.DataSource = StaticFunc.ToDataTable(voucherBLL.GetPayments(upd));
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
            if (!decimal.TryParse(txtDiscount.Text, out decimal discount) || !int.TryParse(txtQuantity.Text, out int quantity))
            {
                MessageBox.Show("Wrong format discount anf quantity", "ERROR", 0, MessageBoxIcon.Error);
                return;
            }
            VoucherBLL voucherBLL = new VoucherBLL();
            if (upd == -1)
            {
                if (!voucherBLL.Create(new Voucher { Code = txtCode.Text, Discount = discount, Quantity = quantity }))
                {
                    MessageBox.Show("Wrong information and create customer failed", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (!voucherBLL.Update(new Voucher { VoucherId = upd, Code = txtCode.Text, Discount = discount, Quantity = quantity }))
                {
                    MessageBox.Show("Wrong information and update customer failed", "ERROR", 0, MessageBoxIcon.Error); ;
                    return;
                }
            }
            RefreshPanelGeneral(voucherBLL);
            panelGeneral.BringToFront();
        }
    }
}
