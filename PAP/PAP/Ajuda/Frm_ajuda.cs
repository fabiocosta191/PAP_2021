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
    public partial class Frm_ajuda : Form
    {
        public Frm_ajuda()
        {
            InitializeComponent();
        }

        private void btn_website_Click(object sender, EventArgs e)
        {
            //direciona para o website
            System.Diagnostics.Process.Start("https://suportesrbe.wixsite.com/suportesrbe");
        }
    }
}
