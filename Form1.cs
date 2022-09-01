using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Parqueadero
{
    public partial class MainW : Form
    {
        public MainW()
        {
            InitializeComponent();
        }

        private void MainW_Load(object sender, EventArgs e)
        {            
        }

        private void tmtime_Tick(object sender, EventArgs e)
        {
            lbdate.Text = DateTime.Now.ToString();
        }

        private void btTime_Click(object sender, EventArgs e)
        {
            if (lbdate.Visible==false)
            {
                lbdate.Visible = true;
                tmtime.Enabled = true;
                btTime.Text = "Ocultar hora";
            }
            else
            {
                lbdate.Visible = false;
                tmtime.Enabled = false;
                btTime.Text = "Mostrar hora";
            }
            
        }
    }
}
