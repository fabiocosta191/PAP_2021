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
    public partial class Frm_AcessorestritoDefinicoes : Form
    {
        public Frm_AcessorestritoDefinicoes()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

            if (textBox1.Text == "admin")
            { 
                Frm_definicoes definicoes = new Frm_definicoes();
                definicoes.Show();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Chave Errada!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }
    }
}
