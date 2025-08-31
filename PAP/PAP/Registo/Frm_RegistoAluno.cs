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
    public partial class Frm_RegistoAluno : Form
    {
        public Frm_RegistoAluno()
        {
            InitializeComponent();

            //Fazer desaparecer os butoes 
            button1.Hide();
            button3.Hide();
        }
        
        
        private void fichaAlunoBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaAlunoBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
          
           

        }

        private void Frm_RegistoAluno_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.FichaAluno' table. You can move, or remove it, as needed.
            this.fichaAlunoTableAdapter.Fill(this.bDPAPDataSet.FichaAluno);

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {
                this.Validate();
                this.fichaAlunoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
                MessageBox.Show("Registo guardado com sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
          
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            
        }

        private void turmaTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_PesquisarAluno pesquisarAlunoRegisto = new Frm_PesquisarAluno();
            pesquisarAlunoRegisto.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaAlunoBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            //Fazer desaparecer os butoes 
            button1.Show();
            button3.Show();
            button2.Hide();

        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            //Campos Obrigatorios
            if (nomeTextBox.Text == "" && nCartaoTextBox.Text == "")
            {
                errorProvider1.SetError(nomeTextBox, "Preencha os campos obrigatorio");
                errorProvider2.SetError(nCartaoTextBox, "Preencha os campos obrigatorio");
                MessageBox.Show("Preencha todos os campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Warning);
               
            }
            else
            {
                this.Validate();
                this.fichaAlunoBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
                MessageBox.Show("Registo guardado com sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                button2.Show();
                button1.Hide();
                button3.Hide();
            }
        }

    

         private void button3_Click(object sender, EventArgs e)
        {
            Frm_PesquisarAluno pesquisarAluno = new Frm_PesquisarAluno();
            pesquisarAluno.Show();
        }

        private void nomeTextBox_TextChanged(object sender, EventArgs e)
        {
  
        }
    }
}
