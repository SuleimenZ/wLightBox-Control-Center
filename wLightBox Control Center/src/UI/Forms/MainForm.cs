using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using wLightBox_Control_Center.src;
using wLightBox_Control_Center.src.UI.UserControls;

namespace wLightBox_Control_Center
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
            UC_Home uc = new UC_Home(api);
            addUserControl(uc);
        }

        private void addUserControl(UserControl userControl)
        {
            userControl.Dock = DockStyle.Fill;
            pnlContainer.Controls.Clear();
            pnlContainer.Controls.Add(userControl);
            userControl.BringToFront();
        }

        private void HomeButton_Click(object sender, EventArgs e)
        {
            UC_Home uc = new UC_Home(api);
            addUserControl(uc);
        }

        private void pnlContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
