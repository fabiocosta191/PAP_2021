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
    public partial class Frm_RegistoTablet : Form
    {
        public Frm_RegistoTablet()
        {
            InitializeComponent();

            //Fazer desaparecer
            button2.Hide();
            button1.Hide();
        }

        private void tabletsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabletsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_RegistoTablet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.Tablets' table. You can move, or remove it, as needed.
            this.tabletsTableAdapter.Fill(this.bDPAPDataSet.Tablets);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabletsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Registo guardado com sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            Frm_PesquisarTablet pesquisarTabletRegisto = new Frm_PesquisarTablet();
            pesquisarTabletRegisto.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.tabletsBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            //Fazer desaparecer
            button3.Hide();
            //Fazer aparecer
            button2.Show();
            button1.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Campos Obrigatorios
            if (modeloTextBox.Text == "" && númeroTextBox.Text =="")
            {
                errorProvider2.SetError(númeroTextBox, "Preencha os campos obrigatórios");
                errorProvider1.SetError(modeloTextBox, "Preencha os campos obrigatórios");
                MessageBox.Show("Preencha todos os campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Validate();
                this.tabletsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
                MessageBox.Show("Registo guardado com sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                //Fazer aparecer
                button3.Show();
                //Fazer desaparecer
                button2.Hide();
                button1.Hide();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_PesquisarTablet pesquisarTablet = new Frm_PesquisarTablet();
            pesquisarTablet.Show();
        }

        private void númeroTextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
