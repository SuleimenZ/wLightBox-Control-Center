namespace wLightBox_Control_Center
{
    partial class Form1
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
            this.SidePanelMain = new System.Windows.Forms.Panel();
            this.SidePanelHeader = new System.Windows.Forms.Panel();
            this.SidePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // SidePanel
            // 
            this.SidePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(181)))), ((int)(((byte)(128)))));
            this.SidePanel.Controls.Add(this.SidePanelMain);
            this.SidePanel.Controls.Add(this.SidePanelHeader);
            this.SidePanel.Dock = System.Windows.Forms.DockStyle.Left;
            this.SidePanel.Location = new System.Drawing.Point(0, 0);
            this.SidePanel.Name = "SidePanel";
            this.SidePanel.Size = new System.Drawing.Size(228, 637);
            this.SidePanel.TabIndex = 0;
            // 
            // SidePanelMain
            // 
            this.SidePanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.SidePanelMain.Location = new System.Drawing.Point(0, 150);
            this.SidePanelMain.Name = "SidePanelMain";
            this.SidePanelMain.Size = new System.Drawing.Size(228, 487);
            this.SidePanelMain.TabIndex = 1;
            // 
            // SidePanelHeader
            // 
            this.SidePanelHeader.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SidePanelHeader.Dock = System.Windows.Forms.DockStyle.Top;
            this.SidePanelHeader.Location = new System.Drawing.Point(0, 0);
            this.SidePanelHeader.MinimumSize = new System.Drawing.Size(228, 150);
            this.SidePanelHeader.Name = "SidePanelHeader";
            this.SidePanelHeader.Size = new System.Drawing.Size(228, 150);
            this.SidePanelHeader.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(75)))), ((int)(((byte)(74)))), ((int)(((byte)(103)))));
            this.ClientSize = new System.Drawing.Size(1018, 637);
            this.Controls.Add(this.SidePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Control Center";
            this.SidePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel SidePanel;
        private System.Windows.Forms.Panel SidePanelHeader;
        private System.Windows.Forms.Panel SidePanelMain;
    }
}

