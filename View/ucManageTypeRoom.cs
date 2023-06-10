using PBL.BLL;
using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class ucManageTypeRoom : UserControl
    {
        public ucManageTypeRoom()
        {
            InitializeComponent();
            panelGeneral.BringToFront();
        }
        void RefreshPanelGeneral(TypeRoomBLL typeRoomBLL)
        {
            dgvListTypeRooms.DataSource = StaticFunc.ToDataTable(typeRoomBLL.GetAll());
            labelTotalTypeRoom.Text = $"Total : {dgvListTypeRooms.Rows.Count}";
        }
        private void BtnListAll_Click(object sender, System.EventArgs e)
        {
            TypeRoomBLL typeRoomBLL = new TypeRoomBLL();
            RefreshPanelGeneral(typeRoomBLL);
        }

        private void BtnSearch_Click(object sender, System.EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int id))
            {
                TypeRoomBLL typeRoomBLL = new TypeRoomBLL();
                dgvListTypeRooms.DataSource = new TypeRoom[] { typeRoomBLL.Get(id) };
                dgvListTypeRooms.Columns["Rooms"].Visible = false;
                labelTotalTypeRoom.Text = $"Total : {dgvListTypeRooms.Rows.Count}";
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }

        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListTypeRooms.SelectedRows.Count > 0)
            {
                List<int> ids = new List<int>();
                foreach (DataGridViewRow r in dgvListTypeRooms.SelectedRows)
                {
                    ids.Add(Convert.ToInt32(r.Cells["TypeRoomId"].Value));
                }
                TypeRoomBLL typeRoomBLL = new TypeRoomBLL();
                if (!typeRoomBLL.Delete(ids.ToArray()))
                {
                    MessageBox.Show("ERROR");
                    return;
                }
                RefreshPanelGeneral(typeRoomBLL);
            }
        }
        int upd;

        private void BtnAdd_Click(object sender, EventArgs e)
        {
            upd = -1;
            txtName.Text = string.Empty;
            labelTotalRoom.Text = "Total : 0";
            dgvRooms.Columns?.Clear();
            panelDetail.BringToFront();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvListTypeRooms.SelectedRows.Count == 1)
            {
                upd = Convert.ToInt32(dgvListTypeRooms.SelectedRows[0].Cells["TypeRoomId"].Value);
                TypeRoomBLL typeRoomBLL = new TypeRoomBLL();
                TypeRoom typeRoom = typeRoomBLL.Get(upd);
                txtName.Text = typeRoom.Name;
                dgvRooms.DataSource = StaticFunc.ToDataTable(typeRoomBLL.GetRooms(upd));
                labelTotalRoom.Text = $"Total : {dgvRooms.Rows.Count}";
                panelDetail.BringToFront();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            panelGeneral.BringToFront();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            TypeRoomBLL typeRoomBLL = new TypeRoomBLL();
            if (upd == -1)
            {
                if (!typeRoomBLL.Create(new TypeRoom { Name = txtName.Text }))
                {
                    MessageBox.Show("ERROR");
                    return;
                }
            }
            else
            {
                if (!typeRoomBLL.Update(new TypeRoom { TypeRoomId = upd, Name = txtName.Text }))
                {
                    MessageBox.Show("ERROR");
                    return;
                }
            }
            RefreshPanelGeneral(typeRoomBLL);
            panelGeneral.BringToFront();
        }
    }
}
