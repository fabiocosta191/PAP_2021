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
    public partial class Frm_definicoes : Form
    {
        public Frm_definicoes()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void Frm_definicoes_Load(object sender, EventArgs e)
        {

        }

        private void btn_menueditora_Click(object sender, EventArgs e)
        {
            Frm_MenuEditora menuEditora = new Frm_MenuEditora();
            menuEditora.Show();
        }

        private void btn_menubackup_Click(object sender, EventArgs e)
        {
            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                System.IO.File.Copy(Application.StartupPath.ToString() + "\\BDPAP.mdb", saveFileDialog1.FileName);
                MessageBox.Show("Backup concluido com sucesso!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Backup Cancelado!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_menurestaurar_Click(object sender, EventArgs e)
        {
            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {
                if (System.IO.File.Exists(Application.StartupPath.ToString() + "\\BDPAP.mdb"))
                {
                    System.IO.File.Delete(Application.StartupPath.ToString() + "\\BDPAP.mdb");
                }
                System.IO.File.Copy(openFileDialog1.FileName, Application.StartupPath.ToString() + "\\BDPAP.mdb");
                MessageBox.Show("Restauro concluido com sucesso!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Restauro Cancelado!", "Backup", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btn_menucomputador_Click(object sender, EventArgs e)
        {
            Frm_menucomp menucomp = new Frm_menucomp();
            menucomp.Show();
        }

        private void btn_menulivros_Click(object sender, EventArgs e)
        {
            Frm_MenuLivro menuLivros = new Frm_MenuLivro();
            menuLivros.Show();
        }

        private void btn_menutablet_Click(object sender, EventArgs e)
        {
            Frm_menutablet menutablet = new Frm_menutablet();
            menutablet.Show();
        }

        private void btn_menufilme_Click(object sender, EventArgs e)
        {
            Frm_menufilme menufilme = new Frm_menufilme();
            menufilme.Show();
        }

        private void btn_menurelatoriolivros_Click(object sender, EventArgs e)
        {
            Frm_RelatorioLivro relatorioLivrodef = new Frm_RelatorioLivro();
            relatorioLivrodef.Show();
        }

        private void btn_menurelatoriotablet_Click(object sender, EventArgs e)
        {
            Frm_RelatorioTablet relatorioTabletdef = new Frm_RelatorioTablet();
            relatorioTabletdef.Show();
        }

        private void btn_menurelatoriocomputador_Click(object sender, EventArgs e)
        {
            Frm_RelatorioComputador relatorioComputadordef = new Frm_RelatorioComputador();
            relatorioComputadordef.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Frm_RelatorioTablet relatorioTabletdef = new Frm_RelatorioTablet();
            relatorioTabletdef.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Frm_RelatorioAluno relatorioalunodef = new Frm_RelatorioAluno();
            relatorioalunodef.Show();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            Frm_RelatorioProfessor relatorioprofdef = new Frm_RelatorioProfessor();
            relatorioprofdef.Show();
        }

        private void btn_menucategoria_Click(object sender, EventArgs e)
        {
            Frm_MenuCategorias menucategorias = new Frm_MenuCategorias();
            menucategorias.Show();
        }

        private void btn_menufuncionarios_Click(object sender, EventArgs e)
        {
            Frm_MenuFuncionaria menuFuncionaria = new Frm_MenuFuncionaria();
            menuFuncionaria.Show();
        }

        private void btn_menuprofessores_Click(object sender, EventArgs e)
        {
            Frm_MenuProfessores menuProfessores = new Frm_MenuProfessores();
            menuProfessores.Show();
        }

        private void btn_menualunos_Click(object sender, EventArgs e)
        {
            Frm_MenuAluno menuAluno = new Frm_MenuAluno();
            menuAluno.Show();
        }
    }
}
