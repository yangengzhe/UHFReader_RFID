using ReaderB;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RFID
{
    public partial class Form1 : Form
    {
        private byte fComAdr = 0xff; //当前操作的ComAdr
        private byte fBaud;//波特率
        private int frmcomportindex;//传回，打开的端口
        private int fOpenComIndex;//已经打开的端口
        private bool ComOpen;//是否打开端口
        private bool fIsInventoryScan;//是否开始扫描
        private bool fIsInvoke;//是否执行
        private int fCmdRet; //所有执行指令的返回值
        private bool fAppClosed; //在测试模式下响应关闭应用程序
        Dictionary<String, RfidCard> epcs = new Dictionary<String, RfidCard>();//搜索的卡片
        Dictionary<String, RfidCard> window_epcs = new Dictionary<String, RfidCard>();//新获卡，待处理窗口
        public Form1()
        {
            InitializeComponent();
        }
        //复位窗口
        private void reset_view()
        {
            ComOpen = false;
            fCmdRet = 30;
            fOpenComIndex = -1;
            ComboBox_AlreadyOpenCOM.Items.Clear();
            ComboBox_AlreadyOpenCOM.Refresh();
            Button3.Enabled = false;
            ComOpen = false;
            Timer_Scan.Enabled = false;
            fIsInventoryScan = false;
            fIsInvoke = false;
            button2.Enabled = false;
            button2.Text = "开始";
            ClosePort.Enabled = false;
            ComboBox_baud2.SelectedIndex = 3;//初始化波特率选项
        }
        //连接端口
        private void openCom_view()
        {
            Button3.Enabled = true;
            button2.Enabled = true;
            ClosePort.Enabled = true;
            int i = 0;
            while (i <= 300)
            {
                ComboBox_IntervalTime.Items.Add(Convert.ToString(i) + "ms");
                i = i + 10;
            }
            ComboBox_IntervalTime.SelectedIndex = 10;
        }
        //初始化端口列表
        private void InitComList()
        {
            int i = 0;
            ComboBox_COM.Items.Clear();
            ComboBox_COM.Items.Add(" AUTO");
            for (i = 1; i < 13; i++)
                ComboBox_COM.Items.Add(" COM" + Convert.ToString(i));
            ComboBox_COM.SelectedIndex = 0;
        }
        //加载自动执行
        private void Form1_Load(object sender, EventArgs e)
        {
            InitComList();
            reset_view();
            Log_Box.AppendText("[" + DateTime.Now.ToLocalTime().ToString() + "] 系统启动");
        }
        //打开端口按钮
        private void OpenPort_Click(object sender, EventArgs e)
        {
            int port = 0;
            string temp;
            Cursor = Cursors.WaitCursor;
            if (Edit_CmdComAddr.Text == "")
                Edit_CmdComAddr.Text = "FF";
            fComAdr = Convert.ToByte(Edit_CmdComAddr.Text, 16); // $FF;
            try
            {
                if (ComboBox_COM.SelectedIndex == 0)//Auto
                {
                    fBaud = Convert.ToByte(ComboBox_baud2.SelectedIndex);
                    if (fBaud > 2)
                        fBaud = Convert.ToByte(fBaud + 2);
                    fCmdRet = StaticClassReaderB.AutoOpenComPort(ref port, ref fComAdr, fBaud, ref frmcomportindex);//自动打开端口
                    fOpenComIndex = frmcomportindex;
                    if (fCmdRet == 0)//成功
                    {
                        ComOpen = true;
                        if (fBaud > 3)
                        {
                            ComboBox_baud.SelectedIndex = Convert.ToInt32(fBaud - 2);
                        }
                        else
                        {
                            ComboBox_baud.SelectedIndex = Convert.ToInt32(fBaud);
                        }
                        Button3_Click(sender, e); //自动执行读取写卡器信息
                        if ((fCmdRet == 0x35) | (fCmdRet == 0x30))
                        {
                            MessageBox.Show("串口通讯错误", "信息提示");
                            StaticClassReaderB.CloseSpecComPort(frmcomportindex);
                            ComOpen = false;
                        }
                    }
                    else if (fCmdRet == 0x35)
                    {
                        MessageBox.Show("串口已打开", "信息提示");
                        return;
                    }
                }
                else
                {
                    temp = ComboBox_COM.SelectedItem.ToString();
                    temp = temp.Trim();
                    port = Convert.ToInt32(temp.Substring(3, temp.Length - 3));
                    for (int i = 6; i >= 0; i--)
                    {
                        fBaud = Convert.ToByte(i);
                        if (fBaud == 3)
                            continue;
                        fCmdRet = StaticClassReaderB.OpenComPort(port, ref fComAdr, fBaud, ref frmcomportindex);
                        fOpenComIndex = frmcomportindex;
                        if (fCmdRet == 0x35)
                        {
                            MessageBox.Show("串口已打开", "信息提示");
                            return;
                        }
                        else if (fCmdRet == 0)
                        {
                            ComOpen = true;
                            Button3_Click(sender, e); //自动执行读取写卡器信息
                            if (fBaud > 3)
                            {
                                ComboBox_baud.SelectedIndex = Convert.ToInt32(fBaud - 2);
                            }
                            else
                            {
                                ComboBox_baud.SelectedIndex = Convert.ToInt32(fBaud);
                            }
                            if ((fCmdRet == 0x35) || (fCmdRet == 0x30))
                            {
                                ComOpen = false;
                                MessageBox.Show("串口通讯错误", "信息提示");
                                StaticClassReaderB.CloseSpecComPort(frmcomportindex);
                                return;
                            }
                            break;
                        }
                    }
                }
            }
            finally
            {
                Cursor = Cursors.Default;
            }
            //根据是否连接成功 做界面的调整
            if ((fOpenComIndex != -1) & (fCmdRet != 0X35) & (fCmdRet != 0X30))
            {
                ComboBox_AlreadyOpenCOM.Items.Add("COM" + Convert.ToString(fOpenComIndex));
                ComboBox_AlreadyOpenCOM.SelectedIndex = ComboBox_AlreadyOpenCOM.SelectedIndex + 1;
                ComOpen = true;
                openCom_view();
                write_log("打开端口：COM" + Convert.ToString(fOpenComIndex));
            }
            if ((fOpenComIndex == -1) && (fCmdRet == 0x30))
                MessageBox.Show("串口通讯错误", "信息提示");

            if ((ComboBox_AlreadyOpenCOM.Items.Count != 0) & (fOpenComIndex != -1) & (fCmdRet != 0X35) & (fCmdRet != 0X30) & (fCmdRet == 0))
            {
                fComAdr = Convert.ToByte(Edit_ComAdr.Text, 16);
                temp = ComboBox_AlreadyOpenCOM.SelectedItem.ToString();
                frmcomportindex = Convert.ToInt32(temp.Substring(3, temp.Length - 3));
            }
        }
        //获得读写器信息
        private void Button3_Click(object sender, EventArgs e)
        {
            byte[] TrType = new byte[2];
            byte[] VersionInfo = new byte[2];
            byte ReaderType = 0;
            byte ScanTime = 0;
            byte dmaxfre = 0;
            byte dminfre = 0;
            byte powerdBm = 0;
            Edit_Version.Text = "";
            Edit_ComAdr.Text = "";
            Edit_scantime.Text = "";
            Edit_Type.Text = "";
            ISO180006B.Checked = false;
            EPCC1G2.Checked = false;
            Edit_powerdBm.Text = "";
            fCmdRet = StaticClassReaderB.GetReaderInformation(ref fComAdr, VersionInfo, ref ReaderType, TrType, ref dmaxfre, ref dminfre, ref powerdBm, ref ScanTime, frmcomportindex);
            if (fCmdRet == 0)
            {
                Edit_Version.Text = Convert.ToString(VersionInfo[0], 10).PadLeft(2, '0') + "." + Convert.ToString(VersionInfo[1], 10).PadLeft(2, '0');
                
                Edit_ComAdr.Text = Convert.ToString(fComAdr, 16).PadLeft(2, '0');
                Edit_scantime.Text = Convert.ToString(ScanTime, 10).PadLeft(2, '0') + "*100ms";
                Edit_powerdBm.Text = Convert.ToString(powerdBm, 10).PadLeft(2, '0');

                if (ReaderType == 0x03)
                    Edit_Type.Text = "";
                if (ReaderType == 0x06)
                    Edit_Type.Text = "";
                if (ReaderType == 0x09)
                    Edit_Type.Text = "UHFReader18";
                if ((TrType[0] & 0x02) == 0x02) //第二个字节低第四位代表支持的协议“ISO/IEC 15693”
                {
                    ISO180006B.Checked = true;
                    EPCC1G2.Checked = true;
                }
                else
                {
                    ISO180006B.Checked = false;
                    EPCC1G2.Checked = false;
                }
                write_log("获得读写器信息");
            }
        }
        //关闭端口按钮
        private void ClosePort_Click(object sender, EventArgs e)
        {
            int port;
            string temp;
            //ClearLastInfo();
            try
            {
                if (ComboBox_AlreadyOpenCOM.SelectedIndex < 0)
                {
                    MessageBox.Show("请选择要关闭的端口", "信息提示");
                }
                else
                {
                    temp = ComboBox_AlreadyOpenCOM.SelectedItem.ToString();
                    port = Convert.ToInt32(temp.Substring(3, temp.Length - 3));
                    fCmdRet = StaticClassReaderB.CloseSpecComPort(port);
                    if (fCmdRet == 0)
                    {
                        ComboBox_AlreadyOpenCOM.Items.RemoveAt(0);
                        if (ComboBox_AlreadyOpenCOM.Items.Count != 0)
                        {
                            temp = ComboBox_AlreadyOpenCOM.SelectedItem.ToString();
                            port = Convert.ToInt32(temp.Substring(3, temp.Length - 3));
                            StaticClassReaderB.CloseSpecComPort(port);
                            fComAdr = 0xFF;
                            StaticClassReaderB.OpenComPort(port, ref fComAdr, fBaud, ref frmcomportindex);
                            fOpenComIndex = frmcomportindex;
                            Button3_Click(sender, e); //自动执行读取写卡器信息
                        }
                        else
                            reset_view();
                        write_log("关闭端口：COM" + port);
                    }
                    else
                        MessageBox.Show("串口通讯错误", "信息提示");
                }
            }
            finally
            {

            }
            if (ComboBox_AlreadyOpenCOM.Items.Count != 0)
                ComboBox_AlreadyOpenCOM.SelectedIndex = 0;
            else
            {
                if (Timer_Scan.Enabled)
                    button2_Click(sender, e); //关闭查询
            }
        }
        //选择间隔时间
        private void ComboBox_IntervalTime_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (ComboBox_IntervalTime.SelectedIndex < 6)
                Timer_Scan.Interval = 100;
            else
                Timer_Scan.Interval = (ComboBox_IntervalTime.SelectedIndex + 4) * 10;
        }
        //关闭窗口
        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            reset_view();
            fAppClosed = true;
            StaticClassReaderB.CloseComPort();
        }
        //扫描的方法
        private void Inventory()
        {
            int CardNum = 0;
            int Totallen = 0;
            int EPClen, m;
            byte[] EPC = new byte[5000];
            int CardIndex;
            string fInventory_EPC;
            string sEPC;
            fIsInventoryScan = true;
            byte AdrTID = 0;
            byte LenTID = 0;
            byte TIDFlag = 0;

            if (CheckBox_TID.Checked)
            {
                AdrTID = Convert.ToByte(textBox4.Text, 16);
                LenTID = Convert.ToByte(textBox5.Text, 16);
                TIDFlag = 1;
            }
            else
            {
                AdrTID = 0;
                LenTID = 0;
                TIDFlag = 0;
            }
            fCmdRet = StaticClassReaderB.Inventory_G2(ref fComAdr, AdrTID, LenTID, TIDFlag, EPC, ref Totallen, ref CardNum, frmcomportindex);
            if ((fCmdRet == 1) | (fCmdRet == 2) | (fCmdRet == 3) | (fCmdRet == 4) | (fCmdRet == 0xFB))//代表已查找结束，
            {
                byte[] daw = new byte[Totallen];
                Array.Copy(EPC, daw, Totallen);
                fInventory_EPC = ByteArrayToHexString(daw);
                m = 0;
                if (CardNum == 0)//没有找到卡
                {
                    fIsInventoryScan = false;
                    return;
                }
                for (CardIndex = 0; CardIndex < CardNum; CardIndex++)
                {
                    EPClen = daw[m];
                    sEPC = fInventory_EPC.Substring(m * 2 + 2, EPClen * 2);//sEPC为结果的
                    m = m + EPClen + 1;
                    if (sEPC.Length != EPClen * 2)//验证EPC正确性
                        return;

                    if (epcs.ContainsKey(sEPC))//存在卡
                    {
                        if (epcs[sEPC].add_refresh())//刷新
                        {
                            if(!window_epcs.ContainsKey(sEPC))
                                window_epcs.Add(sEPC, epcs[sEPC]);
                            else window_epcs[sEPC] = epcs[sEPC];
                        }
                    }
                    else
                    {
                        epcs.Add(sEPC, new RfidCard(sEPC));
                        if (!window_epcs.ContainsKey(sEPC))
                            window_epcs.Add(sEPC, epcs[sEPC]);
                        else window_epcs[sEPC] = epcs[sEPC];
                    }
                }

                //更新列表
                ListView1_EPC.Items.Clear();
                ListView1_EPC.BeginUpdate();
                int temp = 0;
                foreach(KeyValuePair<String,RfidCard> epc in epcs){
                    temp++;
                    ListViewItem lvi = new ListViewItem();
                    lvi.Text = temp.ToString();
                    lvi.SubItems.Add(epc.Key);
                    lvi.SubItems.Add(epc.Key.Length.ToString());
                    lvi.SubItems.Add(epc.Value.times.ToString());
                    lvi.SubItems.Add(util.Long2Time(epc.Value.timestamp));
                    ListView1_EPC.Items.Add(lvi);
                }
                ListView1_EPC.EndUpdate();

            }

            fIsInventoryScan = false;
            if (fAppClosed)
                Close();
        }
        //定时器
        private void Timer_Scan_Tick(object sender, EventArgs e)
        {
            if (!fIsInventoryScan)
                Inventory();
            if (!fIsInvoke)
                fun_invoke();
        }
        //查询按钮
        private void button2_Click(object sender, EventArgs e)
        {
            if (CheckBox_TID.Checked)
            {
                if ((textBox4.Text.Length) != 2 || ((textBox5.Text.Length) != 2))
                {
                     MessageBox.Show( "TID询查参数错误！");
                    return;
                }
            }
            Timer_Scan.Enabled = !Timer_Scan.Enabled;
            if (Timer_Scan.Enabled)//开始查询
            {
                textBox4.Enabled = false;
                textBox5.Enabled = false;
                CheckBox_TID.Enabled = false;

                ListView1_EPC.Items.Clear();
                epcs.Clear();
                window_epcs.Clear();
                button2.Text = "停止";
                write_log("开始查询 时间间隔：" + ComboBox_IntervalTime.SelectedItem.ToString());
            }else//停止查询
            {
                textBox4.Enabled = true;
                textBox5.Enabled = true;
                CheckBox_TID.Enabled = true;
                button2.Text = "开始";
                write_log("关闭查询");
            }
        }

        private string ByteArrayToHexString(byte[] data)
        {
            StringBuilder sb = new StringBuilder(data.Length * 3);
            foreach (byte b in data)
                sb.Append(Convert.ToString(b, 16).PadLeft(2, '0'));
            return sb.ToString().ToUpper();

        }
        //记录日志
        private void write_log(String msg)
        {
            String time = DateTime.Now.ToLocalTime().ToString();
            Log_Box.AppendText(Environment.NewLine + "[" + time +"] "+msg);
            Log_Box.ScrollToCaret();
        }
        private void Log_Box_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = true;
        }
        //处理新卡的函数
        private void fun_invoke()
        {
            fIsInvoke = true;
            while (window_epcs.Count != 0)
            {
                KeyValuePair<String, RfidCard> epc = window_epcs.First();
                RfidCard rc = epc.Value;
                //do something
                post2web(rc);
                write_log("新刷卡：" + rc.epc + " 时间：" + util.Long2Time(rc.timestamp));
                window_epcs.Remove(epc.Key);
            }
            fIsInvoke = false;
        }
        //post提交数据
        private void post2web(RfidCard rc)
        {
            string url = "http://localhost/index.php";
            string data = "epc="+rc.epc+"&time="+rc.timestamp;
            string result = HttpClientFacde.HttpPost(url, data);
            if (result == null) write_log("传输出错");
            else
            {
                write_log("传输成功");
            }
        }

    }
}
