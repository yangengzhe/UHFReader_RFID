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
            this.GroupBox1 = new System.Windows.Forms.GroupBox();
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
            this.ComboBox_baud = new System.Windows.Forms.ComboBox();
            this.label16 = new System.Windows.Forms.Label();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.Button3 = new System.Windows.Forms.Button();
            this.Edit_scantime = new System.Windows.Forms.TextBox();
            this.EPCC1G2 = new System.Windows.Forms.CheckBox();
            this.ISO180006B = new System.Windows.Forms.CheckBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.Edit_dmaxfre = new System.Windows.Forms.TextBox();
            this.Edit_powerdBm = new System.Windows.Forms.TextBox();
            this.Edit_Version = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.Edit_dminfre = new System.Windows.Forms.TextBox();
            this.Edit_ComAdr = new System.Windows.Forms.TextBox();
            this.Edit_Type = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.GroupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
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
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.Button3);
            this.groupBox2.Controls.Add(this.Edit_scantime);
            this.groupBox2.Controls.Add(this.EPCC1G2);
            this.groupBox2.Controls.Add(this.ISO180006B);
            this.groupBox2.Controls.Add(this.label11);
            this.groupBox2.Controls.Add(this.label10);
            this.groupBox2.Controls.Add(this.Edit_dmaxfre);
            this.groupBox2.Controls.Add(this.Edit_powerdBm);
            this.groupBox2.Controls.Add(this.Edit_Version);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.Edit_dminfre);
            this.groupBox2.Controls.Add(this.Edit_ComAdr);
            this.groupBox2.Controls.Add(this.Edit_Type);
            this.groupBox2.Controls.Add(this.label6);
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
            // Edit_dmaxfre
            // 
            this.Edit_dmaxfre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Edit_dmaxfre.Location = new System.Drawing.Point(286, 78);
            this.Edit_dmaxfre.Name = "Edit_dmaxfre";
            this.Edit_dmaxfre.Size = new System.Drawing.Size(100, 21);
            this.Edit_dmaxfre.TabIndex = 11;
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
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(197, 81);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(65, 12);
            this.label9.TabIndex = 8;
            this.label9.Text = "最高频率：";
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
            // Edit_dminfre
            // 
            this.Edit_dminfre.BackColor = System.Drawing.SystemColors.ScrollBar;
            this.Edit_dminfre.Location = new System.Drawing.Point(95, 78);
            this.Edit_dminfre.Name = "Edit_dminfre";
            this.Edit_dminfre.Size = new System.Drawing.Size(85, 21);
            this.Edit_dminfre.TabIndex = 5;
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 81);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 12);
            this.label6.TabIndex = 2;
            this.label6.Text = "最低频率：";
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
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(949, 562);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.GroupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.GroupBox1.ResumeLayout(false);
            this.GroupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
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
        private System.Windows.Forms.TextBox Edit_dmaxfre;
        private System.Windows.Forms.TextBox Edit_powerdBm;
        private System.Windows.Forms.TextBox Edit_Version;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox Edit_dminfre;
        private System.Windows.Forms.TextBox Edit_ComAdr;
        private System.Windows.Forms.TextBox Edit_Type;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

