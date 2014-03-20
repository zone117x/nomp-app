using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Management;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NOMP_Client
{
    public partial class Main : Form
    {
        public Main()
        {
            InitializeComponent();

            var setupPrompt = INI.Value("setup_prompt");
            if (setupPrompt != "false")
                new Setup().ShowDialog();

            

        }
    }
}
