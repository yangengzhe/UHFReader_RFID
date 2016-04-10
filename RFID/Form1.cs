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
        private int fCmdRet; //所有执行指令的返回值
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
        }
        //连接端口
        private void openCom_view()
        {
            Button3.Enabled = true;
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
            //RefreshStatus();//状态栏内容
        }
        //加载自动执行
        private void Form1_Load(object sender, EventArgs e)
        {
            InitComList();
            reset_view();
            ComboBox_baud2.SelectedIndex = 3;//初始化波特率选项
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
            Edit_dminfre.Text = "";
            Edit_dmaxfre.Text = "";
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
            }
        }

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
                reset_view();
            }
        }
    }
}
