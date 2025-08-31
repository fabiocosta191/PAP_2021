
namespace PAP
{
    partial class Frm_definicoes
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_definicoes));
            this.btn_menualunos = new System.Windows.Forms.Button();
            this.btn_menucomputador = new System.Windows.Forms.Button();
            this.btn_menurelatoriocomputador = new System.Windows.Forms.Button();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.btn_menueditora = new System.Windows.Forms.Button();
            this.btn_menucategoria = new System.Windows.Forms.Button();
            this.btn_menufilme = new System.Windows.Forms.Button();
            this.btn_menulivros = new System.Windows.Forms.Button();
            this.btn_menutablet = new System.Windows.Forms.Button();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.btn_menuprofessores = new System.Windows.Forms.Button();
            this.btn_menufuncionarios = new System.Windows.Forms.Button();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.btn_menurelatoriolivros = new System.Windows.Forms.Button();
            this.btn_menurelatoriotablet = new System.Windows.Forms.Button();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.btn_menurestaurar = new System.Windows.Forms.Button();
            this.btn_menubackup = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.tabControl1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_menualunos
            // 
            this.btn_menualunos.BackColor = System.Drawing.Color.White;
            this.btn_menualunos.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menualunos.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menualunos.Location = new System.Drawing.Point(376, 54);
            this.btn_menualunos.Name = "btn_menualunos";
            this.btn_menualunos.Size = new System.Drawing.Size(154, 67);
            this.btn_menualunos.TabIndex = 2;
            this.btn_menualunos.Text = "Menu Alunos";
            this.btn_menualunos.UseVisualStyleBackColor = false;
            this.btn_menualunos.Click += new System.EventHandler(this.btn_menualunos_Click);
            // 
            // btn_menucomputador
            // 
            this.btn_menucomputador.BackColor = System.Drawing.Color.White;
            this.btn_menucomputador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menucomputador.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menucomputador.Location = new System.Drawing.Point(371, 18);
            this.btn_menucomputador.Name = "btn_menucomputador";
            this.btn_menucomputador.Size = new System.Drawing.Size(154, 63);
            this.btn_menucomputador.TabIndex = 5;
            this.btn_menucomputador.Text = "Menu Computador";
            this.btn_menucomputador.UseVisualStyleBackColor = false;
            this.btn_menucomputador.Click += new System.EventHandler(this.btn_menucomputador_Click);
            // 
            // btn_menurelatoriocomputador
            // 
            this.btn_menurelatoriocomputador.BackColor = System.Drawing.Color.White;
            this.btn_menurelatoriocomputador.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menurelatoriocomputador.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menurelatoriocomputador.Location = new System.Drawing.Point(370, 17);
            this.btn_menurelatoriocomputador.Name = "btn_menurelatoriocomputador";
            this.btn_menurelatoriocomputador.Size = new System.Drawing.Size(175, 65);
            this.btn_menurelatoriocomputador.TabIndex = 7;
            this.btn_menurelatoriocomputador.Text = "Relatório Computador";
            this.btn_menurelatoriocomputador.UseVisualStyleBackColor = false;
            this.btn_menurelatoriocomputador.Click += new System.EventHandler(this.btn_menurelatoriocomputador_Click);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Controls.Add(this.tabPage3);
            this.tabControl1.Location = new System.Drawing.Point(12, 85);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(556, 199);
            this.tabControl1.TabIndex = 4;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage2.Controls.Add(this.btn_menueditora);
            this.tabPage2.Controls.Add(this.btn_menucategoria);
            this.tabPage2.Controls.Add(this.btn_menufilme);
            this.tabPage2.Controls.Add(this.btn_menulivros);
            this.tabPage2.Controls.Add(this.btn_menutablet);
            this.tabPage2.Controls.Add(this.btn_menucomputador);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(548, 168);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Dados Gerais";
            // 
            // btn_menueditora
            // 
            this.btn_menueditora.BackColor = System.Drawing.Color.White;
            this.btn_menueditora.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menueditora.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menueditora.Location = new System.Drawing.Point(371, 99);
            this.btn_menueditora.Name = "btn_menueditora";
            this.btn_menueditora.Size = new System.Drawing.Size(154, 63);
            this.btn_menueditora.TabIndex = 11;
            this.btn_menueditora.Text = "Menu Editora";
            this.btn_menueditora.UseVisualStyleBackColor = false;
            this.btn_menueditora.Click += new System.EventHandler(this.btn_menueditora_Click);
            // 
            // btn_menucategoria
            // 
            this.btn_menucategoria.BackColor = System.Drawing.Color.White;
            this.btn_menucategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menucategoria.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menucategoria.Location = new System.Drawing.Point(196, 99);
            this.btn_menucategoria.Name = "btn_menucategoria";
            this.btn_menucategoria.Size = new System.Drawing.Size(154, 63);
            this.btn_menucategoria.TabIndex = 10;
            this.btn_menucategoria.Text = "Menu Categoria";
            this.btn_menucategoria.UseVisualStyleBackColor = false;
            this.btn_menucategoria.Click += new System.EventHandler(this.btn_menucategoria_Click);
            // 
            // btn_menufilme
            // 
            this.btn_menufilme.BackColor = System.Drawing.Color.White;
            this.btn_menufilme.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menufilme.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menufilme.Location = new System.Drawing.Point(21, 99);
            this.btn_menufilme.Name = "btn_menufilme";
            this.btn_menufilme.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.btn_menufilme.Size = new System.Drawing.Size(154, 63);
            this.btn_menufilme.TabIndex = 9;
            this.btn_menufilme.Text = "Menu Filme";
            this.btn_menufilme.UseVisualStyleBackColor = false;
            this.btn_menufilme.Click += new System.EventHandler(this.btn_menufilme_Click);
            // 
            // btn_menulivros
            // 
            this.btn_menulivros.BackColor = System.Drawing.Color.White;
            this.btn_menulivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menulivros.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menulivros.Location = new System.Drawing.Point(21, 18);
            this.btn_menulivros.Name = "btn_menulivros";
            this.btn_menulivros.Size = new System.Drawing.Size(154, 63);
            this.btn_menulivros.TabIndex = 8;
            this.btn_menulivros.Text = "Menu Livro";
            this.btn_menulivros.UseVisualStyleBackColor = false;
            this.btn_menulivros.Click += new System.EventHandler(this.btn_menulivros_Click);
            // 
            // btn_menutablet
            // 
            this.btn_menutablet.BackColor = System.Drawing.Color.White;
            this.btn_menutablet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menutablet.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menutablet.Location = new System.Drawing.Point(196, 18);
            this.btn_menutablet.Name = "btn_menutablet";
            this.btn_menutablet.Size = new System.Drawing.Size(154, 63);
            this.btn_menutablet.TabIndex = 7;
            this.btn_menutablet.Text = "Menu Tablet";
            this.btn_menutablet.UseVisualStyleBackColor = false;
            this.btn_menutablet.Click += new System.EventHandler(this.btn_menutablet_Click);
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage1.Controls.Add(this.btn_menuprofessores);
            this.tabPage1.Controls.Add(this.btn_menufuncionarios);
            this.tabPage1.Controls.Add(this.btn_menualunos);
            this.tabPage1.Font = new System.Drawing.Font("Bahnschrift Condensed", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(548, 173);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados Admistrativos";
            // 
            // btn_menuprofessores
            // 
            this.btn_menuprofessores.BackColor = System.Drawing.Color.White;
            this.btn_menuprofessores.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menuprofessores.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menuprofessores.Location = new System.Drawing.Point(196, 54);
            this.btn_menuprofessores.Name = "btn_menuprofessores";
            this.btn_menuprofessores.Size = new System.Drawing.Size(159, 67);
            this.btn_menuprofessores.TabIndex = 4;
            this.btn_menuprofessores.Text = "Menu Professores";
            this.btn_menuprofessores.UseVisualStyleBackColor = false;
            this.btn_menuprofessores.Click += new System.EventHandler(this.btn_menuprofessores_Click);
            // 
            // btn_menufuncionarios
            // 
            this.btn_menufuncionarios.BackColor = System.Drawing.Color.White;
            this.btn_menufuncionarios.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menufuncionarios.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menufuncionarios.Location = new System.Drawing.Point(20, 54);
            this.btn_menufuncionarios.Name = "btn_menufuncionarios";
            this.btn_menufuncionarios.Size = new System.Drawing.Size(161, 67);
            this.btn_menufuncionarios.TabIndex = 3;
            this.btn_menufuncionarios.Text = "Menu Funcionários";
            this.btn_menufuncionarios.UseVisualStyleBackColor = false;
            this.btn_menufuncionarios.Click += new System.EventHandler(this.btn_menufuncionarios_Click);
            // 
            // tabPage4
            // 
            this.tabPage4.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage4.Controls.Add(this.button3);
            this.tabPage4.Controls.Add(this.button2);
            this.tabPage4.Controls.Add(this.button1);
            this.tabPage4.Controls.Add(this.btn_menurelatoriolivros);
            this.tabPage4.Controls.Add(this.btn_menurelatoriotablet);
            this.tabPage4.Controls.Add(this.btn_menurelatoriocomputador);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Size = new System.Drawing.Size(548, 173);
            this.tabPage4.TabIndex = 3;
            this.tabPage4.Text = "Relatórios";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.Color.White;
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button3.Location = new System.Drawing.Point(370, 98);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(175, 67);
            this.button3.TabIndex = 12;
            this.button3.Text = "Relatório Professores";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.White;
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(184, 98);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(181, 67);
            this.button2.TabIndex = 11;
            this.button2.Text = "Relatório alunos";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.White;
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button1.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(3, 98);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(175, 67);
            this.button1.TabIndex = 10;
            this.button1.Text = "Relatório Filme";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn_menurelatoriolivros
            // 
            this.btn_menurelatoriolivros.BackColor = System.Drawing.Color.White;
            this.btn_menurelatoriolivros.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menurelatoriolivros.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menurelatoriolivros.Location = new System.Drawing.Point(3, 17);
            this.btn_menurelatoriolivros.Name = "btn_menurelatoriolivros";
            this.btn_menurelatoriolivros.Size = new System.Drawing.Size(175, 65);
            this.btn_menurelatoriolivros.TabIndex = 9;
            this.btn_menurelatoriolivros.Text = "Relatório Livros";
            this.btn_menurelatoriolivros.UseVisualStyleBackColor = false;
            this.btn_menurelatoriolivros.Click += new System.EventHandler(this.btn_menurelatoriolivros_Click);
            // 
            // btn_menurelatoriotablet
            // 
            this.btn_menurelatoriotablet.BackColor = System.Drawing.Color.White;
            this.btn_menurelatoriotablet.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menurelatoriotablet.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menurelatoriotablet.Location = new System.Drawing.Point(183, 17);
            this.btn_menurelatoriotablet.Name = "btn_menurelatoriotablet";
            this.btn_menurelatoriotablet.Size = new System.Drawing.Size(181, 65);
            this.btn_menurelatoriotablet.TabIndex = 8;
            this.btn_menurelatoriotablet.Text = "Relatório Tablet";
            this.btn_menurelatoriotablet.UseVisualStyleBackColor = false;
            this.btn_menurelatoriotablet.Click += new System.EventHandler(this.btn_menurelatoriotablet_Click);
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.WhiteSmoke;
            this.tabPage3.Controls.Add(this.btn_menurestaurar);
            this.tabPage3.Controls.Add(this.btn_menubackup);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(548, 168);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Ferramentas";
            // 
            // btn_menurestaurar
            // 
            this.btn_menurestaurar.BackColor = System.Drawing.Color.White;
            this.btn_menurestaurar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menurestaurar.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menurestaurar.Location = new System.Drawing.Point(303, 55);
            this.btn_menurestaurar.Name = "btn_menurestaurar";
            this.btn_menurestaurar.Size = new System.Drawing.Size(154, 55);
            this.btn_menurestaurar.TabIndex = 7;
            this.btn_menurestaurar.Text = "Restaurar";
            this.btn_menurestaurar.UseVisualStyleBackColor = false;
            this.btn_menurestaurar.Click += new System.EventHandler(this.btn_menurestaurar_Click);
            // 
            // btn_menubackup
            // 
            this.btn_menubackup.BackColor = System.Drawing.Color.White;
            this.btn_menubackup.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_menubackup.Font = new System.Drawing.Font("Bahnschrift Condensed", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_menubackup.Location = new System.Drawing.Point(97, 55);
            this.btn_menubackup.Name = "btn_menubackup";
            this.btn_menubackup.Size = new System.Drawing.Size(154, 55);
            this.btn_menubackup.TabIndex = 6;
            this.btn_menubackup.Text = "Backup";
            this.btn_menubackup.UseVisualStyleBackColor = false;
            this.btn_menubackup.Click += new System.EventHandler(this.btn_menubackup_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Bahnschrift Condensed", 39.75F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.OrangeRed;
            this.label2.Location = new System.Drawing.Point(201, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(210, 64);
            this.label2.TabIndex = 5;
            this.label2.Text = "Definições";
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // saveFileDialog1
            // 
            this.saveFileDialog1.DefaultExt = "BkSrbe";
            this.saveFileDialog1.Filter = "\"Backup Srbe (*.BkSrbe)|*.BkSrbe|All files (*.*)|*.*\"";
            // 
            // Frm_definicoes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(590, 303);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_definicoes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Definições";
            this.Load += new System.EventHandler(this.Frm_definicoes_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.tabPage3.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button btn_menualunos;
        private System.Windows.Forms.Button btn_menucomputador;
        private System.Windows.Forms.Button btn_menurelatoriocomputador;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.Button btn_menubackup;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.Button btn_menuprofessores;
        private System.Windows.Forms.Button btn_menufuncionarios;
        private System.Windows.Forms.Button btn_menulivros;
        private System.Windows.Forms.Button btn_menutablet;
        private System.Windows.Forms.Button btn_menurestaurar;
        private System.Windows.Forms.Button btn_menurelatoriolivros;
        private System.Windows.Forms.Button btn_menurelatoriotablet;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button btn_menufilme;
        private System.Windows.Forms.Button btn_menucategoria;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btn_menueditora;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
    }
}