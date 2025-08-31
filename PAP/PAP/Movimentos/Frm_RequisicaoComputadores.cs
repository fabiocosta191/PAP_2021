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
    public partial class Frm_RequisicaoComputadores : Form
    {
        public Frm_RequisicaoComputadores()
        {
            InitializeComponent();
        }

        private void requisicaoComputadorBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requisicaoComputadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void requisicaoComputadorBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.requisicaoComputadorBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_RequisicaoComputadores_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.Computadores' table. You can move, or remove it, as needed.
            this.computadoresTableAdapter.Fill(this.bDPAPDataSet.Computadores);
            // TODO: This line of code loads data into the 'bDPAPDataSet.FichaFuncionario' table. You can move, or remove it, as needed.
            this.fichaFuncionarioTableAdapter.Fill(this.bDPAPDataSet.FichaFuncionario);
            // TODO: This line of code loads data into the 'bDPAPDataSet.FichaAluno' table. You can move, or remove it, as needed.
            this.fichaAlunoTableAdapter.Fill(this.bDPAPDataSet.FichaAluno);
            // TODO: This line of code loads data into the 'bDPAPDataSet.RequisicaoComputador' table. You can move, or remove it, as needed.
            this.requisicaoComputadorTableAdapter.Fill(this.bDPAPDataSet.RequisicaoComputador);

        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {

                this.Validate();
                this.requisicaoComputadorBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
                MessageBox.Show("Registo Guardado com Sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requisicaoComputadorBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
        }
    }
}
