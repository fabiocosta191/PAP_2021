
namespace PAP
{
    partial class Frm_RegistoAluno
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
            System.Windows.Forms.Label idAlunoLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label nCartaoLabel;
            System.Windows.Forms.Label turmaLabel;
            System.Windows.Forms.Label contactoLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistoAluno));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.fichaAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPAPDataSet = new PAP.BDPAPDataSet();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.idAlunoTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nCartaoTextBox = new System.Windows.Forms.TextBox();
            this.turmaTextBox = new System.Windows.Forms.TextBox();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fichaAlunoTableAdapter = new PAP.BDPAPDataSetTableAdapters.FichaAlunoTableAdapter();
            this.tableAdapterManager = new PAP.BDPAPDataSetTableAdapters.TableAdapterManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            idAlunoLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            nCartaoLabel = new System.Windows.Forms.Label();
            turmaLabel = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fichaAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            this.SuspendLayout();
            // 
            // idAlunoLabel
            // 
            idAlunoLabel.AutoSize = true;
            idAlunoLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idAlunoLabel.Location = new System.Drawing.Point(30, 271);
            idAlunoLabel.Name = "idAlunoLabel";
            idAlunoLabel.Size = new System.Drawing.Size(55, 16);
            idAlunoLabel.TabIndex = 0;
            idAlunoLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(258, 52);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(49, 16);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // nCartaoLabel
            // 
            nCartaoLabel.AutoSize = true;
            nCartaoLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nCartaoLabel.Location = new System.Drawing.Point(462, 52);
            nCartaoLabel.Name = "nCartaoLabel";
            nCartaoLabel.Size = new System.Drawing.Size(70, 16);
            nCartaoLabel.TabIndex = 4;
            nCartaoLabel.Text = "NºCartão:";
            // 
            // turmaLabel
            // 
            turmaLabel.AutoSize = true;
            turmaLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            turmaLabel.Location = new System.Drawing.Point(258, 123);
            turmaLabel.Name = "turmaLabel";
            turmaLabel.Size = new System.Drawing.Size(53, 16);
            turmaLabel.TabIndex = 6;
            turmaLabel.Text = "Turma:";
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactoLabel.Location = new System.Drawing.Point(462, 123);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(68, 16);
            contactoLabel.TabIndex = 8;
            contactoLabel.Text = "Contacto:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(258, 192);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(47, 16);
            emailLabel.TabIndex = 10;
            emailLabel.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.bindingNavigator1);
            this.groupBox1.Controls.Add(idAlunoLabel);
            this.groupBox1.Controls.Add(this.idAlunoTextBox);
            this.groupBox1.Controls.Add(nomeLabel);
            this.groupBox1.Controls.Add(this.nomeTextBox);
            this.groupBox1.Controls.Add(nCartaoLabel);
            this.groupBox1.Controls.Add(this.nCartaoTextBox);
            this.groupBox1.Controls.Add(turmaLabel);
            this.groupBox1.Controls.Add(this.turmaTextBox);
            this.groupBox1.Controls.Add(contactoLabel);
            this.groupBox1.Controls.Add(this.contactoTextBox);
            this.groupBox1.Controls.Add(emailLabel);
            this.groupBox1.Controls.Add(this.emailTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(690, 349);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Gerais";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(444, 71);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 19;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(240, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 17;
            this.label1.Text = "*";
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(582, 304);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 16;
            this.button3.Text = "Pesquisar";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(580, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 15;
            this.button2.Text = "Novo";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(499, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 14;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 52);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 13;
            this.pictureBox1.TabStop = false;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.BindingSource = this.fichaAlunoBindingSource;
            this.bindingNavigator1.CountItem = null;
            this.bindingNavigator1.DeleteItem = null;
            this.bindingNavigator1.ImageScalingSize = new System.Drawing.Size(26, 26);
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripSeparator2,
            this.toolStripButton1,
            this.toolStripButton7,
            this.toolStripSeparator3,
            this.toolStripButton2});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 16);
            this.bindingNavigator1.MoveFirstItem = null;
            this.bindingNavigator1.MoveLastItem = null;
            this.bindingNavigator1.MoveNextItem = null;
            this.bindingNavigator1.MovePreviousItem = null;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(680, 48);
            this.bindingNavigator1.TabIndex = 12;
            this.bindingNavigator1.Text = "bindingNavigator1";
            this.bindingNavigator1.Visible = false;
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(40, 45);
            this.toolStripButton1.Text = "Novo";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton1.Click += new System.EventHandler(this.toolStripButton1_Click);
            // 
            // fichaAlunoBindingSource
            // 
            this.fichaAlunoBindingSource.DataMember = "FichaAluno";
            this.fichaAlunoBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // bDPAPDataSet
            // 
            this.bDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.bDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(53, 45);
            this.toolStripButton7.Text = "Guardar";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click);
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 48);
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.Size = new System.Drawing.Size(61, 45);
            this.toolStripButton2.Text = "Pesquisar";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton2.Click += new System.EventHandler(this.toolStripButton2_Click);
            // 
            // idAlunoTextBox
            // 
            this.idAlunoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fichaAlunoBindingSource, "IdAluno", true));
            this.idAlunoTextBox.Enabled = false;
            this.idAlunoTextBox.Location = new System.Drawing.Point(33, 290);
            this.idAlunoTextBox.Name = "idAlunoTextBox";
            this.idAlunoTextBox.Size = new System.Drawing.Size(100, 20);
            this.idAlunoTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fichaAlunoBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(261, 71);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(148, 20);
            this.nomeTextBox.TabIndex = 3;
            this.nomeTextBox.TextChanged += new System.EventHandler(this.nomeTextBox_TextChanged);
            // 
            // nCartaoTextBox
            // 
            this.nCartaoTextBox.BackColor = System.Drawing.SystemColors.Window;
            this.nCartaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fichaAlunoBindingSource, "NCartao", true));
            this.nCartaoTextBox.Location = new System.Drawing.Point(465, 71);
            this.nCartaoTextBox.Name = "nCartaoTextBox";
            this.nCartaoTextBox.Size = new System.Drawing.Size(148, 20);
            this.nCartaoTextBox.TabIndex = 5;
            // 
            // turmaTextBox
            // 
            this.turmaTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fichaAlunoBindingSource, "Turma", true));
            this.turmaTextBox.Location = new System.Drawing.Point(261, 142);
            this.turmaTextBox.Name = "turmaTextBox";
            this.turmaTextBox.Size = new System.Drawing.Size(148, 20);
            this.turmaTextBox.TabIndex = 7;
            this.turmaTextBox.TextChanged += new System.EventHandler(this.turmaTextBox_TextChanged);
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fichaAlunoBindingSource, "Contacto", true));
            this.contactoTextBox.Location = new System.Drawing.Point(465, 142);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(148, 20);
            this.contactoTextBox.TabIndex = 9;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fichaAlunoBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(261, 211);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(148, 20);
            this.emailTextBox.TabIndex = 11;
            // 
            // fichaAlunoTableAdapter
            // 
            this.fichaAlunoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaFilmesTableAdapter = null;
            this.tableAdapterManager.CategoriaLivrosTableAdapter = null;
            this.tableAdapterManager.ComputadoresTableAdapter = null;
            this.tableAdapterManager.EditoraLivrosTableAdapter = null;
            this.tableAdapterManager.FichaAlunoTableAdapter = this.fichaAlunoTableAdapter;
            this.tableAdapterManager.FichaFuncionarioTableAdapter = null;
            this.tableAdapterManager.FichaProfessoresTableAdapter = null;
            this.tableAdapterManager.FilmesTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoComputadorTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoFilmesTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoLivrosTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoTabletTableAdapter = null;
            this.tableAdapterManager.LivrosTableAdapter = null;
            this.tableAdapterManager.RequisicaoComputadorTableAdapter = null;
            this.tableAdapterManager.RequisicaoTableAdapter = null;
            this.tableAdapterManager.RequisicaoTabletsTableAdapter = null;
            this.tableAdapterManager.RequisitacaoTableAdapter = null;
            this.tableAdapterManager.TabletsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.BDPAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitanteTableAdapter = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // Frm_RegistoAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(714, 373);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_RegistoAluno";
            this.Text = "Registo Aluno";
            this.Load += new System.EventHandler(this.Frm_RegistoAluno_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fichaAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BDPAPDataSet bDPAPDataSet;
        private System.Windows.Forms.BindingSource fichaAlunoBindingSource;
        private BDPAPDataSetTableAdapters.FichaAlunoTableAdapter fichaAlunoTableAdapter;
        private BDPAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.TextBox idAlunoTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox nCartaoTextBox;
        private System.Windows.Forms.TextBox turmaTextBox;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
    }
}