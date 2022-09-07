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

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            if (pnlIn.Visible)
            {
                pnlIn.Visible = false;
                cleanpnl();
            }
            else
            {
                pnlIn.Visible = true;
            }
        }

        private void rbmot_CheckedChanged(object sender, EventArgs e)
        {
            if (lbCasc.Enabled)
            {
                lbCasc.Enabled = false;
                cbcsc.Enabled = false;                
            }
            else
            {
                lbCasc.Enabled = true;
                cbcsc.Enabled = true;
            }
        }

        private void btingr_Click(object sender, EventArgs e)
        {
            if (txplac.Text.Length==6|| txplac.Text.Length == 5)
            {
                string typeI, typeV;
                if (rbDia.Checked)
                {
                    typeI = "DÍA";
                }
                else if (rbhor.Checked)
                {
                    typeI = "HORA";
                }else typeI = "MES";
                if (rbmot.Checked)
                {
                    typeV = "MOTO";
                }
                else typeV = "CARRO";
                CDatos.Datos datin = new CDatos.Datos();
                datin.ingreso(txplac.Text.ToUpper(),0,typeI,typeV,lbdate.Text, lbdate.Text, 0,0);
                cleanpnl();
            }
        }

        private void cleanpnl()
        {
            txplac.Text = "";
            rbcar.Checked = false;
            rbmot.Checked = false;
            rbMes.Checked = false;
            rbhor.Checked = false;
            rbDia.Checked = false;
            cbcsc.SelectedIndex = -1;
        }
    }
}
