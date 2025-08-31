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
    public partial class FrmRequisicaoLivros : Form
    {
 
        public FrmRequisicaoLivros()
        {
            InitializeComponent();
        }

        private void AlterarData()
        {
            data_de_saídaDateTimePicker.Text = DateTime.Now.ToShortDateString();
            data_de_entregaDateTimePicker.Text = DateTime.Now.AddDays(15).ToShortDateString();
        }

        private void requisicaoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requisicaoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void FrmRequisicaoLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDPAPDataSet.Livros'. Você pode movê-la ou removê-la conforme necessário.
            this.livrosTableAdapter.Fill(this.bDPAPDataSet.Livros);
            // TODO: esta linha de código carrega dados na tabela 'bDPAPDataSet.FichaFuncionario'. Você pode movê-la ou removê-la conforme necessário.
            this.fichaFuncionarioTableAdapter.Fill(this.bDPAPDataSet.FichaFuncionario);
            // TODO: esta linha de código carrega dados na tabela 'bDPAPDataSet.FichaAluno'. Você pode movê-la ou removê-la conforme necessário.
            this.fichaAlunoTableAdapter.Fill(this.bDPAPDataSet.FichaAluno);
            // TODO: esta linha de código carrega dados na tabela 'bDPAPDataSet.Requisicao'. Você pode movê-la ou removê-la conforme necessário.
            this.requisicaoTableAdapter.Fill(this.bDPAPDataSet.Requisicao);
            AlterarData();

        }

        private void bindingNavigatorAddNewItem_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requisicaoBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                
                this.Validate();
                this.requisicaoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
                MessageBox.Show("Registo Guardado com Sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_PesquisarLivros pesquisarLivros = new Frm_PesquisarLivros();
            pesquisarLivros.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
    
        }

        private void button4_Click(object sender, EventArgs e)
        {
            Frm_PesquisarAluno pesquisaAlunoDevolucao = new Frm_PesquisarAluno();
            pesquisaAlunoDevolucao.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
           
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Frm_PesquisarAluno pesquisarAluno = new Frm_PesquisarAluno();
            pesquisarAluno.Show();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.requisicaoBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
        }
    }
}
