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
            actgrid();
        }
        int select=-1;
        CNeg.cNeg dat = new CNeg.cNeg();
        private void btselct_Click(object sender, EventArgs e)
        {
            if (select > -1)
            {
                txCed.Text = "";
                txNom.Text = "";
                txTel.Text = "";
            }
            else MessageBox.Show("Seleccione cliente.","Advertencia");
        }

        private void dgcli_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            select=e.RowIndex;
        }
        private void actgrid()
        {
            DataTable datos = dat.conscli();
            dgcli.DataSource = datos.DefaultView;
        }
    }
}
