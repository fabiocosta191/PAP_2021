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
    public partial class Frm_MenuCategorias : Form
    {
        public Frm_MenuCategorias()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_MenuCategoriaLivro menuCategoriaLivro = new Frm_MenuCategoriaLivro();
            menuCategoriaLivro.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_MenuCategoriaFilme menuCategoriaFilme = new Frm_MenuCategoriaFilme();
            menuCategoriaFilme.Show();
        }
    }
}
