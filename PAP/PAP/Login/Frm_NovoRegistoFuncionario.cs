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
    public partial class Frm_NovoRegistoFuncionario : Form
    {
        public Frm_NovoRegistoFuncionario()
        {
            //Desaparecer os botões 
            InitializeComponent();
            btn_registar.Hide();
            label_usuario.Hide();
            pictureBox2.Hide();
            textbox_login.Hide();
            label_password.Hide();
            textbox_password.Hide();
            btn_imagempassword.Hide();
            btn_imagemcartão.Hide();
            label_Ncartao.Hide();
            textbox_ncartao.Hide();
        }

        private void btn_registar_Click(object sender, EventArgs e)
        {
            //Processo do Registo Funcionario
            if (textbox_login.Text == "" && textbox_ncartao.Text == "" && textbox_password.Text == "")
            {
                errorProvider1.SetError(textbox_login, "Preencha todos os campos");
                errorProvider2.SetError(textbox_ncartao, "Preencha todos os campos");
                errorProvider3.SetError(textbox_password, "Preencha todos os campos");
                
            }
            else
            {
                this.Validate();
                this.fichaFuncionarioBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

                Frm_LoginFuncionario loginFuncionario = new Frm_LoginFuncionario();
                loginFuncionario.Show();
                this.Visible = false;

                MessageBox.Show("Registo Guardado Com Sucesso", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }

          
        }

        private void btn_voltarlogin_Click(object sender, EventArgs e)
        {
            Frm_LoginFuncionario loginFuncionario = new Frm_LoginFuncionario();
            loginFuncionario.Show();
            this.Visible = false;
        }

        private void btn_novofuncionario_Click(object sender, EventArgs e)
        {
            
            this.Validate();
            this.fichaFuncionarioBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

            //Aparecer os bootões
            btn_novofuncionario.Hide();
            btn_registar.Show();
            label_usuario.Show();
            pictureBox2.Show();
            textbox_login.Show();
            label_password.Show();
            textbox_password.Show();
            btn_imagempassword.Show();
            btn_imagemcartão.Show();
            label_Ncartao.Show();
            textbox_ncartao.Show();
        }

        private void fichaFuncionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaFuncionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_NovoRegistoFuncionario_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.FichaFuncionario' table. You can move, or remove it, as needed.
            this.fichaFuncionarioTableAdapter.Fill(this.bDPAPDataSet.FichaFuncionario);

        }
    }
}
