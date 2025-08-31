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
    public partial class Frm_menufilme : Form
    {
        public Frm_menufilme()
        {
            InitializeComponent();
        }

        private void Frm_menufilme_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.CategoriaFilmes' table. You can move, or remove it, as needed.
            this.categoriaFilmesTableAdapter.Fill(this.bDPAPDataSet.CategoriaFilmes);
            // TODO: This line of code loads data into the 'bDPAPDataSet.Filmes' table. You can move, or remove it, as needed.
            this.filmesTableAdapter.Fill(this.bDPAPDataSet.Filmes);
            // TODO: This line of code loads data into the 'bDPAPDataSet.CategoriaFilmes' table. You can move, or remove it, as needed.
            this.categoriaFilmesTableAdapter.Fill(this.bDPAPDataSet.CategoriaFilmes);
            // TODO: This line of code loads data into the 'bDPAPDataSet.Filmes' table. You can move, or remove it, as needed.
            this.filmesTableAdapter.Fill(this.bDPAPDataSet.Filmes);
            // TODO: esta linha de código carrega dados na tabela 'bDPAPDataSet.Filmes'. Você pode movê-la ou removê-la conforme necessário.
            this.filmesTableAdapter.Fill(this.bDPAPDataSet.Filmes);
            // TODO: This line of code loads data into the 'bDPAPDataSet.Filmes' table. You can move, or remove it, as needed.
            this.filmesTableAdapter.Fill(this.bDPAPDataSet.Filmes);

        }

        private void filmesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.filmesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Resgisto concluído com sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void filmesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.filmesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void filmesBindingNavigatorSaveItem_Click_2(object sender, EventArgs e)
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
            MessageBox.Show("Resgisto concluído com sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
