using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
namespace RMS
{
    public partial class MDI : Form
    {
        public MDI()
        {
            InitializeComponent();
        }

        private void MDI_Load(object sender, EventArgs e)
        {
            if (ConfigurationManager.ConnectionStrings[0].ConnectionString == null)
            {
                Settings obj = new Settings();
                MainClass.showWindow(obj, this);
            }
            else
            {
                LoginScreen ls = new LoginScreen();
                MainClass.showWindow(ls, this);
            }

        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

    }
}
