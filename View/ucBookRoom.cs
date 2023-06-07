using PBL.BLL;
using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class ucBookRoom : UserControl
    {
        public int AccountId { get; set; }

        public ucBookRoom()
        {
            InitializeComponent();
            Create();
        }
        void Create()
        {
            panelBookRoom.BringToFront();
            dateTimePickerStart.MinDate = DateTime.Now.Date;
            dateTimePickerEnd.MinDate = dateTimePickerStart.Value.AddDays(1);

            cbbLate.Items?.Clear();
            cbbLate.Items.Add("None");
            LateBLL lateBLL = new LateBLL();
            foreach(Late late in lateBLL.GetAll())
            {
                int maximum = late.Maximum;
                if(maximum > 0 && maximum < 24)
                {
                    cbbLate.Items.Add(maximum - 2);
                }
            }
            cbbLate.SelectedIndex = 0;
        }
        private void DateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.MinDate = dateTimePickerStart.Value.Date.AddDays(1);
        }

        private void BtnSearchRoom_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantityCustomer.Text, out int quantity))
            {
                if(!radioButtonNone.Checked && cbbLate.SelectedIndex != 0)
                {
                    MessageBox.Show("Maximum one exception selected (early or late or nothing)", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
                dateTimePickerStart.Value = dateTimePickerStart.Value.Date.AddHours(14);
                dateTimePickerEnd.Value = dateTimePickerEnd.Value.Date.AddHours(12);
                if(radioButtonEarly59.Checked)
                {
                    dateTimePickerStart.Value = dateTimePickerStart.Value.Date.AddHours(5);
                }
                else if (radioButtonEarly914.Checked)
                {
                    dateTimePickerStart.Value = dateTimePickerStart.Value.Date.AddHours(9);
                }
                else if (cbbLate.SelectedIndex != 0)
                {
                    dateTimePickerStart.Value = dateTimePickerStart.Value.AddHours(Convert.ToInt32(cbbLate.SelectedItem));
                }
                RoomBLL bll = new RoomBLL();
                dgvRoomAvailable.DataSource = StaticFunc.ToDataTable(bll.GetRoomsAvailable(dateTimePickerStart.Value, dateTimePickerEnd.Value, quantity));
                labelTotalRoom.Text = $"Total room : {dgvRoomAvailable.Rows.Count}";
            }
            else
            {
                MessageBox.Show("Quantity must be numberic", "ERROR", 0, MessageBoxIcon.Error);
            }
        }

        private void DgvRoomAvailable_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int capacity = 0;
            foreach (DataGridViewRow r in dgvRoomAvailable.SelectedRows)
            {
                capacity += Convert.ToInt32(r.Cells["Capacity"].Value);
            }
            labelTotalCapacity.Text = $"Total capacity : {capacity}";
        }
        void ResetPanelInfoCustomer()
        {
            txtName.Text = string.Empty;
            txtCCCD.Text = string.Empty;
            txtPhoneNumberCustomer.Text = string.Empty;
            cbbCountry.SelectedIndex = -1;
            dgvServiceAvailable.Columns?.Clear();
            ServiceBLL serviceBLL = new ServiceBLL();
            dgvServiceAvailable.DataSource = StaticFunc.ToDataTable(serviceBLL.GetAll());
            dgvServiceAvailable.Columns.Add("Quantity", "Quantity");
            dgvServiceAvailable.Columns["ServiceId"].ReadOnly = true;
            dgvServiceAvailable.Columns["Name"].ReadOnly = true;
            dgvServiceAvailable.Columns["Price"].ReadOnly = true;
            labelTotalService.Text = $"Total service : {dgvServiceAvailable.Rows.Count}";
        }
        private void BtnBookRoom_Click(object sender, EventArgs e)
        {
            ResetPanelInfoCustomer();
            panelInformationCustomer.BringToFront();
        }

        private void BtnSearchCustomer_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtCCCD.Text, out int cccd))
            {
                CustomerBLL bll = new CustomerBLL();
                Customer customerSearch = bll.Get(cccd);
                if (customerSearch != null)
                {
                    txtName.Text = customerSearch.Name;
                    dateTimePickerBirthday.Text = customerSearch.Birthday.ToString();
                    cbbCountry.SelectedIndex = cbbCountry.FindString(customerSearch.Country);
                    txtPhoneNumberCustomer.Text = customerSearch.PhoneNumber;
                }
                else
                {
                    MessageBox.Show("Not found", "ERROR", 0, MessageBoxIcon.Error);
                }
            }
            else
            {
                MessageBox.Show("CCCD must be numberic", "ERROR", 0, MessageBoxIcon.Error);
            }
        }

        List<Reservation> reservations;
        List<Addition> additions;
        Voucher voucher;
        private void BtnOkInformation_Click(object sender, EventArgs e)
        {
            if (dgvServiceAvailable.SelectedRows.Count == 0 && dgvRoomAvailable.SelectedRows.Count == 0)
            {
                MessageBox.Show("You haven't selected whatever yet", "ERROR", 0, MessageBoxIcon.Error);
                return;
            }

            if (dgvServiceAvailable.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dgvServiceAvailable.SelectedRows)
                {
                    bool check = int.TryParse(r.Cells["Quantity"].Value?.ToString(), out int quantity);
                    if (!check || quantity > 100 || quantity < 1)
                    {
                        MessageBox.Show("Quantity must be numberic (1-100)", "ERROR", 0, MessageBoxIcon.Error);
                        return;
                    }
                }
            }

            if (!int.TryParse(txtCCCD.Text, out int cccd))
            {
                MessageBox.Show("CCCD must be numberic", "ERROR", 0, MessageBoxIcon.Error);
                return;
            }

            CustomerBLL customerBLL = new CustomerBLL();
            if (!customerBLL.AddOrUpdate(new Customer
            {
                PersonId = cccd,
                Birthday = dateTimePickerBirthday.Value,
                Name = txtName.Text,
                Country = cbbCountry.SelectedItem?.ToString(),
                PhoneNumber = txtPhoneNumberCustomer.Text
            }))
            {
                MessageBox.Show("Invalid information customer", "ERROR", 0, MessageBoxIcon.Error);
                return;
            }

            reservations = new List<Reservation>();
            decimal priceReservations = 0;
            foreach (DataGridViewRow r in dgvRoomAvailable.SelectedRows)
            {
                decimal price = Convert.ToDecimal(r.Cells["Price"].Value);
                priceReservations += price;
                reservations.Add(new Reservation
                {
                    DateStart = dateTimePickerStart.Value,
                    DateEnd = dateTimePickerEnd.Value,
                    Price = price,
                    RoomId = Convert.ToInt32(r.Cells["RoomId"].Value),
                    PersonId = cccd,
                });
            }
            labelPriceReservations.Text = priceReservations.ToString();

            additions = new List<Addition>();
            decimal priceServices = 0;
            foreach (DataGridViewRow r in dgvServiceAvailable.SelectedRows)
            {
                decimal price = Convert.ToDecimal(r.Cells["Price"].Value);
                int quantity = Convert.ToInt32(r.Cells["Quantity"].Value);
                priceServices += price * quantity;
                additions.Add(new Addition
                {
                    ServiceId = Convert.ToInt32(r.Cells["ServiceId"].Value),
                    Quantity = quantity,
                    Price = price,
                });
            }
            labelPriceServices.Text = priceServices.ToString();

            CreatePanelPayment();
            panelPayment.BringToFront();
        }

        void CreatePanelPayment()
        {
            cbbDeposit.SelectedIndex = 0;
            txtVoucher.Text = string.Empty;
            labelVoucher.Text = string.Empty;
            labelCCCDCustomer.Text = txtCCCD.Text;
            labelNameCustomer.Text = txtName.Text;
            labelPhoneNumber.Text = txtPhoneNumberCustomer.Text;
            dgvListRooms.Columns?.Clear();
            dgvListServices.Columns?.Clear();
            if (dgvRoomAvailable.SelectedRows.Count > 0)
            {
                dgvListRooms.DataSource = StaticFunc.ToDataTable(reservations);
                dgvListRooms.Columns["ReservationId"].Visible = false;
                dgvListRooms.Columns["PaymentId"].Visible = false;
                dgvListRooms.Columns["PersonId"].Visible = false;
                labelTotalReservation.Text = $"Total : {dgvListRooms.Rows.Count}";
            }
            if (dgvServiceAvailable.SelectedRows.Count > 0)
            {
                dgvListServices.DataSource = StaticFunc.ToDataTable(additions);
                dgvListServices.Columns["AdditionId"].Visible = false;
                dgvListServices.Columns["PaymentId"].Visible = false;
                labelTotalAddition.Text = $"Total : {dgvListServices.Rows.Count}";
            }

            decimal feeEarly;
            if (radioButtonEarly59.Checked)
            {
                feeEarly = 0.5m;
                labelFeeEarly.Text = radioButtonEarly59.Text;
            }
            else if (radioButtonEarly914.Checked)
            {
                feeEarly = 0.3m;
                labelFeeEarly.Text = radioButtonEarly914.Text;
            }
            else
            {
                feeEarly = 0;
                labelFeeEarly.Text = string.Empty;
            }
            labelTotalPrice.Text = (Convert.ToDecimal(labelPriceReservations.Text) * (1 + feeEarly) + Convert.ToDecimal(labelPriceServices.Text)).ToString();
        }
        private void BtnOkVoucher_Click(object sender, EventArgs e)
        {
            VoucherBLL voucherBLL = new VoucherBLL();
            voucher = voucherBLL.GetByCode(txtVoucher.Text);
            if (voucher != null)
            {
                decimal feeEarly = 0;
                if (radioButtonEarly59.Checked)
                {
                    feeEarly = 0.5m;
                }
                else if (radioButtonEarly914.Checked)
                {
                    feeEarly = 0.3m;
                }
                labelVoucher.Text = voucher.Discount.ToString("p");
                labelTotalPrice.Text = ((Convert.ToDecimal(labelPriceReservations.Text) * (1 + feeEarly) + Convert.ToDecimal(labelPriceServices.Text)) * (1 - voucher.Discount)).ToString();
                labelDeposit.Text = (Convert.ToDecimal(labelTotalPrice.Text) * Convert.ToDecimal(cbbDeposit.SelectedItem)).ToString();
            }
            else
            {
                MessageBox.Show("Invalid voucher", "ERROR", 0, MessageBoxIcon.Error);
            }
        }

        private void CbbDeposit_SelectedIndexChanged(object sender, EventArgs e)
        {
            labelDeposit.Text = (Convert.ToDecimal(labelTotalPrice.Text) * Convert.ToDecimal(cbbDeposit.SelectedItem)).ToString();
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            if(sender == btnCancelInformation)
            {
                panelBookRoom.BringToFront();
            }
            else if(sender == btnCancelPayment)
            {
                panelInformationCustomer.BringToFront();
            }
        }
        void ClearPanelBookRoom()
        {
            dgvRoomAvailable.Columns?.Clear();
            labelTotalRoom.Text = "Total room : 0";
            labelTotalCapacity.Text = "Total capacity : 0";
            radioButtonNone.Checked = true;
            cbbLate.SelectedIndex = 0;
        }
        private void BtnOkPayment_Click(object sender, EventArgs e)
        {
            decimal feeEarly = 0;
            if (radioButtonEarly59.Checked)
            {
                feeEarly = 0.5m;
            }
            else if (radioButtonEarly914.Checked)
            {
                feeEarly = 0.3m;
            }
            PaymentBLL paymentBLL = new PaymentBLL();
            if(!paymentBLL.BookRoomCompleted(new Payment 
                { DateCreate = DateTime.Now, PersonId = AccountId
                , Deposit = Convert.ToDecimal(cbbDeposit.SelectedItem)
                , VoucherId = voucher?.VoucherId, FeeEarly = feeEarly
                }
            , reservations, additions))
            {
                MessageBox.Show("Wrong information and create payment failed", "ERROR", 0, MessageBoxIcon.Error);
                return;
            }
            ClearPanelBookRoom();
            panelBookRoom.BringToFront();
        }
    }
}
