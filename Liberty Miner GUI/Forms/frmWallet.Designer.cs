﻿namespace LibertyMinerGUI
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmWallet));
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
            this.XMRIG_Duration_Panel = new System.Windows.Forms.Panel();
            this.XMRIG_Duration_Lbl = new System.Windows.Forms.Label();
            this.XMRIG_Duration_Title = new System.Windows.Forms.Label();
            this.CPUpanel = new System.Windows.Forms.Panel();
            this.CPULbl = new System.Windows.Forms.Label();
            this.CPUtitle = new System.Windows.Forms.Label();
            this.Stats_Panel = new System.Windows.Forms.Panel();
            this.ConsoleButton = new System.Windows.Forms.Button();
            this.StatsButton = new System.Windows.Forms.Button();
            this.RunCloseButton = new System.Windows.Forms.Button();
            this.ConsolePanel = new System.Windows.Forms.Panel();
            this.consoleControl1 = new ConsoleControl.ConsoleControl();
            this.ConsoleTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.PaymentsPanel = new System.Windows.Forms.Panel();
            this.updateThPanel = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.batteryBtn = new System.Windows.Forms.Button();
            this.thresholdAmountTxt = new System.Windows.Forms.TextBox();
            this.payments_refresh_btn = new System.Windows.Forms.Button();
            this.payments_displayconsole = new ConsoleControl.ConsoleControl();
            this.GraphPanel = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.PaymentButton = new System.Windows.Forms.Button();
            this.HashPanel.SuspendLayout();
            this.PaidPanel.SuspendLayout();
            this.PendingPanel.SuspendLayout();
            this.RAMpanel.SuspendLayout();
            this.XMRIG_Duration_Panel.SuspendLayout();
            this.CPUpanel.SuspendLayout();
            this.Stats_Panel.SuspendLayout();
            this.ConsolePanel.SuspendLayout();
            this.PaymentsPanel.SuspendLayout();
            this.updateThPanel.SuspendLayout();
            this.GraphPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // CopyWalletButton
            // 
            this.CopyWalletButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            this.CopyWalletButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.CopyWalletButton, "CopyWalletButton");
            this.CopyWalletButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.CopyWalletButton.Name = "CopyWalletButton";
            this.CopyWalletButton.UseVisualStyleBackColor = false;
            this.CopyWalletButton.Click += new System.EventHandler(this.CopyWalletButton_Click);
            // 
            // HashPanel
            // 
            this.HashPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.HashPanel.Controls.Add(this.HashLbl);
            this.HashPanel.Controls.Add(this.hashTitle);
            resources.ApplyResources(this.HashPanel, "HashPanel");
            this.HashPanel.Name = "HashPanel";
            // 
            // HashLbl
            // 
            resources.ApplyResources(this.HashLbl, "HashLbl");
            this.HashLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.HashLbl.Name = "HashLbl";
            // 
            // hashTitle
            // 
            resources.ApplyResources(this.hashTitle, "hashTitle");
            this.hashTitle.ForeColor = System.Drawing.Color.White;
            this.hashTitle.Name = "hashTitle";
            // 
            // PaidPanel
            // 
            this.PaidPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.PaidPanel.Controls.Add(this.PaidLbl);
            this.PaidPanel.Controls.Add(this.PaidTitle);
            resources.ApplyResources(this.PaidPanel, "PaidPanel");
            this.PaidPanel.Name = "PaidPanel";
            // 
            // PaidLbl
            // 
            resources.ApplyResources(this.PaidLbl, "PaidLbl");
            this.PaidLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.PaidLbl.Name = "PaidLbl";
            // 
            // PaidTitle
            // 
            resources.ApplyResources(this.PaidTitle, "PaidTitle");
            this.PaidTitle.ForeColor = System.Drawing.Color.White;
            this.PaidTitle.Name = "PaidTitle";
            // 
            // PendingPanel
            // 
            this.PendingPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.PendingPanel.Controls.Add(this.PendingLbl);
            this.PendingPanel.Controls.Add(this.PendingTitle);
            resources.ApplyResources(this.PendingPanel, "PendingPanel");
            this.PendingPanel.Name = "PendingPanel";
            // 
            // PendingLbl
            // 
            resources.ApplyResources(this.PendingLbl, "PendingLbl");
            this.PendingLbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.PendingLbl.Name = "PendingLbl";
            // 
            // PendingTitle
            // 
            resources.ApplyResources(this.PendingTitle, "PendingTitle");
            this.PendingTitle.ForeColor = System.Drawing.Color.White;
            this.PendingTitle.Name = "PendingTitle";
            // 
            // RAMpanel
            // 
            this.RAMpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.RAMpanel.Controls.Add(this.RAMlbl);
            this.RAMpanel.Controls.Add(this.RAMtitle);
            resources.ApplyResources(this.RAMpanel, "RAMpanel");
            this.RAMpanel.Name = "RAMpanel";
            // 
            // RAMlbl
            // 
            resources.ApplyResources(this.RAMlbl, "RAMlbl");
            this.RAMlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.RAMlbl.Name = "RAMlbl";
            // 
            // RAMtitle
            // 
            resources.ApplyResources(this.RAMtitle, "RAMtitle");
            this.RAMtitle.ForeColor = System.Drawing.Color.White;
            this.RAMtitle.Name = "RAMtitle";
            // 
            // XMRIG_Duration_Panel
            // 
            this.XMRIG_Duration_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.XMRIG_Duration_Panel.Controls.Add(this.XMRIG_Duration_Lbl);
            this.XMRIG_Duration_Panel.Controls.Add(this.XMRIG_Duration_Title);
            resources.ApplyResources(this.XMRIG_Duration_Panel, "XMRIG_Duration_Panel");
            this.XMRIG_Duration_Panel.Name = "XMRIG_Duration_Panel";
            // 
            // XMRIG_Duration_Lbl
            // 
            resources.ApplyResources(this.XMRIG_Duration_Lbl, "XMRIG_Duration_Lbl");
            this.XMRIG_Duration_Lbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.XMRIG_Duration_Lbl.Name = "XMRIG_Duration_Lbl";
            // 
            // XMRIG_Duration_Title
            // 
            resources.ApplyResources(this.XMRIG_Duration_Title, "XMRIG_Duration_Title");
            this.XMRIG_Duration_Title.ForeColor = System.Drawing.Color.Cyan;
            this.XMRIG_Duration_Title.Name = "XMRIG_Duration_Title";
            // 
            // CPUpanel
            // 
            this.CPUpanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(37)))), ((int)(((byte)(42)))), ((int)(((byte)(64)))));
            this.CPUpanel.Controls.Add(this.CPULbl);
            this.CPUpanel.Controls.Add(this.CPUtitle);
            resources.ApplyResources(this.CPUpanel, "CPUpanel");
            this.CPUpanel.Name = "CPUpanel";
            // 
            // CPULbl
            // 
            resources.ApplyResources(this.CPULbl, "CPULbl");
            this.CPULbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(158)))), ((int)(((byte)(161)))), ((int)(((byte)(176)))));
            this.CPULbl.Name = "CPULbl";
            // 
            // CPUtitle
            // 
            resources.ApplyResources(this.CPUtitle, "CPUtitle");
            this.CPUtitle.ForeColor = System.Drawing.Color.OrangeRed;
            this.CPUtitle.Name = "CPUtitle";
            // 
            // Stats_Panel
            // 
            this.Stats_Panel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Stats_Panel.Controls.Add(this.CPUpanel);
            this.Stats_Panel.Controls.Add(this.XMRIG_Duration_Panel);
            this.Stats_Panel.Controls.Add(this.RAMpanel);
            this.Stats_Panel.Controls.Add(this.PendingPanel);
            this.Stats_Panel.Controls.Add(this.PaidPanel);
            this.Stats_Panel.Controls.Add(this.HashPanel);
            resources.ApplyResources(this.Stats_Panel, "Stats_Panel");
            this.Stats_Panel.Name = "Stats_Panel";
            // 
            // ConsoleButton
            // 
            this.ConsoleButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ConsoleButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.ConsoleButton, "ConsoleButton");
            this.ConsoleButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.ConsoleButton.Image = global::LibertyMinerGUI.Properties.Resources.code;
            this.ConsoleButton.Name = "ConsoleButton";
            this.ConsoleButton.UseVisualStyleBackColor = false;
            this.ConsoleButton.Click += new System.EventHandler(this.ConsoleButton_Click);
            // 
            // StatsButton
            // 
            this.StatsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.StatsButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.StatsButton, "StatsButton");
            this.StatsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.StatsButton.Image = global::LibertyMinerGUI.Properties.Resources.statistics;
            this.StatsButton.Name = "StatsButton";
            this.StatsButton.UseVisualStyleBackColor = false;
            this.StatsButton.Click += new System.EventHandler(this.StatsButton_Click);
            // 
            // RunCloseButton
            // 
            this.RunCloseButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.RunCloseButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.RunCloseButton, "RunCloseButton");
            this.RunCloseButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.RunCloseButton.Image = global::LibertyMinerGUI.Properties.Resources.play;
            this.RunCloseButton.Name = "RunCloseButton";
            this.RunCloseButton.UseVisualStyleBackColor = false;
            this.RunCloseButton.Click += new System.EventHandler(this.RunClose_Click);
            // 
            // ConsolePanel
            // 
            this.ConsolePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.ConsolePanel.Controls.Add(this.consoleControl1);
            this.ConsolePanel.Controls.Add(this.ConsoleTitle);
            resources.ApplyResources(this.ConsolePanel, "ConsolePanel");
            this.ConsolePanel.Name = "ConsolePanel";
            // 
            // consoleControl1
            // 
            this.consoleControl1.BackColor = System.Drawing.Color.Black;
            this.consoleControl1.IsInputEnabled = true;
            resources.ApplyResources(this.consoleControl1, "consoleControl1");
            this.consoleControl1.Name = "consoleControl1";
            this.consoleControl1.SendKeyboardCommandsToProcess = false;
            this.consoleControl1.ShowDiagnostics = false;
            this.consoleControl1.Enter += new System.EventHandler(this.consoleControl1_Enter);
            // 
            // ConsoleTitle
            // 
            resources.ApplyResources(this.ConsoleTitle, "ConsoleTitle");
            this.ConsoleTitle.ForeColor = System.Drawing.Color.White;
            this.ConsoleTitle.Name = "ConsoleTitle";
            // 
            // label1
            // 
            resources.ApplyResources(this.label1, "label1");
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Name = "label1";
            // 
            // PaymentsPanel
            // 
            this.PaymentsPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PaymentsPanel.Controls.Add(this.updateThPanel);
            this.PaymentsPanel.Controls.Add(this.thresholdAmountTxt);
            this.PaymentsPanel.Controls.Add(this.payments_refresh_btn);
            this.PaymentsPanel.Controls.Add(this.payments_displayconsole);
            this.PaymentsPanel.Controls.Add(this.label1);
            resources.ApplyResources(this.PaymentsPanel, "PaymentsPanel");
            this.PaymentsPanel.Name = "PaymentsPanel";
            // 
            // updateThPanel
            // 
            this.updateThPanel.Controls.Add(this.button2);
            this.updateThPanel.Controls.Add(this.batteryBtn);
            resources.ApplyResources(this.updateThPanel, "updateThPanel");
            this.updateThPanel.Name = "updateThPanel";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            resources.ApplyResources(this.button2, "button2");
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.button2.Image = global::LibertyMinerGUI.Properties.Resources.upload1;
            this.button2.Name = "button2";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // batteryBtn
            // 
            this.batteryBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(74)))), ((int)(((byte)(79)))), ((int)(((byte)(99)))));
            resources.ApplyResources(this.batteryBtn, "batteryBtn");
            this.batteryBtn.FlatAppearance.BorderSize = 0;
            this.batteryBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.batteryBtn.Name = "batteryBtn";
            this.batteryBtn.UseVisualStyleBackColor = false;
            this.batteryBtn.Click += new System.EventHandler(this.batteryBtn_Click);
            // 
            // thresholdAmountTxt
            // 
            this.thresholdAmountTxt.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            resources.ApplyResources(this.thresholdAmountTxt, "thresholdAmountTxt");
            this.thresholdAmountTxt.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.thresholdAmountTxt.Name = "thresholdAmountTxt";
            // 
            // payments_refresh_btn
            // 
            this.payments_refresh_btn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.payments_refresh_btn.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.payments_refresh_btn, "payments_refresh_btn");
            this.payments_refresh_btn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.payments_refresh_btn.Image = global::LibertyMinerGUI.Properties.Resources.refresh;
            this.payments_refresh_btn.Name = "payments_refresh_btn";
            this.payments_refresh_btn.UseVisualStyleBackColor = false;
            this.payments_refresh_btn.Click += new System.EventHandler(this.payments_refresh_btn_Click);
            // 
            // payments_displayconsole
            // 
            this.payments_displayconsole.BackColor = System.Drawing.Color.Black;
            this.payments_displayconsole.IsInputEnabled = true;
            resources.ApplyResources(this.payments_displayconsole, "payments_displayconsole");
            this.payments_displayconsole.Name = "payments_displayconsole";
            this.payments_displayconsole.SendKeyboardCommandsToProcess = false;
            this.payments_displayconsole.ShowDiagnostics = false;
            // 
            // GraphPanel
            // 
            this.GraphPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.GraphPanel.Controls.Add(this.label2);
            resources.ApplyResources(this.GraphPanel, "GraphPanel");
            this.GraphPanel.Name = "GraphPanel";
            // 
            // label2
            // 
            resources.ApplyResources(this.label2, "label2");
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Name = "label2";
            // 
            // PaymentButton
            // 
            this.PaymentButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.PaymentButton.FlatAppearance.BorderSize = 0;
            resources.ApplyResources(this.PaymentButton, "PaymentButton");
            this.PaymentButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(200)))), ((int)(((byte)(200)))), ((int)(((byte)(200)))));
            this.PaymentButton.Image = global::LibertyMinerGUI.Properties.Resources.us_dollar;
            this.PaymentButton.Name = "PaymentButton";
            this.PaymentButton.UseVisualStyleBackColor = false;
            this.PaymentButton.Click += new System.EventHandler(this.PaymentButton_Click);
            // 
            // frmWallet
            // 
            resources.ApplyResources(this, "$this");
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(46)))), ((int)(((byte)(51)))), ((int)(((byte)(73)))));
            this.Controls.Add(this.PaymentButton);
            this.Controls.Add(this.PaymentsPanel);
            this.Controls.Add(this.ConsolePanel);
            this.Controls.Add(this.Stats_Panel);
            this.Controls.Add(this.GraphPanel);
            this.Controls.Add(this.ConsoleButton);
            this.Controls.Add(this.StatsButton);
            this.Controls.Add(this.CopyWalletButton);
            this.Controls.Add(this.RunCloseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "frmWallet";
            this.HashPanel.ResumeLayout(false);
            this.HashPanel.PerformLayout();
            this.PaidPanel.ResumeLayout(false);
            this.PaidPanel.PerformLayout();
            this.PendingPanel.ResumeLayout(false);
            this.PendingPanel.PerformLayout();
            this.RAMpanel.ResumeLayout(false);
            this.RAMpanel.PerformLayout();
            this.XMRIG_Duration_Panel.ResumeLayout(false);
            this.XMRIG_Duration_Panel.PerformLayout();
            this.CPUpanel.ResumeLayout(false);
            this.CPUpanel.PerformLayout();
            this.Stats_Panel.ResumeLayout(false);
            this.ConsolePanel.ResumeLayout(false);
            this.ConsolePanel.PerformLayout();
            this.PaymentsPanel.ResumeLayout(false);
            this.PaymentsPanel.PerformLayout();
            this.updateThPanel.ResumeLayout(false);
            this.GraphPanel.ResumeLayout(false);
            this.GraphPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button RunCloseButton;
        private System.Windows.Forms.Button CopyWalletButton;
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
        private System.Windows.Forms.Panel XMRIG_Duration_Panel;
        private System.Windows.Forms.Label XMRIG_Duration_Lbl;
        private System.Windows.Forms.Label XMRIG_Duration_Title;
        private System.Windows.Forms.Panel CPUpanel;
        private System.Windows.Forms.Label CPULbl;
        private System.Windows.Forms.Label CPUtitle;
        public System.Windows.Forms.Panel Stats_Panel;
        private System.Windows.Forms.Button ConsoleButton;
        private System.Windows.Forms.Panel ConsolePanel;
        private System.Windows.Forms.Label ConsoleTitle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel PaymentsPanel;
        private System.Windows.Forms.Panel GraphPanel;
        private System.Windows.Forms.Label label2;
        private ConsoleControl.ConsoleControl consoleControl1;
        private ConsoleControl.ConsoleControl payments_displayconsole;
        private System.Windows.Forms.Button payments_refresh_btn;
        private System.Windows.Forms.Button PaymentButton;
        private System.Windows.Forms.TextBox thresholdAmountTxt;
        private System.Windows.Forms.Button batteryBtn;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Panel updateThPanel;
    }
}