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
        private enum Effects
        {
            NONE = 0,
            FADE = 1,
            RGB = 2,
            POLICE = 3,
            RELAX = 4,
            STROBO = 5,
            BELL = 6
        }

        public UC_Home()
        {
            InitializeComponent();
            colorDialog = new ColorDialog();
        }
        public UC_Home(wLightBoxAPI api) : this()
        {
            this.api = api;
        }

        private async void UC_Home_Load(object sender, EventArgs e) 
        {
            this.cmbEffect.Items.Clear();
            foreach(var effect in Enum.GetValues(typeof(Effects)))
            {
                cmbEffect.Items.Add(effect.ToString());
            }
            if(cmbEffect.Items.Count > 0)
            {
                cmbEffect.SelectedIndex = 0;
            }
            await Task.Run(() => UpdateUC());
        }

        private void txtR_TextChanged(object sender, EventArgs e)
        {
            txtR.Text = new string(txtR.Text.Where(c => char.IsDigit(c)).ToArray());
            txtR.Text = txtR.Text.Length > 0 ?
                 txtR.Text = int.Parse(txtR.Text) >= 255 ? "255" : txtR.Text    //  0 <= R <= 255
                 : "0";
        }

        private void txtG_TextChanged(object sender, EventArgs e)
        {
            txtG.Text = new string(txtG.Text.Where(c => char.IsDigit(c)).ToArray());
            txtG.Text = txtG.Text.Length > 0 ?
                 txtG.Text = int.Parse(txtG.Text) >= 255 ? "255" : txtG.Text    //  0 <= G <= 255
                 : "0";
        }

        private void txtB_TextChanged(object sender, EventArgs e)
        {
            txtB.Text = new string(txtB.Text.Where(c => char.IsDigit(c)).ToArray());
            txtB.Text = txtB.Text.Length > 0 ?
                 txtB.Text = int.Parse(txtB.Text) >= 255 ? "255" : txtB.Text    //  0 <= B <= 255
                 : "0";
        }

        private void txtW_TextChanged(object sender, EventArgs e)
        {
            txtW.Text = new string(txtW.Text.Where(c => char.IsDigit(c)).ToArray());
            txtW.Text = txtW.Text.Length > 0 ?
                 txtW.Text = int.Parse(txtW.Text) >= 255 ? "255" : txtW.Text    //  0 <= W <= 255
                 : "0";

        }
        private void txtColorFade_TextChanged(object sender, EventArgs e)
        {
            txtColorFade.Text = new string(txtColorFade.Text.Where(c => char.IsDigit(c)).ToArray());
            txtColorFade.Text = txtColorFade.Text.Length > 0 ?                  //  1 <= colorFade <= 10000
                 int.Parse(txtColorFade.Text) <= 1 ? "1" :
                 int.Parse(txtColorFade.Text) >= 10000 ? "10000" : txtColorFade.Text : "1";
        }

        private void txtEffectFade_TextChanged(object sender, EventArgs e)
        {
            txtEffectFade.Text = new string(txtEffectFade.Text.Where(c => char.IsDigit(c)).ToArray());
            txtEffectFade.Text = txtEffectFade.Text.Length > 0 ?                //  1 <= effectFade <= 10000
                 int.Parse(txtEffectFade.Text) <= 1 ? "1" :
                 int.Parse(txtEffectFade.Text) >= 10000 ? "10000" : txtEffectFade.Text : "1";
        }

        private void txtEffectStep_TextChanged(object sender, EventArgs e)
        {
            txtEffectStep.Text = new string(txtEffectStep.Text.Where(c => char.IsDigit(c)).ToArray());
            txtEffectStep.Text = txtEffectStep.Text.Length > 0 ?                //  1 <= effectStep <= 10000
                 int.Parse(txtEffectStep.Text) <= 1 ? "1" :
                 int.Parse(txtEffectStep.Text) >= 10000 ? "10000" : txtEffectStep.Text : "1";                                                                                   //<0
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
            int white = int.Parse(txtW.Text);
            int colorFade = int.Parse(txtColorFade.Text);
            int effectFade = int.Parse(txtEffectFade.Text);
            int effectStep = int.Parse(txtEffectStep.Text);
            api.SetLightning(cmbEffect.SelectedIndex, red, green, blue, white, colorFade, effectFade, effectStep);
        }

        private void UpdateColorDialog()
        {
            colorDialog.Reset();
            colorDialog.Color = Color.FromArgb(int.Parse(txtR.Text), int.Parse(txtG.Text), int.Parse(txtB.Text));
        }

        private async Task UpdateUC()
        {
            string deviceInfo = null;
            string deviceLightning = null;
            MethodInvoker Fail = delegate ()
            {
                lblDeviceName.Text = "Device was not found";
                lblDeviceId.Text = "";
                btnUpdateColor.Enabled = false;
            };
            MethodInvoker Success = delegate ()
            {
                dynamic device = JsonConvert.DeserializeObject(deviceInfo);
                lblDeviceName.Text = device.deviceName;
                lblDeviceId.Text = device.id;
                btnUpdateColor.Enabled = true;
                device = JsonConvert.DeserializeObject(deviceLightning);

                //We have to format color because api gives us #RRGGBBWW hex value
                //And ColorTranslator accepts ##AARRGGBB, where A - alpha (transparency)
                //Because we don't need alpha value, im using White value instead of it
                string rgb = device.currentColor.Substring(0, 6);
                string white = device.currentColor.Substring(6, 2);
                string formattedColor = "#" + rgb + white;
                Color color = ColorTranslator.FromHtml(formattedColor);

                txtR.Text = color.R.ToString();
                txtG.Text = color.G.ToString();
                txtB.Text = color.B.ToString();
                txtW.Text = color.A.ToString(); //Value stored in alpha goes back as White value;
                txtColorFade.Text = device.durationsMs.colorFade.ToString();
                txtEffectFade.Text = device.durationsMs.effectFade.ToString();
                txtEffectStep.Text = device.durationsMs.effectStep.ToString();
                cmbEffect.SelectedIndex = int.Parse(device.effectID);
            };

            if (api != null)
            {
                deviceInfo = await api.GetDeviceInfoAsync();
                deviceLightning = api.GetLightingInfo();
                if (deviceInfo != null && deviceLightning != null)
                {
                    this.Invoke(Success);
                    return;
                }
            }

            this.Invoke(Fail);
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
