namespace LibertyMinerGUI
{
    partial class frmWallet 
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
            this.CopyWalletButton = new System.Windows.Forms.Button();
            this.HashPanel = new System.Windows.Forms.Panel();
            this.HashLbl = new System.Windows.Forms.Label();
            this.hashTitle = new System.Windows.Forms.Label();
            this.PaidPanel = new System.Windows.Forms.Panel();
            this.PaidLbl = new System.Windows.Forms.Label();
            this.PaidTitle = new System.Windows.Forms.Label();
            this.PendingPanel = new System.Windows.Forms.Panel();
            this.PendingLbl = new System.Windows.Forms.Label();
            this.PendingTitle = new System.Windows.Forms.Label();
            this.RAMpanel = new System.Windows.Forms.Panel();
            this.RAMlbl = new System.Windows.Forms.Label();
            this.RAMtitle = new System.Windows.Forms.Label();
            this.FanPanel = new System.Windows.Forms.Panel();
            this.FanLbl = new System.Windows.Forms.Label();
            this.FanTitle = new System.Windows.Forms.Label();
            this.CPUpanel = new System.Windows.Forms.Panel();
            this.CPULbl = new System.Windows.Forms.Label();
            this.CPUtitle = new System.Windows.Forms.Label();
            this.Stats_Panel = new System.Windows.Forms.Panel();
            this.ConsoleButton = new System.Windows.Forms.Button();
            this.GraphButton = new System.Windows.Forms.Button();
            this.StatsButton = new System.Windows.Forms.Button();
            this.PaymentsButton = new System.Windows.Forms.Button();
            this.RunCloseButton = new System.Windows.Forms.Button();
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.XmrigOutput = new System.Windows.Forms.RichTextBox();
            this.ConsoleTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentsPanel = new System.Windows.Forms.Panel();
            this.GraphPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.HashPanel.SuspendLayout();
            this.PaidPanel.SuspendLayout();
            this.PendingPanel.SuspendLayout();
            this.RAMpanel.SuspendLayout();
            this.FanPanel.SuspendLayout();
            this.CPUpanel.SuspendLayout();
            this.Stats_Panel.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.PaymentsPanel.SuspendLayout();
            this.GraphPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CopyWalletButton
            // 
            this.CopyWalletButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.CopyWalletButton.FlatAppearance.BorderSize = 0;
            this.CopyWalletButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.CopyWalletButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CopyWalletButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CopyWalletButton.Location = new System.Drawing.Point(26, 25);
            this.CopyWalletButton.Margin = new System.Windows.Forms.Padding(8);
            this.CopyWalletButton.Name = "CopyWalletButton";
            this.CopyWalletButton.Size = new System.Drawing.Size(1918, 64);
            this.CopyWalletButton.TabIndex = 38;
            this.CopyWalletButton.Text = "Copy:86buK1FuQAWXKvALgU9xk6FcdRKgoAGtEj5fzzBgGJm98mAG1svZDEDEFbfbFqe9EfJeYijF765S" +
    "gKDCQTny3TsLNG4K5zk";
            this.CopyWalletButton.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.CopyWalletButton.UseVisualStyleBackColor = false;
            this.CopyWalletButton.Click += new System.EventHandler(this.CopyWalletButton_Click);
            // 
            // HashPanel
            // 
            this.HashPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.HashPanel.Controls.Add(this.HashLbl);
            this.HashPanel.Controls.Add(this.hashTitle);
            this.HashPanel.Location = new System.Drawing.Point(0, 39);
            this.HashPanel.Margin = new System.Windows.Forms.Padding(8);
            this.HashPanel.Name = "HashPanel";
            this.HashPanel.Size = new System.Drawing.Size(920, 170);
            this.HashPanel.TabIndex = 39;
            // 
            // HashLbl
            // 
            this.HashLbl.AutoSize = true;
            this.HashLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HashLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.HashLbl.Location = new System.Drawing.Point(38, 95);
            this.HashLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.HashLbl.Name = "HashLbl";
            this.HashLbl.Size = new System.Drawing.Size(791, 45);
            this.HashLbl.TabIndex = 0;
            this.HashLbl.Text = "Some extra text here to make the tab more  attractive";
            this.HashLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // hashTitle
            // 
            this.hashTitle.AutoSize = true;
            this.hashTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hashTitle.ForeColor = System.Drawing.Color.White;
            this.hashTitle.Location = new System.Drawing.Point(34, 27);
            this.hashTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.hashTitle.Name = "hashTitle";
            this.hashTitle.Size = new System.Drawing.Size(225, 65);
            this.hashTitle.TabIndex = 0;
            this.hashTitle.Text = "Hashrate:";
            // 
            // PaidPanel
            // 
            this.PaidPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.PaidPanel.Controls.Add(this.PaidLbl);
            this.PaidPanel.Controls.Add(this.PaidTitle);
            this.PaidPanel.Location = new System.Drawing.Point(982, 39);
            this.PaidPanel.Margin = new System.Windows.Forms.Padding(8);
            this.PaidPanel.Name = "PaidPanel";
            this.PaidPanel.Size = new System.Drawing.Size(920, 170);
            this.PaidPanel.TabIndex = 40;
            // 
            // PaidLbl
            // 
            this.PaidLbl.AutoSize = true;
            this.PaidLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.PaidLbl.Location = new System.Drawing.Point(38, 95);
            this.PaidLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.PaidLbl.Name = "PaidLbl";
            this.PaidLbl.Size = new System.Drawing.Size(791, 45);
            this.PaidLbl.TabIndex = 0;
            this.PaidLbl.Text = "Some extra text here to make the tab more  attractive";
            this.PaidLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PaidTitle
            // 
            this.PaidTitle.AutoSize = true;
            this.PaidTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaidTitle.ForeColor = System.Drawing.Color.White;
            this.PaidTitle.Location = new System.Drawing.Point(34, 27);
            this.PaidTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.PaidTitle.Name = "PaidTitle";
            this.PaidTitle.Size = new System.Drawing.Size(240, 65);
            this.PaidTitle.TabIndex = 0;
            this.PaidTitle.Text = "XMR Paid:";
            // 
            // PendingPanel
            // 
            this.PendingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.PendingPanel.Controls.Add(this.PendingLbl);
            this.PendingPanel.Controls.Add(this.PendingTitle);
            this.PendingPanel.Location = new System.Drawing.Point(0, 225);
            this.PendingPanel.Margin = new System.Windows.Forms.Padding(8);
            this.PendingPanel.Name = "PendingPanel";
            this.PendingPanel.Size = new System.Drawing.Size(920, 170);
            this.PendingPanel.TabIndex = 41;
            // 
            // PendingLbl
            // 
            this.PendingLbl.AutoSize = true;
            this.PendingLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.PendingLbl.Location = new System.Drawing.Point(38, 95);
            this.PendingLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.PendingLbl.Name = "PendingLbl";
            this.PendingLbl.Size = new System.Drawing.Size(791, 45);
            this.PendingLbl.TabIndex = 0;
            this.PendingLbl.Text = "Some extra text here to make the tab more  attractive";
            this.PendingLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // PendingTitle
            // 
            this.PendingTitle.AutoSize = true;
            this.PendingTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PendingTitle.ForeColor = System.Drawing.Color.White;
            this.PendingTitle.Location = new System.Drawing.Point(34, 27);
            this.PendingTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.PendingTitle.Name = "PendingTitle";
            this.PendingTitle.Size = new System.Drawing.Size(323, 65);
            this.PendingTitle.TabIndex = 0;
            this.PendingTitle.Text = "XMR Pending:";
            // 
            // RAMpanel
            // 
            this.RAMpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.RAMpanel.Controls.Add(this.RAMlbl);
            this.RAMpanel.Controls.Add(this.RAMtitle);
            this.RAMpanel.Location = new System.Drawing.Point(982, 225);
            this.RAMpanel.Margin = new System.Windows.Forms.Padding(8);
            this.RAMpanel.Name = "RAMpanel";
            this.RAMpanel.Size = new System.Drawing.Size(920, 170);
            this.RAMpanel.TabIndex = 42;
            // 
            // RAMlbl
            // 
            this.RAMlbl.AutoSize = true;
            this.RAMlbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAMlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.RAMlbl.Location = new System.Drawing.Point(38, 95);
            this.RAMlbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.RAMlbl.Name = "RAMlbl";
            this.RAMlbl.Size = new System.Drawing.Size(47, 45);
            this.RAMlbl.TabIndex = 0;
            this.RAMlbl.Text = "%";
            this.RAMlbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // RAMtitle
            // 
            this.RAMtitle.AutoSize = true;
            this.RAMtitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RAMtitle.ForeColor = System.Drawing.Color.White;
            this.RAMtitle.Location = new System.Drawing.Point(34, 27);
            this.RAMtitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.RAMtitle.Name = "RAMtitle";
            this.RAMtitle.Size = new System.Drawing.Size(284, 65);
            this.RAMtitle.TabIndex = 0;
            this.RAMtitle.Text = "RAM Usage:";
            // 
            // FanPanel
            // 
            this.FanPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.FanPanel.Controls.Add(this.FanLbl);
            this.FanPanel.Controls.Add(this.FanTitle);
            this.FanPanel.Location = new System.Drawing.Point(0, 411);
            this.FanPanel.Margin = new System.Windows.Forms.Padding(8);
            this.FanPanel.Name = "FanPanel";
            this.FanPanel.Size = new System.Drawing.Size(920, 170);
            this.FanPanel.TabIndex = 43;
            // 
            // FanLbl
            // 
            this.FanLbl.AutoSize = true;
            this.FanLbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FanLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.FanLbl.Location = new System.Drawing.Point(38, 95);
            this.FanLbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.FanLbl.Name = "FanLbl";
            this.FanLbl.Size = new System.Drawing.Size(791, 45);
            this.FanLbl.TabIndex = 0;
            this.FanLbl.Text = "Some extra text here to make the tab more  attractive";
            this.FanLbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // FanTitle
            // 
            this.FanTitle.AutoSize = true;
            this.FanTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FanTitle.ForeColor = System.Drawing.Color.Cyan;
            this.FanTitle.Location = new System.Drawing.Point(34, 27);
            this.FanTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.FanTitle.Name = "FanTitle";
            this.FanTitle.Size = new System.Drawing.Size(245, 65);
            this.FanTitle.TabIndex = 0;
            this.FanTitle.Text = "Fan Speed";
            // 
            // CPUpanel
            // 
            this.CPUpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.CPUpanel.Controls.Add(this.CPULbl);
            this.CPUpanel.Controls.Add(this.CPUtitle);
            this.CPUpanel.Location = new System.Drawing.Point(982, 411);
            this.CPUpanel.Margin = new System.Windows.Forms.Padding(8);
            this.CPUpanel.Name = "CPUpanel";
            this.CPUpanel.Size = new System.Drawing.Size(920, 170);
            this.CPUpanel.TabIndex = 44;
            // 
            // CPULbl
            // 
            this.CPULbl.AutoSize = true;
            this.CPULbl.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPULbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.CPULbl.Location = new System.Drawing.Point(38, 95);
            this.CPULbl.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.CPULbl.Name = "CPULbl";
            this.CPULbl.Size = new System.Drawing.Size(791, 45);
            this.CPULbl.TabIndex = 0;
            this.CPULbl.Text = "Some extra text here to make the tab more  attractive";
            this.CPULbl.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // CPUtitle
            // 
            this.CPUtitle.AutoSize = true;
            this.CPUtitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CPUtitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.CPUtitle.Location = new System.Drawing.Point(34, 27);
            this.CPUtitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.CPUtitle.Name = "CPUtitle";
            this.CPUtitle.Size = new System.Drawing.Size(255, 65);
            this.CPUtitle.TabIndex = 0;
            this.CPUtitle.Text = "CPU Temp:";
            // 
            // Stats_Panel
            // 
            this.Stats_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Stats_Panel.Controls.Add(this.CPUpanel);
            this.Stats_Panel.Controls.Add(this.FanPanel);
            this.Stats_Panel.Controls.Add(this.RAMpanel);
            this.Stats_Panel.Controls.Add(this.PendingPanel);
            this.Stats_Panel.Controls.Add(this.PaidPanel);
            this.Stats_Panel.Controls.Add(this.HashPanel);
            this.Stats_Panel.Location = new System.Drawing.Point(26, 492);
            this.Stats_Panel.Margin = new System.Windows.Forms.Padding(8);
            this.Stats_Panel.Name = "Stats_Panel";
            this.Stats_Panel.Size = new System.Drawing.Size(1902, 620);
            this.Stats_Panel.TabIndex = 41;
            // 
            // ConsoleButton
            // 
            this.ConsoleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ConsoleButton.FlatAppearance.BorderSize = 0;
            this.ConsoleButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.ConsoleButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ConsoleButton.Image = global::LibertyMinerGUI.Properties.Resources.code;
            this.ConsoleButton.Location = new System.Drawing.Point(838, 185);
            this.ConsoleButton.Margin = new System.Windows.Forms.Padding(8);
            this.ConsoleButton.Name = "ConsoleButton";
            this.ConsoleButton.Size = new System.Drawing.Size(332, 291);
            this.ConsoleButton.TabIndex = 43;
            this.ConsoleButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.ConsoleButton.UseVisualStyleBackColor = false;
            this.ConsoleButton.Click += new System.EventHandler(this.ConsoleButton_Click);
            // 
            // GraphButton
            // 
            this.GraphButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.GraphButton.FlatAppearance.BorderSize = 0;
            this.GraphButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.GraphButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.GraphButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.GraphButton.Image = global::LibertyMinerGUI.Properties.Resources.graph_report;
            this.GraphButton.Location = new System.Drawing.Point(1210, 186);
            this.GraphButton.Margin = new System.Windows.Forms.Padding(8);
            this.GraphButton.Name = "GraphButton";
            this.GraphButton.Size = new System.Drawing.Size(332, 291);
            this.GraphButton.TabIndex = 42;
            this.GraphButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.GraphButton.UseVisualStyleBackColor = false;
            this.GraphButton.Click += new System.EventHandler(this.GraphButton_Click);
            // 
            // StatsButton
            // 
            this.StatsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.StatsButton.FlatAppearance.BorderSize = 0;
            this.StatsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.StatsButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.StatsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.StatsButton.Image = global::LibertyMinerGUI.Properties.Resources.statistics;
            this.StatsButton.Location = new System.Drawing.Point(420, 186);
            this.StatsButton.Margin = new System.Windows.Forms.Padding(8);
            this.StatsButton.Name = "StatsButton";
            this.StatsButton.Size = new System.Drawing.Size(332, 291);
            this.StatsButton.TabIndex = 40;
            this.StatsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.StatsButton.UseVisualStyleBackColor = false;
            this.StatsButton.Click += new System.EventHandler(this.StatsButton_Click);
            // 
            // PaymentsButton
            // 
            this.PaymentsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PaymentsButton.FlatAppearance.BorderSize = 0;
            this.PaymentsButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.PaymentsButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PaymentsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.PaymentsButton.Image = global::LibertyMinerGUI.Properties.Resources.us_dollar;
            this.PaymentsButton.Location = new System.Drawing.Point(1558, 186);
            this.PaymentsButton.Margin = new System.Windows.Forms.Padding(8);
            this.PaymentsButton.Name = "PaymentsButton";
            this.PaymentsButton.Size = new System.Drawing.Size(332, 291);
            this.PaymentsButton.TabIndex = 39;
            this.PaymentsButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.PaymentsButton.UseVisualStyleBackColor = false;
            this.PaymentsButton.Click += new System.EventHandler(this.PaymentsButton_Click);
            // 
            // RunCloseButton
            // 
            this.RunCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.RunCloseButton.FlatAppearance.BorderSize = 0;
            this.RunCloseButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.RunCloseButton.Font = new System.Drawing.Font("Nirmala UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RunCloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.RunCloseButton.Image = global::LibertyMinerGUI.Properties.Resources.play;
            this.RunCloseButton.Location = new System.Drawing.Point(72, 186);
            this.RunCloseButton.Margin = new System.Windows.Forms.Padding(8);
            this.RunCloseButton.Name = "RunCloseButton";
            this.RunCloseButton.Size = new System.Drawing.Size(332, 291);
            this.RunCloseButton.TabIndex = 37;
            this.RunCloseButton.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.RunCloseButton.UseVisualStyleBackColor = false;
            this.RunCloseButton.Click += new System.EventHandler(this.RunClose_Click);
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ConsolePanel.Controls.Add(this.XmrigOutput);
            this.ConsolePanel.Controls.Add(this.ConsoleTitle);
            this.ConsolePanel.Location = new System.Drawing.Point(26, 492);
            this.ConsolePanel.Margin = new System.Windows.Forms.Padding(8);
            this.ConsolePanel.Name = "ConsolePanel";
            this.ConsolePanel.Size = new System.Drawing.Size(1902, 620);
            this.ConsolePanel.TabIndex = 46;
            // 
            // XmrigOutput
            // 
            this.XmrigOutput.BackColor = System.Drawing.Color.Black;
            this.XmrigOutput.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.XmrigOutput.ForeColor = System.Drawing.Color.Lime;
            this.XmrigOutput.Location = new System.Drawing.Point(21, 93);
            this.XmrigOutput.Name = "XmrigOutput";
            this.XmrigOutput.ReadOnly = true;
            this.XmrigOutput.Size = new System.Drawing.Size(1878, 515);
            this.XmrigOutput.TabIndex = 14;
            this.XmrigOutput.Text = "";
            // 
            // ConsoleTitle
            // 
            this.ConsoleTitle.AutoSize = true;
            this.ConsoleTitle.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ConsoleTitle.ForeColor = System.Drawing.Color.White;
            this.ConsoleTitle.Location = new System.Drawing.Point(39, 25);
            this.ConsoleTitle.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.ConsoleTitle.Name = "ConsoleTitle";
            this.ConsoleTitle.Size = new System.Drawing.Size(208, 65);
            this.ConsoleTitle.TabIndex = 1;
            this.ConsoleTitle.Text = "Console:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(39, 25);
            this.label1.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(239, 65);
            this.label1.TabIndex = 1;
            this.label1.Text = "Payments:";
            // 
            // PaymentsPanel
            // 
            this.PaymentsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PaymentsPanel.Controls.Add(this.label1);
            this.PaymentsPanel.Location = new System.Drawing.Point(26, 492);
            this.PaymentsPanel.Margin = new System.Windows.Forms.Padding(8);
            this.PaymentsPanel.Name = "PaymentsPanel";
            this.PaymentsPanel.Size = new System.Drawing.Size(1902, 620);
            this.PaymentsPanel.TabIndex = 45;
            // 
            // GraphPanel
            // 
            this.GraphPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.GraphPanel.Controls.Add(this.label2);
            this.GraphPanel.Location = new System.Drawing.Point(26, 492);
            this.GraphPanel.Margin = new System.Windows.Forms.Padding(8);
            this.GraphPanel.Name = "GraphPanel";
            this.GraphPanel.Size = new System.Drawing.Size(1902, 620);
            this.GraphPanel.TabIndex = 46;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Nirmala UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(10, 25);
            this.label2.Margin = new System.Windows.Forms.Padding(8, 0, 8, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(167, 65);
            this.label2.TabIndex = 1;
            this.label2.Text = "Graph:";
            // 
            // frmWallet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(16F, 31F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ClientSize = new System.Drawing.Size(1954, 1137);
            this.Controls.Add(this.GraphPanel);
            this.Controls.Add(this.ConsolePanel);
            this.Controls.Add(this.Stats_Panel);
            this.Controls.Add(this.PaymentsPanel);
            this.Controls.Add(this.ConsoleButton);
            this.Controls.Add(this.GraphButton);
            this.Controls.Add(this.StatsButton);
            this.Controls.Add(this.PaymentsButton);
            this.Controls.Add(this.CopyWalletButton);
            this.Controls.Add(this.RunCloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(8);
            this.Name = "frmWallet";
            this.Text = "frmWallet";
            this.HashPanel.ResumeLayout(false);
            this.HashPanel.PerformLayout();
            this.PaidPanel.ResumeLayout(false);
            this.PaidPanel.PerformLayout();
            this.PendingPanel.ResumeLayout(false);
            this.PendingPanel.PerformLayout();
            this.RAMpanel.ResumeLayout(false);
            this.RAMpanel.PerformLayout();
            this.FanPanel.ResumeLayout(false);
            this.FanPanel.PerformLayout();
            this.CPUpanel.ResumeLayout(false);
            this.CPUpanel.PerformLayout();
            this.Stats_Panel.ResumeLayout(false);
            this.ConsolePanel.ResumeLayout(false);
            this.ConsolePanel.PerformLayout();
            this.PaymentsPanel.ResumeLayout(false);
            this.PaymentsPanel.PerformLayout();
            this.GraphPanel.ResumeLayout(false);
            this.GraphPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RunCloseButton;
        private System.Windows.Forms.Button CopyWalletButton;
        private System.Windows.Forms.Button PaymentsButton;
        private System.Windows.Forms.Button StatsButton;
        private System.Windows.Forms.Panel HashPanel;
        private System.Windows.Forms.Label HashLbl;
        private System.Windows.Forms.Label hashTitle;
        private System.Windows.Forms.Panel PaidPanel;
        private System.Windows.Forms.Label PaidLbl;
        private System.Windows.Forms.Label PaidTitle;
        private System.Windows.Forms.Panel PendingPanel;
        private System.Windows.Forms.Label PendingLbl;
        private System.Windows.Forms.Label PendingTitle;
        private System.Windows.Forms.Panel RAMpanel;
        private System.Windows.Forms.Label RAMlbl;
        private System.Windows.Forms.Label RAMtitle;
        private System.Windows.Forms.Panel FanPanel;
        private System.Windows.Forms.Label FanLbl;
        private System.Windows.Forms.Label FanTitle;
        private System.Windows.Forms.Panel CPUpanel;
        private System.Windows.Forms.Label CPULbl;
        private System.Windows.Forms.Label CPUtitle;
        public System.Windows.Forms.Panel Stats_Panel;
        private System.Windows.Forms.Button GraphButton;
        private System.Windows.Forms.Button ConsoleButton;
        private System.Windows.Forms.Panel ConsolePanel;
        private System.Windows.Forms.Label ConsoleTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PaymentsPanel;
        private System.Windows.Forms.Panel GraphPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.RichTextBox XmrigOutput;
    }
}