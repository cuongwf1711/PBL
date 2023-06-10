using PBL.BLL;
using PBL.DTO;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class ucManageService : UserControl
    {
        public ucManageService()
        {
            InitializeComponent();
            panelGeneral.BringToFront();
        }

        void RefreshPanelGeneral(ServiceBLL serviceBLL)
        {
            dgvListServices.DataSource = StaticFunc.ToDataTable(serviceBLL.GetAll());
            labelTotalService.Text = $"Total : {dgvListServices.Rows.Count}";
        }
        private void BtnListAll_Click(object sender, EventArgs e)
        {
            ServiceBLL serviceBLL = new ServiceBLL();
            RefreshPanelGeneral(serviceBLL);
        }

        private void BtnSearch_Click(object sender, EventArgs e)
        {
            if (int.TryParse(txtSearch.Text,out int id))
            {
                ServiceBLL serviceBLL = new ServiceBLL();
                dgvListServices.DataSource = new Service[] { serviceBLL.Get(id) };
                dgvListServices.Columns["Additions"].Visible = false;
                labelTotalService.Text = $"Total : {dgvListServices.Rows.Count}";
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
        
        private void BtnDelete_Click(object sender, EventArgs e)
        {
            if (dgvListServices.SelectedRows.Count > 0)
            {
                List<int> ids = new List<int>();
                foreach (DataGridViewRow r in dgvListServices.SelectedRows)
                {
                    ids.Add(Convert.ToInt32(r.Cells["ServiceId"].Value));
                }
                ServiceBLL serviceBLL = new ServiceBLL();
                if (!serviceBLL.Delete(ids.ToArray()))
                {
                    MessageBox.Show("ERROR");
                    return;
                }
                RefreshPanelGeneral(serviceBLL);
            }
        }

        int upd;
        private void BtnAdd_Click(object sender, EventArgs e)
        {
            upd = -1;
            txtName.Text = string.Empty;
            txtPrice.Text = string.Empty;
            labelTotalAddition.Text = "Total : 0";
            dgvAdditions.Columns?.Clear();
            panelDetail.BringToFront();
        }

        private void BtnUpdate_Click(object sender, EventArgs e)
        {
            if (dgvListServices.SelectedRows.Count == 1)
            {
                upd = Convert.ToInt32(dgvListServices.SelectedRows[0].Cells["ServiceId"].Value);
                ServiceBLL serviceBLL = new ServiceBLL();
                Service service = serviceBLL.Get(upd);
                txtName.Text = service.Name;
                txtPrice.Text = service.Price.ToString();
                dgvAdditions.DataSource = StaticFunc.ToDataTable(serviceBLL.GetAdditions(upd));
                labelTotalAddition.Text = $"Total : {dgvAdditions.Rows.Count}";

                panelDetail.BringToFront();
            }
        }

        private void BtnCancel_Click(object sender, EventArgs e)
        {
            panelGeneral.BringToFront();
        }

        private void BtnConfirm_Click(object sender, EventArgs e)
        {
            if (decimal.TryParse(txtPrice.Text, out decimal price))
            {
                ServiceBLL serviceBLL = new ServiceBLL();
                if (upd == -1)
                {
                    if (!serviceBLL.Create(new Service { Name = txtName.Text, Price = price }))
                    {
                        MessageBox.Show("ERROR");
                        return;
                    }
                }
                else
                {
                    if (!serviceBLL.Update(new Service { ServiceId = upd, Name = txtName.Text, Price = price }))
                    {
                        MessageBox.Show("ERROR");
                        return;
                    }
                }
                panelGeneral.BringToFront();
                RefreshPanelGeneral(serviceBLL);
            }
            else
            {
                MessageBox.Show("ERROR");
            }
        }
    }
}
