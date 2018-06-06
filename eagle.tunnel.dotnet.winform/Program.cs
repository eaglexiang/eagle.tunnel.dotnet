using System;
using System.Windows.Forms;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using eagle.tunnel.dotnet.core;

namespace eagle.tunnel.dotnet.winform
{
    class Program
    {
        [STAThread]
        public static void Main(string[] args)
        {
            string localPath = System.Reflection.Assembly.GetEntryAssembly().Location;
            localPath = System.IO.Path.GetDirectoryName(localPath);
            string configFilePath = localPath + System.IO.Path.DirectorySeparatorChar + "eagle-tunnel.conf";
            Conf.Init(configFilePath);
            if (Conf.allConf.ContainsKey("config-dir"))
            {
                if (Conf.allConf["config-dir"].Count == 0)
                {
                    Conf.allConf["config-dir"].Add(localPath);
                }
                else
                {
                    if (Conf.allConf["config-dir"][0] != localPath)
                    {
                        Conf.allConf["config-dir"][0] = localPath;
                    }
                }
            }
            else
            {
                if (Conf.allConf.TryAdd("config-dir", new List<string>()))
                {
                    Conf.allConf["config-dir"].Add(localPath);
                }
            }

            if (Conf.allConf.ContainsKey("speed-check"))
            {
                if (Conf.allConf["speed-check"].Count == 0)
                {
                    Conf.allConf["speed-check"].Add("on");
                }
                else
                {
                    Conf.allConf["speed-check"][0] = "on";
                }
            }
            else
            {
                if (Conf.allConf.TryAdd("speed-check", new List<string>()))
                {
                    Conf.allConf["speed-check"].Add("on");
                }
            }

            Conf.Save();

            Application.Run(new MainForm());
        }
    }
}
