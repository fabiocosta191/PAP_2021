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
    public partial class Frm_MenuProfessores : Form
    {
        public Frm_MenuProfessores()
        {
            InitializeComponent();
        }

        private void fichaProfessoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaProfessoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_MenuProfessores_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDPAPDataSet.FichaProfessores'. Você pode movê-la ou removê-la conforme necessário.
            this.fichaProfessoresTableAdapter.Fill(this.bDPAPDataSet.FichaProfessores);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaProfessoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Resgisto concluído com sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void contactoLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
