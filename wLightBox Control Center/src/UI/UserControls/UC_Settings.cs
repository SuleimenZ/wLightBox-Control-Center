using Newtonsoft.Json;
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
    public partial class UC_Settings : UserControl
    {
        wLightBoxAPI api;
        public UC_Settings(wLightBoxAPI api)
        {
            InitializeComponent();
            this.api = api;
        }

        private async void UC_Settings_Load(object sender, EventArgs e)
        {
            await UpdateUC();
        }

        private async void btnUpdate_Click(object sender, EventArgs e)
        {
            MethodInvoker btnOff = delegate () { btnUpdate.Enabled = false; };
            MethodInvoker btnOn = delegate () { btnUpdate.Enabled = true; };

            if (api == null) { return; }
            this.Invoke(btnOff);
            await api.UpdateFirmwareAsync();
            this.Invoke(btnOn);
        }

        private async void btnChange_Click(object sender, EventArgs e)
        {
            MethodInvoker btnOff = delegate () { btnChange.Enabled = false; };
            MethodInvoker btnOn = delegate () { btnChange.Enabled = true; };

            if (api == null) { return; }
            this.Invoke(btnOff);
            if(string.IsNullOrWhiteSpace(txtDeviceName.Text))
            {
                await api.SetDeviceSettingsAsync(txtDeviceName.Text, chkTunnel.Checked, chkStatusLed.Checked);
            }
            this.Invoke(btnOn);
        }

        private async Task UpdateUC()
        {
            if (api == null) { return; }

            string SettingsJson = await api.GetDeviceSettingsAsync();
            if (SettingsJson == null) {  return; }

            dynamic device = JsonConvert.DeserializeObject(SettingsJson);
            if(device != null)
            {
                txtDeviceName.Text = device.deviceName;
                chkTunnel.Checked = device.tunnel.enabled.ToString() == "1";
                chkStatusLed.Checked = device.statusLed.enabled.ToString() == "1";
            }

        }
    }
}
