namespace RFID
{
    partial class Form1
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
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
            this.ComboBox_baud = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.ComboBox_baud2 = new System.Windows.Forms.ComboBox();
            this.label47 = new System.Windows.Forms.Label();
            this.ComboBox_AlreadyOpenCOM = new System.Windows.Forms.ComboBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ClosePort = new System.Windows.Forms.Button();
            this.OpenPort = new System.Windows.Forms.Button();
            this.Edit_CmdComAddr = new System.Windows.Forms.TextBox();
            this.Label2 = new System.Windows.Forms.Label();
            this.ComboBox_COM = new System.Windows.Forms.ComboBox();
            this.Label1 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Edit_scantime = new System.Windows.Forms.TextBox();
            this.EPCC1G2 = new System.Windows.Forms.CheckBox();
            this.ISO180006B = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Edit_powerdBm = new System.Windows.Forms.TextBox();
            this.Edit_Version = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Edit_ComAdr = new System.Windows.Forms.TextBox();
            this.Edit_Type = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.ListView1_EPC = new System.Windows.Forms.ListView();
            this.listViewCol_Number = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewCol_ID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewCol_Length = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.listViewCol_Times = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.groupBox12 = new System.Windows.Forms.GroupBox();
            this.CheckBox_TID = new System.Windows.Forms.CheckBox();
            this.groupBox33 = new System.Windows.Forms.GroupBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.label55 = new System.Windows.Forms.Label();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.label54 = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            this.ComboBox_IntervalTime = new System.Windows.Forms.ComboBox();
            this.label23 = new System.Windows.Forms.Label();
            this.Timer_Scan = new System.Windows.Forms.Timer(this.components);
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox12.SuspendLayout();
            this.groupBox33.SuspendLayout();
            this.SuspendLayout();
            // 
            // GroupBox1
            // 
            this.GroupBox1.Controls.Add(this.ComboBox_baud);
            this.GroupBox1.Controls.Add(this.label16);
            this.GroupBox1.Controls.Add(this.ComboBox_baud2);
            this.GroupBox1.Controls.Add(this.label47);
            this.GroupBox1.Controls.Add(this.ComboBox_AlreadyOpenCOM);
            this.GroupBox1.Controls.Add(this.label3);
            this.GroupBox1.Controls.Add(this.ClosePort);
            this.GroupBox1.Controls.Add(this.OpenPort);
            this.GroupBox1.Controls.Add(this.Edit_CmdComAddr);
            this.GroupBox1.Controls.Add(this.Label2);
            this.GroupBox1.Controls.Add(this.ComboBox_COM);
            this.GroupBox1.Controls.Add(this.Label1);
            this.GroupBox1.Location = new System.Drawing.Point(22, 12);
            this.GroupBox1.Name = "GroupBox1";
            this.GroupBox1.Size = new System.Drawing.Size(191, 372);
            this.GroupBox1.TabIndex = 41;
            this.GroupBox1.TabStop = false;
            this.GroupBox1.Text = "通讯";
            // 
            // ComboBox_baud
            // 
            this.ComboBox_baud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_baud.FormattingEnabled = true;
            this.ComboBox_baud.Items.AddRange(new object[] {
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.ComboBox_baud.Location = new System.Drawing.Point(5, 191);
            this.ComboBox_baud.Name = "ComboBox_baud";
            this.ComboBox_baud.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_baud.TabIndex = 14;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(6, 176);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(47, 12);
            this.label16.TabIndex = 13;
            this.label16.Text = "波特率:";
            // 
            // ComboBox_baud2
            // 
            this.ComboBox_baud2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_baud2.FormattingEnabled = true;
            this.ComboBox_baud2.Items.AddRange(new object[] {
            "9600bps",
            "19200bps",
            "38400bps",
            "57600bps",
            "115200bps"});
            this.ComboBox_baud2.Location = new System.Drawing.Point(7, 110);
            this.ComboBox_baud2.Name = "ComboBox_baud2";
            this.ComboBox_baud2.Size = new System.Drawing.Size(121, 20);
            this.ComboBox_baud2.TabIndex = 12;
            // 
            // label47
            // 
            this.label47.AutoSize = true;
            this.label47.Location = new System.Drawing.Point(6, 95);
            this.label47.Name = "label47";
            this.label47.Size = new System.Drawing.Size(47, 12);
            this.label47.TabIndex = 9;
            this.label47.Text = "波特率:";
            // 
            // ComboBox_AlreadyOpenCOM
            // 
            this.ComboBox_AlreadyOpenCOM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_AlreadyOpenCOM.FormattingEnabled = true;
            this.ComboBox_AlreadyOpenCOM.Location = new System.Drawing.Point(5, 153);
            this.ComboBox_AlreadyOpenCOM.Name = "ComboBox_AlreadyOpenCOM";
            this.ComboBox_AlreadyOpenCOM.Size = new System.Drawing.Size(125, 20);
            this.ComboBox_AlreadyOpenCOM.TabIndex = 7;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(6, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 12);
            this.label3.TabIndex = 6;
            this.label3.Text = "已打开端口:";
            // 
            // ClosePort
            // 
            this.ClosePort.Location = new System.Drawing.Point(3, 325);
            this.ClosePort.Name = "ClosePort";
            this.ClosePort.Size = new System.Drawing.Size(125, 23);
            this.ClosePort.TabIndex = 5;
            this.ClosePort.Text = "关闭端口";
            this.ClosePort.UseVisualStyleBackColor = true;
            this.ClosePort.Click += new System.EventHandler(this.ClosePort_Click);
            // 
            // OpenPort
            // 
            this.OpenPort.Location = new System.Drawing.Point(5, 66);
            this.OpenPort.Name = "OpenPort";
            this.OpenPort.Size = new System.Drawing.Size(125, 23);
            this.OpenPort.TabIndex = 4;
            this.OpenPort.Text = "打开端口";
            this.OpenPort.UseVisualStyleBackColor = true;
            this.OpenPort.Click += new System.EventHandler(this.OpenPort_Click);
            // 
            // Edit_CmdComAddr
            // 
            this.Edit_CmdComAddr.BackColor = System.Drawing.SystemColors.Window;
            this.Edit_CmdComAddr.Location = new System.Drawing.Point(98, 39);
            this.Edit_CmdComAddr.MaxLength = 2;
            this.Edit_CmdComAddr.Name = "Edit_CmdComAddr";
            this.Edit_CmdComAddr.Size = new System.Drawing.Size(32, 21);
            this.Edit_CmdComAddr.TabIndex = 3;
            this.Edit_CmdComAddr.Text = "FF";
            // 
            // Label2
            // 
            this.Label2.AutoSize = true;
            this.Label2.Location = new System.Drawing.Point(6, 42);
            this.Label2.Name = "Label2";
            this.Label2.Size = new System.Drawing.Size(71, 12);
            this.Label2.TabIndex = 2;
            this.Label2.Text = "读写器地址:";
            // 
            // ComboBox_COM
            // 
            this.ComboBox_COM.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_COM.FormattingEnabled = true;
            this.ComboBox_COM.Location = new System.Drawing.Point(65, 13);
            this.ComboBox_COM.Name = "ComboBox_COM";
            this.ComboBox_COM.Size = new System.Drawing.Size(65, 20);
            this.ComboBox_COM.TabIndex = 1;
            // 
            // Label1
            // 
            this.Label1.AutoSize = true;
            this.Label1.Location = new System.Drawing.Point(5, 21);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(41, 12);
            this.Label1.TabIndex = 0;
            this.Label1.Text = "端口：";
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button3);
            this.groupBox2.Controls.Add(this.Edit_scantime);
            this.groupBox2.Controls.Add(this.EPCC1G2);
            this.groupBox2.Controls.Add(this.ISO180006B);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Edit_powerdBm);
            this.groupBox2.Controls.Add(this.Edit_Version);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Edit_ComAdr);
            this.groupBox2.Controls.Add(this.Edit_Type);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Location = new System.Drawing.Point(235, 25);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(663, 106);
            this.groupBox2.TabIndex = 42;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "读写器信息";
            // 
            // Button3
            // 
            this.Button3.Location = new System.Drawing.Point(538, 76);
            this.Button3.Name = "Button3";
            this.Button3.Size = new System.Drawing.Size(118, 23);
            this.Button3.TabIndex = 17;
            this.Button3.Text = "获取读写器信息";
            this.Button3.UseVisualStyleBackColor = true;
            this.Button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // Edit_scantime
            // 
            this.Edit_scantime.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Edit_scantime.Location = new System.Drawing.Point(538, 49);
            this.Edit_scantime.Name = "Edit_scantime";
            this.Edit_scantime.Size = new System.Drawing.Size(118, 21);
            this.Edit_scantime.TabIndex = 16;
            // 
            // EPCC1G2
            // 
            this.EPCC1G2.AutoSize = true;
            this.EPCC1G2.Location = new System.Drawing.Point(538, 32);
            this.EPCC1G2.Name = "EPCC1G2";
            this.EPCC1G2.Size = new System.Drawing.Size(72, 16);
            this.EPCC1G2.TabIndex = 15;
            this.EPCC1G2.Text = "EPCC1-G2";
            this.EPCC1G2.UseVisualStyleBackColor = true;
            // 
            // ISO180006B
            // 
            this.ISO180006B.AutoSize = true;
            this.ISO180006B.Location = new System.Drawing.Point(538, 13);
            this.ISO180006B.Name = "ISO180006B";
            this.ISO180006B.Size = new System.Drawing.Size(90, 16);
            this.ISO180006B.TabIndex = 14;
            this.ISO180006B.Text = "ISO18000-6B";
            this.ISO180006B.UseVisualStyleBackColor = true;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(402, 53);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(125, 12);
            this.label11.TabIndex = 13;
            this.label11.Text = "询查命令最大响应时间";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(402, 21);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 12);
            this.label10.TabIndex = 12;
            this.label10.Text = "支持协议:";
            // 
            // Edit_powerdBm
            // 
            this.Edit_powerdBm.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Edit_powerdBm.Location = new System.Drawing.Point(286, 50);
            this.Edit_powerdBm.Name = "Edit_powerdBm";
            this.Edit_powerdBm.Size = new System.Drawing.Size(100, 21);
            this.Edit_powerdBm.TabIndex = 10;
            // 
            // Edit_Version
            // 
            this.Edit_Version.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Edit_Version.Location = new System.Drawing.Point(286, 18);
            this.Edit_Version.Name = "Edit_Version";
            this.Edit_Version.Size = new System.Drawing.Size(100, 21);
            this.Edit_Version.TabIndex = 9;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(197, 53);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(35, 12);
            this.label8.TabIndex = 7;
            this.label8.Text = "功率:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(197, 21);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 12);
            this.label7.TabIndex = 6;
            this.label7.Text = "版本:";
            // 
            // Edit_ComAdr
            // 
            this.Edit_ComAdr.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Edit_ComAdr.Location = new System.Drawing.Point(95, 50);
            this.Edit_ComAdr.Name = "Edit_ComAdr";
            this.Edit_ComAdr.Size = new System.Drawing.Size(85, 21);
            this.Edit_ComAdr.TabIndex = 4;
            // 
            // Edit_Type
            // 
            this.Edit_Type.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Edit_Type.Location = new System.Drawing.Point(95, 18);
            this.Edit_Type.Name = "Edit_Type";
            this.Edit_Type.Size = new System.Drawing.Size(85, 21);
            this.Edit_Type.TabIndex = 3;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 53);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 12);
            this.label5.TabIndex = 1;
            this.label5.Text = "地址:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(6, 21);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 12);
            this.label4.TabIndex = 0;
            this.label4.Text = "型号:";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.ListView1_EPC);
            this.groupBox4.Location = new System.Drawing.Point(243, 148);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(480, 162);
            this.groupBox4.TabIndex = 43;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "标签显示";
            // 
            // ListView1_EPC
            // 
            this.ListView1_EPC.AccessibleRole = System.Windows.Forms.AccessibleRole.IpAddress;
            this.ListView1_EPC.AutoArrange = false;
            this.ListView1_EPC.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ListView1_EPC.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.listViewCol_Number,
            this.listViewCol_ID,
            this.listViewCol_Length,
            this.listViewCol_Times});
            this.ListView1_EPC.Dock = System.Windows.Forms.DockStyle.Top;
            this.ListView1_EPC.FullRowSelect = true;
            this.ListView1_EPC.GridLines = true;
            this.ListView1_EPC.Location = new System.Drawing.Point(3, 17);
            this.ListView1_EPC.Name = "ListView1_EPC";
            this.ListView1_EPC.Size = new System.Drawing.Size(474, 138);
            this.ListView1_EPC.TabIndex = 1;
            this.ListView1_EPC.UseCompatibleStateImageBehavior = false;
            this.ListView1_EPC.View = System.Windows.Forms.View.Details;
            // 
            // listViewCol_Number
            // 
            this.listViewCol_Number.Text = "序号";
            this.listViewCol_Number.Width = 40;
            // 
            // listViewCol_ID
            // 
            this.listViewCol_ID.Text = "EPC号";
            this.listViewCol_ID.Width = 150;
            // 
            // listViewCol_Length
            // 
            this.listViewCol_Length.Text = "EPC长度";
            this.listViewCol_Length.Width = 150;
            // 
            // listViewCol_Times
            // 
            this.listViewCol_Times.Text = "次数";
            // 
            // groupBox12
            // 
            this.groupBox12.Controls.Add(this.CheckBox_TID);
            this.groupBox12.Controls.Add(this.groupBox33);
            this.groupBox12.Controls.Add(this.button2);
            this.groupBox12.Controls.Add(this.ComboBox_IntervalTime);
            this.groupBox12.Controls.Add(this.label23);
            this.groupBox12.Location = new System.Drawing.Point(246, 337);
            this.groupBox12.Name = "groupBox12";
            this.groupBox12.Size = new System.Drawing.Size(325, 93);
            this.groupBox12.TabIndex = 44;
            this.groupBox12.TabStop = false;
            this.groupBox12.Text = "询查标签";
            // 
            // CheckBox_TID
            // 
            this.CheckBox_TID.AutoSize = true;
            this.CheckBox_TID.Location = new System.Drawing.Point(226, 61);
            this.CheckBox_TID.Name = "CheckBox_TID";
            this.CheckBox_TID.Size = new System.Drawing.Size(66, 16);
            this.CheckBox_TID.TabIndex = 4;
            this.CheckBox_TID.Text = "TID询查";
            this.CheckBox_TID.UseVisualStyleBackColor = true;
            // 
            // groupBox33
            // 
            this.groupBox33.Controls.Add(this.textBox5);
            this.groupBox33.Controls.Add(this.label55);
            this.groupBox33.Controls.Add(this.textBox4);
            this.groupBox33.Controls.Add(this.label54);
            this.groupBox33.Location = new System.Drawing.Point(6, 41);
            this.groupBox33.Name = "groupBox33";
            this.groupBox33.Size = new System.Drawing.Size(209, 48);
            this.groupBox33.TabIndex = 3;
            this.groupBox33.TabStop = false;
            this.groupBox33.Text = "TID询查条件";
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(167, 14);
            this.textBox5.MaxLength = 2;
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(37, 21);
            this.textBox5.TabIndex = 3;
            this.textBox5.Text = "04";
            // 
            // label55
            // 
            this.label55.AutoSize = true;
            this.label55.Location = new System.Drawing.Point(107, 24);
            this.label55.Name = "label55";
            this.label55.Size = new System.Drawing.Size(65, 12);
            this.label55.TabIndex = 2;
            this.label55.Text = "数据字数：";
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(64, 14);
            this.textBox4.MaxLength = 2;
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(37, 21);
            this.textBox4.TabIndex = 1;
            this.textBox4.Text = "02";
            // 
            // label54
            // 
            this.label54.AutoSize = true;
            this.label54.Location = new System.Drawing.Point(4, 24);
            this.label54.Name = "label54";
            this.label54.Size = new System.Drawing.Size(65, 12);
            this.label54.TabIndex = 0;
            this.label54.Text = "起始地址：";
            // 
            // button2
            // 
            this.button2.Enabled = false;
            this.button2.Location = new System.Drawing.Point(226, 17);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(93, 23);
            this.button2.TabIndex = 2;
            this.button2.Text = "查询标签";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // ComboBox_IntervalTime
            // 
            this.ComboBox_IntervalTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.ComboBox_IntervalTime.FormattingEnabled = true;
            this.ComboBox_IntervalTime.Location = new System.Drawing.Point(117, 20);
            this.ComboBox_IntervalTime.Name = "ComboBox_IntervalTime";
            this.ComboBox_IntervalTime.Size = new System.Drawing.Size(98, 20);
            this.ComboBox_IntervalTime.TabIndex = 1;
            this.ComboBox_IntervalTime.SelectedIndexChanged += new System.EventHandler(this.ComboBox_IntervalTime_SelectedIndexChanged);
            // 
            // label23
            // 
            this.label23.AutoSize = true;
            this.label23.Location = new System.Drawing.Point(6, 24);
            this.label23.Name = "label23";
            this.label23.Size = new System.Drawing.Size(113, 12);
            this.label23.TabIndex = 0;
            this.label23.Text = "询查标签间隔时间：";
            // 
            // Timer_Scan
            // 
            this.Timer_Scan.Tick += new System.EventHandler(this.Timer_Scan_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 562);
            this.Controls.Add(this.groupBox12);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox12.ResumeLayout(false);
            this.groupBox12.PerformLayout();
            this.groupBox33.ResumeLayout(false);
            this.groupBox33.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        internal System.Windows.Forms.GroupBox GroupBox1;
        private System.Windows.Forms.ComboBox ComboBox_baud2;
        private System.Windows.Forms.Label label47;
        private System.Windows.Forms.ComboBox ComboBox_AlreadyOpenCOM;
        private System.Windows.Forms.Label label3;
        internal System.Windows.Forms.Button ClosePort;
        internal System.Windows.Forms.Button OpenPort;
        internal System.Windows.Forms.TextBox Edit_CmdComAddr;
        internal System.Windows.Forms.Label Label2;
        internal System.Windows.Forms.ComboBox ComboBox_COM;
        internal System.Windows.Forms.Label Label1;
        private System.Windows.Forms.ComboBox ComboBox_baud;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button Button3;
        private System.Windows.Forms.TextBox Edit_scantime;
        private System.Windows.Forms.CheckBox EPCC1G2;
        private System.Windows.Forms.CheckBox ISO180006B;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox Edit_powerdBm;
        private System.Windows.Forms.TextBox Edit_Version;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Edit_ComAdr;
        private System.Windows.Forms.TextBox Edit_Type;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.ListView ListView1_EPC;
        private System.Windows.Forms.ColumnHeader listViewCol_Number;
        private System.Windows.Forms.ColumnHeader listViewCol_ID;
        private System.Windows.Forms.ColumnHeader listViewCol_Length;
        private System.Windows.Forms.ColumnHeader listViewCol_Times;
        private System.Windows.Forms.GroupBox groupBox12;
        private System.Windows.Forms.CheckBox CheckBox_TID;
        private System.Windows.Forms.GroupBox groupBox33;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.Label label55;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.Label label54;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox ComboBox_IntervalTime;
        private System.Windows.Forms.Label label23;
        private System.Windows.Forms.Timer Timer_Scan;
    }
}

