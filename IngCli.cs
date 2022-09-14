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
    public partial class IngCli : Form
    {
        public IngCli()
        {
            InitializeComponent();            
        }
        int select=-1;
        CNeg.cNeg dat = new CNeg.cNeg();
        

        private void btselct_Click(object sender, EventArgs e)
        {
            if (select > -1)
            { 
                dat.Cedula= dgcli.Rows[select].Cells[0].Value.ToString();
                this.Close();
            }
            else MessageBox.Show("Seleccione cliente.","Advertencia");
        }

        private void dgcli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select=e.RowIndex;
            txCed.Text = dgcli.Rows[select].Cells[0].Value.ToString() ;
            txNom.Text = dgcli.Rows[select].Cells[1].Value.ToString() ;;
            txTel.Text = dgcli.Rows[select].Cells[2].Value.ToString(); ;
        }
        private void actgrid()
        {
            DataTable datos = dat.conscli();
            dgcli.DataSource = datos.DefaultView;
        }

        private void btsave_Click(object sender, EventArgs e)
        {
            if (txCed.Text != "" && txNom.Text != "" && txTel.Text != "") 
            {
                dat.ingrCl(txCed.Text, txNom.Text.ToUpper(), txTel.Text);
                actgrid();
            }
            else MessageBox.Show("Ingrese los datos del cliente.", "Advertencia");

        }

        private void IngCli_Load(object sender, EventArgs e)
        {
            actgrid();
        }
    }
}
