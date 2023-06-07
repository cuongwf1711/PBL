using PBL.BLL;
using PBL.DTO;
using System;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace PBL.View
{
    public partial class FormMain : Form
    {
        bool sidebarExpand;
        public FormMain(int accountId, int roleId, string permissions = "")
        {
            InitializeComponent();
            Create(accountId, roleId, permissions);
        }
        void Create(int accountId, int roleId, string permissions)
        {
            pictureBoxHome.BringToFront();
            flowLayoutPanelSidebar.BringToFront();

            ucBookRoom1.AccountId = accountId;
            ucManageEmployee1.AccountId = accountId;
            ucMyAccount1.AccountId = accountId;
            if (roleId != 1)
            {
                foreach (Button button in flowLayoutPanelSidebar.Controls.OfType<Button>())
                {
                    button.Visible = false;
                    foreach (string permission in permissions.Split(','))
                    {
                        if (button.Name.Contains(permission))
                        {
                            button.Visible = true;
                            break;
                        }
                    }
                }
                btnMyAccount.Visible = true;
                btnLogout.Visible = true;
            }
        }

        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (sidebarExpand)
            {
                flowLayoutPanelSidebar.Width -= 10;
                if (flowLayoutPanelSidebar.Width == flowLayoutPanelSidebar.MinimumSize.Width)
                {
                    sidebarExpand = false;
                    timerSidebar.Stop();
                }
            }
            else
            {
                flowLayoutPanelSidebar.Width += 10;
                if (flowLayoutPanelSidebar.Width == flowLayoutPanelSidebar.MaximumSize.Width)
                {
                    sidebarExpand = true;
                    timerSidebar.Stop();
                }
            }
        }

        private void PictureBoxMenu_Click(object sender, EventArgs e)
        {
            timerSidebar.Start();
        }
        void ColorButton(object btn)
        {
            foreach (Button button in flowLayoutPanelSidebar.Controls.OfType<Button>())
            {
                if (button != btn)
                {
                    button.BackColor = SystemColors.ActiveCaption;
                }
                else
                {
                    button.BackColor = SystemColors.Info;
                }
            }
        }
        private void SidebarButton_Click(object sender, EventArgs e)
        {
            ColorButton(sender);
            sidebarExpand = true;
            timerSidebar.Start();
            if (sender == btnBookRoom)
            {
                ucBookRoom1.BringToFront();
            }
            else if (sender == btnRoom)
            {
                ucManageRoom1.BringToFront();
            }
            else if (sender == btnCustomer)
            {
                ucManageCustomer1.BringToFront();
            }
            else if (sender == btnService)
            {
                ucManageService1.BringToFront();
            }
            else if (sender == btnPayment)
            {
                ucManagePayment1.BringToFront();
            }
            else if (sender == btnEmployee)
            {
                ucManageEmployee1.BringToFront();
            }
            else if (sender == btnRole)
            {
                ucManageRole1.BringToFront();
            }
            else if (sender == btnMyAccount)
            {
                ucMyAccount1.BringToFront();
            }
            else if (sender == btnVoucher)
            {
                ucManageVoucher1.BringToFront();
            }
            else if (sender == btnTypeRoom)
            {
                ucManageTypeRoom1.BringToFront();
            }
            else if (sender == btnLate)
            {
                ucManageLate1.BringToFront();
            }
            else if (sender == btnLogout)
            {
                Dispose();
            }
            flowLayoutPanelSidebar.BringToFront();
        }
    }
}
