namespace Server
{
    partial class ServerForm
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
            this.menuStripMain = new System.Windows.Forms.MenuStrip();
            this.TCPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseTCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.closeSelectedSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UDPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenUDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseUDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EXITEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTCP = new System.Windows.Forms.TabPage();
            this.sCMain = new System.Windows.Forms.SplitContainer();
            this.cBAll = new System.Windows.Forms.CheckBox();
            this.cLBConnected = new System.Windows.Forms.CheckedListBox();
            this.gBStart = new System.Windows.Forms.GroupBox();
            this.lBPort = new System.Windows.Forms.Label();
            this.tBPort = new System.Windows.Forms.TextBox();
            this.gBSend = new System.Windows.Forms.GroupBox();
            this.BTSend = new System.Windows.Forms.Button();
            this.rBCmd = new System.Windows.Forms.RadioButton();
            this.rBText = new System.Windows.Forms.RadioButton();
            this.tBText = new System.Windows.Forms.TextBox();
            this.rtbMSG = new System.Windows.Forms.RichTextBox();
            this.tabPageUDP = new System.Windows.Forms.TabPage();
            this.gbServer = new System.Windows.Forms.GroupBox();
            this.tbUDPPort = new System.Windows.Forms.MaskedTextBox();
            this.tbHost = new System.Windows.Forms.MaskedTextBox();
            this.lblPort = new System.Windows.Forms.Label();
            this.rBip = new System.Windows.Forms.RadioButton();
            this.rBDomain = new System.Windows.Forms.RadioButton();
            this.gbMsg = new System.Windows.Forms.GroupBox();
            this.btnSendMsg = new System.Windows.Forms.Button();
            this.tbMsg = new System.Windows.Forms.TextBox();
            this.gbFileTrans = new System.Windows.Forms.GroupBox();
            this.btnStopTrans = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btSendFile = new System.Windows.Forms.Button();
            this.tbUDPPortToBind = new System.Windows.Forms.TextBox();
            this.tbMsgHistory = new System.Windows.Forms.RichTextBox();
            this.menuStripMain.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageTCP.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCMain)).BeginInit();
            this.sCMain.Panel1.SuspendLayout();
            this.sCMain.Panel2.SuspendLayout();
            this.sCMain.SuspendLayout();
            this.gBStart.SuspendLayout();
            this.gBSend.SuspendLayout();
            this.tabPageUDP.SuspendLayout();
            this.gbServer.SuspendLayout();
            this.gbMsg.SuspendLayout();
            this.gbFileTrans.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMain
            // 
            this.menuStripMain.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStripMain.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TCPTToolStripMenuItem,
            this.UDPUToolStripMenuItem,
            this.EXITEToolStripMenuItem});
            this.menuStripMain.Location = new System.Drawing.Point(0, 0);
            this.menuStripMain.Name = "menuStripMain";
            this.menuStripMain.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStripMain.Size = new System.Drawing.Size(548, 25);
            this.menuStripMain.TabIndex = 0;
            // 
            // TCPTToolStripMenuItem
            // 
            this.TCPTToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenTCPToolStripMenuItem,
            this.CloseTCPToolStripMenuItem,
            this.closeSelectedSToolStripMenuItem});
            this.TCPTToolStripMenuItem.Name = "TCPTToolStripMenuItem";
            this.TCPTToolStripMenuItem.Size = new System.Drawing.Size(73, 21);
            this.TCPTToolStripMenuItem.Text = "TCP（&T）";
            // 
            // OpenTCPToolStripMenuItem
            // 
            this.OpenTCPToolStripMenuItem.Name = "OpenTCPToolStripMenuItem";
            this.OpenTCPToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.OpenTCPToolStripMenuItem.Text = "OpenTCP（&O)";
            this.OpenTCPToolStripMenuItem.Click += new System.EventHandler(this.OpenTCPToolStripMenuItem_Click);
            // 
            // CloseTCPToolStripMenuItem
            // 
            this.CloseTCPToolStripMenuItem.Name = "CloseTCPToolStripMenuItem";
            this.CloseTCPToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.CloseTCPToolStripMenuItem.Text = "CloseTCP（&C)";
            this.CloseTCPToolStripMenuItem.Click += new System.EventHandler(this.CloseTCPToolStripMenuItem_Click);
            // 
            // closeSelectedSToolStripMenuItem
            // 
            this.closeSelectedSToolStripMenuItem.Name = "closeSelectedSToolStripMenuItem";
            this.closeSelectedSToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.closeSelectedSToolStripMenuItem.Text = "CloseSelected（&S）";
            this.closeSelectedSToolStripMenuItem.Click += new System.EventHandler(this.closeSelectedSToolStripMenuItem_Click);
            // 
            // UDPUToolStripMenuItem
            // 
            this.UDPUToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.OpenUDPToolStripMenuItem,
            this.CloseUDPToolStripMenuItem});
            this.UDPUToolStripMenuItem.Name = "UDPUToolStripMenuItem";
            this.UDPUToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.UDPUToolStripMenuItem.Text = "UDP（&U)";
            // 
            // OpenUDPToolStripMenuItem
            // 
            this.OpenUDPToolStripMenuItem.Name = "OpenUDPToolStripMenuItem";
            this.OpenUDPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.OpenUDPToolStripMenuItem.Text = "OpenUDP（&O)";
            this.OpenUDPToolStripMenuItem.Click += new System.EventHandler(this.OpenUDPToolStripMenuItem_Click);
            // 
            // CloseUDPToolStripMenuItem
            // 
            this.CloseUDPToolStripMenuItem.Name = "CloseUDPToolStripMenuItem";
            this.CloseUDPToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.CloseUDPToolStripMenuItem.Text = "CloseUDP（&C)";
            this.CloseUDPToolStripMenuItem.Click += new System.EventHandler(this.CloseUDPToolStripMenuItem_Click);
            // 
            // EXITEToolStripMenuItem
            // 
            this.EXITEToolStripMenuItem.Name = "EXITEToolStripMenuItem";
            this.EXITEToolStripMenuItem.Size = new System.Drawing.Size(63, 21);
            this.EXITEToolStripMenuItem.Text = "Exit（&E)";
            this.EXITEToolStripMenuItem.Click += new System.EventHandler(this.EXITEToolStripMenuItem_Click);
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPageTCP);
            this.tabControlMain.Controls.Add(this.tabPageUDP);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControlMain.Location = new System.Drawing.Point(0, 25);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(548, 448);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageTCP
            // 
            this.tabPageTCP.Controls.Add(this.sCMain);
            this.tabPageTCP.Location = new System.Drawing.Point(4, 22);
            this.tabPageTCP.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageTCP.Name = "tabPageTCP";
            this.tabPageTCP.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageTCP.Size = new System.Drawing.Size(540, 422);
            this.tabPageTCP.TabIndex = 0;
            this.tabPageTCP.Text = "TCPServer";
            this.tabPageTCP.UseVisualStyleBackColor = true;
            // 
            // sCMain
            // 
            this.sCMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.sCMain.Location = new System.Drawing.Point(2, 2);
            this.sCMain.Name = "sCMain";
            this.sCMain.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // sCMain.Panel1
            // 
            this.sCMain.Panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.sCMain.Panel1.Controls.Add(this.btSendFile);
            this.sCMain.Panel1.Controls.Add(this.cBAll);
            this.sCMain.Panel1.Controls.Add(this.cLBConnected);
            this.sCMain.Panel1.Controls.Add(this.gBStart);
            this.sCMain.Panel1.Controls.Add(this.gBSend);
            // 
            // sCMain.Panel2
            // 
            this.sCMain.Panel2.Controls.Add(this.rtbMSG);
            this.sCMain.Size = new System.Drawing.Size(536, 418);
            this.sCMain.SplitterDistance = 200;
            this.sCMain.TabIndex = 13;
            // 
            // cBAll
            // 
            this.cBAll.AutoSize = true;
            this.cBAll.Location = new System.Drawing.Point(297, 36);
            this.cBAll.Name = "cBAll";
            this.cBAll.Size = new System.Drawing.Size(72, 16);
            this.cBAll.TabIndex = 13;
            this.cBAll.Text = "CheckAll";
            this.cBAll.UseVisualStyleBackColor = true;
            this.cBAll.CheckedChanged += new System.EventHandler(this.cBAll_CheckedChanged);
            // 
            // cLBConnected
            // 
            this.cLBConnected.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cLBConnected.Dock = System.Windows.Forms.DockStyle.Right;
            this.cLBConnected.FormattingEnabled = true;
            this.cLBConnected.Location = new System.Drawing.Point(385, 0);
            this.cLBConnected.Name = "cLBConnected";
            this.cLBConnected.Size = new System.Drawing.Size(151, 200);
            this.cLBConnected.TabIndex = 12;
            // 
            // gBStart
            // 
            this.gBStart.BackColor = System.Drawing.Color.Aquamarine;
            this.gBStart.Controls.Add(this.lBPort);
            this.gBStart.Controls.Add(this.tBPort);
            this.gBStart.Location = new System.Drawing.Point(10, 7);
            this.gBStart.Name = "gBStart";
            this.gBStart.Size = new System.Drawing.Size(267, 56);
            this.gBStart.TabIndex = 10;
            this.gBStart.TabStop = false;
            this.gBStart.Text = "Start";
            // 
            // lBPort
            // 
            this.lBPort.AutoSize = true;
            this.lBPort.Location = new System.Drawing.Point(6, 27);
            this.lBPort.Name = "lBPort";
            this.lBPort.Size = new System.Drawing.Size(29, 12);
            this.lBPort.TabIndex = 13;
            this.lBPort.Text = "Port";
            // 
            // tBPort
            // 
            this.tBPort.Location = new System.Drawing.Point(52, 24);
            this.tBPort.Margin = new System.Windows.Forms.Padding(2);
            this.tBPort.Name = "tBPort";
            this.tBPort.Size = new System.Drawing.Size(76, 21);
            this.tBPort.TabIndex = 10;
            this.tBPort.Text = "7777";
            // 
            // gBSend
            // 
            this.gBSend.BackColor = System.Drawing.Color.Aquamarine;
            this.gBSend.Controls.Add(this.BTSend);
            this.gBSend.Controls.Add(this.rBCmd);
            this.gBSend.Controls.Add(this.rBText);
            this.gBSend.Controls.Add(this.tBText);
            this.gBSend.Location = new System.Drawing.Point(10, 84);
            this.gBSend.Name = "gBSend";
            this.gBSend.Size = new System.Drawing.Size(267, 99);
            this.gBSend.TabIndex = 11;
            this.gBSend.TabStop = false;
            this.gBSend.Text = "Send";
            // 
            // BTSend
            // 
            this.BTSend.Location = new System.Drawing.Point(177, 27);
            this.BTSend.Name = "BTSend";
            this.BTSend.Size = new System.Drawing.Size(75, 23);
            this.BTSend.TabIndex = 15;
            this.BTSend.Text = "Send";
            this.BTSend.UseVisualStyleBackColor = true;
            this.BTSend.Click += new System.EventHandler(this.BTSend_Click);
            // 
            // rBCmd
            // 
            this.rBCmd.AutoSize = true;
            this.rBCmd.Location = new System.Drawing.Point(76, 27);
            this.rBCmd.Name = "rBCmd";
            this.rBCmd.Size = new System.Drawing.Size(41, 16);
            this.rBCmd.TabIndex = 14;
            this.rBCmd.Text = "Cmd";
            this.rBCmd.UseVisualStyleBackColor = true;
            // 
            // rBText
            // 
            this.rBText.AutoSize = true;
            this.rBText.Checked = true;
            this.rBText.Location = new System.Drawing.Point(23, 27);
            this.rBText.Name = "rBText";
            this.rBText.Size = new System.Drawing.Size(47, 16);
            this.rBText.TabIndex = 13;
            this.rBText.TabStop = true;
            this.rBText.Text = "Text";
            this.rBText.UseVisualStyleBackColor = true;
            // 
            // tBText
            // 
            this.tBText.Location = new System.Drawing.Point(23, 60);
            this.tBText.Name = "tBText";
            this.tBText.Size = new System.Drawing.Size(229, 21);
            this.tBText.TabIndex = 12;
            // 
            // rtbMSG
            // 
            this.rtbMSG.BackColor = System.Drawing.Color.Azure;
            this.rtbMSG.Cursor = System.Windows.Forms.Cursors.Default;
            this.rtbMSG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMSG.Location = new System.Drawing.Point(0, 0);
            this.rtbMSG.Margin = new System.Windows.Forms.Padding(2);
            this.rtbMSG.Name = "rtbMSG";
            this.rtbMSG.Size = new System.Drawing.Size(536, 214);
            this.rtbMSG.TabIndex = 3;
            this.rtbMSG.Text = "";
            // 
            // tabPageUDP
            // 
            this.tabPageUDP.Controls.Add(this.gbFileTrans);
            this.tabPageUDP.Controls.Add(this.gbMsg);
            this.tabPageUDP.Controls.Add(this.gbServer);
            this.tabPageUDP.Location = new System.Drawing.Point(4, 22);
            this.tabPageUDP.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageUDP.Name = "tabPageUDP";
            this.tabPageUDP.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageUDP.Size = new System.Drawing.Size(540, 422);
            this.tabPageUDP.TabIndex = 1;
            this.tabPageUDP.Text = "UDPServer";
            this.tabPageUDP.UseVisualStyleBackColor = true;
            // 
            // gbServer
            // 
            this.gbServer.Controls.Add(this.tbUDPPortToBind);
            this.gbServer.Controls.Add(this.rBDomain);
            this.gbServer.Controls.Add(this.rBip);
            this.gbServer.Controls.Add(this.tbUDPPort);
            this.gbServer.Controls.Add(this.tbHost);
            this.gbServer.Controls.Add(this.lblPort);
            this.gbServer.Dock = System.Windows.Forms.DockStyle.Top;
            this.gbServer.Location = new System.Drawing.Point(2, 2);
            this.gbServer.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbServer.Name = "gbServer";
            this.gbServer.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbServer.Size = new System.Drawing.Size(536, 81);
            this.gbServer.TabIndex = 8;
            this.gbServer.TabStop = false;
            this.gbServer.Text = "Aim IPEndPoint";
            // 
            // tbUDPPort
            // 
            this.tbUDPPort.Location = new System.Drawing.Point(154, 45);
            this.tbUDPPort.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbUDPPort.Mask = "99999";
            this.tbUDPPort.Name = "tbUDPPort";
            this.tbUDPPort.PromptChar = ' ';
            this.tbUDPPort.Size = new System.Drawing.Size(71, 21);
            this.tbUDPPort.TabIndex = 6;
            this.tbUDPPort.Text = "6666";
            // 
            // tbHost
            // 
            this.tbHost.Location = new System.Drawing.Point(17, 45);
            this.tbHost.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbHost.Name = "tbHost";
            this.tbHost.Size = new System.Drawing.Size(110, 21);
            this.tbHost.TabIndex = 3;
            this.tbHost.Text = "127.0.0.1";
            // 
            // lblPort
            // 
            this.lblPort.AutoSize = true;
            this.lblPort.Location = new System.Drawing.Point(174, 25);
            this.lblPort.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblPort.Name = "lblPort";
            this.lblPort.Size = new System.Drawing.Size(29, 12);
            this.lblPort.TabIndex = 1;
            this.lblPort.Text = "Port";
            // 
            // rBip
            // 
            this.rBip.AutoSize = true;
            this.rBip.Checked = true;
            this.rBip.Location = new System.Drawing.Point(17, 21);
            this.rBip.Name = "rBip";
            this.rBip.Size = new System.Drawing.Size(35, 16);
            this.rBip.TabIndex = 7;
            this.rBip.TabStop = true;
            this.rBip.Text = "ip";
            this.rBip.UseVisualStyleBackColor = true;
            // 
            // rBDomain
            // 
            this.rBDomain.AutoSize = true;
            this.rBDomain.Location = new System.Drawing.Point(61, 21);
            this.rBDomain.Name = "rBDomain";
            this.rBDomain.Size = new System.Drawing.Size(59, 16);
            this.rBDomain.TabIndex = 7;
            this.rBDomain.Text = "domain";
            this.rBDomain.UseVisualStyleBackColor = true;
            // 
            // gbMsg
            // 
            this.gbMsg.Controls.Add(this.tbMsgHistory);
            this.gbMsg.Controls.Add(this.panel1);
            this.gbMsg.Dock = System.Windows.Forms.DockStyle.Fill;
            this.gbMsg.Location = new System.Drawing.Point(2, 83);
            this.gbMsg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbMsg.Name = "gbMsg";
            this.gbMsg.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbMsg.Size = new System.Drawing.Size(536, 337);
            this.gbMsg.TabIndex = 9;
            this.gbMsg.TabStop = false;
            this.gbMsg.Text = "Message";
            // 
            // btnSendMsg
            // 
            this.btnSendMsg.Location = new System.Drawing.Point(386, 12);
            this.btnSendMsg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnSendMsg.Name = "btnSendMsg";
            this.btnSendMsg.Size = new System.Drawing.Size(100, 27);
            this.btnSendMsg.TabIndex = 1;
            this.btnSendMsg.Text = "Send";
            this.btnSendMsg.UseVisualStyleBackColor = true;
            this.btnSendMsg.Click += new System.EventHandler(this.btnSendMsg_Click);
            // 
            // tbMsg
            // 
            this.tbMsg.Location = new System.Drawing.Point(13, 12);
            this.tbMsg.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.tbMsg.Multiline = true;
            this.tbMsg.Name = "tbMsg";
            this.tbMsg.Size = new System.Drawing.Size(357, 22);
            this.tbMsg.TabIndex = 0;
            // 
            // gbFileTrans
            // 
            this.gbFileTrans.Controls.Add(this.btnStopTrans);
            this.gbFileTrans.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.gbFileTrans.Location = new System.Drawing.Point(2, 355);
            this.gbFileTrans.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFileTrans.Name = "gbFileTrans";
            this.gbFileTrans.Padding = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.gbFileTrans.Size = new System.Drawing.Size(536, 65);
            this.gbFileTrans.TabIndex = 10;
            this.gbFileTrans.TabStop = false;
            this.gbFileTrans.Text = "FileTransmit";
            // 
            // btnStopTrans
            // 
            this.btnStopTrans.Location = new System.Drawing.Point(29, 23);
            this.btnStopTrans.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnStopTrans.Name = "btnStopTrans";
            this.btnStopTrans.Size = new System.Drawing.Size(100, 27);
            this.btnStopTrans.TabIndex = 0;
            this.btnStopTrans.Text = "StopTransmit";
            this.btnStopTrans.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.tbMsg);
            this.panel1.Controls.Add(this.btnSendMsg);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(4, 17);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 49);
            this.panel1.TabIndex = 3;
            // 
            // btSendFile
            // 
            this.btSendFile.Location = new System.Drawing.Point(294, 7);
            this.btSendFile.Name = "btSendFile";
            this.btSendFile.Size = new System.Drawing.Size(75, 23);
            this.btSendFile.TabIndex = 14;
            this.btSendFile.Text = "SendFile";
            this.btSendFile.UseVisualStyleBackColor = true;
            this.btSendFile.Click += new System.EventHandler(this.btSendFile_Click);
            // 
            // tbUDPPortToBind
            // 
            this.tbUDPPortToBind.Location = new System.Drawing.Point(274, 45);
            this.tbUDPPortToBind.Name = "tbUDPPortToBind";
            this.tbUDPPortToBind.Size = new System.Drawing.Size(68, 21);
            this.tbUDPPortToBind.TabIndex = 8;
            this.tbUDPPortToBind.Text = "7777";
            // 
            // tbMsgHistory
            // 
            this.tbMsgHistory.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tbMsgHistory.Location = new System.Drawing.Point(4, 66);
            this.tbMsgHistory.Name = "tbMsgHistory";
            this.tbMsgHistory.Size = new System.Drawing.Size(528, 268);
            this.tbMsgHistory.TabIndex = 4;
            this.tbMsgHistory.Text = "";
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(548, 473);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStripMain);
            this.MainMenuStrip = this.menuStripMain;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.menuStripMain.ResumeLayout(false);
            this.menuStripMain.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTCP.ResumeLayout(false);
            this.sCMain.Panel1.ResumeLayout(false);
            this.sCMain.Panel1.PerformLayout();
            this.sCMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sCMain)).EndInit();
            this.sCMain.ResumeLayout(false);
            this.gBStart.ResumeLayout(false);
            this.gBStart.PerformLayout();
            this.gBSend.ResumeLayout(false);
            this.gBSend.PerformLayout();
            this.tabPageUDP.ResumeLayout(false);
            this.gbServer.ResumeLayout(false);
            this.gbServer.PerformLayout();
            this.gbMsg.ResumeLayout(false);
            this.gbFileTrans.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMain;
        private System.Windows.Forms.ToolStripMenuItem TCPTToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenTCPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseTCPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem UDPUToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem OpenUDPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem CloseUDPToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem EXITEToolStripMenuItem;
        private System.Windows.Forms.TabControl tabControlMain;
        private System.Windows.Forms.TabPage tabPageTCP;
        private System.Windows.Forms.TabPage tabPageUDP;
        private System.Windows.Forms.GroupBox gBSend;
        private System.Windows.Forms.RadioButton rBCmd;
        private System.Windows.Forms.RadioButton rBText;
        private System.Windows.Forms.TextBox tBText;
        private System.Windows.Forms.GroupBox gBStart;
        private System.Windows.Forms.Label lBPort;
        private System.Windows.Forms.TextBox tBPort;
        private System.Windows.Forms.Button BTSend;
        private System.Windows.Forms.CheckedListBox cLBConnected;
        private System.Windows.Forms.SplitContainer sCMain;
        private System.Windows.Forms.ToolStripMenuItem closeSelectedSToolStripMenuItem;
        private System.Windows.Forms.CheckBox cBAll;
        public System.Windows.Forms.RichTextBox rtbMSG;
        private System.Windows.Forms.GroupBox gbServer;
        private System.Windows.Forms.MaskedTextBox tbUDPPort;
        private System.Windows.Forms.MaskedTextBox tbHost;
        private System.Windows.Forms.Label lblPort;
        private System.Windows.Forms.RadioButton rBDomain;
        private System.Windows.Forms.RadioButton rBip;
        private System.Windows.Forms.GroupBox gbFileTrans;
        private System.Windows.Forms.Button btnStopTrans;
        private System.Windows.Forms.GroupBox gbMsg;
        private System.Windows.Forms.Button btnSendMsg;
        private System.Windows.Forms.TextBox tbMsg;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btSendFile;
        private System.Windows.Forms.TextBox tbUDPPortToBind;
        private System.Windows.Forms.RichTextBox tbMsgHistory;
    }
}

