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
    public partial class UC_Home : UserControl
    {
        private ColorDialog colorDialog;
        private wLightBoxAPI api;

        public UC_Home()
        {
            InitializeComponent();
            colorDialog = new ColorDialog();
        }
        public UC_Home(wLightBoxAPI api) : this()
        {
            this.api = api;
            UpdateUC();
        }

        private void UC_Home_Load(object sender, EventArgs e) {}

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            txtR.Text = new string(txtR.Text.Where(c => char.IsDigit(c)).ToArray());
            txtR.Text = txtR.Text.Length > 0 ?
                 txtR.Text = int.Parse(txtR.Text) >= 255 ? "255" : txtR.Text    //>0
                 : "0";                                                         //<0
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            txtG.Text = new string(txtG.Text.Where(c => char.IsDigit(c)).ToArray());
            txtG.Text = txtG.Text.Length > 0 ?
                 txtG.Text = int.Parse(txtG.Text) >= 255 ? "255" : txtG.Text    //>0
                 : "0";                                                         //<0
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            txtB.Text = new string(txtB.Text.Where(c => char.IsDigit(c)).ToArray());
            txtB.Text = txtB.Text.Length > 0 ?
                 txtB.Text = int.Parse(txtB.Text) >= 255 ? "255" : txtB.Text    //>0
                 : "0";                                                         //<0
        }

        private void txtW_TextChanged(object sender, EventArgs e)
        {
            txtW.Text = new string(txtW.Text.Where(c => char.IsDigit(c)).ToArray());
            txtW.Text = txtW.Text.Length > 0 ?
                 txtW.Text = int.Parse(txtW.Text) >= 255 ? "255" : txtW.Text    //>0
                 : "0";                                                         //<0

        }

        private void btnColorDialog_Click(object sender, EventArgs e)
        {
            UpdateColorDialog();
            if (colorDialog.ShowDialog() != DialogResult.OK) { return; }
            txtR.Text = colorDialog.Color.R.ToString();
            txtG.Text = colorDialog.Color.G.ToString();
            txtB.Text = colorDialog.Color.B.ToString();
        }

        private void btnUpdateColor_Click(object sender, EventArgs e)
        {
            if(api == null) { return; }
            int red = int.Parse(txtR.Text);
            int green = int.Parse(txtG.Text);
            int blue = int.Parse(txtB.Text);
            api.SetLightning(1, red, green, blue, 1000, 1500, 2000);
        }

        private void UpdateColorDialog()
        {
            colorDialog.Reset();
            colorDialog.Color = Color.FromArgb(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
        }

        private void UpdateUC()
        {
            if (api != null)
            {
                var response = api.GetDeviceInfo();
                if (response != null)
                {
                    dynamic device = JsonConvert.DeserializeObject(response);
                    lblDeviceName.Text = device.deviceName;
                    lblDeviceId.Text = device.id;
                    return;
                }
            }

            lblDeviceName.Text = "Device not found";
            lblDeviceId.Text = "";
            btnUpdateColor.Enabled = false;
        }
    }
}
