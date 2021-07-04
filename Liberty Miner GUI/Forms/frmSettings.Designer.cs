namespace LibertyMinerGUI
{
    partial class frmSettings
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
            this.workerPanel = new System.Windows.Forms.Panel();
            this.workerTxt = new System.Windows.Forms.TextBox();
            this.workerTitle = new System.Windows.Forms.Label();
            this.coinPanel = new System.Windows.Forms.Panel();
            this.coinCombo = new System.Windows.Forms.ComboBox();
            this.coinTitle = new System.Windows.Forms.Label();
            this.batteryPanel = new System.Windows.Forms.Panel();
            this.batteryTitle = new System.Windows.Forms.Label();
            this.batteryBtn = new System.Windows.Forms.Button();
            this.startupPanel = new System.Windows.Forms.Panel();
            this.startupTitle = new System.Windows.Forms.Label();
            this.startupBtn = new System.Windows.Forms.Button();
            this.walletPanel = new System.Windows.Forms.Panel();
            this.walletTxt = new System.Windows.Forms.TextBox();
            this.walletTitle = new System.Windows.Forms.Label();
            this.cpuPanel = new System.Windows.Forms.Panel();
            this.cpuCombo = new System.Windows.Forms.ComboBox();
            this.cpuTitle = new System.Windows.Forms.Label();
            this.applyButton = new MaterialSkin.Controls.MaterialRaisedButton();
            this.errorWarningLbl = new System.Windows.Forms.Label();
            this.workerPanel.SuspendLayout();
            this.coinPanel.SuspendLayout();
            this.batteryPanel.SuspendLayout();
            this.startupPanel.SuspendLayout();
            this.walletPanel.SuspendLayout();
            this.cpuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // workerPanel
            // 
            this.workerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.workerPanel.Controls.Add(this.workerTxt);
            this.workerPanel.Controls.Add(this.workerTitle);
            this.workerPanel.Location = new System.Drawing.Point(26, 200);
            this.workerPanel.Margin = new System.Windows.Forms.Padding(8);
            this.workerPanel.Name = "workerPanel";
            this.workerPanel.Size = new System.Drawing.Size(1902, 167);
            this.workerPanel.TabIndex = 34;
            // 
            // workerTxt
            // 
            this.workerTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.workerTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.workerTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.workerTxt.Location = new System.Drawing.Point(20, 72);
            this.workerTxt.Margin = new System.Windows.Forms.Padding(8);
            this.workerTxt.Multiline = true;
            this.workerTxt.Name = "workerTxt";
            this.workerTxt.Size = new System.Drawing.Size(1848, 60);
            this.workerTxt.TabIndex = 12;
            this.workerTxt.Text = " Change your worker name here...";
            // 
            // workerTitle
            // 
            this.workerTitle.AutoSize = true;
            this.workerTitle.BackColor = System.Drawing.Color.Transparent;
            this.workerTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.workerTitle.ForeColor = System.Drawing.Color.White;
            this.workerTitle.Location = new System.Drawing.Point(8, 2);
            this.workerTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.workerTitle.Name = "workerTitle";
            this.workerTitle.Size = new System.Drawing.Size(331, 65);
            this.workerTitle.TabIndex = 0;
            this.workerTitle.Text = "Worker Name:";
            // 
            // coinPanel
            // 
            this.coinPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.coinPanel.Controls.Add(this.coinCombo);
            this.coinPanel.Controls.Add(this.coinTitle);
            this.coinPanel.Location = new System.Drawing.Point(26, 382);
            this.coinPanel.Margin = new System.Windows.Forms.Padding(8);
            this.coinPanel.Name = "coinPanel";
            this.coinPanel.Size = new System.Drawing.Size(1902, 167);
            this.coinPanel.TabIndex = 35;
            // 
            // coinCombo
            // 
            this.coinCombo.AllowDrop = true;
            this.coinCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.coinCombo.DisplayMember = "1";
            this.coinCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.coinCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.coinCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.coinCombo.FormattingEnabled = true;
            this.coinCombo.Items.AddRange(new object[] {
            "XMR",
            "AUTO-ALGO Switching (the most profitable mode)",
            "ARQ",
            "CCX",
            "DERO",
            "ETH",
            "IRD",
            "LTHN",
            "MSR",
            "RVN",
            "RYO",
            "SUMO",
            "TRTL",
            "TUBE",
            "WOW",
            "XHV",
            "XLA",
            "XMC",
            "XMR",
            "XMV",
            "XWP"});
            this.coinCombo.Location = new System.Drawing.Point(20, 70);
            this.coinCombo.Margin = new System.Windows.Forms.Padding(6);
            this.coinCombo.Name = "coinCombo";
            this.coinCombo.Size = new System.Drawing.Size(1844, 62);
            this.coinCombo.TabIndex = 1;
            // 
            // coinTitle
            // 
            this.coinTitle.AutoSize = true;
            this.coinTitle.BackColor = System.Drawing.Color.Transparent;
            this.coinTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.coinTitle.ForeColor = System.Drawing.Color.White;
            this.coinTitle.Location = new System.Drawing.Point(8, 2);
            this.coinTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.coinTitle.Name = "coinTitle";
            this.coinTitle.Size = new System.Drawing.Size(135, 65);
            this.coinTitle.TabIndex = 0;
            this.coinTitle.Text = "Coin:";
            // 
            // batteryPanel
            // 
            this.batteryPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.batteryPanel.Controls.Add(this.batteryTitle);
            this.batteryPanel.Controls.Add(this.batteryBtn);
            this.batteryPanel.Location = new System.Drawing.Point(26, 746);
            this.batteryPanel.Margin = new System.Windows.Forms.Padding(8);
            this.batteryPanel.Name = "batteryPanel";
            this.batteryPanel.Size = new System.Drawing.Size(1902, 167);
            this.batteryPanel.TabIndex = 37;
            // 
            // batteryTitle
            // 
            this.batteryTitle.AutoSize = true;
            this.batteryTitle.BackColor = System.Drawing.Color.Transparent;
            this.batteryTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryTitle.ForeColor = System.Drawing.Color.White;
            this.batteryTitle.Location = new System.Drawing.Point(8, 2);
            this.batteryTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.batteryTitle.Name = "batteryTitle";
            this.batteryTitle.Size = new System.Drawing.Size(390, 65);
            this.batteryTitle.TabIndex = 0;
            this.batteryTitle.Text = "Pause on battery:";
            // 
            // batteryBtn
            // 
            this.batteryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.batteryBtn.FlatAppearance.BorderSize = 0;
            this.batteryBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.batteryBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.batteryBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.batteryBtn.Location = new System.Drawing.Point(20, 72);
            this.batteryBtn.Margin = new System.Windows.Forms.Padding(8);
            this.batteryBtn.Name = "batteryBtn";
            this.batteryBtn.Size = new System.Drawing.Size(1848, 60);
            this.batteryBtn.TabIndex = 36;
            this.batteryBtn.Text = "True";
            this.batteryBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.batteryBtn.UseVisualStyleBackColor = false;
            this.batteryBtn.Click += new System.EventHandler(this.batterybtn_Click);
            // 
            // startupPanel
            // 
            this.startupPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.startupPanel.Controls.Add(this.startupTitle);
            this.startupPanel.Controls.Add(this.startupBtn);
            this.startupPanel.Location = new System.Drawing.Point(26, 928);
            this.startupPanel.Margin = new System.Windows.Forms.Padding(8);
            this.startupPanel.Name = "startupPanel";
            this.startupPanel.Size = new System.Drawing.Size(1902, 167);
            this.startupPanel.TabIndex = 38;
            // 
            // startupTitle
            // 
            this.startupTitle.AutoSize = true;
            this.startupTitle.BackColor = System.Drawing.Color.Transparent;
            this.startupTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startupTitle.ForeColor = System.Drawing.Color.White;
            this.startupTitle.Location = new System.Drawing.Point(9, 10);
            this.startupTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.startupTitle.Name = "startupTitle";
            this.startupTitle.Size = new System.Drawing.Size(431, 65);
            this.startupTitle.TabIndex = 0;
            this.startupTitle.Text = "Run on PC StartUp:";
            // 
            // startupBtn
            // 
            this.startupBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.startupBtn.FlatAppearance.BorderSize = 0;
            this.startupBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.startupBtn.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.startupBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.startupBtn.Location = new System.Drawing.Point(20, 72);
            this.startupBtn.Margin = new System.Windows.Forms.Padding(8);
            this.startupBtn.Name = "startupBtn";
            this.startupBtn.Size = new System.Drawing.Size(1848, 60);
            this.startupBtn.TabIndex = 36;
            this.startupBtn.Text = "False";
            this.startupBtn.TextImageRelation = System.Windows.Forms.TextImageRelation.TextBeforeImage;
            this.startupBtn.UseVisualStyleBackColor = false;
            this.startupBtn.Click += new System.EventHandler(this.startupBtn_Click);
            // 
            // walletPanel
            // 
            this.walletPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.walletPanel.Controls.Add(this.walletTxt);
            this.walletPanel.Controls.Add(this.walletTitle);
            this.walletPanel.Location = new System.Drawing.Point(26, 8);
            this.walletPanel.Margin = new System.Windows.Forms.Padding(8);
            this.walletPanel.Name = "walletPanel";
            this.walletPanel.Size = new System.Drawing.Size(1902, 167);
            this.walletPanel.TabIndex = 35;
            // 
            // walletTxt
            // 
            this.walletTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.walletTxt.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.walletTxt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.walletTxt.Location = new System.Drawing.Point(20, 72);
            this.walletTxt.Margin = new System.Windows.Forms.Padding(8);
            this.walletTxt.Multiline = true;
            this.walletTxt.Name = "walletTxt";
            this.walletTxt.Size = new System.Drawing.Size(1848, 60);
            this.walletTxt.TabIndex = 12;
            this.walletTxt.Text = " Change your wallet address here...";
            // 
            // walletTitle
            // 
            this.walletTitle.AutoSize = true;
            this.walletTitle.BackColor = System.Drawing.Color.Transparent;
            this.walletTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.walletTitle.ForeColor = System.Drawing.Color.White;
            this.walletTitle.Location = new System.Drawing.Point(8, 2);
            this.walletTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.walletTitle.Name = "walletTitle";
            this.walletTitle.Size = new System.Drawing.Size(351, 65);
            this.walletTitle.TabIndex = 0;
            this.walletTitle.Text = "Wallet Address:";
            // 
            // cpuPanel
            // 
            this.cpuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.cpuPanel.Controls.Add(this.cpuCombo);
            this.cpuPanel.Controls.Add(this.cpuTitle);
            this.cpuPanel.Location = new System.Drawing.Point(26, 564);
            this.cpuPanel.Margin = new System.Windows.Forms.Padding(8);
            this.cpuPanel.Name = "cpuPanel";
            this.cpuPanel.Size = new System.Drawing.Size(1902, 167);
            this.cpuPanel.TabIndex = 36;
            // 
            // cpuCombo
            // 
            this.cpuCombo.AllowDrop = true;
            this.cpuCombo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.cpuCombo.DisplayMember = "1";
            this.cpuCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cpuCombo.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.cpuCombo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.cpuCombo.FormattingEnabled = true;
            this.cpuCombo.Items.AddRange(new object[] {
            "3333: Old CPU/GPU",
            "5555: Modern CPU/GPU",
            "7777: CPU/GPU farm",
            "9000: SSL/TLS"});
            this.cpuCombo.Location = new System.Drawing.Point(20, 70);
            this.cpuCombo.Margin = new System.Windows.Forms.Padding(6);
            this.cpuCombo.Name = "cpuCombo";
            this.cpuCombo.Size = new System.Drawing.Size(1844, 62);
            this.cpuCombo.TabIndex = 1;
            // 
            // cpuTitle
            // 
            this.cpuTitle.AutoSize = true;
            this.cpuTitle.BackColor = System.Drawing.Color.Transparent;
            this.cpuTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpuTitle.ForeColor = System.Drawing.Color.White;
            this.cpuTitle.Location = new System.Drawing.Point(8, 2);
            this.cpuTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.cpuTitle.Name = "cpuTitle";
            this.cpuTitle.Size = new System.Drawing.Size(447, 65);
            this.cpuTitle.TabIndex = 0;
            this.cpuTitle.Text = "CPU Capacity (Port):";
            // 
            // applyButton
            // 
            this.applyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.applyButton.Depth = 0;
            this.applyButton.Location = new System.Drawing.Point(1576, 1108);
            this.applyButton.Margin = new System.Windows.Forms.Padding(6);
            this.applyButton.MouseState = MaterialSkin.MouseState.HOVER;
            this.applyButton.Name = "applyButton";
            this.applyButton.Primary = true;
            this.applyButton.Size = new System.Drawing.Size(352, 74);
            this.applyButton.TabIndex = 39;
            this.applyButton.Text = "Apply";
            this.applyButton.UseVisualStyleBackColor = false;
            this.applyButton.Click += new System.EventHandler(this.applyButton_Click);
            // 
            // errorWarningLbl
            // 
            this.errorWarningLbl.AutoSize = true;
            this.errorWarningLbl.BackColor = System.Drawing.Color.Transparent;
            this.errorWarningLbl.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.errorWarningLbl.ForeColor = System.Drawing.Color.Red;
            this.errorWarningLbl.Location = new System.Drawing.Point(34, 1103);
            this.errorWarningLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.errorWarningLbl.Name = "errorWarningLbl";
            this.errorWarningLbl.Size = new System.Drawing.Size(369, 65);
            this.errorWarningLbl.TabIndex = 13;
            this.errorWarningLbl.Text = "Wallet not valid!";
            // 
            // frmSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1954, 1190);
            this.Controls.Add(this.errorWarningLbl);
            this.Controls.Add(this.applyButton);
            this.Controls.Add(this.cpuPanel);
            this.Controls.Add(this.walletPanel);
            this.Controls.Add(this.startupPanel);
            this.Controls.Add(this.batteryPanel);
            this.Controls.Add(this.coinPanel);
            this.Controls.Add(this.workerPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frmSettings";
            this.Text = "frmSettings";
            this.workerPanel.ResumeLayout(false);
            this.workerPanel.PerformLayout();
            this.coinPanel.ResumeLayout(false);
            this.coinPanel.PerformLayout();
            this.batteryPanel.ResumeLayout(false);
            this.batteryPanel.PerformLayout();
            this.startupPanel.ResumeLayout(false);
            this.startupPanel.PerformLayout();
            this.walletPanel.ResumeLayout(false);
            this.walletPanel.PerformLayout();
            this.cpuPanel.ResumeLayout(false);
            this.cpuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel workerPanel;
        private System.Windows.Forms.Label workerTitle;
        private System.Windows.Forms.Panel coinPanel;
        private System.Windows.Forms.ComboBox coinCombo;
        private System.Windows.Forms.Label coinTitle;
        private System.Windows.Forms.TextBox workerTxt;
        private System.Windows.Forms.Panel batteryPanel;
        private System.Windows.Forms.Label batteryTitle;
        private System.Windows.Forms.Button batteryBtn;
        private System.Windows.Forms.Panel startupPanel;
        private System.Windows.Forms.Label startupTitle;
        private System.Windows.Forms.Button startupBtn;
        private System.Windows.Forms.Panel walletPanel;
        private System.Windows.Forms.TextBox walletTxt;
        private System.Windows.Forms.Label walletTitle;
        private System.Windows.Forms.Panel cpuPanel;
        private System.Windows.Forms.ComboBox cpuCombo;
        private System.Windows.Forms.Label cpuTitle;
        private MaterialSkin.Controls.MaterialRaisedButton applyButton;
        private System.Windows.Forms.Label errorWarningLbl;
    }
}