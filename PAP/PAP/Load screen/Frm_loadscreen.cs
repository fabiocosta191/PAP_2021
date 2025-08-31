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

    public partial class Frm_loadscreen : Form
    {
        public Frm_loadscreen()
        {
            InitializeComponent();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void progressBar1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_loadscreen_Load(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            //se a barra concluir o processo vai abrir o novo menu, senão vai fechar a aplicação
            if (progressBar1.Value < 100)
            {
                progressBar1.Value = progressBar1.Value + 2;
            }
            else
            {
                timer1.Enabled = false;
                //novo formulário
                Frm_LoginFuncionario login = new Frm_LoginFuncionario();
                login.Show();

                //fecha o formulário aberto
                this.Visible = false;
            }
        }
    } 
        
}
