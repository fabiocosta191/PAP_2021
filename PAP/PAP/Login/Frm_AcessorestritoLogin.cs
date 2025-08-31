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
    public partial class Frm_AcessorestritoLogin : Form
    {
        public Frm_AcessorestritoLogin()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Visible = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "admin") //&& textBox1.Text != "func")
            {
                Frm_NovoRegistoFuncionario novologin = new Frm_NovoRegistoFuncionario();
                novologin.Show();
                this.Validate();
                this.Validate();
                this.Visible = false;
            }
            else
            {
                MessageBox.Show("Chave Errada!", "Acesso Negado", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
         
        }

        private void fichaFuncionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
        
        }

        private void Frm_AcessorestritoLogin_Load(object sender, EventArgs e)
        {

        }
    }
}
