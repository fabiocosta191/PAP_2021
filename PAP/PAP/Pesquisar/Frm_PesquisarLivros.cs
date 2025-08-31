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
    public partial class Frm_PesquisarLivros : Form
    {
        public Frm_PesquisarLivros()
        {
            InitializeComponent();
        }

        private void livrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.livrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_PesquisarLivros_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.Livros' table. You can move, or remove it, as needed.
            this.livrosTableAdapter.Fill(this.bDPAPDataSet.Livros);

        }

        private void radiobtn_filme_titulo_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            if (radiobtn_titulo_livro.Checked)
            {
                this.livrosTableAdapter.FillByPesquisarLivroTitulo(bDPAPDataSet.Livros, textBox1.Text);
            }
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
