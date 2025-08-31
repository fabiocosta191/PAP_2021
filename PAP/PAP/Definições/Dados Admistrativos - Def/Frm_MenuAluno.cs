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
    public partial class Frm_MenuAluno : Form
    {
        public Frm_MenuAluno()
        {
            InitializeComponent();
        }

        private void fichaAlunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaAlunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_MenuAluno_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDPAPDataSet.FichaAluno'. Você pode movê-la ou removê-la conforme necessário.
            this.fichaAlunoTableAdapter.Fill(this.bDPAPDataSet.FichaAluno);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaAlunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Resgisto concluído com sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
        }
    }
}
