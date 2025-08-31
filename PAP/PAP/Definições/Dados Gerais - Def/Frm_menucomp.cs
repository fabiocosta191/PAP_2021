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
    public partial class Frm_menucomp : Form
    {
        public Frm_menucomp()
        {
            InitializeComponent();
        }

        private void computadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.computadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_menucomp_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.Computadores' table. You can move, or remove it, as needed.
            this.computadoresTableAdapter.Fill(this.bDPAPDataSet.Computadores);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.computadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Resgisto concluído com sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
