using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using System.Collections.Generic;
using System.Net;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;
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
            this.btnSettings = new System.Windows.Forms.Button();
            this.btnNetwork = new System.Windows.Forms.Button();
            this.btnHome = new System.Windows.Forms.Button();
            this.PnlSideHeader = new System.Windows.Forms.Panel();
            this.lblName = new System.Windows.Forms.Label();
            this.lblUptime = new System.Windows.Forms.Label();
            this.lblIp = new System.Windows.Forms.Label();
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
            this.PnlSideMain.Controls.Add(this.btnSettings);
            this.PnlSideMain.Controls.Add(this.btnNetwork);
            this.PnlSideMain.Controls.Add(this.btnHome);
            this.PnlSideMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PnlSideMain.Location = new System.Drawing.Point(0, 150);
            this.PnlSideMain.Name = "PnlSideMain";
            this.PnlSideMain.Size = new System.Drawing.Size(228, 515);
            this.PnlSideMain.TabIndex = 1;
            // 
            // btnSettings
            // 
            this.btnSettings.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSettings.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.SidePanelBackColor;
            this.btnSettings.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(189)))), ((int)(((byte)(149)))));
            this.btnSettings.FlatAppearance.BorderSize = 2;
            this.btnSettings.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(189)))), ((int)(((byte)(149)))));
            this.btnSettings.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(121)))));
            this.btnSettings.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSettings.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont25;
            this.btnSettings.Location = new System.Drawing.Point(0, 228);
            this.btnSettings.Margin = new System.Windows.Forms.Padding(15);
            this.btnSettings.MinimumSize = new System.Drawing.Size(0, 69);
            this.btnSettings.Name = "btnSettings";
            this.btnSettings.Size = new System.Drawing.Size(228, 69);
            this.btnSettings.TabIndex = 0;
            this.btnSettings.Text = "Settings";
            this.btnSettings.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSettings.UseVisualStyleBackColor = false;
            this.btnSettings.Click += new System.EventHandler(this.SettingsButton_Click);
            // 
            // btnNetwork
            // 
            this.btnNetwork.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.btnNetwork.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.SidePanelBackColor;
            this.btnNetwork.FlatAppearance.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(189)))), ((int)(((byte)(149)))));
            this.btnNetwork.FlatAppearance.BorderSize = 2;
            this.btnNetwork.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(165)))), ((int)(((byte)(189)))), ((int)(((byte)(149)))));
            this.btnNetwork.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(121)))), ((int)(((byte)(149)))), ((int)(((byte)(121)))));
            this.btnNetwork.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnNetwork.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont25;
            this.btnNetwork.Location = new System.Drawing.Point(0, 129);
            this.btnNetwork.Margin = new System.Windows.Forms.Padding(15);
            this.btnNetwork.MinimumSize = new System.Drawing.Size(0, 69);
            this.btnNetwork.Name = "btnNetwork";
            this.btnNetwork.Size = new System.Drawing.Size(228, 69);
            this.btnNetwork.TabIndex = 0;
            this.btnNetwork.Text = "Network";
            this.btnNetwork.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnNetwork.UseVisualStyleBackColor = false;
            this.btnNetwork.Click += new System.EventHandler(this.NetworkButton_Click);
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
            this.btnHome.Location = new System.Drawing.Point(0, 30);
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
            this.PnlSideHeader.BackColor = System.Drawing.Color.Red;
            this.PnlSideHeader.Controls.Add(this.lblName);
            this.PnlSideHeader.Controls.Add(this.lblUptime);
            this.PnlSideHeader.Controls.Add(this.lblIp);
            this.PnlSideHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlSideHeader.Location = new System.Drawing.Point(0, 0);
            this.PnlSideHeader.Margin = new System.Windows.Forms.Padding(15);
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
            // 
            // lblUptime
            // 
            this.lblUptime.AutoSize = true;
            this.lblUptime.BackColor = System.Drawing.Color.Red;
            this.lblUptime.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.lblUptime.Location = new System.Drawing.Point(0, 118);
            this.lblUptime.Name = "lblUptime";
            this.lblUptime.Size = new System.Drawing.Size(121, 29);
            this.lblUptime.TabIndex = 0;
            this.lblUptime.Text = "Uptime: 0s";
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.BackColor = System.Drawing.Color.Red;
            this.lblIp.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.lblIp.Location = new System.Drawing.Point(0, 89);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(175, 29);
            this.lblIp.TabIndex = 0;
            this.lblIp.Text = "IP: disconnected";
            // 
            // pnlContainer
            // 
            this.pnlContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pnlContainer.Location = new System.Drawing.Point(228, 0);
            this.pnlContainer.Name = "pnlContainer";
            this.pnlContainer.Size = new System.Drawing.Size(790, 665);
            this.pnlContainer.TabIndex = 1;
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
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblName;
        private Button btnNetwork;
        private Label lblUptime;
        private Button btnSettings;
    }
}

