using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAP
{
    public partial class Frm_RelatorioComputador : Form
    {
        public Frm_RelatorioComputador()
        {
            InitializeComponent();
        }

        private void Frm_RelatorioComputador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDPAPDataSet.Computadores' table. You can move, or remove it, as needed.
            this.ComputadoresTableAdapter.Fill(this.BDPAPDataSet.Computadores);

            this.reportViewer1.RefreshReport();
        }
    }
}
