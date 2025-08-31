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
    public partial class Frm_RequisicaoTablet : Form
    {
        public Frm_RequisicaoTablet()
        {
            InitializeComponent();
        }

        private void requisicaoTabletsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requisicaoTabletsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);

        }

        private void Frm_RequisicaoTablet_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'bDPAPDataSet.Tablets' table. You can move, or remove it, as needed.
            this.tabletsTableAdapter.Fill(this.bDPAPDataSet.Tablets);
            // TODO: This line of code loads data into the 'bDPAPDataSet.FichaFuncionario' table. You can move, or remove it, as needed.
            this.fichaFuncionarioTableAdapter.Fill(this.bDPAPDataSet.FichaFuncionario);
            // TODO: This line of code loads data into the 'bDPAPDataSet.FichaAluno' table. You can move, or remove it, as needed.
            this.fichaAlunoTableAdapter.Fill(this.bDPAPDataSet.FichaAluno);
            // TODO: This line of code loads data into the 'bDPAPDataSet.RequisicaoTablets' table. You can move, or remove it, as needed.
            this.requisicaoTabletsTableAdapter.Fill(this.bDPAPDataSet.RequisicaoTablets);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.requisicaoTabletsBindingSource.AddNew();
            this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
        }

        private void btn_guardar_Click(object sender, EventArgs e)
        {
            if (this.Validate())
            {

                this.Validate();
                this.requisicaoTabletsBindingSource.EndEdit();
                this.tableAdapterManager.UpdateAll(this.bDPAPDataSet);
                MessageBox.Show("Registo Guardado com Sucesso!", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Ocorreu um erro!", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
