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
    public partial class Frm_login : Form
    {
        public Frm_login()
        {
            InitializeComponent();
        }

        private void btn_sair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void linkLabel_registar_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Frm_AcessorestritoLogin restritologin = new Frm_AcessorestritoLogin();
            restritologin.Show();
        }

        private void btn_login_Click(object sender, EventArgs e)
        {
  

        private void fichaFuncionarioBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaFuncionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.BDPAPDataSet);

        }

        private void fichaFuncionarioBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.fichaFuncionarioBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.BDPAPDataSet);

        }

        private void Frm_login_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPapTesteDataSet.FichaFuncionario' table. You can move, or remove it, as needed.
            this.fichaFuncionarioTableAdapter.Fill(this.BDPAPDataSet.FichaFuncionario);

        }
    }
}
