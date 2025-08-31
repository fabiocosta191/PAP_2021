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
    public partial class Frm_MenuCategoriaLivro : Form
    {
        public Frm_MenuCategoriaLivro()
        {
            InitializeComponent();
        }

        private void categoriaLivrosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaLivrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_MenuCategoriaLivro_Load(object sender, EventArgs e)
        {
            // TODO: esta linha de código carrega dados na tabela 'bDPAPDataSet.CategoriaLivros'. Você pode movê-la ou removê-la conforme necessário.
            this.categoriaLivrosTableAdapter.Fill(this.bDPAPDataSet.CategoriaLivros);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.categoriaLivrosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Resgisto concluído com sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

        }

        private void iDCategoriaLivrosLabel_Click(object sender, EventArgs e)
        {

        }
    }
}
