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
    public partial class Frm_MenuFuncionaria : Form
    {
        public Frm_MenuFuncionaria()
        {
            InitializeComponent();
        }

        private void fichaFuncionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaFuncionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_MenuFuncionaria_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDPAPDataSet.FichaFuncionario'. Você pode movê-la ou removê-la conforme necessário.
            this.fichaFuncionarioTableAdapter.Fill(this.bDPAPDataSet.FichaFuncionario);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                this.fichaFuncionarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
                MessageBox.Show("Resgisto concluído com sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
