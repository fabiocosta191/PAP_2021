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
    public partial class Frm_menutablet : Form
    {
        public Frm_menutablet()
        {
            InitializeComponent();
        }

        private void tabletsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabletsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_menutablet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.Tablets' table. You can move, or remove it, as needed.
            this.tabletsTableAdapter.Fill(this.bDPAPDataSet.Tablets);

        }

        private void toolStripButton14_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabletsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Resgisto concluído com sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
