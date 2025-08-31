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
    public partial class Frm_RelatorioProfessor : Form
    {
        public Frm_RelatorioProfessor()
        {
            InitializeComponent();
        }

        private void Frm_RelatorioProfessor_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'BDPAPDataSet.FichaProfessores' table. You can move, or remove it, as needed.
            this.FichaProfessoresTableAdapter.Fill(this.BDPAPDataSet.FichaProfessores);

            this.reportViewer1.RefreshReport();
        }
    }
}
