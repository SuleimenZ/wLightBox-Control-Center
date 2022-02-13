using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wLightBox_Control_Center.src.UI.UserControls
{
    public partial class UC_Network : UserControl
    {
        private wLightBoxAPI api;
        public event EventHandler<string> IpChangedEvent;

        public UC_Network(wLightBoxAPI api)
        {
            InitializeComponent();
            this.api = api;
        }

        private void UC_Network_Load(object sender, EventArgs e)
        {

        }

        private void txtIp1_TextChanged(object sender, EventArgs e)
        {
            txtIp1.Text = new string(txtIp1.Text.Where(c => char.IsDigit(c)).ToArray());
            txtIp1.Text = txtIp1.Text.Length > 0 ?
                 txtIp1.Text = int.Parse(txtIp1.Text) >= 255 ? "255" : txtIp1.Text    //  0 <= Ip1 <= 255
                 : "0";
        }
        private void txtIp2_TextChanged(object sender, EventArgs e)
        {
            txtIp2.Text = new string(txtIp2.Text.Where(c => char.IsDigit(c)).ToArray());
            txtIp2.Text = txtIp2.Text.Length > 0 ?
                 txtIp2.Text = int.Parse(txtIp2.Text) >= 255 ? "255" : txtIp2.Text    //  0 <= Ip1 <= 255
                 : "0";
        }
        private void txtIp3_TextChanged(object sender, EventArgs e)
        {
            txtIp3.Text = new string(txtIp3.Text.Where(c => char.IsDigit(c)).ToArray());
            txtIp3.Text = txtIp3.Text.Length > 0 ?
                 txtIp3.Text = int.Parse(txtIp3.Text) >= 255 ? "255" : txtIp3.Text    //  0 <= Ip1 <= 255
                 : "0";
        }
        private void txtIp4_TextChanged(object sender, EventArgs e)
        {
            txtIp4.Text = new string(txtIp4.Text.Where(c => char.IsDigit(c)).ToArray());
            txtIp4.Text = txtIp4.Text.Length > 0 ?
                 txtIp4.Text = int.Parse(txtIp4.Text) >= 255 ? "255" : txtIp4.Text    //  0 <= Ip1 <= 255
                 : "0";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            string newIp = txtIp1.Text + "." + txtIp2.Text + "." + txtIp3.Text + "." + txtIp4.Text;
            IpChangedEvent?.Invoke(this, newIp);
        }
    }
}
