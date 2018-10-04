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
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.rBUDPip = new System.Windows.Forms.RadioButton();
            this.tbUDPPort = new System.Windows.Forms.MaskedTextBox();
            this.tbUDPHost = new System.Windows.Forms.MaskedTextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.gbFileTrans = new System.Windows.Forms.GroupBox();
            this.btnStopSend = new System.Windows.Forms.Button();
            this.btnSend = new System.Windows.Forms.Button();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lblSentLen = new System.Windows.Forms.Label();
            this.lblSentLen2 = new System.Windows.Forms.Label();
            this.lblFileSize = new System.Windows.Forms.Label();
            this.lblFileSize2 = new System.Windows.Forms.Label();
            this.lblFileName = new System.Windows.Forms.Label();
            this.lblFileName2 = new System.Windows.Forms.Label();
            this.gbMsg = new System.Windows.Forms.GroupBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.textBoxMSG = new System.Windows.Forms.TextBox();
            this.btnStart = new System.Windows.Forms.Button();
            this.tBPortToBind = new System.Windows.Forms.TextBox();
            this.tbMsgHistory = new System.Windows.Forms.RichTextBox();
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageTCP.SuspendLayout();
            this.gBConnect.SuspendLayout();
            this.tabPageUDP.SuspendLayout();
            this.gbServer.SuspendLayout();
            this.gbFileTrans.SuspendLayout();
            this.gbMsg.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.exitEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(389, 25);
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
            this.tabControlMain.Size = new System.Drawing.Size(389, 447);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageTCP
            // 
            this.tabPageTCP.Controls.Add(this.rTBMSG);
            this.tabPageTCP.Controls.Add(this.gBConnect);
            this.tabPageTCP.Location = new System.Drawing.Point(4, 22);
            this.tabPageTCP.Name = "tabPageTCP";
            this.tabPageTCP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageTCP.Size = new System.Drawing.Size(381, 421);
            this.tabPageTCP.TabIndex = 0;
            this.tabPageTCP.Text = "TCP";
            this.tabPageTCP.UseVisualStyleBackColor = true;
            // 
            // rTBMSG
            // 
            this.rTBMSG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rTBMSG.Location = new System.Drawing.Point(3, 109);
            this.rTBMSG.Name = "rTBMSG";
            this.rTBMSG.Size = new System.Drawing.Size(375, 309);
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
            this.gBConnect.Size = new System.Drawing.Size(375, 106);
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
            this.tabPageUDP.Controls.Add(this.gbMsg);
            this.tabPageUDP.Controls.Add(this.gbFileTrans);
            this.tabPageUDP.Controls.Add(this.gbServer);
            this.tabPageUDP.Location = new System.Drawing.Point(4, 22);
            this.tabPageUDP.Name = "tabPageUDP";
            this.tabPageUDP.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageUDP.Size = new System.Drawing.Size(381, 421);
            this.tabPageUDP.TabIndex = 1;
            this.tabPageUDP.Text = "UDP";
            this.tabPageUDP.UseVisualStyleBackColor = true;
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.tBPortToBind);
            this.gbServer.Controls.Add(this.btnStart);
            this.gbServer.Controls.Add(this.radioButton1);
            this.gbServer.Controls.Add(this.rBUDPip);
            this.gbServer.Controls.Add(this.tbUDPPort);
            this.gbServer.Controls.Add(this.tbUDPHost);
            this.gbServer.Controls.Add(this.lblPort);
            this.gbServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbServer.Location = new System.Drawing.Point(3, 3);
            this.gbServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbServer.Name = "gbServer";
            this.gbServer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbServer.Size = new System.Drawing.Size(375, 81);
            this.gbServer.TabIndex = 9;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "Aim IPEndPoint";
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(61, 21);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.Size = new System.Drawing.Size(59, 16);
            this.radioButton1.TabIndex = 7;
            this.radioButton1.Text = "domain";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // rBUDPip
            // 
            this.rBUDPip.AutoSize = true;
            this.rBUDPip.Checked = true;
            this.rBUDPip.Location = new System.Drawing.Point(17, 21);
            this.rBUDPip.Name = "rBUDPip";
            this.rBUDPip.Size = new System.Drawing.Size(35, 16);
            this.rBUDPip.TabIndex = 7;
            this.rBUDPip.TabStop = true;
            this.rBUDPip.Text = "ip";
            this.rBUDPip.UseVisualStyleBackColor = true;
            // 
            // tbUDPPort
            // 
            this.tbUDPPort.Location = new System.Drawing.Point(139, 45);
            this.tbUDPPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbUDPPort.Mask = "99999";
            this.tbUDPPort.Name = "tbUDPPort";
            this.tbUDPPort.PromptChar = ' ';
            this.tbUDPPort.Size = new System.Drawing.Size(71, 21);
            this.tbUDPPort.TabIndex = 6;
            this.tbUDPPort.Text = "7777";
            // 
            // tbUDPHost
            // 
            this.tbUDPHost.Location = new System.Drawing.Point(17, 45);
            this.tbUDPHost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbUDPHost.Name = "tbUDPHost";
            this.tbUDPHost.Size = new System.Drawing.Size(103, 21);
            this.tbUDPHost.TabIndex = 3;
            this.tbUDPHost.Text = "127.0.0.1";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(154, 23);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 12);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port";
            // 
            // gbFileTrans
            // 
            this.gbFileTrans.Controls.Add(this.btnStopSend);
            this.gbFileTrans.Controls.Add(this.btnSend);
            this.gbFileTrans.Controls.Add(this.progressBar1);
            this.gbFileTrans.Controls.Add(this.lblSentLen);
            this.gbFileTrans.Controls.Add(this.lblSentLen2);
            this.gbFileTrans.Controls.Add(this.lblFileSize);
            this.gbFileTrans.Controls.Add(this.lblFileSize2);
            this.gbFileTrans.Controls.Add(this.lblFileName);
            this.gbFileTrans.Controls.Add(this.lblFileName2);
            this.gbFileTrans.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbFileTrans.Location = new System.Drawing.Point(3, 325);
            this.gbFileTrans.Name = "gbFileTrans";
            this.gbFileTrans.Size = new System.Drawing.Size(375, 93);
            this.gbFileTrans.TabIndex = 11;
            this.gbFileTrans.TabStop = false;
            this.gbFileTrans.Text = "FileTransmit";
            // 
            // btnStopSend
            // 
            this.btnStopSend.Location = new System.Drawing.Point(266, 57);
            this.btnStopSend.Name = "btnStopSend";
            this.btnStopSend.Size = new System.Drawing.Size(92, 21);
            this.btnStopSend.TabIndex = 8;
            this.btnStopSend.Text = "StopTransmit";
            this.btnStopSend.UseVisualStyleBackColor = true;
            // 
            // btnSend
            // 
            this.btnSend.Location = new System.Drawing.Point(154, 57);
            this.btnSend.Name = "btnSend";
            this.btnSend.Size = new System.Drawing.Size(99, 21);
            this.btnSend.TabIndex = 7;
            this.btnSend.Text = "SelectAndSend";
            this.btnSend.UseVisualStyleBackColor = true;
            // 
            // progressBar1
            // 
            this.progressBar1.Location = new System.Drawing.Point(27, 84);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(331, 14);
            this.progressBar1.TabIndex = 6;
            // 
            // lblSentLen
            // 
            this.lblSentLen.AutoSize = true;
            this.lblSentLen.Location = new System.Drawing.Point(87, 40);
            this.lblSentLen.Name = "lblSentLen";
            this.lblSentLen.Size = new System.Drawing.Size(0, 12);
            this.lblSentLen.TabIndex = 5;
            // 
            // lblSentLen2
            // 
            this.lblSentLen2.AutoSize = true;
            this.lblSentLen2.Location = new System.Drawing.Point(26, 61);
            this.lblSentLen2.Name = "lblSentLen2";
            this.lblSentLen2.Size = new System.Drawing.Size(89, 12);
            this.lblSentLen2.TabIndex = 4;
            this.lblSentLen2.Text = "Transmintted：";
            // 
            // lblFileSize
            // 
            this.lblFileSize.AutoSize = true;
            this.lblFileSize.Location = new System.Drawing.Point(280, 18);
            this.lblFileSize.Name = "lblFileSize";
            this.lblFileSize.Size = new System.Drawing.Size(0, 12);
            this.lblFileSize.TabIndex = 3;
            // 
            // lblFileSize2
            // 
            this.lblFileSize2.AutoSize = true;
            this.lblFileSize2.Location = new System.Drawing.Point(237, 30);
            this.lblFileSize2.Name = "lblFileSize2";
            this.lblFileSize2.Size = new System.Drawing.Size(65, 12);
            this.lblFileSize2.TabIndex = 2;
            this.lblFileSize2.Text = "FileSize：";
            // 
            // lblFileName
            // 
            this.lblFileName.AutoSize = true;
            this.lblFileName.Location = new System.Drawing.Point(87, 18);
            this.lblFileName.Name = "lblFileName";
            this.lblFileName.Size = new System.Drawing.Size(0, 12);
            this.lblFileName.TabIndex = 1;
            // 
            // lblFileName2
            // 
            this.lblFileName2.AutoSize = true;
            this.lblFileName2.Location = new System.Drawing.Point(26, 30);
            this.lblFileName2.Name = "lblFileName2";
            this.lblFileName2.Size = new System.Drawing.Size(65, 12);
            this.lblFileName2.TabIndex = 0;
            this.lblFileName2.Text = "FileName：";
            // 
            // gbMsg
            // 
            this.gbMsg.Controls.Add(this.tbMsgHistory);
            this.gbMsg.Controls.Add(this.btnSendMsg);
            this.gbMsg.Controls.Add(this.textBoxMSG);
            this.gbMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMsg.Location = new System.Drawing.Point(3, 84);
            this.gbMsg.Name = "gbMsg";
            this.gbMsg.Size = new System.Drawing.Size(375, 241);
            this.gbMsg.TabIndex = 13;
            this.gbMsg.TabStop = false;
            this.gbMsg.Text = "Message";
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(283, 214);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(75, 21);
            this.btnSendMsg.TabIndex = 1;
            this.btnSendMsg.Text = "Send";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // textBoxMSG
            // 
            this.textBoxMSG.Location = new System.Drawing.Point(7, 214);
            this.textBoxMSG.Multiline = true;
            this.textBoxMSG.Name = "textBoxMSG";
            this.textBoxMSG.Size = new System.Drawing.Size(269, 19);
            this.textBoxMSG.TabIndex = 0;
            // 
            // btnStart
            // 
            this.btnStart.Location = new System.Drawing.Point(283, 14);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(75, 23);
            this.btnStart.TabIndex = 8;
            this.btnStart.Text = "Start";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // tBPortToBind
            // 
            this.tBPortToBind.Location = new System.Drawing.Point(283, 45);
            this.tBPortToBind.Name = "tBPortToBind";
            this.tBPortToBind.Size = new System.Drawing.Size(75, 21);
            this.tBPortToBind.TabIndex = 9;
            this.tBPortToBind.Text = "6666";
            // 
            // tbMsgHistory
            // 
            this.tbMsgHistory.Location = new System.Drawing.Point(6, 20);
            this.tbMsgHistory.Name = "tbMsgHistory";
            this.tbMsgHistory.Size = new System.Drawing.Size(352, 188);
            this.tbMsgHistory.TabIndex = 2;
            this.tbMsgHistory.Text = "";
            // 
            // ClientForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(389, 472);
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
            this.tabPageUDP.ResumeLayout(false);
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.gbFileTrans.ResumeLayout(false);
            this.gbFileTrans.PerformLayout();
            this.gbMsg.ResumeLayout(false);
            this.gbMsg.PerformLayout();
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
        private System.Windows.Forms.GroupBox gbFileTrans;
        private System.Windows.Forms.Button btnStopSend;
        private System.Windows.Forms.Button btnSend;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lblSentLen;
        private System.Windows.Forms.Label lblSentLen2;
        private System.Windows.Forms.Label lblFileSize;
        private System.Windows.Forms.Label lblFileSize2;
        private System.Windows.Forms.Label lblFileName;
        private System.Windows.Forms.Label lblFileName2;
        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton rBUDPip;
        private System.Windows.Forms.MaskedTextBox tbUDPPort;
        private System.Windows.Forms.MaskedTextBox tbUDPHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.GroupBox gbMsg;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox textBoxMSG;
        private System.Windows.Forms.TextBox tBPortToBind;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.RichTextBox tbMsgHistory;
    }
}

