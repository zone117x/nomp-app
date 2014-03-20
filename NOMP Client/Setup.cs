using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOMP_Client
{
    public partial class Setup : Form
    {
        string hardwareType = "CPU";

        public Setup()
        {
            InitializeComponent();

            tabControlInfo.ItemSize = new Size(0, 1);

            string driverUrlNVIDIA = "http://www.nvidia.com/Download/index.aspx";
            string driverUrlAMD = "http://support.amd.com/en-us/download";

            string gfxCard = GetGraphicsCard();
            

            if (gfxCard.ToLower().Contains("nvidiaf"))
            {
                hardwareType = "Nvidia";
                linkLabelGFX.Click += (s, e) => Process.Start(driverUrlNVIDIA);
                linkLabelGFX.Text = String.Format(linkLabelGFX.Text, hardwareType);
            }
            else if (gfxCard.ToLower().Contains("amd") || gfxCard.ToLower().Contains("ati"))
            {
                hardwareType = "AMD";
                linkLabelGFX.Click += (s, e) => Process.Start(driverUrlAMD);
                linkLabelGFX.Text = String.Format(linkLabelGFX.Text, hardwareType);
            }


            labelHardwareType.Text = hardwareType;

            if (hardwareType != "CPU")
            {
                tabControlInfo.TabPages.Remove(tabPageCPU);
                labelHardwareName.Text = gfxCard;
                
            }
            else
            {
                tabControlInfo.TabPages.Remove(tabPageGFX);
                labelHardwareName.Text = GetCPUName();
                linkLabelNVIDIA.Click += (s, e) => { Process.Start(driverUrlNVIDIA); Application.Exit(); };
                linkLabelAMD.Click += (s, e) => { Process.Start(driverUrlAMD); Application.Exit(); };
            }

        }

        string GetCPUName()
        {
            var cpu = new ManagementObjectSearcher("select * from Win32_Processor").Get().Cast<ManagementObject>().First();
            string cpuName = (string)cpu["Name"];
            cpuName = cpuName
               .Replace("(TM)", "™")
               .Replace("(tm)", "™")
               .Replace("(R)", "®")
               .Replace("(r)", "®")
               .Replace("(C)", "©")
               .Replace("(c)", "©")
               .Replace("    ", " ")
               .Replace("  ", " ");

            return cpuName;
        }

        string GetGraphicsCard()
        {
            ManagementObjectSearcher searcher = new ManagementObjectSearcher("SELECT * FROM Win32_DisplayConfiguration");

            string graphicsCard = string.Empty;
            foreach (ManagementObject mo in searcher.Get())
            {
                foreach (PropertyData property in mo.Properties)
                {
                    if (property.Name == "Description")
                    {
                        graphicsCard = property.Value.ToString();
                        return graphicsCard;
                    }
                }
            }
            return null;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            INI.Config(
                "setup_prompt", "false",
                "mining_hardware", hardwareType
                );
            Close();
        }
    }
}
