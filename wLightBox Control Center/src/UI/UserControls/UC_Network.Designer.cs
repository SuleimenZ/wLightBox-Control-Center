namespace wLightBox_Control_Center.src.UI.UserControls
{
    partial class UC_Network
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIp1 = new System.Windows.Forms.TextBox();
            this.lblIp = new System.Windows.Forms.Label();
            this.lblDot1 = new System.Windows.Forms.Label();
            this.txtIp2 = new System.Windows.Forms.TextBox();
            this.lblDot2 = new System.Windows.Forms.Label();
            this.txtIp3 = new System.Windows.Forms.TextBox();
            this.lblDot3 = new System.Windows.Forms.Label();
            this.txtIp4 = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbWifiList = new System.Windows.Forms.ComboBox();
            this.lblWifiList = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtPassword = new System.Windows.Forms.TextBox();
            this.btnWifiScan = new System.Windows.Forms.Button();
            this.btnWifiConnect = new System.Windows.Forms.Button();
            this.txtAPPassword = new System.Windows.Forms.TextBox();
            this.lblAPSsid = new System.Windows.Forms.Label();
            this.lblAPPassword = new System.Windows.Forms.Label();
            this.lblAP = new System.Windows.Forms.Label();
            this.btnAPUpdate = new System.Windows.Forms.Button();
            this.txtAPSsid = new System.Windows.Forms.TextBox();
            this.btnWifiDisconnect = new System.Windows.Forms.Button();
            this.chkAPEnabled = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // txtIp1
            // 
            this.txtIp1.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont25;
            this.txtIp1.Location = new System.Drawing.Point(101, 36);
            this.txtIp1.Margin = new System.Windows.Forms.Padding(0);
            this.txtIp1.Name = "txtIp1";
            this.txtIp1.Size = new System.Drawing.Size(100, 54);
            this.txtIp1.TabIndex = 0;
            this.txtIp1.TextChanged += new System.EventHandler(this.txtIp1_TextChanged);
            // 
            // lblIp
            // 
            this.lblIp.AutoSize = true;
            this.lblIp.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont25;
            this.lblIp.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.lblIp.Location = new System.Drawing.Point(11, 39);
            this.lblIp.Name = "lblIp";
            this.lblIp.Size = new System.Drawing.Size(87, 48);
            this.lblIp.TabIndex = 1;
            this.lblIp.Text = "IP: ";
            // 
            // lblDot1
            // 
            this.lblDot1.AutoSize = true;
            this.lblDot1.BackColor = System.Drawing.Color.Transparent;
            this.lblDot1.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont25;
            this.lblDot1.Location = new System.Drawing.Point(201, 42);
            this.lblDot1.Margin = new System.Windows.Forms.Padding(0);
            this.lblDot1.Name = "lblDot1";
            this.lblDot1.Size = new System.Drawing.Size(35, 48);
            this.lblDot1.TabIndex = 1;
            this.lblDot1.Text = ".";
            // 
            // txtIp2
            // 
            this.txtIp2.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont25;
            this.txtIp2.Location = new System.Drawing.Point(236, 36);
            this.txtIp2.Margin = new System.Windows.Forms.Padding(0);
            this.txtIp2.Name = "txtIp2";
            this.txtIp2.Size = new System.Drawing.Size(100, 54);
            this.txtIp2.TabIndex = 0;
            this.txtIp2.TextChanged += new System.EventHandler(this.txtIp2_TextChanged);
            // 
            // lblDot2
            // 
            this.lblDot2.AutoSize = true;
            this.lblDot2.BackColor = System.Drawing.Color.Transparent;
            this.lblDot2.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont25;
            this.lblDot2.Location = new System.Drawing.Point(336, 42);
            this.lblDot2.Margin = new System.Windows.Forms.Padding(0);
            this.lblDot2.Name = "lblDot2";
            this.lblDot2.Size = new System.Drawing.Size(35, 48);
            this.lblDot2.TabIndex = 1;
            this.lblDot2.Text = ".";
            // 
            // txtIp3
            // 
            this.txtIp3.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont25;
            this.txtIp3.Location = new System.Drawing.Point(371, 36);
            this.txtIp3.Margin = new System.Windows.Forms.Padding(0);
            this.txtIp3.Name = "txtIp3";
            this.txtIp3.Size = new System.Drawing.Size(100, 54);
            this.txtIp3.TabIndex = 0;
            this.txtIp3.TextChanged += new System.EventHandler(this.txtIp3_TextChanged);
            // 
            // lblDot3
            // 
            this.lblDot3.AutoSize = true;
            this.lblDot3.BackColor = System.Drawing.Color.Transparent;
            this.lblDot3.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont25;
            this.lblDot3.Location = new System.Drawing.Point(471, 42);
            this.lblDot3.Margin = new System.Windows.Forms.Padding(0);
            this.lblDot3.Name = "lblDot3";
            this.lblDot3.Size = new System.Drawing.Size(35, 48);
            this.lblDot3.TabIndex = 1;
            this.lblDot3.Text = ".";
            // 
            // txtIp4
            // 
            this.txtIp4.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont25;
            this.txtIp4.Location = new System.Drawing.Point(506, 36);
            this.txtIp4.Margin = new System.Windows.Forms.Padding(0);
            this.txtIp4.Name = "txtIp4";
            this.txtIp4.Size = new System.Drawing.Size(100, 54);
            this.txtIp4.TabIndex = 0;
            this.txtIp4.TextChanged += new System.EventHandler(this.txtIp4_TextChanged);
            // 
            // btnConnect
            // 
            this.btnConnect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnConnect.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.SidePanelBackColor;
            this.btnConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnConnect.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.btnConnect.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.btnConnect.Location = new System.Drawing.Point(644, 36);
            this.btnConnect.Margin = new System.Windows.Forms.Padding(3, 3, 12, 3);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(128, 54);
            this.btnConnect.TabIndex = 2;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = false;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont25;
            this.label1.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.label1.Location = new System.Drawing.Point(11, 170);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(238, 48);
            this.label1.TabIndex = 1;
            this.label1.Text = "Wifi settings";
            // 
            // cmbWifiList
            // 
            this.cmbWifiList.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cmbWifiList.Font = new System.Drawing.Font("Comic Sans MS", 11.5F, System.Drawing.FontStyle.Bold);
            this.cmbWifiList.FormattingEnabled = true;
            this.cmbWifiList.Location = new System.Drawing.Point(101, 237);
            this.cmbWifiList.Name = "cmbWifiList";
            this.cmbWifiList.Size = new System.Drawing.Size(100, 29);
            this.cmbWifiList.TabIndex = 3;
            // 
            // lblWifiList
            // 
            this.lblWifiList.AutoSize = true;
            this.lblWifiList.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.lblWifiList.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.lblWifiList.Location = new System.Drawing.Point(14, 237);
            this.lblWifiList.Name = "lblWifiList";
            this.lblWifiList.Size = new System.Drawing.Size(75, 29);
            this.lblWifiList.TabIndex = 1;
            this.lblWifiList.Text = "SSID:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.label2.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.label2.Location = new System.Drawing.Point(366, 237);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(111, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // txtPassword
            // 
            this.txtPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtPassword.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.txtPassword.Location = new System.Drawing.Point(506, 239);
            this.txtPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtPassword.Name = "txtPassword";
            this.txtPassword.PasswordChar = '*';
            this.txtPassword.Size = new System.Drawing.Size(100, 28);
            this.txtPassword.TabIndex = 0;
            this.txtPassword.TextChanged += new System.EventHandler(this.txtIp1_TextChanged);
            // 
            // btnWifiScan
            // 
            this.btnWifiScan.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.SidePanelBackColor;
            this.btnWifiScan.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWifiScan.Font = new System.Drawing.Font("Comic Sans MS", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnWifiScan.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.btnWifiScan.Location = new System.Drawing.Point(236, 237);
            this.btnWifiScan.Name = "btnWifiScan";
            this.btnWifiScan.Size = new System.Drawing.Size(100, 30);
            this.btnWifiScan.TabIndex = 4;
            this.btnWifiScan.Text = "Scan";
            this.btnWifiScan.UseVisualStyleBackColor = false;
            this.btnWifiScan.Click += new System.EventHandler(this.btnWifiScan_Click);
            // 
            // btnWifiConnect
            // 
            this.btnWifiConnect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnWifiConnect.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.SidePanelBackColor;
            this.btnWifiConnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWifiConnect.Font = new System.Drawing.Font("Comic Sans MS", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnWifiConnect.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.btnWifiConnect.Location = new System.Drawing.Point(644, 237);
            this.btnWifiConnect.Name = "btnWifiConnect";
            this.btnWifiConnect.Size = new System.Drawing.Size(128, 30);
            this.btnWifiConnect.TabIndex = 4;
            this.btnWifiConnect.Text = "Connect";
            this.btnWifiConnect.UseVisualStyleBackColor = false;
            this.btnWifiConnect.Click += new System.EventHandler(this.btnWifiConnect_Click);
            // 
            // txtAPPassword
            // 
            this.txtAPPassword.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAPPassword.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.txtAPPassword.Location = new System.Drawing.Point(371, 401);
            this.txtAPPassword.Margin = new System.Windows.Forms.Padding(0);
            this.txtAPPassword.Name = "txtAPPassword";
            this.txtAPPassword.PasswordChar = '*';
            this.txtAPPassword.Size = new System.Drawing.Size(100, 28);
            this.txtAPPassword.TabIndex = 0;
            this.txtAPPassword.TextChanged += new System.EventHandler(this.txtIp1_TextChanged);
            // 
            // lblAPSsid
            // 
            this.lblAPSsid.AutoSize = true;
            this.lblAPSsid.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.lblAPSsid.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.lblAPSsid.Location = new System.Drawing.Point(14, 399);
            this.lblAPSsid.Name = "lblAPSsid";
            this.lblAPSsid.Size = new System.Drawing.Size(75, 29);
            this.lblAPSsid.TabIndex = 1;
            this.lblAPSsid.Text = "SSID:";
            // 
            // lblAPPassword
            // 
            this.lblAPPassword.AutoSize = true;
            this.lblAPPassword.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.lblAPPassword.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.lblAPPassword.Location = new System.Drawing.Point(231, 399);
            this.lblAPPassword.Name = "lblAPPassword";
            this.lblAPPassword.Size = new System.Drawing.Size(111, 29);
            this.lblAPPassword.TabIndex = 1;
            this.lblAPPassword.Text = "Password:";
            // 
            // lblAP
            // 
            this.lblAP.AutoSize = true;
            this.lblAP.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont25;
            this.lblAP.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.lblAP.Location = new System.Drawing.Point(11, 332);
            this.lblAP.Name = "lblAP";
            this.lblAP.Size = new System.Drawing.Size(373, 48);
            this.lblAP.TabIndex = 1;
            this.lblAP.Text = "Access point settings";
            // 
            // btnAPUpdate
            // 
            this.btnAPUpdate.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.SidePanelBackColor;
            this.btnAPUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnAPUpdate.Font = new System.Drawing.Font("Comic Sans MS", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnAPUpdate.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.btnAPUpdate.Location = new System.Drawing.Point(644, 398);
            this.btnAPUpdate.Name = "btnAPUpdate";
            this.btnAPUpdate.Size = new System.Drawing.Size(128, 30);
            this.btnAPUpdate.TabIndex = 4;
            this.btnAPUpdate.Text = "Update AP";
            this.btnAPUpdate.UseVisualStyleBackColor = false;
            this.btnAPUpdate.Click += new System.EventHandler(this.btnAPUpdate_Click);
            // 
            // txtAPSsid
            // 
            this.txtAPSsid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtAPSsid.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.txtAPSsid.Location = new System.Drawing.Point(101, 401);
            this.txtAPSsid.Margin = new System.Windows.Forms.Padding(0);
            this.txtAPSsid.Name = "txtAPSsid";
            this.txtAPSsid.PasswordChar = '*';
            this.txtAPSsid.Size = new System.Drawing.Size(100, 28);
            this.txtAPSsid.TabIndex = 0;
            this.txtAPSsid.TextChanged += new System.EventHandler(this.txtIp1_TextChanged);
            // 
            // btnWifiDisconnect
            // 
            this.btnWifiDisconnect.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.btnWifiDisconnect.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.SidePanelBackColor;
            this.btnWifiDisconnect.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnWifiDisconnect.Font = new System.Drawing.Font("Comic Sans MS", 11.5F, System.Drawing.FontStyle.Bold);
            this.btnWifiDisconnect.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.btnWifiDisconnect.Location = new System.Drawing.Point(644, 295);
            this.btnWifiDisconnect.Name = "btnWifiDisconnect";
            this.btnWifiDisconnect.Size = new System.Drawing.Size(128, 30);
            this.btnWifiDisconnect.TabIndex = 4;
            this.btnWifiDisconnect.Text = "Disconnect";
            this.btnWifiDisconnect.UseVisualStyleBackColor = false;
            this.btnWifiDisconnect.Click += new System.EventHandler(this.btnWifiDisconnect_Click);
            // 
            // chkAPEnabled
            // 
            this.chkAPEnabled.AutoSize = true;
            this.chkAPEnabled.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.chkAPEnabled.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.chkAPEnabled.Location = new System.Drawing.Point(506, 398);
            this.chkAPEnabled.Name = "chkAPEnabled";
            this.chkAPEnabled.Size = new System.Drawing.Size(105, 33);
            this.chkAPEnabled.TabIndex = 5;
            this.chkAPEnabled.Text = "Enabled";
            this.chkAPEnabled.UseVisualStyleBackColor = true;
            // 
            // UC_Network
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.MainBackColor;
            this.Controls.Add(this.chkAPEnabled);
            this.Controls.Add(this.btnAPUpdate);
            this.Controls.Add(this.btnWifiDisconnect);
            this.Controls.Add(this.btnWifiConnect);
            this.Controls.Add(this.btnWifiScan);
            this.Controls.Add(this.cmbWifiList);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.lblDot3);
            this.Controls.Add(this.lblDot2);
            this.Controls.Add(this.lblDot1);
            this.Controls.Add(this.lblAP);
            this.Controls.Add(this.lblAPPassword);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblAPSsid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.lblWifiList);
            this.Controls.Add(this.lblIp);
            this.Controls.Add(this.txtIp4);
            this.Controls.Add(this.txtIp3);
            this.Controls.Add(this.txtAPSsid);
            this.Controls.Add(this.txtAPPassword);
            this.Controls.Add(this.txtIp2);
            this.Controls.Add(this.txtPassword);
            this.Controls.Add(this.txtIp1);
            this.Name = "UC_Network";
            this.Size = new System.Drawing.Size(790, 665);
            this.Load += new System.EventHandler(this.UC_Network_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtIp1;
        private System.Windows.Forms.Label lblIp;
        private System.Windows.Forms.Label lblDot1;
        private System.Windows.Forms.TextBox txtIp2;
        private System.Windows.Forms.Label lblDot2;
        private System.Windows.Forms.TextBox txtIp3;
        private System.Windows.Forms.Label lblDot3;
        private System.Windows.Forms.TextBox txtIp4;
        private System.Windows.Forms.Button btnConnect;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cmbWifiList;
        private System.Windows.Forms.Label lblWifiList;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtPassword;
        private System.Windows.Forms.Button btnWifiScan;
        private System.Windows.Forms.Button btnWifiConnect;
        private System.Windows.Forms.TextBox txtAPPassword;
        private System.Windows.Forms.Label lblAPSsid;
        private System.Windows.Forms.Label lblAPPassword;
        private System.Windows.Forms.Label lblAP;
        private System.Windows.Forms.Button btnAPUpdate;
        private System.Windows.Forms.TextBox txtAPSsid;
        private System.Windows.Forms.Button btnWifiDisconnect;
        private System.Windows.Forms.CheckBox chkAPEnabled;
    }
}
