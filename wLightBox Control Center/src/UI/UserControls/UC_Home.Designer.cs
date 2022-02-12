namespace wLightBox_Control_Center.src.UI.UserControls
{
    partial class UC_Home
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
            this.lblDeviceName = new System.Windows.Forms.Label();
            this.lblDeviceId = new System.Windows.Forms.Label();
            this.lblChangeColor = new System.Windows.Forms.Label();
            this.lblR = new System.Windows.Forms.Label();
            this.txtR = new System.Windows.Forms.TextBox();
            this.lblG = new System.Windows.Forms.Label();
            this.lblB = new System.Windows.Forms.Label();
            this.txtG = new System.Windows.Forms.TextBox();
            this.txtB = new System.Windows.Forms.TextBox();
            this.txtW = new System.Windows.Forms.TextBox();
            this.lblW = new System.Windows.Forms.Label();
            this.btnColorDialog = new System.Windows.Forms.Button();
            this.btnUpdateColor = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblDeviceName
            // 
            this.lblDeviceName.AutoSize = true;
            this.lblDeviceName.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont40;
            this.lblDeviceName.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.lblDeviceName.Location = new System.Drawing.Point(3, 0);
            this.lblDeviceName.Name = "lblDeviceName";
            this.lblDeviceName.Size = new System.Drawing.Size(546, 69);
            this.lblDeviceName.TabIndex = 0;
            this.lblDeviceName.Text = "Device was not found";
            // 
            // lblDeviceId
            // 
            this.lblDeviceId.AutoSize = true;
            this.lblDeviceId.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.lblDeviceId.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.lblDeviceId.Location = new System.Drawing.Point(3, 69);
            this.lblDeviceId.Name = "lblDeviceId";
            this.lblDeviceId.Size = new System.Drawing.Size(0, 29);
            this.lblDeviceId.TabIndex = 0;
            // 
            // lblChangeColor
            // 
            this.lblChangeColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblChangeColor.AutoSize = true;
            this.lblChangeColor.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont40;
            this.lblChangeColor.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.lblChangeColor.Location = new System.Drawing.Point(3, 298);
            this.lblChangeColor.Name = "lblChangeColor";
            this.lblChangeColor.Size = new System.Drawing.Size(337, 69);
            this.lblChangeColor.TabIndex = 0;
            this.lblChangeColor.Text = "Change color";
            // 
            // lblR
            // 
            this.lblR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblR.AutoSize = true;
            this.lblR.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.lblR.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.lblR.Location = new System.Drawing.Point(3, 377);
            this.lblR.Name = "lblR";
            this.lblR.Size = new System.Drawing.Size(35, 29);
            this.lblR.TabIndex = 2;
            this.lblR.Text = "R:";
            // 
            // txtR
            // 
            this.txtR.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtR.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtR.CausesValidation = false;
            this.txtR.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.txtR.Location = new System.Drawing.Point(44, 377);
            this.txtR.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtR.Name = "txtR";
            this.txtR.Size = new System.Drawing.Size(73, 28);
            this.txtR.TabIndex = 1;
            this.txtR.Text = "255";
            this.txtR.TextChanged += new System.EventHandler(this.txtR_TextChanged);
            // 
            // lblG
            // 
            this.lblG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblG.AutoSize = true;
            this.lblG.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.lblG.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.lblG.Location = new System.Drawing.Point(3, 415);
            this.lblG.Name = "lblG";
            this.lblG.Size = new System.Drawing.Size(36, 29);
            this.lblG.TabIndex = 2;
            this.lblG.Text = "G:";
            // 
            // lblB
            // 
            this.lblB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblB.AutoSize = true;
            this.lblB.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.lblB.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.lblB.Location = new System.Drawing.Point(3, 453);
            this.lblB.Name = "lblB";
            this.lblB.Size = new System.Drawing.Size(35, 29);
            this.lblB.TabIndex = 2;
            this.lblB.Text = "B:";
            // 
            // txtG
            // 
            this.txtG.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtG.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtG.CausesValidation = false;
            this.txtG.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.txtG.Location = new System.Drawing.Point(44, 415);
            this.txtG.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtG.Name = "txtG";
            this.txtG.Size = new System.Drawing.Size(73, 28);
            this.txtG.TabIndex = 1;
            this.txtG.Text = "0";
            this.txtG.TextChanged += new System.EventHandler(this.txtG_TextChanged);
            // 
            // txtB
            // 
            this.txtB.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtB.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtB.CausesValidation = false;
            this.txtB.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.txtB.Location = new System.Drawing.Point(44, 453);
            this.txtB.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtB.Name = "txtB";
            this.txtB.Size = new System.Drawing.Size(73, 28);
            this.txtB.TabIndex = 1;
            this.txtB.Text = "0";
            this.txtB.TextChanged += new System.EventHandler(this.txtB_TextChanged);
            // 
            // txtW
            // 
            this.txtW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.txtW.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtW.CausesValidation = false;
            this.txtW.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.txtW.Location = new System.Drawing.Point(44, 492);
            this.txtW.MinimumSize = new System.Drawing.Size(0, 29);
            this.txtW.Name = "txtW";
            this.txtW.Size = new System.Drawing.Size(73, 28);
            this.txtW.TabIndex = 1;
            this.txtW.Text = "127";
            this.txtW.TextChanged += new System.EventHandler(this.txtW_TextChanged);
            // 
            // lblW
            // 
            this.lblW.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.lblW.AutoSize = true;
            this.lblW.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.lblW.ForeColor = global::wLightBox_Control_Center.Properties.Settings.Default.ApplicationForeColor;
            this.lblW.Location = new System.Drawing.Point(3, 492);
            this.lblW.Name = "lblW";
            this.lblW.Size = new System.Drawing.Size(43, 29);
            this.lblW.TabIndex = 2;
            this.lblW.Text = "W:";
            // 
            // btnColorDialog
            // 
            this.btnColorDialog.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnColorDialog.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.btnColorDialog.Location = new System.Drawing.Point(157, 377);
            this.btnColorDialog.Name = "btnColorDialog";
            this.btnColorDialog.Size = new System.Drawing.Size(183, 67);
            this.btnColorDialog.TabIndex = 3;
            this.btnColorDialog.Text = "Choose Color";
            this.btnColorDialog.UseVisualStyleBackColor = true;
            this.btnColorDialog.Click += new System.EventHandler(this.btnColorDialog_Click);
            // 
            // btnUpdateColor
            // 
            this.btnUpdateColor.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.btnUpdateColor.Font = global::wLightBox_Control_Center.Properties.Settings.Default.MainPanelFont15;
            this.btnUpdateColor.Location = new System.Drawing.Point(157, 453);
            this.btnUpdateColor.Name = "btnUpdateColor";
            this.btnUpdateColor.Size = new System.Drawing.Size(183, 67);
            this.btnUpdateColor.TabIndex = 3;
            this.btnUpdateColor.Text = "Update ";
            this.btnUpdateColor.UseVisualStyleBackColor = true;
            this.btnUpdateColor.Click += new System.EventHandler(this.btnUpdateColor_Click);
            // 
            // UC_Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = global::wLightBox_Control_Center.Properties.Settings.Default.MainBackColor;
            this.Controls.Add(this.btnUpdateColor);
            this.Controls.Add(this.btnColorDialog);
            this.Controls.Add(this.lblW);
            this.Controls.Add(this.lblB);
            this.Controls.Add(this.txtW);
            this.Controls.Add(this.lblG);
            this.Controls.Add(this.txtB);
            this.Controls.Add(this.txtG);
            this.Controls.Add(this.txtR);
            this.Controls.Add(this.lblR);
            this.Controls.Add(this.lblDeviceId);
            this.Controls.Add(this.lblChangeColor);
            this.Controls.Add(this.lblDeviceName);
            this.Name = "UC_Home";
            this.Size = new System.Drawing.Size(790, 665);
            this.Load += new System.EventHandler(this.UC_Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblDeviceName;
        private System.Windows.Forms.Label lblDeviceId;
        private System.Windows.Forms.Label lblChangeColor;
        private System.Windows.Forms.Label lblR;
        private System.Windows.Forms.TextBox txtR;
        private System.Windows.Forms.Label lblG;
        private System.Windows.Forms.Label lblB;
        private System.Windows.Forms.TextBox txtG;
        private System.Windows.Forms.TextBox txtB;
        private System.Windows.Forms.TextBox txtW;
        private System.Windows.Forms.Label lblW;
        private System.Windows.Forms.Button btnColorDialog;
        private System.Windows.Forms.Button btnUpdateColor;
    }
}
