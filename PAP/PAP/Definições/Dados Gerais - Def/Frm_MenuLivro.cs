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
    public partial class Frm_MenuLivro : Form
    {
        public Frm_MenuLivro()
        {
            InitializeComponent();
        }

        private void livrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_MenuLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.CategoriaLivros' table. You can move, or remove it, as needed.
            this.categoriaLivrosTableAdapter.Fill(this.bDPAPDataSet.CategoriaLivros);
            // TODO: This line of code loads data into the 'bDPAPDataSet.EditoraLivros' table. You can move, or remove it, as needed.
            this.editoraLivrosTableAdapter.Fill(this.bDPAPDataSet.EditoraLivros);
            // TODO: This line of code loads data into the 'bDPAPDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.bDPAPDataSet.Livros);
            // TODO: This line of code loads data into the 'bDPAPDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.bDPAPDataSet.Livros);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Resgisto concluído com sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void livrosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void toolStripButton7_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Resgisto concluído com sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
