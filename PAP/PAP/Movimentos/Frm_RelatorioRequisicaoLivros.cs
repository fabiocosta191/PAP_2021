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
    public partial class Frm_RelatorioRequisicaoLivros : Form
    {
        public Frm_RelatorioRequisicaoLivros()
        {
            InitializeComponent();
        }

        private void Frm_RelatorioRequisicaoLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.bDPAPDataSet.Livros);
            // TODO: This line of code loads data into the 'bDPAPDataSet.FichaFuncionario' table. You can move, or remove it, as needed.
            this.fichaFuncionarioTableAdapter.Fill(this.bDPAPDataSet.FichaFuncionario);
            // TODO: This line of code loads data into the 'bDPAPDataSet.FichaAluno' table. You can move, or remove it, as needed.
            this.fichaAlunoTableAdapter.Fill(this.bDPAPDataSet.FichaAluno);
            // TODO: This line of code loads data into the 'bDPAPDataSet.Requisicao' table. You can move, or remove it, as needed.
            this.requisicaoTableAdapter.Fill(this.bDPAPDataSet.Requisicao);
            // TODO: This line of code loads data into the 'bDPAPDataSet.EditoraLivros' table. You can move, or remove it, as needed.


            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaAlunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Registo guardado com sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void livrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void requisicaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requisicaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.requisicaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Registo guardado com sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
