using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace wLightBox_Control_Center.src.UI.UserControls
{
    public partial class UC_Network : UserControl
    {
        private wLightBoxAPI api;
        public event EventHandler<string> IpChangedEvent;
        private Dictionary<string, int> WifiList;   //Using Dictionary to store signal strength (rssi)

        public UC_Network(wLightBoxAPI api)
        {
            InitializeComponent();
            this.api = api;
        }

        private async void UC_Network_Load(object sender, EventArgs e)
        {
            await UpdateUC();
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
                 txtIp2.Text = int.Parse(txtIp2.Text) >= 255 ? "255" : txtIp2.Text    //  0 <= Ip2 <= 255
                 : "0";
        }
        private void txtIp3_TextChanged(object sender, EventArgs e)
        {
            txtIp3.Text = new string(txtIp3.Text.Where(c => char.IsDigit(c)).ToArray());
            txtIp3.Text = txtIp3.Text.Length > 0 ?
                 txtIp3.Text = int.Parse(txtIp3.Text) >= 255 ? "255" : txtIp3.Text    //  0 <= Ip3 <= 255
                 : "0";
        }
        private void txtIp4_TextChanged(object sender, EventArgs e)
        {
            txtIp4.Text = new string(txtIp4.Text.Where(c => char.IsDigit(c)).ToArray());
            txtIp4.Text = txtIp4.Text.Length > 0 ?
                 txtIp4.Text = int.Parse(txtIp4.Text) >= 255 ? "255" : txtIp4.Text    //  0 <= Ip4 <= 255
                 : "0";
        }

        private void btnConnect_Click(object sender, EventArgs e)
        {
            MethodInvoker btnOff = delegate () { btnConnect.Enabled = false; };
            MethodInvoker btnOn = delegate () { btnConnect.Enabled = true; };

            this.Invoke(btnOff);
            string newIp = txtIp1.Text + "." + txtIp2.Text + "." + txtIp3.Text + "." + txtIp4.Text;
            IpChangedEvent?.Invoke(this, newIp);
            this.Invoke(btnOn);
        }

        private async void btnWifiScan_Click(object sender, EventArgs e)
        {
            await Task.Run(() => WifiScan());
        }

        private async void btnAPUpdate_Click(object sender, EventArgs e)
        {
            MethodInvoker btnOff = delegate () { btnAPUpdate.Enabled = false; };
            MethodInvoker btnOn = delegate () { btnAPUpdate.Enabled = true; };

            this.Invoke(btnOff);
            await api.SetAccessPointAsync(chkAPEnabled.Checked, txtAPSsid.Text, txtAPPassword.Text);
            await UpdateUC();
            this.Invoke(btnOn);
        }

        private async void btnWifiConnect_Click(object sender, EventArgs e)
        {
            MethodInvoker btnOff = delegate () { btnWifiConnect.Enabled = false; };
            MethodInvoker btnOn = delegate () { btnWifiConnect.Enabled = true; };

            this.Invoke(btnOff);
            await api.WifiConnectAsync(cmbWifiList.SelectedText, txtPassword.Text);
            this.Invoke(btnOn);
        }

        private async void btnWifiDisconnect_Click(object sender, EventArgs e)
        {
            MethodInvoker btnOff = delegate () { btnWifiDisconnect.Enabled = false; };
            MethodInvoker btnOn = delegate () { btnWifiDisconnect.Enabled = true; };

            this.Invoke(btnOff);
            await api.WifiDisconnectAsync();
            this.Invoke(btnOn);
        }

        private async void WifiScan()
        {
            MethodInvoker btnOff = delegate () { btnWifiScan.Enabled = false; };
            MethodInvoker btnOn = delegate () { btnWifiScan.Enabled = true; };

            this.Invoke(btnOff);
            string WifiJson = await api.WifiScanAsync();
            if (WifiJson == null) { this.Invoke(btnOn); return; }

            dynamic device = JsonConvert.DeserializeObject(WifiJson);
            WifiList.Clear();
            if (device != null)
            {
                foreach (dynamic wifi in device.ap)
                {
                    WifiList.Add(wifi.ssid, wifi.rssi);
                }
                WifiList = WifiList.OrderBy(w => w.Value).ToDictionary(w => w.Key, w => w.Value); //sorting by signal strength


                //Filling comboBox with available wifi's
                MethodInvoker fillComboBox = delegate ()
                {
                    cmbWifiList.Items.Clear();
                    foreach (var wifi in WifiList)
                    {
                        cmbWifiList.Items.Add(wifi.Key);
                    }
                };
                this.Invoke(fillComboBox);
            }
            this.Invoke(btnOn);
        }

        private async void UpdateAP()
        {
            string APJson = await api.GetNetworkInfoAsync();
            if (APJson == null) { return; }
            dynamic device = JsonConvert.DeserializeObject(APJson);

            if(device != null)
            {
                txtAPSsid.Text = device.ssid;
                txtAPPassword.Text = device.apPasswd;
            }
        }

        private async Task UpdateUC()
        {
            //Filling IP boxes
            string ip = api.ip;
            txtIp1.Text = ip.Substring(0, ip.IndexOf('.'));
            ip = ip.Remove(0, ip.IndexOf('.') + 1);
            txtIp2.Text = ip.Substring(0, ip.IndexOf('.'));
            ip = ip.Remove(0, ip.IndexOf('.') + 1);
            txtIp3.Text = ip.Substring(0, ip.IndexOf('.'));
            ip = ip.Remove(0, ip.IndexOf('.') + 1);
            txtIp4.Text = ip;

            //Performing Wifi scan and filling Wifi combo box
            await Task.Run(() => WifiScan());

            //Filling Access point SSID and Password boxes
            await Task.Run(() => UpdateAP());
        }
    }
}
