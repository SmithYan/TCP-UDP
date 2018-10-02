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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.TCPTToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenTCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseTCPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.UDPUToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.OpenUDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.CloseUDPToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.EXITEToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPageTCP = new System.Windows.Forms.TabPage();
            this.rtbMSG = new System.Windows.Forms.RichTextBox();
            this.tabPageUDP = new System.Windows.Forms.TabPage();
            this.gBStart = new System.Windows.Forms.GroupBox();
            this.lBPort = new System.Windows.Forms.Label();
            this.tBPort = new System.Windows.Forms.TextBox();
            this.gBSend = new System.Windows.Forms.GroupBox();
            this.rBCmd = new System.Windows.Forms.RadioButton();
            this.tBText = new System.Windows.Forms.RadioButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.cLBConnected = new System.Windows.Forms.CheckedListBox();
            this.sCMain = new System.Windows.Forms.SplitContainer();
            this.closeSelectedSToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cBAll = new System.Windows.Forms.CheckBox();
            this.menuStrip1.SuspendLayout();
            this.tabControlMain.SuspendLayout();
            this.tabPageTCP.SuspendLayout();
            this.gBStart.SuspendLayout();
            this.gBSend.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.sCMain)).BeginInit();
            this.sCMain.Panel1.SuspendLayout();
            this.sCMain.Panel2.SuspendLayout();
            this.sCMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.TCPTToolStripMenuItem,
            this.UDPUToolStripMenuItem,
            this.EXITEToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Padding = new System.Windows.Forms.Padding(4, 2, 0, 2);
            this.menuStrip1.Size = new System.Drawing.Size(656, 25);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
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
            this.OpenUDPToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.OpenUDPToolStripMenuItem.Text = "OpenUDP（&O)";
            // 
            // CloseUDPToolStripMenuItem
            // 
            this.CloseUDPToolStripMenuItem.Name = "CloseUDPToolStripMenuItem";
            this.CloseUDPToolStripMenuItem.Size = new System.Drawing.Size(159, 22);
            this.CloseUDPToolStripMenuItem.Text = "CloseUDP（&C)";
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
            this.tabControlMain.Size = new System.Drawing.Size(656, 448);
            this.tabControlMain.TabIndex = 1;
            // 
            // tabPageTCP
            // 
            this.tabPageTCP.Controls.Add(this.sCMain);
            this.tabPageTCP.Location = new System.Drawing.Point(4, 22);
            this.tabPageTCP.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageTCP.Name = "tabPageTCP";
            this.tabPageTCP.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageTCP.Size = new System.Drawing.Size(648, 422);
            this.tabPageTCP.TabIndex = 0;
            this.tabPageTCP.Text = "TCPServer";
            this.tabPageTCP.UseVisualStyleBackColor = true;
            // 
            // rtbMSG
            // 
            this.rtbMSG.BackColor = System.Drawing.Color.Azure;
            this.rtbMSG.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtbMSG.Location = new System.Drawing.Point(0, 0);
            this.rtbMSG.Margin = new System.Windows.Forms.Padding(2);
            this.rtbMSG.Name = "rtbMSG";
            this.rtbMSG.Size = new System.Drawing.Size(644, 214);
            this.rtbMSG.TabIndex = 3;
            this.rtbMSG.Text = "";
            // 
            // tabPageUDP
            // 
            this.tabPageUDP.Location = new System.Drawing.Point(4, 22);
            this.tabPageUDP.Margin = new System.Windows.Forms.Padding(2);
            this.tabPageUDP.Name = "tabPageUDP";
            this.tabPageUDP.Padding = new System.Windows.Forms.Padding(2);
            this.tabPageUDP.Size = new System.Drawing.Size(648, 422);
            this.tabPageUDP.TabIndex = 1;
            this.tabPageUDP.Text = "UDPServer";
            this.tabPageUDP.UseVisualStyleBackColor = true;
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
            this.gBSend.Controls.Add(this.button1);
            this.gBSend.Controls.Add(this.rBCmd);
            this.gBSend.Controls.Add(this.tBText);
            this.gBSend.Controls.Add(this.textBox1);
            this.gBSend.Location = new System.Drawing.Point(10, 84);
            this.gBSend.Name = "gBSend";
            this.gBSend.Size = new System.Drawing.Size(267, 99);
            this.gBSend.TabIndex = 11;
            this.gBSend.TabStop = false;
            this.gBSend.Text = "Send";
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
            // tBText
            // 
            this.tBText.AutoSize = true;
            this.tBText.Checked = true;
            this.tBText.Location = new System.Drawing.Point(23, 27);
            this.tBText.Name = "tBText";
            this.tBText.Size = new System.Drawing.Size(47, 16);
            this.tBText.TabIndex = 13;
            this.tBText.TabStop = true;
            this.tBText.Text = "Text";
            this.tBText.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(23, 60);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(229, 21);
            this.textBox1.TabIndex = 12;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(177, 27);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Send";
            this.button1.UseVisualStyleBackColor = true;
            // 
            // cLBConnected
            // 
            this.cLBConnected.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.cLBConnected.Dock = System.Windows.Forms.DockStyle.Right;
            this.cLBConnected.FormattingEnabled = true;
            this.cLBConnected.Location = new System.Drawing.Point(493, 0);
            this.cLBConnected.Name = "cLBConnected";
            this.cLBConnected.Size = new System.Drawing.Size(151, 200);
            this.cLBConnected.TabIndex = 12;
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
            this.sCMain.Panel1.Controls.Add(this.cBAll);
            this.sCMain.Panel1.Controls.Add(this.cLBConnected);
            this.sCMain.Panel1.Controls.Add(this.gBStart);
            this.sCMain.Panel1.Controls.Add(this.gBSend);
            // 
            // sCMain.Panel2
            // 
            this.sCMain.Panel2.Controls.Add(this.rtbMSG);
            this.sCMain.Size = new System.Drawing.Size(644, 418);
            this.sCMain.SplitterDistance = 200;
            this.sCMain.TabIndex = 13;
            // 
            // closeSelectedSToolStripMenuItem
            // 
            this.closeSelectedSToolStripMenuItem.Name = "closeSelectedSToolStripMenuItem";
            this.closeSelectedSToolStripMenuItem.Size = new System.Drawing.Size(188, 22);
            this.closeSelectedSToolStripMenuItem.Text = "CloseSelected（&S）";
            this.closeSelectedSToolStripMenuItem.Click += new System.EventHandler(this.closeSelectedSToolStripMenuItem_Click);
            // 
            // cBAll
            // 
            this.cBAll.AutoSize = true;
            this.cBAll.Location = new System.Drawing.Point(409, 7);
            this.cBAll.Name = "cBAll";
            this.cBAll.Size = new System.Drawing.Size(72, 16);
            this.cBAll.TabIndex = 13;
            this.cBAll.Text = "CheckAll";
            this.cBAll.UseVisualStyleBackColor = true;
            this.cBAll.CheckedChanged += new System.EventHandler(this.cBAll_CheckedChanged);
            // 
            // ServerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(656, 473);
            this.Controls.Add(this.tabControlMain);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "ServerForm";
            this.Text = "Server";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.tabControlMain.ResumeLayout(false);
            this.tabPageTCP.ResumeLayout(false);
            this.gBStart.ResumeLayout(false);
            this.gBStart.PerformLayout();
            this.gBSend.ResumeLayout(false);
            this.gBSend.PerformLayout();
            this.sCMain.Panel1.ResumeLayout(false);
            this.sCMain.Panel1.PerformLayout();
            this.sCMain.Panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.sCMain)).EndInit();
            this.sCMain.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
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
        private System.Windows.Forms.RichTextBox rtbMSG;
        private System.Windows.Forms.GroupBox gBSend;
        private System.Windows.Forms.RadioButton rBCmd;
        private System.Windows.Forms.RadioButton tBText;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox gBStart;
        private System.Windows.Forms.Label lBPort;
        private System.Windows.Forms.TextBox tBPort;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.CheckedListBox cLBConnected;
        private System.Windows.Forms.SplitContainer sCMain;
        private System.Windows.Forms.ToolStripMenuItem closeSelectedSToolStripMenuItem;
        private System.Windows.Forms.CheckBox cBAll;
    }
}

