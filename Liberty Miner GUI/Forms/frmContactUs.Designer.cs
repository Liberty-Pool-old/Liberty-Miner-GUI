namespace LibertyMinerGUI
{
    partial class frmContactUs
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
            this.Contact_Us_Panel = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.OpenDiscordButton = new System.Windows.Forms.Button();
            this.emailLink = new System.Windows.Forms.LinkLabel();
            this.label3 = new System.Windows.Forms.Label();
            this.Contact_Us_Panel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Contact_Us_Panel
            // 
            this.Contact_Us_Panel.Controls.Add(this.label1);
            this.Contact_Us_Panel.Controls.Add(this.OpenDiscordButton);
            this.Contact_Us_Panel.Controls.Add(this.emailLink);
            this.Contact_Us_Panel.Controls.Add(this.label3);
            this.Contact_Us_Panel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Contact_Us_Panel.Location = new System.Drawing.Point(0, 0);
            this.Contact_Us_Panel.Name = "Contact_Us_Panel";
            this.Contact_Us_Panel.Size = new System.Drawing.Size(1954, 1149);
            this.Contact_Us_Panel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(12, 1108);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(69, 32);
            this.label1.TabIndex = 39;
            this.label1.Text = "v1.2";
            // 
            // OpenDiscordButton
            // 
            this.OpenDiscordButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.OpenDiscordButton.FlatAppearance.BorderSize = 0;
            this.OpenDiscordButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.OpenDiscordButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.OpenDiscordButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.OpenDiscordButton.Image = global::LibertyMinerGUI.Properties.Resources.discord;
            this.OpenDiscordButton.Location = new System.Drawing.Point(733, 88);
            this.OpenDiscordButton.Margin = new System.Windows.Forms.Padding(8);
            this.OpenDiscordButton.Name = "OpenDiscordButton";
            this.OpenDiscordButton.Size = new System.Drawing.Size(100, 108);
            this.OpenDiscordButton.TabIndex = 38;
            this.OpenDiscordButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.OpenDiscordButton.UseVisualStyleBackColor = false;
            this.OpenDiscordButton.Click += new System.EventHandler(this.OpenDiscordButton_Click);
            // 
            // emailLink
            // 
            this.emailLink.AutoSize = true;
            this.emailLink.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLink.LinkColor = System.Drawing.Color.LightSeaGreen;
            this.emailLink.Location = new System.Drawing.Point(1377, 39);
            this.emailLink.Name = "emailLink";
            this.emailLink.Size = new System.Drawing.Size(529, 46);
            this.emailLink.TabIndex = 1;
            this.emailLink.TabStop = true;
            this.emailLink.Text = "liberty-pool@libercrypto.com";
            this.emailLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.emailLink_LinkClicked);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Nirmala UI", 15F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(6, 22);
            this.label3.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1398, 134);
            this.label3.TabIndex = 0;
            this.label3.Text = "If you have any issues or complaints, please refer to the email: \r\nor chat with u" +
    "s through Discord:\r\n";
            // 
            // frmContactUs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1954, 1149);
            this.Controls.Add(this.Contact_Us_Panel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frmContactUs";
            this.Text = "frmContactUs";
            this.Contact_Us_Panel.ResumeLayout(false);
            this.Contact_Us_Panel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel Contact_Us_Panel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.LinkLabel emailLink;
        private System.Windows.Forms.Button OpenDiscordButton;
        private System.Windows.Forms.Label label1;
    }
}