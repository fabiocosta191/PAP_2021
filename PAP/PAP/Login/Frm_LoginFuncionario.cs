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
    public partial class Frm_LoginFuncionario : Form
    {
        public Frm_LoginFuncionario()
        {
            InitializeComponent();

        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            int result = this.fichaFuncionarioTableAdapter.FillByLoginFuncionario(bDPAPDataSet.FichaFuncionario, textBox_login.Text, textBox_password.Text);


            if (result == 1)
            {
                if (textBox_login.Text == " " && textBox_password.Text == " ")
                {
                    MessageBox.Show("Usuário e/ou Password Inválido/s, contacte o admistrador ou o fornecedor da aplicação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }

                //direcionaro usuario ao menu principal
                Frm_MenuPrincipal menuprincipal = new Frm_MenuPrincipal();
                menuprincipal.Show();

                //esconder o formulário login
                this.Visible = false;

                MessageBox.Show("Dados válidados com sucesso", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);
                textBox_password.Clear();
                textBox_login.Clear();

            }
            else
            {
                //mensagem de erro
                MessageBox.Show("Usuário e/ou Password Inválido/s, contacte o admistrador ou o fornecedor da aplicação", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);

                //limpar caixas de texto do menu login
            }
         }
    

        private void linkLabel_registar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            //direcionar o usuario ao novo registo
            Frm_AcessorestritoLogin novoRegistoFuncionario = new Frm_AcessorestritoLogin();
            novoRegistoFuncionario.Show();
            this.Visible = false;
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            //Mensagem a perguntar a confirmação se quer sair ou não
            if (MessageBox.Show("Deseja sair da aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)

                //Fechar aplicação
                Application.Exit();
        }

        private void fichaFuncionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaFuncionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void fichaFuncionarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaFuncionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_LoginFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.FichaFuncionario' table. You can move, or remove it, as needed.
            this.fichaFuncionarioTableAdapter.Fill(this.bDPAPDataSet.FichaFuncionario);

        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {
            if (textBox_login.Text =="'")
            {
                textBox_login.Clear();
            }
        }
        private void textBox_password_TextChanged(object sender, EventArgs e)
        {
            if (textBox_password.Text == "'")
            {
                textBox_password.Clear();
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void button3_Click(object sender, EventArgs e)
        {
            //direciona para o website
            System.Diagnostics.Process.Start("https://suportesrbe.wixsite.com/suportesrbe/ajuda");
        }

        private void btn_login_KeyPress(object sender, KeyPressEventArgs e)
        {

        }

        private void textBox_password_Enter(object sender, EventArgs e)
        {

        }

        private void textBox_login_Enter(object sender, EventArgs e)
        {

        }

        private void fichaFuncionarioBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
