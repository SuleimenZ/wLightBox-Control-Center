using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
using wLightBox_Control_Center.src;
using wLightBox_Control_Center.src.UI.UserControls;

namespace wLightBox_Control_Center
{
    public partial class MainForm : Form
    {
        private wLightBoxAPI api;

        public MainForm()
        {
            InitializeComponent();
            Task.Run(() => ConnectDevice());
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
        private void NetworkButton_Click(object sender, EventArgs e)
        {
            UC_Network uc = new UC_Network(api);
            uc.IpChangedEvent += Uc_IpChangedEvent;
            addUserControl(uc);
        }

        private void Uc_IpChangedEvent(object sender, string ip)
        {
            Task.Run(() => ConnectDevice(ip));
        }

        public async void ConnectDevice(string ip = null)
        {
            ip = ip == null ? GetLocalIP() : ip;
            MethodInvoker Connecting = delegate ()
            {
                this.PnlSideHeader.BackColor = System.Drawing.Color.Blue;
                this.lblIp.BackColor = System.Drawing.Color.Blue;
                this.lblName.BackColor = System.Drawing.Color.Blue;
                this.lblIp.Text = "IP: " + ip;
                this.lblName.Text = "Connecting...";
            };

            MethodInvoker Fail = delegate ()
            {
                this.PnlSideHeader.BackColor = System.Drawing.Color.Red;
                this.lblIp.BackColor = System.Drawing.Color.Red;
                this.lblName.BackColor = System.Drawing.Color.Red;
                this.lblIp.Text = "IP: disconnected";
                this.lblName.Text = "Device not found";
            };

            api = new wLightBoxAPI(ip);

            this.Invoke(Connecting);
            var response = await Task.Run(() => api.GetDeviceInfoAsync());

            if (response == null)
            {
                this.Invoke(Fail);
                return;
            }
            dynamic device = JsonConvert.DeserializeObject(response);
            MethodInvoker Success = delegate ()
            {
                this.PnlSideHeader.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.SidePanelBackColor;
                this.lblIp.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.SidePanelBackColor;
                this.lblName.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.SidePanelBackColor;
                this.lblIp.Text = "IP: " + device.ip;
                this.lblName.Text = device.deviceName;
            };
            this.Invoke(Success);
        }

        private string GetLocalIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach (var ip in host.AddressList)
            {
                if (ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) { return ip.ToString(); }
            }
            return null;
        }

        private void ChangeLblName(string s) => this.lblName.Text = s;
        private void ChangeLblIP(string s) => this.lblIp.Text = s;
    }
}
