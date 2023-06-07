using PBL.BLL;
using PBL.DTO;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class ucManageLate : UserControl
    {
        public ucManageLate()
        {
            InitializeComponent();
            panelGeneral.BringToFront();
        }
        void RefreshPanelGeneral(LateBLL lateBLL)
        {
            dgvListLates.DataSource = StaticFunc.ToDataTable(lateBLL.GetAll());
            labelTotal.Text = $"Total : {dgvListLates.Rows.Count}";
        }
        private void BtnListAll_Click(object sender, EventArgs e)
        {
            LateBLL lateBLL = new LateBLL();
            RefreshPanelGeneral(lateBLL);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text, out int id))
            {
                LateBLL lateBLL = new LateBLL();
                dgvListLates.DataSource = new Late[] { lateBLL.Get(id) };
                labelTotal.Text = $"Total : {dgvListLates.Rows.Count}";
            }
            else
            {
                MessageBox.Show("LateId must be numberic", "ERROR", 0, MessageBoxIcon.Error);
            }
        }
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListLates.SelectedRows.Count > 0)
            {
                List<int> ids = new List<int>();
                foreach (DataGridViewRow r in dgvListLates.SelectedRows)
                {
                    ids.Add(Convert.ToInt32(r.Cells["LateId"].Value));
                }
                LateBLL lateBLL = new LateBLL();
                if (!lateBLL.Delete(ids.ToArray()))
                {
                    MessageBox.Show("Delete failed", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
                RefreshPanelGeneral(lateBLL);
            }
        }
        int upd;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            upd = -1;
            txtName.Text = string.Empty;
            txtFeeLate.Text = string.Empty;
            panelDetail.BringToFront();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvListLates.SelectedRows.Count == 1)
            {
                upd = Convert.ToInt32(dgvListLates.SelectedRows[0].Cells["LateId"].Value);
                LateBLL lateBLL = new LateBLL();
                Late late = lateBLL.Get(upd);
                txtName.Text = late.Name;
                txtFeeLate.Text = late.FeeLate.ToString();
                txtMaximum.Text = late.Maximum.ToString();
                panelDetail.BringToFront();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            panelGeneral.BringToFront();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if(!decimal.TryParse(txtFeeLate.Text, out decimal feeLate) || !int.TryParse(txtMaximum.Text, out int maximum))
            {
                MessageBox.Show("FeeLate and Maximum must be numberic", "ERROR", 0, MessageBoxIcon.Error);
                return;
            }
            LateBLL lateBLL = new LateBLL();
            if (upd == -1)
            {
                if (!lateBLL.Create(new Late { Name = txtName.Text, Maximum = maximum, FeeLate = feeLate }))
                {
                    MessageBox.Show("Wrong information and create customer failed", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
            }
            else
            {
                if (!lateBLL.Update(new Late { LateId = upd, Name = txtName.Text, Maximum = maximum, FeeLate = feeLate }))
                {
                    MessageBox.Show("Wrong information and update customer failed", "ERROR", 0, MessageBoxIcon.Error);
                    return;
                }
            }
            RefreshPanelGeneral(lateBLL);
            panelGeneral.BringToFront();
        }
    }
}
