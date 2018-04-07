using System;
using System.Runtime.InteropServices;
using Microsoft.Win32;
using System.Net;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using eagle.tunnel.dotnet.core;

namespace eagle.tunnel.dotnet.winform
{
    public partial class MainForm : Form
    {
        [DllImport("wininet.dll")]
        public static extern bool InternetSetOption
         (IntPtr hInternet, int dwOption, IntPtr lpBuffer, int dwBufferLength);
        public const int INTERNET_OPTION_SETTINGS_CHANGED = 39;
        public const int INTERNET_OPTION_REFRESH = 37;

        private double speed; // KB/s
        double oldSpeed;

        public MainForm()
        {
            InitializeComponent();
            Conf.Init(@".\eagle-tunnel.conf");
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            UI_Update();
            Thread threadCheckSpeed = new Thread(CheckSpeed);
            threadCheckSpeed.IsBackground = true;
            threadCheckSpeed.Start();
        }

        private void UI_Update()
        {
            if (Conf.RemoteAddresses != null)
            {
                textBox_Relayer.Text = Conf.RemoteAddresses[0].ToString();
            }
            if (Conf.LocalAddresses != null)
            {
                textBox_Listen.Text = Conf.LocalAddresses[0].ToString();
            }
            checkBox_SOCKS.Checked = Conf.EnableSOCKS;
            checkBox_HTTP.Checked = Conf.EnableHTTP;
            checkBox_ET.Checked = Conf.EnableEagleTunnel;

            checkBox_User.Checked = Conf.LocalUser != null;
            if (checkBox_User.Checked)
            {
                textBox_ID.Enabled = true;
                textBox_Key.Enabled = true;
                textBox_ID.Text = Conf.LocalUser.ID;
                textBox_Key.Text = Conf.LocalUser.Password;
            }
            else
            {
                textBox_ID.Enabled = false;
                textBox_Key.Enabled = false;
            }

            button_Save.Enabled = false;
        }

        private void Proxy_Set(bool enable)
        {
            bool settingsReturn, refreshReturn;

            RegistryKey registry = Registry.CurrentUser.OpenSubKey
               ("Software\\Microsoft\\Windows\\CurrentVersion\\Internet Settings", true);

            if (enable && Conf.LocalAddresses != null)
            {
                string ip = Conf.LocalAddresses[0].Address.ToString();
                string port = Conf.LocalAddresses[0].Port.ToString();
                registry.SetValue("ProxyEnable", 1);
                registry.SetValue
                ("ProxyServer", ip + ':' + port);
                if ((int)registry.GetValue("ProxyEnable", 0) == 0)
                    Console.WriteLine("Unable to enable the proxy.");
                else
                    Console.WriteLine("The proxy has been turned on.");
            }
            else
            {
                registry.SetValue("ProxyEnable", 0);
                registry.SetValue("ProxyServer", 0);
                if ((int)registry.GetValue("ProxyEnable", 1) == 1)
                    Console.WriteLine("Unable to disable the proxy.");
                else
                    Console.WriteLine("The proxy has been turned off.");
            }
            registry.Close();
            settingsReturn = InternetSetOption
            (IntPtr.Zero, INTERNET_OPTION_SETTINGS_CHANGED, IntPtr.Zero, 0);
            refreshReturn = InternetSetOption
            (IntPtr.Zero, INTERNET_OPTION_REFRESH, IntPtr.Zero, 0);
        }

        private void Radio_Proxy_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Proxy.Checked)
            {
                radio_Direct.Checked = false;
                Proxy_Set(true);
            }
        }

        private void Radio_Direct_CheckedChanged(object sender, EventArgs e)
        {
            if (radio_Direct.Checked)
            {
                radio_Proxy.Checked = false;
                Proxy_Set(false);
            }
        }

        private void checkBox_User_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBox_User.Checked)
            {
                textBox_ID.Enabled = true;
                textBox_Key.Enabled = true;
                if (Conf.LocalUser != null)
                {
                    textBox_ID.Text = Conf.LocalUser.ID;
                    textBox_Key.Text = Conf.LocalUser.Password;
                }
            }
            else
            {
                textBox_ID.Enabled = false;
                textBox_Key.Enabled = false;
            }
            button_Save.Enabled = true;
        }

        private void textBox_Relayer_TextChanged(object sender, EventArgs e)
        {
            Conf.RemoteAddress_Set(textBox_Relayer.Text);
            button_Save.Enabled = true;
        }

        private void button_Switch_Click(object sender, EventArgs e)
        {
            if (button_Switch.Text == "关闭服务")
            {
                button_Switch.Text = "关闭中...";
                Server.Close();
                Proxy_Set(false);
                button_Switch.Text = "开启服务";
            }
            else
            {
                if (Conf.LocalAddresses != null)
                {
                    button_Switch.Text = "开启中...";
                    Thread thread_Server = new Thread(StartServer);
                    thread_Server.IsBackground = true;
                    thread_Server.Start();
                    radio_Proxy.Checked = true;
                    Radio_Proxy_CheckedChanged(null, null);
                    timer_CheckWorking.Start();
                }
            }
        }

        private void StartServer()
        {
            Server.Start(Conf.LocalAddresses);
        }

        private void checkBox_SOCKS_CheckedChanged(object sender, EventArgs e)
        {
            button_Save.Enabled = true;
        }

        private void checkBox_HTTP_CheckedChanged(object sender, EventArgs e)
        {
            button_Save.Enabled = true;
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Server.Close();
            Proxy_Set(false);
        }

        private void textBox_Listen_TextChanged(object sender, EventArgs e)
        {
            button_Save.Enabled = true;
        }

        private void textBox_ID_TextChanged(object sender, EventArgs e)
        {
            button_Save.Enabled = true;
        }

        private void textBox_Key_TextChanged(object sender, EventArgs e)
        {
            button_Save.Enabled = true;
        }

        private void button_Save_Click(object sender, EventArgs e)
        {
            Conf.EnableSOCKS = checkBox_SOCKS.Checked;
            Conf.EnableHTTP = checkBox_HTTP.Checked;
            Conf.LocalAddress_Set(textBox_Listen.Text);
            Conf.LocalUser = new EagleTunnelUser(textBox_ID.Text, textBox_Key.Text);
            Conf.Save();
            button_Save.Enabled = false;
        }

        private void timer_CheckSpeed_Tick(object sender, EventArgs e)
        {
            if (speed != oldSpeed)
            {
                string print = " KB/s";
                if (speed > 1024)
                {
                    speed /= 1024;
                    print = " MB/s";
                    if (speed > 1024)
                    {
                        speed /= 1024;
                        print = "GB/s";
                    }
                }
                label_Speed.Text = ((int)speed) + print;
                oldSpeed = speed;
            }
        }

        private void CheckSpeed()
        {
            speed = 0;
            oldSpeed = 0;
            while (true)
            {
                speed = Server.Speed();
                Thread.Sleep(1000);
            }
        }

        private void timer_CheckWorking_Tick(object sender, EventArgs e)
        {
            if (Server.IsWorking)
            {
                button_Switch.Text = "关闭服务";
                timer_CheckWorking.Stop();
            }
        }
    }
}
