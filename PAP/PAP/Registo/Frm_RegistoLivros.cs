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
    public partial class Frm_RegistoLivros : Form
    {
        public Frm_RegistoLivros()
        {
            InitializeComponent();

            //Fazer desaparecer 
            button2.Hide();
            button1.Hide();
        }

        private void livrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_RegistoLivros_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDPAPDataSet.CategoriaLivros'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaLivrosTableAdapter.Fill(this.bDPAPDataSet.CategoriaLivros);
            // TODO: esta linha de código carrega dados na tabela 'bDPAPDataSet.EditoraLivros'. Você pode movê-la ou removê-la conforme necessário.
            this.editoraLivrosTableAdapter.Fill(this.bDPAPDataSet.EditoraLivros);
            // TODO: This line of code loads data into the 'bDPAPDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.bDPAPDataSet.Livros);
            // TODO: This line of code loads data into the 'bDPAPDataSet.Filmes' table. You can move, or remove it, as needed.
            this.filmesTableAdapter.Fill(this.bDPAPDataSet.Filmes);
            // TODO: This line of code loads data into the 'bDPAPDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.bDPAPDataSet.Livros);

        }

        private void fotoPictureBox_Click(object sender, EventArgs e)
        {

        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
        }

        private void livrosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Registo guardado com sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_PesquisarLivros pesquisarLivrosRegisto = new Frm_PesquisarLivros();
            pesquisarLivrosRegisto.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

            //Fazer desaparecer 
            button3.Hide();
            //Fazer aparecer 
            button2.Show();
            button1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (títuloTextBox.Text == "" && comboBox1.Text == "" && autorTextBox.Text == "" && codigo_EANTextBox.Text =="" && comboBox2.Text == "")
            {
                errorProvider1.SetError(títuloTextBox, "Preencha os campos obrigatórios");
                errorProvider2.SetError(comboBox1, "Preencha os campos obrigatórios");
                errorProvider3.SetError(autorTextBox, "Preencha os campos obrigatórios");
                errorProvider4.SetError(codigo_EANTextBox, "Preencha os campos obrigatórios");
                errorProvider5.SetError(comboBox2, "Preencha os campos obrigatórios");
                MessageBox.Show("Preencha todos os campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Validate();
                this.livrosBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
                MessageBox.Show("Registo guardado com sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Fazer desaparecer 
                button3.Show();
                //Fazer aparecer 
                button2.Hide();
                button1.Hide();
            }


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_PesquisarLivros pesquisarLivros = new Frm_PesquisarLivros();
            pesquisarLivros.Show();
        }
    }
}
