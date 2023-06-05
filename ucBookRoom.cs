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
            panelBookRoom.BringToFront();
            dateTimePickerStart.MinDate = DateTime.Now;
            dateTimePickerEnd.MinDate = dateTimePickerStart.Value.AddDays(1);
        }

        private void DateTimePickerStart_ValueChanged(object sender, EventArgs e)
        {
            dateTimePickerEnd.MinDate = dateTimePickerStart.Value.AddDays(1);
        }

        private void BtnSearchRoom_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtQuantityCustomer.Text, out int quantity))
            {
                RoomBLL bll = new RoomBLL();
                dgvRoomAvailable.DataSource = StaticFunc.ToDataTable(bll.GetRoomsAvailable(dateTimePickerStart.Value.Date.AddHours(14)
                    , dateTimePickerEnd.Value.Date.AddHours(12), quantity));
                labelTotalRoom.Text = $"Total room : {dgvRoomAvailable.Rows.Count}";
            }
            else
            {
                MessageBox.Show("ERROR");
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
                    MessageBox.Show("ERROR");
                }
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        List<Reservation> reservations;
        List<Addition> additions;
        Voucher voucher;
        private void BtnOkInformation_Click(object sender, EventArgs e)
        {
            if (dgvServiceAvailable.SelectedRows.Count == 0 && dgvRoomAvailable.SelectedRows.Count == 0)
            {
                MessageBox.Show("ERROR");
                return;
            }

            if (dgvServiceAvailable.SelectedRows.Count > 0)
            {
                foreach (DataGridViewRow r in dgvServiceAvailable.SelectedRows)
                {
                    bool check = int.TryParse(r.Cells["Quantity"].Value?.ToString(), out int quantity);
                    if (!check || quantity > 100 || quantity < 1)
                    {
                        MessageBox.Show("ERROR");
                        return;
                    }
                }
            }

            if (!int.TryParse(txtCCCD.Text, out int cccd))
            {
                MessageBox.Show("ERROR");
                return;
            }

            CustomerBLL customerBLL = new CustomerBLL();
            if (!customerBLL.AddOrUpdate(new Customer
            {
                PersonId = cccd,
                Birthday = dateTimePickerBirthday.Value,
                Name = txtName.Text,
                Country = cbbCountry.SelectedItem.ToString(),
                PhoneNumber = txtPhoneNumberCustomer.Text
            }))
            {
                MessageBox.Show("ERROR");
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
                    DateStart = dateTimePickerStart.Value.Date.AddHours(14),
                    DateEnd = dateTimePickerEnd.Value.Date.AddHours(12),
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
            labelTotalPrice.Text = (Convert.ToDecimal(labelPriceReservations.Text) + Convert.ToDecimal(labelPriceServices.Text)).ToString();
        }
        private void BtnOkVoucher_Click(object sender, EventArgs e)
        {
            VoucherBLL voucherBLL = new VoucherBLL();
            voucher = voucherBLL.GetByCode(txtVoucher.Text);
            if (voucher != null)
            {
                labelVoucher.Text = voucher.Discount.ToString("p");
                labelTotalPrice.Text = ((Convert.ToDecimal(labelPriceReservations.Text) + Convert.ToDecimal(labelPriceServices.Text)) * (1 - voucher.Discount)).ToString();
                labelDeposit.Text = (Convert.ToDecimal(labelTotalPrice.Text) * Convert.ToDecimal(cbbDeposit.SelectedItem)).ToString();
            }
            else
            {
                MessageBox.Show("ERROR");
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
        }
        private void BtnOkPayment_Click(object sender, EventArgs e)
        {
            PaymentBLL paymentBLL = new PaymentBLL();
            if(!paymentBLL.BookRoomCompleted(new Payment 
                { DateCreate = DateTime.Now, PersonId = AccountId
                , Deposit = Convert.ToDecimal(cbbDeposit.SelectedItem)
                , VoucherId = voucher?.VoucherId}
            , reservations, additions))
            {
                MessageBox.Show("ERROR");
                return;
            }
            ClearPanelBookRoom();
            panelBookRoom.BringToFront();
        }
    }
}
