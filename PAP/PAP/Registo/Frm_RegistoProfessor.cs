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
    public partial class Frm_RegistoProfessor : Form
    {
        public Frm_RegistoProfessor()
        {
            InitializeComponent();

            //Fazer desaparecer 
            button1.Hide();
            button2.Hide();

        }

        private void fichaProfessoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaProfessoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_RegistoProfessor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.FichaProfessores' table. You can move, or remove it, as needed.
            this.fichaProfessoresTableAdapter.Fill(this.bDPAPDataSet.FichaProfessores);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaProfessoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Registo guardado com sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton2_Click_1(object sender, EventArgs e)
        {
            Frm_PesquisarProfessor pesquisarProfessorRegisto = new Frm_PesquisarProfessor();
            pesquisarProfessorRegisto.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_PesquisarProfessor pesquisarProfessor = new Frm_PesquisarProfessor();
            pesquisarProfessor.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaProfessoresBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

            //Fazer desaparecer 
            button1.Show();
            button2.Show();
            //Fazer aparecer
            button3.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Campos Obrigatorios
            if (nomeTextBox.Text == "" && nCartãoTextBox.Text == "")
            {
                errorProvider1.SetError(nomeTextBox, "Preencha os campos obrigatorio");
                errorProvider2.SetError(nCartãoTextBox, "Preencha os campos obrigatorio");
                MessageBox.Show("Preencha todos os campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Validate();
                this.fichaProfessoresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
                MessageBox.Show("Registo guardado com sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Fazer desaparecer 
                button1.Hide();
                button2.Hide();
                //Fazer aparecer
                button3.Show();
            }
        }
    }
}
