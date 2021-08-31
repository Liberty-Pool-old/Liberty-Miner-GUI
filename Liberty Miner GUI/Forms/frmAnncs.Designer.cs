namespace LibertyMinerGUI
{
    partial class frmAbout
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
            this.webBrowser1 = new System.Windows.Forms.WebBrowser();
            this.errorPanel = new System.Windows.Forms.Panel();
            this.MessageTxtb = new System.Windows.Forms.TextBox();
            this.errorPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // webBrowser1
            // 
            this.webBrowser1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.webBrowser1.Location = new System.Drawing.Point(0, 0);
            this.webBrowser1.MinimumSize = new System.Drawing.Size(20, 20);
            this.webBrowser1.Name = "webBrowser1";
            this.webBrowser1.Size = new System.Drawing.Size(1954, 1149);
            this.webBrowser1.TabIndex = 0;
            // 
            // errorPanel
            // 
            this.errorPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.errorPanel.Controls.Add(this.MessageTxtb);
            this.errorPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.errorPanel.Location = new System.Drawing.Point(0, 0);
            this.errorPanel.Name = "errorPanel";
            this.errorPanel.Size = new System.Drawing.Size(1954, 1149);
            this.errorPanel.TabIndex = 1;
            // 
            // MessageTxtb
            // 
            this.MessageTxtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.MessageTxtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.MessageTxtb.Dock = System.Windows.Forms.DockStyle.Top;
            this.MessageTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MessageTxtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.MessageTxtb.Location = new System.Drawing.Point(0, 0);
            this.MessageTxtb.Margin = new System.Windows.Forms.Padding(8);
            this.MessageTxtb.Multiline = true;
            this.MessageTxtb.Name = "MessageTxtb";
            this.MessageTxtb.ReadOnly = true;
            this.MessageTxtb.Size = new System.Drawing.Size(1954, 74);
            this.MessageTxtb.TabIndex = 13;
            this.MessageTxtb.Text = "Unfortunately, we could connect to the internet :(";
            this.MessageTxtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmAbout
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1954, 1149);
            this.Controls.Add(this.errorPanel);
            this.Controls.Add(this.webBrowser1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frmAbout";
            this.Text = "frmAbout ";
            this.errorPanel.ResumeLayout(false);
            this.errorPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.WebBrowser webBrowser1;
        private System.Windows.Forms.Panel errorPanel;
        private System.Windows.Forms.TextBox MessageTxtb;
    }
}