namespace Client
{
    partial class ClientForm
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要修改
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.exitEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTCP = new System.Windows.Forms.TabPage();
            this.rTBMSG = new System.Windows.Forms.RichTextBox();
            this.gBConnect = new System.Windows.Forms.GroupBox();
            this.BTConnect = new System.Windows.Forms.Button();
            this.lbPort = new System.Windows.Forms.Label();
            this.rBDomain = new System.Windows.Forms.RadioButton();
            this.rBip = new System.Windows.Forms.RadioButton();
            this.BTSend = new System.Windows.Forms.Button();
            this.tBmsg = new System.Windows.Forms.TextBox();
            this.tBPort = new System.Windows.Forms.TextBox();
            this.tBHost = new System.Windows.Forms.TextBox();
            this.tabPageUDP = new System.Windows.Forms.TabPage();
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageTCP.SuspendLayout();
            this.gBConnect.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(600, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStripMain";
            // 
            // exitEToolStripMenuItem
            // 
            this.exitEToolStripMenuItem.Name = "exitEToolStripMenuItem";
            this.exitEToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.exitEToolStripMenuItem.Text = "Exit（&E)";
            this.exitEToolStripMenuItem.Click += new System.EventHandler(this.exitEToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageTCP);
            this.tabControlMain.Controls.Add(this.tabPageUDP);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 25);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(600, 335);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageTCP
            // 
            this.tabPageTCP.Controls.Add(this.rTBMSG);
            this.tabPageTCP.Controls.Add(this.gBConnect);
            this.tabPageTCP.Location = new System.Drawing.Point(4, 22);
            this.tabPageTCP.Name = "tabPageTCP";
            this.tabPageTCP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTCP.Size = new System.Drawing.Size(592, 309);
            this.tabPageTCP.TabIndex = 0;
            this.tabPageTCP.Text = "TCP";
            this.tabPageTCP.UseVisualStyleBackColor = true;
            // 
            // rTBMSG
            // 
            this.rTBMSG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBMSG.Location = new System.Drawing.Point(3, 109);
            this.rTBMSG.Name = "rTBMSG";
            this.rTBMSG.Size = new System.Drawing.Size(586, 197);
            this.rTBMSG.TabIndex = 1;
            this.rTBMSG.Text = "";
            // 
            // gBConnect
            // 
            this.gBConnect.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.gBConnect.Controls.Add(this.BTConnect);
            this.gBConnect.Controls.Add(this.lbPort);
            this.gBConnect.Controls.Add(this.rBDomain);
            this.gBConnect.Controls.Add(this.rBip);
            this.gBConnect.Controls.Add(this.BTSend);
            this.gBConnect.Controls.Add(this.tBmsg);
            this.gBConnect.Controls.Add(this.tBPort);
            this.gBConnect.Controls.Add(this.tBHost);
            this.gBConnect.Dock = System.Windows.Forms.DockStyle.Top;
            this.gBConnect.Location = new System.Drawing.Point(3, 3);
            this.gBConnect.Name = "gBConnect";
            this.gBConnect.Size = new System.Drawing.Size(586, 106);
            this.gBConnect.TabIndex = 0;
            this.gBConnect.TabStop = false;
            this.gBConnect.Text = "Connect";
            // 
            // BTConnect
            // 
            this.BTConnect.Location = new System.Drawing.Point(288, 42);
            this.BTConnect.Name = "BTConnect";
            this.BTConnect.Size = new System.Drawing.Size(75, 23);
            this.BTConnect.TabIndex = 6;
            this.BTConnect.Text = "Connect";
            this.BTConnect.UseVisualStyleBackColor = true;
            this.BTConnect.Click += new System.EventHandler(this.BTConnect_Click);
            // 
            // lbPort
            // 
            this.lbPort.AutoSize = true;
            this.lbPort.Location = new System.Drawing.Point(234, 23);
            this.lbPort.Name = "lbPort";
            this.lbPort.Size = new System.Drawing.Size(29, 12);
            this.lbPort.TabIndex = 5;
            this.lbPort.Text = "Port";
            // 
            // rBDomain
            // 
            this.rBDomain.AutoSize = true;
            this.rBDomain.Location = new System.Drawing.Point(48, 21);
            this.rBDomain.Name = "rBDomain";
            this.rBDomain.Size = new System.Drawing.Size(59, 16);
            this.rBDomain.TabIndex = 4;
            this.rBDomain.TabStop = true;
            this.rBDomain.Text = "demain";
            this.rBDomain.UseVisualStyleBackColor = true;
            // 
            // rBip
            // 
            this.rBip.AutoSize = true;
            this.rBip.Checked = true;
            this.rBip.Location = new System.Drawing.Point(7, 21);
            this.rBip.Name = "rBip";
            this.rBip.Size = new System.Drawing.Size(35, 16);
            this.rBip.TabIndex = 3;
            this.rBip.TabStop = true;
            this.rBip.Text = "ip";
            this.rBip.UseVisualStyleBackColor = true;
            // 
            // BTSend
            // 
            this.BTSend.Location = new System.Drawing.Point(288, 67);
            this.BTSend.Name = "BTSend";
            this.BTSend.Size = new System.Drawing.Size(75, 23);
            this.BTSend.TabIndex = 2;
            this.BTSend.Text = "send";
            this.BTSend.UseVisualStyleBackColor = true;
            this.BTSend.Click += new System.EventHandler(this.BTSend_Click);
            // 
            // tBmsg
            // 
            this.tBmsg.Location = new System.Drawing.Point(7, 69);
            this.tBmsg.Name = "tBmsg";
            this.tBmsg.Size = new System.Drawing.Size(275, 21);
            this.tBmsg.TabIndex = 1;
            // 
            // tBPort
            // 
            this.tBPort.Location = new System.Drawing.Point(220, 42);
            this.tBPort.Name = "tBPort";
            this.tBPort.Size = new System.Drawing.Size(62, 21);
            this.tBPort.TabIndex = 0;
            this.tBPort.Text = "7777";
            // 
            // tBHost
            // 
            this.tBHost.Location = new System.Drawing.Point(7, 42);
            this.tBHost.Name = "tBHost";
            this.tBHost.Size = new System.Drawing.Size(207, 21);
            this.tBHost.TabIndex = 0;
            this.tBHost.Text = "127.0.0.1";
            // 
            // tabPageUDP
            // 
            this.tabPageUDP.Location = new System.Drawing.Point(4, 22);
            this.tabPageUDP.Name = "tabPageUDP";
            this.tabPageUDP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUDP.Size = new System.Drawing.Size(592, 309);
            this.tabPageUDP.TabIndex = 1;
            this.tabPageUDP.Text = "UDP";
            this.tabPageUDP.UseVisualStyleBackColor = true;
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 360);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ClientForm";
            this.Text = "Client";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTCP.ResumeLayout(false);
            this.gBConnect.ResumeLayout(false);
            this.gBConnect.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem exitEToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageTCP;
        private System.Windows.Forms.GroupBox gBConnect;
        private System.Windows.Forms.TextBox tBPort;
        private System.Windows.Forms.TextBox tBHost;
        private System.Windows.Forms.TabPage tabPageUDP;
        private System.Windows.Forms.RadioButton rBDomain;
        private System.Windows.Forms.RadioButton rBip;
        private System.Windows.Forms.Button BTSend;
        private System.Windows.Forms.TextBox tBmsg;
        private System.Windows.Forms.Label lbPort;
        private System.Windows.Forms.RichTextBox rTBMSG;
        private System.Windows.Forms.Button BTConnect;
    }
}

