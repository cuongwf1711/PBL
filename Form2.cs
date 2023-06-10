using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SideBar
{
    public partial class Form2 : Form
    {
        bool sidebarExpand;
        public Form2()
        {
            InitializeComponent();
        }

        private void TimerSidebar_Tick(object sender, EventArgs e)
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
    }
}
