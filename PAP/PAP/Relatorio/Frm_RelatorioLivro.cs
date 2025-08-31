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
    public partial class Frm_RelatorioLivro : Form
    {
        public Frm_RelatorioLivro()
        {
            InitializeComponent();
        }

        private void Frm_RelatorioLivro_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDPAPDataSet.Livros' table. You can move, or remove it, as needed.
            this.LivrosTableAdapter.Fill(this.BDPAPDataSet.Livros);
            // TODO: This line of code loads data into the 'BDPAPDataSet.Livros' table. You can move, or remove it, as needed.
            this.LivrosTableAdapter.Fill(this.BDPAPDataSet.Livros);

            this.reportViewer1.RefreshReport();
            this.reportViewer1.RefreshReport();
        }
    }
}
