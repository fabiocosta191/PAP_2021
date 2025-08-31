using PAP;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PAP
{
    

    public partial class Frm_MenuPrincipal : Form
    {
       

        public Frm_MenuPrincipal()
        {
            InitializeComponent();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }

        private void Frm_MenuPrincipal_Load(object sender, EventArgs e)
        {
                    
        }


        private void ajudaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //direciona para a ajuda
            Frm_ajuda ajuda = new Frm_ajuda();
            ajuda.Show();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //direciona para as definições
            Frm_AcessorestritoDefinicoes def = new Frm_AcessorestritoDefinicoes();
            def.Show();
        }

        private void livrosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegistoLivros registolivro = new Frm_RegistoLivros();
            registolivro.Show();
        }

        private void tabletToolStripMenuItem_Click(object sender, EventArgs e)
        {
         Frm_RegistoTablet registoTablet = new Frm_RegistoTablet();
            registoTablet.Show();
        }

        private void tecnesaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //encaminha para o website
            System.Diagnostics.Process.Start("https://forms.gle/CYmZAVYuPTHDLCHp9");
        }

        private void registarToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void alunoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegistoAluno registoaluno = new Frm_RegistoAluno();
            registoaluno.Show();
        }

        private void professoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegistoProfessor registoProfessor = new Frm_RegistoProfessor();
            registoProfessor.Show();
        }

        private void editoraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }


        private void websiteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //direciona para o website
            System.Diagnostics.Process.Start("https://suportesrbe.wixsite.com/suportesrbe");
        }

        private void sugestõesToolStripMenuItem_Click(object sender, EventArgs e)
        {
           //direciona o utilizador para as sugestões do Website
            System.Diagnostics.Process.Start("https://suportesrbe.wixsite.com/suportesrbe/sugest%C3%A3o");
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            //direciona para o website
            System.Diagnostics.Process.Start("https://suportesrbe.wixsite.com/suportesrbe");
        }

        private void filmesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RegistoFilme registoFilme = new Frm_RegistoFilme();
            registoFilme.Show();
        }

        private void terminarSessãoToolStripMenuItem_Click(object sender, EventArgs e)
        {

            if (MessageBox.Show("Deseja terminar sessão?", "Terminar sessão", MessageBoxButtons.YesNo, MessageBoxIcon.Information, MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            {         
                //direciona novamente para o formulario login
                Frm_LoginFuncionario loginout = new Frm_LoginFuncionario();
                loginout.Show();

                //fecha o formulario anterior
                this.Visible = false;
            }
            

            
        }

        private void minimizarToolStripMenuItem_Click(object sender, EventArgs e)
        {
            // serve para redimensionar o formulário
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
            {
                this.WindowState = FormWindowState.Maximized;
            }
        }

        private void minimizarToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //serve para minimizar o formulario
            this.WindowState = FormWindowState.Minimized;
        }

        private void menuStrip2_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void sairToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            //Mensagem a perguntar a confirmação se quer sair ou não
            if (MessageBox.Show("Deseja sair da aplicação?", "Sair", MessageBoxButtons.YesNo, MessageBoxIcon.Information,MessageBoxDefaultButton.Button1) == DialogResult.Yes)
            //serve para fechar a aplicação
            Application.Exit();
        }

        private void computadorToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Frm_RegistoComputador registoComputador = new Frm_RegistoComputador();
            registoComputador.Show();
        }

        private void label1_Click(object sender, EventArgs e)
        {
           
        }

        private void alunosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void backupToolStripMenuItem_Click(object sender, EventArgs e)
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

        private void livroToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_RelatorioLivro relatorioLivro = new Frm_RelatorioLivro();
            relatorioLivro.Show();
        }

        private void tabletToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_RelatorioTablet relatorioTablet = new Frm_RelatorioTablet();
            relatorioTablet.Show();
        }

        private void computadorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RelatorioComputador relatorioComputador = new Frm_RelatorioComputador();
            relatorioComputador.Show();
        }

        private void alunoToolStripMenuItem2_Click(object sender, EventArgs e)
        {
            Frm_RelatorioAluno relatorioAluno = new Frm_RelatorioAluno();
            relatorioAluno.Show();
        }

        private void professorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RelatorioProfessor relatorioProfessor = new Frm_RelatorioProfessor();
            relatorioProfessor.Show();
        }

        private void filmeToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_RelatorioFilme relatorioFilme = new Frm_RelatorioFilme();
            relatorioFilme.Show();
        }

        private void alunoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_PesquisarAluno pesquisarAluno = new Frm_PesquisarAluno();
            pesquisarAluno.Show();
        }

        private void livroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PesquisarLivros pesquisarLivros = new Frm_PesquisarLivros();
            pesquisarLivros.Show();
        }

        private void professorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_PesquisarProfessor pesquisarProfessor = new Frm_PesquisarProfessor();
            pesquisarProfessor.Show();
        }

        private void editoraToolStripMenuItem1_Click(object sender, EventArgs e)
        {
         
        }

        private void tabletToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_PesquisarTablet pesquisarTablet = new Frm_PesquisarTablet();
            pesquisarTablet.Show();
        }

        private void filmeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_PesquisarFilme pesquisarFilme = new Frm_PesquisarFilme();
            pesquisarFilme.Show();
        }

        private void contactoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //direciona para o website
            System.Diagnostics.Process.Start("https://suportesrbe.wixsite.com/suportesrbe/contato");
        }

        private void filmeToolStripMenuItem1_Click_1(object sender, EventArgs e)
        {
            Frm_RelatorioFilme relatorioFilme = new Frm_RelatorioFilme();
            relatorioFilme.Show();
        }

        private void livrosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            FrmRequisicaoLivros frmRequisicaoLivros = new FrmRequisicaoLivros();
            frmRequisicaoLivros.Show();
        }

        private void livrosToolStripMenuItem2_Click(object sender, EventArgs e)
        {

        }

        private void emailToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_email email = new Frm_email();
            email.Show();
        }

        private void computadoresToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RequisicaoComputadores requisicaoComputadores = new Frm_RequisicaoComputadores();
            requisicaoComputadores.Show();
        }

        private void wordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            System.Diagnostics.Process.Start(@"C:\Users\LaWer\Desktop\Autoavaliação módulo 9 Luis.docx");
            
        }

        private void tabletsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Frm_RequisicaoTablet requisicaoTablet = new Frm_RequisicaoTablet();
            requisicaoTablet.Show();
        }

        private void livrosToolStripMenuItem2_Click_1(object sender, EventArgs e)
        {
            Frm_RelatorioRequisicaoLivros relatorioRequisicaoLivros = new Frm_RelatorioRequisicaoLivros();
            relatorioRequisicaoLivros.Show();
        }

        private void relatoriosToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void computadoresToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_RelatorioRequisicaoComputadores requisicaoComputadores = new Frm_RelatorioRequisicaoComputadores();
            requisicaoComputadores.Show();
        }

        private void tabletsToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Frm_RelatorioRequisicaoTablet relatorioRequisicaoTablet = new Frm_RelatorioRequisicaoTablet();
            relatorioRequisicaoTablet.Show();
        }
    }   
}
