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
    public partial class Frm_RelatorioRequisicaoComputadores : Form
    {
        public Frm_RelatorioRequisicaoComputadores()
        {
            InitializeComponent();
        }

        private void requisicaoComputadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requisicaoComputadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_RelatorioRequisicaoComputadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.FichaFuncionario' table. You can move, or remove it, as needed.
            this.fichaFuncionarioTableAdapter.Fill(this.bDPAPDataSet.FichaFuncionario);
            // TODO: This line of code loads data into the 'bDPAPDataSet.FichaAluno' table. You can move, or remove it, as needed.
            this.fichaAlunoTableAdapter.Fill(this.bDPAPDataSet.FichaAluno);
            // TODO: This line of code loads data into the 'bDPAPDataSet.RequisicaoComputador' table. You can move, or remove it, as needed.
            this.requisicaoComputadorTableAdapter.Fill(this.bDPAPDataSet.RequisicaoComputador);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requisicaoComputadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Registo guardado com sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
