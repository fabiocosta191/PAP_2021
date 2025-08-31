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
    public partial class Frm_PesquisarFilme : Form
    {
        public Frm_PesquisarFilme()
        {
            InitializeComponent();
        }

        private void filmesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_PesquisarFilme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.CategoriaFilmes' table. You can move, or remove it, as needed.
            this.categoriaFilmesTableAdapter.Fill(this.bDPAPDataSet.CategoriaFilmes);
            // TODO: This line of code loads data into the 'bDPAPDataSet.Filmes' table. You can move, or remove it, as needed.
            this.filmesTableAdapter.Fill(this.bDPAPDataSet.Filmes);
            // TODO: This line of code loads data into the 'bDPAPDataSet.Filmes' table. You can move, or remove it, as needed.
            this.filmesTableAdapter.Fill(this.bDPAPDataSet.Filmes);

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            //codigo para pesquisar por nome
            if (radiobtn_filme_titulo.Checked)
            {
                this.filmesTableAdapter.FillByPesquisarFilmeTitulo(bDPAPDataSet.Filmes, textBox1.Text);
            }

            //codigo para pesquisar por numero de cartão
            if (radiobtn_filme_produtora.Checked)
            {
                this.filmesTableAdapter.FillByPesquisarFilmesProdutora(bDPAPDataSet.Filmes, textBox1.Text);
            }

            //1hora e 38 min resolvido
        }

        private void radiobtn_filme_titulo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void filmesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.filmesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }
    }
    
}
