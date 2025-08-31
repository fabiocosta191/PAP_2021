
namespace PAP
{
    partial class Frm_NovoRegistoFuncionario
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_NovoRegistoFuncionario));
            this.btn_novofuncionario = new System.Windows.Forms.Button();
            this.btn_imagemcartão = new System.Windows.Forms.Button();
            this.label_Ncartao = new System.Windows.Forms.Label();
            this.btn_imagempassword = new System.Windows.Forms.Button();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.label_password = new System.Windows.Forms.Label();
            this.btn_registar = new System.Windows.Forms.Button();
            this.label_login = new System.Windows.Forms.Label();
            this.label_usuario = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.btn_voltarlogin = new System.Windows.Forms.Button();
            this.bDPAPDataSet = new PAP.BDPAPDataSet();
            this.fichaFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fichaFuncionarioTableAdapter = new PAP.BDPAPDataSetTableAdapters.FichaFuncionarioTableAdapter();
            this.tableAdapterManager = new PAP.BDPAPDataSetTableAdapters.TableAdapterManager();
            this.textbox_ncartao = new System.Windows.Forms.TextBox();
            this.textbox_login = new System.Windows.Forms.TextBox();
            this.textbox_password = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // btn_novofuncionario
            // 
            this.btn_novofuncionario.BackColor = System.Drawing.Color.White;
            this.btn_novofuncionario.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_novofuncionario.Font = new System.Drawing.Font("Bahnschrift Condensed", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_novofuncionario.Location = new System.Drawing.Point(572, 232);
            this.btn_novofuncionario.Name = "btn_novofuncionario";
            this.btn_novofuncionario.Size = new System.Drawing.Size(186, 69);
            this.btn_novofuncionario.TabIndex = 50;
            this.btn_novofuncionario.Text = "Novo";
            this.btn_novofuncionario.UseVisualStyleBackColor = false;
            this.btn_novofuncionario.Click += new System.EventHandler(this.btn_novofuncionario_Click);
            // 
            // btn_imagemcartão
            // 
            this.btn_imagemcartão.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_imagemcartão.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imagemcartão.BackgroundImage")));
            this.btn_imagemcartão.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_imagemcartão.FlatAppearance.BorderSize = 0;
            this.btn_imagemcartão.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imagemcartão.Location = new System.Drawing.Point(529, 304);
            this.btn_imagemcartão.Name = "btn_imagemcartão";
            this.btn_imagemcartão.Size = new System.Drawing.Size(37, 35);
            this.btn_imagemcartão.TabIndex = 46;
            this.btn_imagemcartão.UseVisualStyleBackColor = false;
            // 
            // label_Ncartao
            // 
            this.label_Ncartao.AutoSize = true;
            this.label_Ncartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_Ncartao.Location = new System.Drawing.Point(620, 276);
            this.label_Ncartao.Name = "label_Ncartao";
            this.label_Ncartao.Size = new System.Drawing.Size(105, 25);
            this.label_Ncartao.TabIndex = 45;
            this.label_Ncartao.Text = "Nº Cartão";
            // 
            // btn_imagempassword
            // 
            this.btn_imagempassword.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_imagempassword.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btn_imagempassword.BackgroundImage")));
            this.btn_imagempassword.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btn_imagempassword.FlatAppearance.BorderSize = 0;
            this.btn_imagempassword.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_imagempassword.Location = new System.Drawing.Point(529, 220);
            this.btn_imagempassword.Name = "btn_imagempassword";
            this.btn_imagempassword.Size = new System.Drawing.Size(37, 35);
            this.btn_imagempassword.TabIndex = 44;
            this.btn_imagempassword.UseVisualStyleBackColor = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("pictureBox2.BackgroundImage")));
            this.pictureBox2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox2.Location = new System.Drawing.Point(529, 141);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(37, 35);
            this.pictureBox2.TabIndex = 43;
            this.pictureBox2.TabStop = false;
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_password.Location = new System.Drawing.Point(620, 192);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(106, 25);
            this.label_password.TabIndex = 42;
            this.label_password.Text = "Password";
            // 
            // btn_registar
            // 
            this.btn_registar.BackColor = System.Drawing.Color.White;
            this.btn_registar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_registar.Font = new System.Drawing.Font("Bahnschrift Condensed", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_registar.Location = new System.Drawing.Point(607, 392);
            this.btn_registar.Name = "btn_registar";
            this.btn_registar.Size = new System.Drawing.Size(119, 45);
            this.btn_registar.TabIndex = 41;
            this.btn_registar.Text = "Registar";
            this.btn_registar.UseVisualStyleBackColor = false;
            this.btn_registar.Click += new System.EventHandler(this.btn_registar_Click);
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Bahnschrift Condensed", 45F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_login.ForeColor = System.Drawing.Color.OrangeRed;
            this.label_login.Location = new System.Drawing.Point(517, 14);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(282, 72);
            this.label_login.TabIndex = 40;
            this.label_login.Text = "Novo Registo";
            // 
            // label_usuario
            // 
            this.label_usuario.AutoSize = true;
            this.label_usuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_usuario.Location = new System.Drawing.Point(602, 113);
            this.label_usuario.Name = "label_usuario";
            this.label_usuario.Size = new System.Drawing.Size(125, 25);
            this.label_usuario.TabIndex = 39;
            this.label_usuario.Text = "Funcionário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-13, -32);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 503);
            this.pictureBox1.TabIndex = 51;
            this.pictureBox1.TabStop = false;
            // 
            // btn_voltarlogin
            // 
            this.btn_voltarlogin.BackColor = System.Drawing.Color.White;
            this.btn_voltarlogin.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_voltarlogin.Font = new System.Drawing.Font("Bahnschrift Condensed", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_voltarlogin.Location = new System.Drawing.Point(155, 343);
            this.btn_voltarlogin.Name = "btn_voltarlogin";
            this.btn_voltarlogin.Size = new System.Drawing.Size(135, 45);
            this.btn_voltarlogin.TabIndex = 52;
            this.btn_voltarlogin.Text = "Login";
            this.btn_voltarlogin.UseVisualStyleBackColor = false;
            this.btn_voltarlogin.Click += new System.EventHandler(this.btn_voltarlogin_Click);
            // 
            // bDPAPDataSet
            // 
            this.bDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.bDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // fichaFuncionarioBindingSource
            // 
            this.fichaFuncionarioBindingSource.DataMember = "FichaFuncionario";
            this.fichaFuncionarioBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // fichaFuncionarioTableAdapter
            // 
            this.fichaFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaFilmesTableAdapter = null;
            this.tableAdapterManager.CategoriaLivrosTableAdapter = null;
            this.tableAdapterManager.ComputadoresTableAdapter = null;
            this.tableAdapterManager.EditoraLivrosTableAdapter = null;
            this.tableAdapterManager.FichaAlunoTableAdapter = null;
            this.tableAdapterManager.FichaFuncionarioTableAdapter = this.fichaFuncionarioTableAdapter;
            this.tableAdapterManager.FichaProfessoresTableAdapter = null;
            this.tableAdapterManager.FilmesTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoComputadorTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoFilmesTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoLivrosTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoTabletTableAdapter = null;
            this.tableAdapterManager.LivrosTableAdapter = null;
            this.tableAdapterManager.RequisitacaoTableAdapter = null;
            this.tableAdapterManager.TabletsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.BDPAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitanteTableAdapter = null;
            // 
            // textbox_ncartao
            // 
            this.textbox_ncartao.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fichaFuncionarioBindingSource, "NCartão", true));
            this.textbox_ncartao.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_ncartao.Location = new System.Drawing.Point(572, 304);
            this.textbox_ncartao.Multiline = true;
            this.textbox_ncartao.Name = "textbox_ncartao";
            this.textbox_ncartao.Size = new System.Drawing.Size(204, 35);
            this.textbox_ncartao.TabIndex = 58;
            // 
            // textbox_login
            // 
            this.textbox_login.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fichaFuncionarioBindingSource, "Login", true));
            this.textbox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_login.Location = new System.Drawing.Point(572, 141);
            this.textbox_login.Multiline = true;
            this.textbox_login.Name = "textbox_login";
            this.textbox_login.Size = new System.Drawing.Size(204, 35);
            this.textbox_login.TabIndex = 60;
            // 
            // textbox_password
            // 
            this.textbox_password.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fichaFuncionarioBindingSource, "Password", true));
            this.textbox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textbox_password.Location = new System.Drawing.Point(572, 220);
            this.textbox_password.Multiline = true;
            this.textbox_password.Name = "textbox_password";
            this.textbox_password.PasswordChar = '*';
            this.textbox_password.Size = new System.Drawing.Size(204, 35);
            this.textbox_password.TabIndex = 62;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // Frm_NovoRegistoFuncionario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 466);
            this.Controls.Add(this.textbox_ncartao);
            this.Controls.Add(this.textbox_login);
            this.Controls.Add(this.textbox_password);
            this.Controls.Add(this.btn_voltarlogin);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btn_novofuncionario);
            this.Controls.Add(this.btn_imagemcartão);
            this.Controls.Add(this.label_Ncartao);
            this.Controls.Add(this.btn_imagempassword);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.btn_registar);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.label_usuario);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Frm_NovoRegistoFuncionario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_NovoRegistoFuncionario";
            this.Load += new System.EventHandler(this.Frm_NovoRegistoFuncionario_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_novofuncionario;
        private System.Windows.Forms.Button btn_imagemcartão;
        private System.Windows.Forms.Label label_Ncartao;
        private System.Windows.Forms.Button btn_imagempassword;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Label label_password;
        private System.Windows.Forms.Button btn_registar;
        private System.Windows.Forms.Label label_login;
        private System.Windows.Forms.Label label_usuario;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button btn_voltarlogin;
        private BDPAPDataSet bDPAPDataSet;
        private System.Windows.Forms.BindingSource fichaFuncionarioBindingSource;
        private BDPAPDataSetTableAdapters.FichaFuncionarioTableAdapter fichaFuncionarioTableAdapter;
        private BDPAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox textbox_ncartao;
        private System.Windows.Forms.TextBox textbox_login;
        private System.Windows.Forms.TextBox textbox_password;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
    }
}