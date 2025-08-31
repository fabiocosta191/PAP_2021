using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Windows.Forms;
using System.Text.RegularExpressions;
using System.Net.Mail;

namespace PAP
{
    public partial class Frm_email : Form
    {
        public Frm_email()
        {
            InitializeComponent();
        }

        private void Frm_email_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            

            string para, remetente, pass, messagebody;
            MailMessage mensagem = new MailMessage();
            para = textBox_para.Text;
            remetente = "suporte.srbe@gmail.com";
            pass = "srbesrbe";
            messagebody = textBox_mensagem.Text;
            mensagem.To.Add(para);
            mensagem.From = new MailAddress(remetente);
            mensagem.Body = messagebody;
            mensagem.Subject = textBox_assunto.Text;
            mensagem.IsBodyHtml = true;
            SmtpClient smtp = new SmtpClient("smtp.gmail.com");
            smtp.EnableSsl = true;
            smtp.Port = 587;
            smtp.DeliveryMethod = SmtpDeliveryMethod.Network;
            smtp.Credentials = new NetworkCredential(remetente, pass);
            

            try
            {
                smtp.Send(mensagem);
                DialogResult code = MessageBox.Show("Email Enviado Com Sucesso", "Email Enviado", MessageBoxButtons.OK, MessageBoxIcon.Information);

                if (code == DialogResult.OK)
                {
                    textBox_assunto.Clear();
                    textBox_mensagem.Clear();
                    textBox_para.Clear();
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void textBox_para_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox_para_Leave(object sender, EventArgs e)
        {
          
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            Frm_PesquisarAluno pesquisaAlunoDevolucao = new Frm_PesquisarAluno();
            pesquisaAlunoDevolucao.Show();
        }
    }
    
}
