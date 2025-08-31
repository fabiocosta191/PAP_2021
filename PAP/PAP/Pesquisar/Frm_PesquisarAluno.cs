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
    public partial class Frm_PesquisarAluno : Form
    {
      

        public Frm_PesquisarAluno()
        {
            InitializeComponent();
        }

        private void fichaAlunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaAlunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_PesquisarAluno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.FichaAluno' table. You can move, or remove it, as needed.
            this.fichaAlunoTableAdapter.Fill(this.bDPAPDataSet.FichaAluno);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {   
            //codigo para pesquisar por nome
            if (radioButton1.Checked)
            {
                this.fichaAlunoTableAdapter.FillByPesquisarNomeAluno(bDPAPDataSet.FichaAluno, textBox1.Text);
            }

            //codigo para pesquisar por numero de cartão
            if (radiobtn_ncartao.Checked)
            {
                this.fichaAlunoTableAdapter.FillByPesquisarAlunoCartao(bDPAPDataSet.FichaAluno, textBox1.Text);
            }

            //1hora e 38 min resolvido
        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void radiobtn_ncartao_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
