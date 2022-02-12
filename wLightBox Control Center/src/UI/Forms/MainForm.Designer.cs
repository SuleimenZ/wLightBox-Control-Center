using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Net;
using System.Threading.Tasks;
using wLightBox_Control_Center.src;

namespace wLightBox_Control_Center
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.SidePanel = new System.Windows.Forms.Panel();
            this.PnlSideMain = new System.Windows.Forms.Panel();
            this.btnHome = new System.Windows.Forms.Button();
            this.PnlSideHeader = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblIP = new System.Windows.Forms.Label();
            this.pnlContainer = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            this.PnlSideMain.SuspendLayout();
            this.PnlSideHeader.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.Controls.Add(this.PnlSideMain);
            this.SidePanel.Controls.Add(this.PnlSideHeader);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(228, 665);
            this.SidePanel.TabIndex = 0;
            // 
            // PnlSideMain
            // 
            this.PnlSideMain.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.SidePanelBackColor;
            this.PnlSideMain.Controls.Add(this.btnHome);
            this.PnlSideMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSideMain.Location = new System.Drawing.Point(0, 150);
            this.PnlSideMain.Name = "PnlSideMain";
            this.PnlSideMain.Size = new System.Drawing.Size(228, 515);
            this.PnlSideMain.TabIndex = 1;
            // 
            // btnHome
            // 
            this.btnHome.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnHome.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.SidePanelBackColor;
            this.btnHome.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(189)))), ((int)(((byte)(149)))));
            this.btnHome.FlatAppearance.BorderSize = 2;
            this.btnHome.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(189)))), ((int)(((byte)(149)))));
            this.btnHome.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(121)))));
            this.btnHome.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnHome.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont25;
            this.btnHome.Location = new System.Drawing.Point(0, 32);
            this.btnHome.Margin = new System.Windows.Forms.Padding(15);
            this.btnHome.MinimumSize = new System.Drawing.Size(0, 69);
            this.btnHome.Name = "btnHome";
            this.btnHome.Size = new System.Drawing.Size(228, 69);
            this.btnHome.TabIndex = 0;
            this.btnHome.Text = "Home";
            this.btnHome.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnHome.UseVisualStyleBackColor = false;
            this.btnHome.Click += new System.EventHandler(this.HomeButton_Click);
            // 
            // PnlSideHeader
            // 
            this.PnlSideHeader.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.SidePanelBackColor;
            this.PnlSideHeader.Controls.Add(this.lblName);
            this.PnlSideHeader.Controls.Add(this.lblIP);
            this.PnlSideHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSideHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlSideHeader.MinimumSize = new System.Drawing.Size(228, 150);
            this.PnlSideHeader.Name = "PnlSideHeader";
            this.PnlSideHeader.Size = new System.Drawing.Size(228, 150);
            this.PnlSideHeader.TabIndex = 0;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Dock = System.Windows.Forms.DockStyle.Top;
            this.lblName.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.lblName.Location = new System.Drawing.Point(0, 0);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(176, 29);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Device not found";
            this.lblName.Click += new System.EventHandler(this.label1_Click);
            // 
            // lblIP
            // 
            this.lblIP.AutoSize = true;
            this.lblIP.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.lblIP.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.lblIP.Location = new System.Drawing.Point(0, 121);
            this.lblIP.Name = "lblIP";
            this.lblIP.Size = new System.Drawing.Size(175, 29);
            this.lblIP.TabIndex = 0;
            this.lblIP.Text = "IP: disconnected";
            this.lblIP.Click += new System.EventHandler(this.label1_Click);
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(228, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(790, 665);
            this.pnlContainer.TabIndex = 1;
            this.pnlContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.pnlContainer_Paint);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.MainBackColor;
            this.ClientSize = new System.Drawing.Size(1018, 665);
            this.Controls.Add(this.pnlContainer);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Center";
            this.SidePanel.ResumeLayout(false);
            this.PnlSideMain.ResumeLayout(false);
            this.PnlSideHeader.ResumeLayout(false);
            this.PnlSideHeader.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel PnlSideHeader;
        private System.Windows.Forms.Panel PnlSideMain;
        private System.Windows.Forms.Button btnHome;
        private System.Windows.Forms.Panel pnlContainer;
        private wLightBoxAPI api;

        public void ConnectDevice(string ip = null)
        {
            api = api == null? new wLightBoxAPI(GetLocalIP()) : api;
            var response = api.GetDeviceInfo();
            if (response == null) {
                this.lblIP.Text = "IP: disconnected";
                this.lblName.Text = "Device not found";
                return; 
            }

            dynamic device = JsonConvert.DeserializeObject(response);
            this.lblIP.Text = "IP: " + device.ip;
            this.lblName.Text = device.deviceName;
        }

        private string GetLocalIP()
        {
            var host = Dns.GetHostEntry(Dns.GetHostName());
            foreach(var ip in host.AddressList)
            {
                if(ip.AddressFamily == System.Net.Sockets.AddressFamily.InterNetwork) { return ip.ToString(); }
            }
            return null;
        }

        private System.Windows.Forms.Label lblIP;
        private System.Windows.Forms.Label lblName;
    }
}

