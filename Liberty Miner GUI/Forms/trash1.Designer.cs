namespace LibertyMinerGUI
{
    partial class Contact_Us_Panel
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
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.PhoneTxtb = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 131);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(526, 29);
            this.progressBar1.TabIndex = 0;
            // 
            // PhoneTxtb
            // 
            this.PhoneTxtb.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.PhoneTxtb.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.PhoneTxtb.Dock = System.Windows.Forms.DockStyle.Top;
            this.PhoneTxtb.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PhoneTxtb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.PhoneTxtb.Location = new System.Drawing.Point(0, 0);
            this.PhoneTxtb.Margin = new System.Windows.Forms.Padding(4);
            this.PhoneTxtb.Multiline = true;
            this.PhoneTxtb.Name = "PhoneTxtb";
            this.PhoneTxtb.Size = new System.Drawing.Size(526, 36);
            this.PhoneTxtb.TabIndex = 13;
            this.PhoneTxtb.Text = "Updating...";
            this.PhoneTxtb.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Contact_Us_Panel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(526, 160);
            this.Controls.Add(this.PhoneTxtb);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "Contact_Us_Panel";
            this.Text = "trash";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox PhoneTxtb;
    }
}