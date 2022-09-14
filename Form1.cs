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
        bool consulta = false;
        int dia, hora, i,tarfinal;
        TimeSpan t;
        public MainW()
        {
            InitializeComponent();
            actgrid();
        }
        CDatos.Datos da = new CDatos.Datos();
        CNeg.cNeg dat = new CNeg.cNeg();

        private void MainW_Load(object sender, EventArgs e)
        {            
        }

        private void tmtime_Tick(object sender, EventArgs e)
        {
            i++;
            lbdate.Text = DateTime.Now.ToString();
            
            //if (horsal)
            //{
            //    lbsalhorsal.Text = DateTime.Now.ToString();
            //}
        }

        

        private void salirToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btIn_Click(object sender, EventArgs e)
        {
            cleanpnl();
        }

        private void rbmot_CheckedChanged(object sender, EventArgs e)
        {
            //if (lbCasc.Enabled)
            //{
            //    lbCasc.Enabled = false;
            //    cbcsc.Enabled = false;                
            //}
            //else
            //{
            //    lbCasc.Enabled = true;
            //    cbcsc.Enabled = true;
            //}
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
                actgrid();
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

        private void btSal_Click(object sender, EventArgs e)
        {
            if (consulta && i<60)
            {
                if (MessageBox.Show(("El valor a pagar es de " + lbsaltar.Text + ". Presione 'Si' si desea continuar o 'No' para cancelar."),"", MessageBoxButtons.YesNo)==DialogResult.Yes)
                {
                    if (i < 60)
                    {                                               
                        dat.exit(lbsalpla.Text, DateTime.Now.ToString(), tarfinal);
                        actgrid();
                    }
                    else MessageBox.Show("Debe consultar nuevamente para actualizar el valor.");
                    
                }
            }
        }

        private void dgsal_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            txplac.Text = dgsal.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void dgsal_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int fila = e.RowIndex;
            txplac.Text = dgsal.Rows[e.RowIndex].Cells[1].Value.ToString();
        }

        private void btconsult_Click(object sender, EventArgs e)
        {
            if (txplac.Text != "")
            {
                i = 0;
                DataTable datos = da.consultind(txplac.Text);
                lbsalpla.Text= datos.Rows[0][1].ToString();
                lbsalhoring.Text = datos.Rows[0][5].ToString();
                tmtime.Enabled = true;
                lbsaltipveh.Text = datos.Rows[0][4].ToString();
                lbsaltiping.Text = datos.Rows[0][3].ToString();
                
                t = DateTime.Now - Convert.ToDateTime(lbsalhoring.Text);
                calcti(lbsaltiping.Text, lbsaltipveh.Text);
                consulta = true;
                //if (lbsaltiping.Text=="HORA")
                //{
                //    lbsaltiemp.Text =(Convert.ToInt32(t.TotalSeconds)).ToString();

                //}
                //MessageBox.Show("El vehiculo con placa " + txplac.Text.ToUpper() + " lleva " + hour +, "Aviso");
            }
            else
            {
                MessageBox.Show("Ingrese una placa válida.", "Error");
            }
        }
        private void calcti(string tipoi, string tipov)
        {
            int tarifa;
            tarifa = dat.Tarifaing(tipoi, tipov);
            if (tipoi=="HORA")
            {             
                hora = Convert.ToInt32(t.TotalSeconds) / 3600;
                lbsaltiemp.Text = hora.ToString()+" horas";
                if (hora==0)
                {
                    tarfinal = tarifa;
                    lbsaltar.Text = tarfinal + "$";
                }
                else
                {
                    tarfinal= hora * tarifa ;
                    lbsaltar.Text = tarfinal + "$";
                } 
            }
            else if (tipoi == "DÍA")
            {
                dia = Convert.ToInt32(t.TotalSeconds) / 86400;
                lbsaltiemp.Text = dia.ToString() + " días";
                if (dia == 0)
                {
                    tarfinal= tarifa ;
                    lbsaltar.Text = tarfinal + "$";
                }
                else
                {
                    tarfinal= dia * tarifa ;
                    lbsaltar.Text = tarfinal + "$";
                } 
            }
        }
        private void actgrid()
        {
            DataTable datos = da.consultat();
            dgsal.DataSource = datos.DefaultView;
        }
    }
}
