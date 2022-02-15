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
            api = new wLightBoxAPI(GetLocalIP());
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

        private void SettingsButton_Click(object sender, EventArgs e)
        {
            UC_Settings uc = new UC_Settings(api);
            addUserControl(uc);
        }

        private void Uc_IpChangedEvent(object sender, string ip)
        {
            Task.Run(() => ConnectDevice(ip));
        }

        public async void ConnectDevice(string ip = null)
        {
            ip = ip == null ? GetLocalIP() : ip;
            Task maintainUptime = MaintainUptime();

            //Change UI to show connectiong state
            MethodInvoker Connecting = delegate ()
            {
                this.PnlSideHeader.BackColor = Color.Blue;
                this.lblIp.BackColor = Color.Blue;
                this.lblName.BackColor = Color.Blue;
                this.lblUptime.BackColor = Color.Blue;
                this.lblIp.Text = "IP: " + ip;
                this.lblName.Text = "Connecting...";
            };

            //Change UI to show fail state
            MethodInvoker Fail = delegate ()
            {
                this.PnlSideHeader.BackColor = Color.Red;
                this.lblIp.BackColor = Color.Red;
                this.lblName.BackColor = Color.Red;
                this.lblUptime.BackColor = Color.Red;
                this.lblIp.Text = "IP: disconnected";
                this.lblName.Text = "Device not found";
            };

            api = new wLightBoxAPI(ip);

            this.Invoke(Connecting);
            var response = await api.GetDeviceInfoAsync();

            if (response == null)
            {
                this.Invoke(Fail);
                return;
            }
            dynamic device = JsonConvert.DeserializeObject(response);

            //Change UI to show success state
            MethodInvoker Success = async delegate ()
            {
                this.PnlSideHeader.BackColor = Properties.Settings.Default.SidePanelBackColor;
                this.lblIp.BackColor = Properties.Settings.Default.SidePanelBackColor;
                this.lblName.BackColor = Properties.Settings.Default.SidePanelBackColor;
                this.lblUptime.BackColor = Properties.Settings.Default.SidePanelBackColor;
                this.lblIp.Text = "IP: " + device.ip;
                this.lblName.Text = device.deviceName;
                await maintainUptime;
            };
            this.Invoke(Success);
        }

        private async Task MaintainUptime()
        {
            while (true)
            {
                Thread.Sleep(2000);
                if (api == null) { continue; }
                dynamic device = await api.GetDeviceUpTimeAsync();
                if (device == null) { continue; }
                lblUptime.Text = "Uptime: " + device.upTimeS + "s";
            }
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
