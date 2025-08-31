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
    public partial class Frm_RegistoFilme : Form
    {
        public Frm_RegistoFilme()
        {
            InitializeComponent();

            //Fazer desaparecer 
            button2.Hide();
            button1.Hide();
        }

        private void filmesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
        }

        private void Frm_RegistoFilme_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDPAPDataSet.CategoriaFilmes'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaFilmesTableAdapter.Fill(this.bDPAPDataSet.CategoriaFilmes);
            // TODO: This line of code loads data into the 'bDPAPDataSet.Filmes' table. You can move, or remove it, as needed.
            this.filmesTableAdapter.Fill(this.bDPAPDataSet.Filmes);
            // TODO: This line of code loads data into the 'bDPAPDataSet.Filmes' table. You can move, or remove it, as needed.
            this.filmesTableAdapter.Fill(this.bDPAPDataSet.Filmes);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmesBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
        }

        private void filmesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.filmesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

         
        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.filmesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Registo guardado com sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_PesquisarFilme pesquisarFilmeRegisto = new Frm_PesquisarFilme();
            pesquisarFilmeRegisto.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {

            //Campos Obrigatorios
            if (tituloTextBox.Text == "" && comboBox1.Text == "" && produtoraTextBox.Text == "")
            {
                errorProvider1.SetError(tituloTextBox, "Prencha os campos obrigatorio");
                errorProvider2.SetError(comboBox1, "Prencha os campos obrigatorio");
                errorProvider3.SetError(produtoraTextBox, "Preencha os campos obrigatorios");
                MessageBox.Show("Preencha todos os campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Validate();
                this.filmesBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
                MessageBox.Show("Registo guardado com sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Fazer aparecer 
                button2.Hide();
                button1.Hide();
                //Fazer desaparecer
                button3.Show();

            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_PesquisarFilme pesquisarFilme = new Frm_PesquisarFilme();
            pesquisarFilme.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmesBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

            //Fazer aparecer 
            button2.Show();
            button1.Show();
            //Fazer desaparecer
            button3.Hide();
        }
    }
}
