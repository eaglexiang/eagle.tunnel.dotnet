using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Net;

namespace Eagle_Tunnel
{
    public partial class Form_Main : Form
    {
        Client httpClient;

        public Form_Main()
        {
            InitializeComponent();
        }

        private void Form_Main_Load(object sender, EventArgs e)
        {
            Conf.ReadConfiguration(Conf.UpType.HttpClient);
            textBox_ServerIP.Text = Conf.RemoteIP;
            textBox_ServerPort.Text = Conf.RemoteHttpPort.ToString();
            textBox_LocalIP.Text = Conf.LocalIP;
            textBox_LocalPort.Text = Conf.LocalHttpPort.ToString();
            button_Save.Enabled = false;
        }

        private void TextBox_ServerIP_TextChanged(object sender, EventArgs e)
        {
            button_Save.Enabled = true;
        }

        private void Button_Save_Click(object sender, EventArgs e)
        {
            string tmp = textBox_ServerIP.Text;
            if (IPAddress.TryParse(tmp, out IPAddress ipa))
            {
                Conf.RemoteIP = tmp;
            }
            tmp = textBox_ServerPort.Text;
            if (int.TryParse(tmp, out int port))
            {
                Conf.RemoteHttpPort = port;
            }
            tmp = textBox_LocalIP.Text;
            if (IPAddress.TryParse(tmp, out ipa))
            {
                Conf.LocalIP = tmp;
            }
            tmp = textBox_LocalPort.Text;
            if (int.TryParse(tmp, out port))
            {
                Conf.LocalHttpPort = port;
            }

            Conf.WriteConf(ref Conf.conf,  "remote ip",  Conf.RemoteIP);
            Conf.WriteConf(ref Conf.conf, "remote http port", Conf.RemoteHttpPort.ToString());
            Conf.WriteConf(ref Conf.conf, "local ip", Conf.LocalIP);
            Conf.WriteConf(ref Conf.conf, "local http port", Conf.LocalHttpPort.ToString());

            try
            {
                Conf.Save();
            }
            catch
            {
                ;
            }

            button_Save.Enabled = false;
        }

        private void Button_Start_Click(object sender, EventArgs e)
        {
            if (button_Start.Text == "启动")
            {
                try
                {
                    httpClient = new Client(
                        Conf.RemoteIP, Conf.RemoteHttpPort,
                        Conf.LocalIP, Conf.LocalHttpPort
                    );
                    httpClient.Start();
                }
                catch
                {
                    return;
                }
                if (button_Proxy.Text == "当前：直连")
                {
                    Button1_Click(sender, e);
                }
                button_Start.Text = "断开";
            }
            else
            {
                httpClient.Stop();
                if (button_Proxy.Text == "当前：代理")
                {
                    Button1_Click(sender, e);
                }
                button_Start.Text = "启动";
            }
        }

        private void Button1_Click(object sender, EventArgs e)
        {
            if(button_Proxy.Text == "当前：直连")
            {
                button_Proxy.Text = "当前：代理";
            }
            else
            {
                button_Proxy.Text = "当前：直连";
            }
        }

        private void Form_Main_FormClosed(object sender, FormClosedEventArgs e)
        {
            if (button_Proxy.Text == "当前：代理")
            {
                Button1_Click(sender, e);
            }
        }
    }
}
