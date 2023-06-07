using PBL.BLL;
using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class ucManageRoom : UserControl
    {
        public ucManageRoom()
        {
            InitializeComponent();
            panelGeneral.BringToFront();
        }

        void SetCBBTypeRoom(int typeRoomId)
        {
            cbbTypeRoom.Items?.Clear();
            cbbTypeRoom.Text = string.Empty;
            cbbTypeRoom.Enabled = true;
            string name = null;
            TypeRoomBLL typeRoomBLL = new TypeRoomBLL();
            foreach (TypeRoom typeRoom in typeRoomBLL.GetAll())
            {
                if(typeRoomId == typeRoom.TypeRoomId)
                {
                    cbbTypeRoom.Enabled = false;
                    name = typeRoom.Name;
                }
                cbbTypeRoom.Items.Add(new CbbItem { Id = typeRoom.TypeRoomId, Name = typeRoom.Name });
            }
            cbbTypeRoom.SelectedIndex = cbbTypeRoom.FindString(name);
        }

        void RefreshPanelGeneral(RoomBLL roomBLL)
        {
            dgvListRooms.DataSource = StaticFunc.ToDataTable(roomBLL.GetAll());
            labelTotalRoom.Text = $"Total : {dgvListRooms.Rows.Count}";
        }
        private void BtnListAll_Click(object sender, EventArgs e)
        {
            RoomBLL roomBLL = new RoomBLL();
            RefreshPanelGeneral(roomBLL);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int roomId))
            {
                RoomBLL roomBLL = new RoomBLL();
                dgvListRooms.DataSource = new Room[] { roomBLL.Get(roomId) };
                dgvListRooms.Columns["Reservations"].Visible = false;
                dgvListRooms.Columns["TypeRoom"].Visible = false;
                labelTotalRoom.Text = $"Total : {dgvListRooms.Rows.Count}";
            }
            else
            {
                MessageBox.Show("RoomId must be numberic", "ERROR", 0, MessageBoxIcon.Error);
            }
        }
        
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListRooms.SelectedRows.Count > 0)
            {
                List<int> ids = new List<int>();
                foreach (DataGridViewRow r in dgvListRooms.SelectedRows)
                {
                    ids.Add(Convert.ToInt32(r.Cells["RoomId"].Value));
                }
                RoomBLL roomBLL = new RoomBLL();
                if (!roomBLL.Delete(ids.ToArray()))
                {
                    MessageBox.Show("Delete failed", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
                RefreshPanelGeneral(roomBLL);
            }
        }
        void ClearPanelDetail()
        {
            txtRoomId.Text = string.Empty;
            txtRoomId.Enabled = true;
            txtCapacity.Text = string.Empty;
            txtPrice.Text = string.Empty;
            SetCBBTypeRoom(-1);
            labelTotalReservation.Text = "Total : 0";
            dgvReservations.Columns?.Clear();
        }
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            ClearPanelDetail();
            panelDetail.BringToFront();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvListRooms.SelectedRows.Count == 1)
            {
                RoomBLL roomBLL = new RoomBLL();
                Room room = roomBLL.Get(Convert.ToInt32(dgvListRooms.SelectedRows[0].Cells["RoomId"].Value));
                txtRoomId.Text = room.RoomId.ToString();
                txtRoomId.Enabled = false;
                txtCapacity.Text = room.Capacity.ToString();
                txtPrice.Text = room.Price.ToString();
                SetCBBTypeRoom(room.TypeRoomId);
                dgvReservations.DataSource = StaticFunc.ToDataTable(roomBLL.GetReservations(room.RoomId));
                labelTotalReservation.Text = $"Total : {dgvReservations.Rows.Count}";
                panelDetail.BringToFront();
            }
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtRoomId.Text, out int roomId) && int.TryParse(txtCapacity.Text, out int capacity) && decimal.TryParse(txtPrice.Text, out decimal price))
            {
                RoomBLL roomBLL = new RoomBLL();
                Room room = new Room
                {
                    RoomId = roomId,
                    Capacity = capacity,
                    Price = price,
                    TypeRoomId = ((CbbItem)cbbTypeRoom.SelectedItem).Id,
                };
                if (txtRoomId.Enabled)
                {
                    if (!roomBLL.Create(room))
                    {
                        MessageBox.Show("Wrong information and create customer failed", "ERROR", 0, MessageBoxIcon.Error);
                        return;
                    }
                }
                else
                {
                    if (!roomBLL.Update(room))
                    {
                        MessageBox.Show("Wrong information and update customer failed", "ERROR", 0, MessageBoxIcon.Error);
                        return;
                    }
                }
                panelGeneral.BringToFront();
                RefreshPanelGeneral(roomBLL);
            }
            else
            {
                MessageBox.Show("Wrong information", "ERROR", 0, MessageBoxIcon.Error);
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            panelGeneral.BringToFront();
        }
    }
}
