﻿using PBL.BLL;
using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class ucManagePayment : UserControl
    {
        public ucManagePayment()
        {
            InitializeComponent();
            Create();
        }
        void Create()
        {
            cbbDate.Items?.Clear();
            cbbDate.Items.AddRange(new string[] { "DateCreate", "DateCheckout" });
            cbbDate.SelectedIndex = 0;
            dateTimePickerEnd.MinDate = dateTimePickerStart.Value.AddDays(1);
            panelGeneral.BringToFront();
        }
        private void DateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.MinDate = dateTimePickerStart.Value.AddDays(1);
        }
        List<int> GetIds(DataGridView dgv)
        {
            List<int> ids = new List<int>();
            foreach (DataGridViewRow row in dgv.Rows)
            {
                ids.Add(Convert.ToInt32(row.Cells[0].Value));
            }
            return ids;
        }
        private void BtnList_Click(object sender, EventArgs e)
        {
            labelTotalPriceAllPayment.Visible = false;
            PaymentBLL paymentBLL = new PaymentBLL();
            if(sender == btnListAll)
            {
                dgvListPayments.DataSource = StaticFunc.ToDataTable(paymentBLL.GetAll());
            }
            else if(sender == btnListNow)
            {
                dgvListPayments.DataSource = StaticFunc.ToDataTable(paymentBLL.GetNow());
            }
            else if(sender == btnListOld)
            {
                dgvListPayments.DataSource = StaticFunc.ToDataTable(paymentBLL.GetOld());
                labelTotalPriceAllPayment.Visible = true;
                labelTotalPriceAllPayment.Text = $"Total : {paymentBLL.GetPriceTotalOfPayments(GetIds(dgvListPayments).ToArray())}";
            }
            else if(sender == btnFilter)
            {
                if (cbbDate.SelectedIndex == 0)
                {
                    dgvListPayments.DataSource = StaticFunc.ToDataTable(paymentBLL.GetByDateCreate(dateTimePickerStart.Value, dateTimePickerEnd.Value));
                }
                else if (cbbDate.SelectedIndex == 1)
                {
                    labelTotalPriceAllPayment.Visible = true;
                    dgvListPayments.DataSource = StaticFunc.ToDataTable(paymentBLL.GetByDateCheckout(dateTimePickerStart.Value, dateTimePickerEnd.Value));
                    labelTotalPriceAllPayment.Text = $"Total : {paymentBLL.GetPriceTotalOfPayments(GetIds(dgvListPayments).ToArray())}";
                }
            }
            dgvListPayments.Columns["PersonId"].HeaderText = "AccountId";
            labelTotalPayment.Text = $"Total : {dgvListPayments.Rows.Count}";
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int id))
            {
                PaymentBLL paymentBLL = new PaymentBLL();
                dgvListPayments.DataSource = StaticFunc.ToDataTable(new List<Payment>() { paymentBLL.Get(id) });
                labelTotalPayment.Text = $"Total : {dgvListPayments.Rows.Count}";
                labelTotalPriceAllPayment.Visible = false;
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
        void RefreshPanelGeneral(PaymentBLL paymentBLL)
        {
            dgvListPayments.DataSource = StaticFunc.ToDataTable(paymentBLL.GetAll());
            labelTotalPayment.Text = $"Total : {dgvListPayments.Rows.Count}";
            labelTotalPriceAllPayment.Visible = false;
            panelGeneral.BringToFront();
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListPayments.SelectedRows.Count > 0)
            {
                List<int> ids = new List<int>();
                foreach (DataGridViewRow r in dgvListPayments.SelectedRows)
                {
                    ids.Add(Convert.ToInt32(r.Cells["PaymentId"].Value));
                }
                PaymentBLL paymentBLL = new PaymentBLL();
                if(!paymentBLL.Delete(ids.ToArray()))
                {
                    MessageBox.Show("ERROR");
                    return;
                }
                RefreshPanelGeneral(paymentBLL);
            }
        }

        private void CbbDeposit_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbbDeposit.SelectedIndex == 0)
            {
                checkBoxDeposit.Checked = false;
                labelDeposit.Text = "0";
                return;
            }
            PaymentBLL paymentBLL = new PaymentBLL();
            labelDeposit.Text = paymentBLL.CalculatePriceWhenChangeDeposit(Convert.ToInt32(dgvListPayments.SelectedRows[0].Cells["PaymentId"].Value)
                , Convert.ToDecimal(cbbDeposit.SelectedItem)).ToString();
            checkBoxDeposit.Checked = true;
        }

        private void BtnBack_Click(object sender, EventArgs e)
        {
            panelGeneral.BringToFront();
        }

        void FillInfo(PaymentBLL paymentBLL, int paymentId)
        {
            labelTotalPriceAllPayment.Visible = false;
            cbbDeposit.Enabled = false;
            checkBoxDeposit.Checked = true;
            groupBoxLate.Visible = true;
            dgvLate.Enabled = false;
            Payment payment = paymentBLL.Get(paymentId);
            dateTimePickerDateCreate.Value = payment.DateCreate;
            checkBoxStatus.Checked = payment.Status;
            labelAccountId.Text = $"AccountId : {payment.PersonId}";
            labelFeeEarly.Text = $"Fee early (%) : {payment.FeeEarly}";
            labelCustomerId.Text = $"CustomerId : {paymentBLL.GetCustomerId(paymentId)}";
            labelPhoneNumberCustomer.Text = $"PhoneNumber Customer : {paymentBLL.GetPhoneNumberCustomer(paymentId)}";
            cbbDeposit.SelectedIndex = cbbDeposit.FindString(payment.Deposit.ToString());
            dgvReservations.DataSource = StaticFunc.ToDataTable(paymentBLL.GetReservations(paymentId));
            dgvReservations.Columns["ReservationId"].Visible = false;
            dgvServices.DataSource = StaticFunc.ToDataTable(paymentBLL.GetAddtions(paymentId));
            dgvServices.Columns["AdditionId"].Visible = false;
            dgvVoucher.DataSource = new Voucher[] {paymentBLL.GetVoucher(paymentId)};
            dgvVoucher.Columns["VoucherId"].Visible = false;
            dgvVoucher.Columns["Quantity"].Visible = false;
            dgvVoucher.Columns["Payments"].Visible = false;
            labelTotalReservation.Text = $"Total : {dgvReservations.Rows.Count}";
            labelTotalAddition.Text = $"Total : {dgvServices.Rows.Count}";
            labelPriceReservations.Text = paymentBLL.GetPriceReservations(paymentId).ToString();
            labelPriceServices.Text = paymentBLL.GetPriceServices(paymentId).ToString();
            labelDeposit.Text = paymentBLL.GetPriceDeposit(paymentId).ToString();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvListPayments.SelectedRows.Count == 1 && !Convert.ToBoolean(dgvListPayments.SelectedRows[0].Cells["Status"].Value))
            {
                PaymentBLL paymentBLL = new PaymentBLL();
                Payment payment = paymentBLL.Get(Convert.ToInt32(dgvListPayments.SelectedRows[0].Cells["PaymentId"].Value));
                FillInfo(paymentBLL, payment.PaymentId);
                btnOk.Enabled = true;
                if (cbbDeposit.SelectedIndex == 0)
                {
                    cbbDeposit.Enabled = true;
                    checkBoxDeposit.Checked = false;
                    groupBoxLate.Visible = false;
                    btnOk.Text = "Confirm";
                }
                else
                {
                    btnOk.Text = "Checkout";
                    labelTotalInGroupBoxLate.Text = "Pay : ";
                    dgvLate.DataSource = new[] { new { payment.FeeLate } };
                    labelTotalPriceOnePayment.Text = paymentBLL.GetPriceRemain(payment.PaymentId).ToString();
                }
                panelDetail.BringToFront();
            }
        }
        private void BtnNoteLate_Click(object sender, EventArgs e)
        {
            if (dgvListPayments.SelectedRows.Count == 1 && !Convert.ToBoolean(dgvListPayments.SelectedRows[0].Cells["Status"].Value) 
                && Convert.ToDecimal(dgvListPayments.SelectedRows[0].Cells["Deposit"].Value) > 0)
            {
                PaymentBLL paymentBLL = new PaymentBLL();
                Payment payment = paymentBLL.Get(Convert.ToInt32(dgvListPayments.SelectedRows[0].Cells["PaymentId"].Value));
                FillInfo(paymentBLL, payment.PaymentId);
                dgvLate.Enabled = true;
                btnOk.Enabled = true;
                btnOk.Text = "Confirm";
                labelTotalInGroupBoxLate.Text = "Pay : ";
                dgvLate.DataSource = StaticFunc.ToDataTable(paymentBLL.GetLates(payment.PaymentId));
                dgvLate.Columns["LateId"].Visible = false;
                labelTotalPriceOnePayment.Text = paymentBLL.GetPriceRemain(payment.PaymentId).ToString();
                panelDetail.BringToFront();
            }
        }
        private void BtnDetail_Click(object sender, EventArgs e)
        {
            if (dgvListPayments.SelectedRows.Count == 1 && Convert.ToBoolean(dgvListPayments.SelectedRows[0].Cells["Status"].Value))
            {
                PaymentBLL paymentBLL = new PaymentBLL();
                Payment payment = paymentBLL.Get(Convert.ToInt32(dgvListPayments.SelectedRows[0].Cells["PaymentId"].Value));
                FillInfo(paymentBLL, payment.PaymentId);
                btnOk.Enabled = false;
                btnOk.Text = payment.DateCheckout.ToString();
                labelTotalInGroupBoxLate.Text = "Total";
                dgvLate.DataSource = new[] { new { payment.FeeLate } };
                labelTotalPriceOnePayment.Text = paymentBLL.GetPriceTotal(payment.PaymentId).ToString();
                panelDetail.BringToFront();
            }
        }

        private void BtnOk_Click(object sender, EventArgs e)
        {
            if (cbbDeposit.Enabled)
            {
                if (cbbDeposit.SelectedIndex > 0)
                {
                    PaymentBLL paymentBLL = new PaymentBLL();
                    Payment payment = paymentBLL.Get(Convert.ToInt32(dgvListPayments.SelectedRows[0].Cells["PaymentId"].Value));
                    payment.Deposit = Convert.ToDecimal(cbbDeposit.SelectedItem);
                    if(!paymentBLL.Update(payment))
                    {
                        MessageBox.Show("Checkin failed", "ERROR", 0, MessageBoxIcon.Error);
                        return;
                    }
                    RefreshPanelGeneral(paymentBLL);
                }
                else
                {
                    MessageBox.Show("Haven't changed yet", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
            }
            else if(dgvLate.Enabled)
            {
                if(dgvLate.SelectedRows.Count == 1)
                {
                    PaymentBLL paymentBLL = new PaymentBLL();
                    if (!paymentBLL.AddLate(Convert.ToInt32(dgvListPayments.SelectedRows[0].Cells["PaymentId"].Value), Convert.ToDecimal(dgvLate.SelectedRows[0].Cells["FeeLate"].Value)
                        , Convert.ToInt32(dgvLate.SelectedRows[0].Cells["Maximum"].Value)))
                    {
                        MessageBox.Show("Failed", "ERROR", 0, MessageBoxIcon.Error);
                        return;
                    }
                    RefreshPanelGeneral(paymentBLL);
                }
                else
                {
                    MessageBox.Show("Haven't changed yet", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                PaymentBLL paymentBLL = new PaymentBLL();
                if (!paymentBLL.Checkout(Convert.ToInt32(dgvListPayments.SelectedRows[0].Cells["PaymentId"].Value)))
                {
                    MessageBox.Show("Checkout failed", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
                RefreshPanelGeneral(paymentBLL);
            }
        }

        private void DgvLate_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            PaymentBLL paymentBLL = new PaymentBLL();
            labelTotalPriceOnePayment.Text = paymentBLL.CalculatePriceNeedPayWhenAddFeeLate(Convert.ToInt32(dgvListPayments.SelectedRows[0].Cells["PaymentId"].Value)
                , dgvLate.SelectedRows.Count == 1 ? Convert.ToDecimal(dgvLate.SelectedRows[0].Cells["FeeLate"].Value) : 0).ToString();
        }
    }
}