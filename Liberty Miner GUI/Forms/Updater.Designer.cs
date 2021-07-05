namespace LibertyMinerGUI
{
    partial class Updater
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Updater));
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.StatusTxt = new System.Windows.Forms.TextBox();
            this.YesBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.NoBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.RetryBtn = new MaterialSkin.Controls.MaterialRaisedButton();
            this.SuspendLayout();
            // 
            // progressBar1
            // 
            this.progressBar1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.progressBar1.Location = new System.Drawing.Point(0, 254);
            this.progressBar1.Margin = new System.Windows.Forms.Padding(6);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(1052, 56);
            this.progressBar1.TabIndex = 0;
            // 
            // StatusTxt
            // 
            this.StatusTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.StatusTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.StatusTxt.Dock = System.Windows.Forms.DockStyle.Top;
            this.StatusTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatusTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.StatusTxt.Location = new System.Drawing.Point(0, 0);
            this.StatusTxt.Margin = new System.Windows.Forms.Padding(8);
            this.StatusTxt.Multiline = true;
            this.StatusTxt.Name = "StatusTxt";
            this.StatusTxt.Size = new System.Drawing.Size(1052, 70);
            this.StatusTxt.TabIndex = 13;
            this.StatusTxt.Text = "Checking that everything is fine...";
            this.StatusTxt.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.StatusTxt.Enter += new System.EventHandler(this.StatusTxt_Enter);
            // 
            // YesBtn
            // 
            this.YesBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.YesBtn.Depth = 0;
            this.YesBtn.Dock = System.Windows.Forms.DockStyle.Left;
            this.YesBtn.Location = new System.Drawing.Point(0, 70);
            this.YesBtn.Margin = new System.Windows.Forms.Padding(6);
            this.YesBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.YesBtn.Name = "YesBtn";
            this.YesBtn.Primary = true;
            this.YesBtn.Size = new System.Drawing.Size(352, 184);
            this.YesBtn.TabIndex = 40;
            this.YesBtn.Text = "Yes";
            this.YesBtn.UseVisualStyleBackColor = false;
            this.YesBtn.Visible = false;
            this.YesBtn.Click += new System.EventHandler(this.YesBtn_Click);
            // 
            // NoBtn
            // 
            this.NoBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.NoBtn.Depth = 0;
            this.NoBtn.Dock = System.Windows.Forms.DockStyle.Right;
            this.NoBtn.Location = new System.Drawing.Point(700, 70);
            this.NoBtn.Margin = new System.Windows.Forms.Padding(6);
            this.NoBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.NoBtn.Name = "NoBtn";
            this.NoBtn.Primary = true;
            this.NoBtn.Size = new System.Drawing.Size(352, 184);
            this.NoBtn.TabIndex = 41;
            this.NoBtn.Text = "No";
            this.NoBtn.UseVisualStyleBackColor = false;
            this.NoBtn.Visible = false;
            this.NoBtn.Click += new System.EventHandler(this.NoBtn_Click);
            // 
            // RetryBtn
            // 
            this.RetryBtn.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)));
            this.RetryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.RetryBtn.Depth = 0;
            this.RetryBtn.Location = new System.Drawing.Point(390, 70);
            this.RetryBtn.Margin = new System.Windows.Forms.Padding(6);
            this.RetryBtn.MouseState = MaterialSkin.MouseState.HOVER;
            this.RetryBtn.Name = "RetryBtn";
            this.RetryBtn.Primary = true;
            this.RetryBtn.Size = new System.Drawing.Size(269, 184);
            this.RetryBtn.TabIndex = 42;
            this.RetryBtn.Text = "Retry";
            this.RetryBtn.UseVisualStyleBackColor = false;
            this.RetryBtn.Visible = false;
            this.RetryBtn.Click += new System.EventHandler(this.RetryBtn_Click);
            // 
            // Updater
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1052, 310);
            this.Controls.Add(this.RetryBtn);
            this.Controls.Add(this.NoBtn);
            this.Controls.Add(this.YesBtn);
            this.Controls.Add(this.StatusTxt);
            this.Controls.Add(this.progressBar1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "Updater";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LP Updater";
            this.Load += new System.EventHandler(this.Updater_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.TextBox StatusTxt;
        private MaterialSkin.Controls.MaterialRaisedButton YesBtn;
        private MaterialSkin.Controls.MaterialRaisedButton NoBtn;
        private MaterialSkin.Controls.MaterialRaisedButton RetryBtn;
    }
}