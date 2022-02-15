namespace wLightBox_Control_Center.src.UI.UserControls
{
    partial class UC_Settings
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtDeviceName = new System.Windows.Forms.TextBox();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.chkTunnel = new System.Windows.Forms.CheckBox();
            this.chkStatusLed = new System.Windows.Forms.CheckBox();
            this.btnChange = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont25;
            this.label1.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.label1.Location = new System.Drawing.Point(3, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(352, 48);
            this.label1.TabIndex = 0;
            this.label1.Text = "Firmware update ->";
            // 
            // btnUpdate
            // 
            this.btnUpdate.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.SidePanelBackColor;
            this.btnUpdate.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnUpdate.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.btnUpdate.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.btnUpdate.Location = new System.Drawing.Point(361, 0);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(129, 48);
            this.btnUpdate.TabIndex = 1;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = false;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtDeviceName
            // 
            this.txtDeviceName.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.txtDeviceName.Location = new System.Drawing.Point(150, 177);
            this.txtDeviceName.Name = "txtDeviceName";
            this.txtDeviceName.Size = new System.Drawing.Size(340, 35);
            this.txtDeviceName.TabIndex = 2;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont25;
            this.label2.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.label2.Location = new System.Drawing.Point(3, 121);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(398, 48);
            this.label2.TabIndex = 0;
            this.label2.Text = "Change device settings";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.label3.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.label3.Location = new System.Drawing.Point(3, 180);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(141, 29);
            this.label3.TabIndex = 0;
            this.label3.Text = "Device name:";
            // 
            // chkTunnel
            // 
            this.chkTunnel.AutoSize = true;
            this.chkTunnel.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.chkTunnel.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.chkTunnel.Location = new System.Drawing.Point(11, 234);
            this.chkTunnel.Name = "chkTunnel";
            this.chkTunnel.Size = new System.Drawing.Size(92, 33);
            this.chkTunnel.TabIndex = 3;
            this.chkTunnel.Text = "Tunnel";
            this.chkTunnel.UseVisualStyleBackColor = true;
            // 
            // chkStatusLed
            // 
            this.chkStatusLed.AutoSize = true;
            this.chkStatusLed.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.chkStatusLed.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.chkStatusLed.Location = new System.Drawing.Point(150, 234);
            this.chkStatusLed.Name = "chkStatusLed";
            this.chkStatusLed.Size = new System.Drawing.Size(141, 33);
            this.chkStatusLed.TabIndex = 3;
            this.chkStatusLed.Text = "Status LED";
            this.chkStatusLed.UseVisualStyleBackColor = true;
            // 
            // btnChange
            // 
            this.btnChange.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.SidePanelBackColor;
            this.btnChange.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnChange.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.btnChange.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.btnChange.Location = new System.Drawing.Point(361, 225);
            this.btnChange.Name = "btnChange";
            this.btnChange.Size = new System.Drawing.Size(129, 48);
            this.btnChange.TabIndex = 1;
            this.btnChange.Text = "Change";
            this.btnChange.UseVisualStyleBackColor = false;
            this.btnChange.Click += new System.EventHandler(this.btnChange_Click);
            // 
            // UC_Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.MainBackColor;
            this.Controls.Add(this.chkStatusLed);
            this.Controls.Add(this.chkTunnel);
            this.Controls.Add(this.txtDeviceName);
            this.Controls.Add(this.btnChange);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "UC_Settings";
            this.Size = new System.Drawing.Size(790, 665);
            this.Load += new System.EventHandler(this.UC_Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtDeviceName;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.CheckBox chkTunnel;
        private System.Windows.Forms.CheckBox chkStatusLed;
        private System.Windows.Forms.Button btnChange;
    }
}
