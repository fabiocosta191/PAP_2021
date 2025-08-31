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
    public partial class Frm_PesquisarProfessor : Form
    {
        public Frm_PesquisarProfessor()
        {
            InitializeComponent();
        }

        private void fichaProfessoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaProfessoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_PesquisarProfessor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.FichaProfessores' table. You can move, or remove it, as needed.
            this.fichaProfessoresTableAdapter.Fill(this.bDPAPDataSet.FichaProfessores);

        }

        private void fichaProfessoresDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void radiobtn_nome_prof_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radiobtn_nome_prof.Checked)
            {
               this.fichaProfessoresTableAdapter.FillByPesquisarProfessorNome(bDPAPDataSet.FichaProfessores, textBox1.Text);
            }

            //codigo para pesquisar por numero de cartão
            if (radiobtn_ncartao_prof.Checked)
            {
               this.fichaProfessoresTableAdapter.FillByPesquisarProfessorCartao(bDPAPDataSet.FichaProfessores, textBox1.Text);
            }
        }

        private void radiobtn_ncartao_prof_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
