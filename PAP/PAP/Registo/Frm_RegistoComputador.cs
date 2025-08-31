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
    public partial class Frm_RegistoComputador : Form
    {
        public Frm_RegistoComputador()
        {
            InitializeComponent();

            //Fazer desaparecer 
            button2.Hide();
     
        }

        private void computadoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.computadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_RegistoComputador_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.Computadores' table. You can move, or remove it, as needed.
            this.computadoresTableAdapter.Fill(this.bDPAPDataSet.Computadores);

        }

        private void toolStripButton7_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.computadoresBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
            MessageBox.Show("Registo guardado com sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            
        }

        private void button2_Click(object sender, EventArgs e)
        {
            //Campos Obrigatorios
            if (númeroTextBox.Text == "" )
            {
                errorProvider1.SetError(númeroTextBox, "Preencha o campo obrigatorio!");
                MessageBox.Show("Preencha todos os campos", "Alerta", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                this.Validate();
                this.computadoresBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
                MessageBox.Show("Registo guardado com sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                //Fazer desaparecer 
                button1.Show();

                //Fazer aparecer
                button2.Hide();
            }
        }

        private void númeroTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.computadoresBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

            //Fazer desaparecer 
            button1.Hide();
            //Fazer aparecer
            button2.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
