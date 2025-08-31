
namespace PAP
{
    partial class Frm_RegistoLivros
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
            System.Windows.Forms.Label idLivroLabel;
            System.Windows.Forms.Label idEditoraLabel;
            System.Windows.Forms.Label codigoISBNLabel;
            System.Windows.Forms.Label títuloLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label ediçãoLabel;
            System.Windows.Forms.Label iDCategoriaLivrosLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistoLivros));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPAPDataSet = new PAP.BDPAPDataSet();
            this.categoriaLivrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.editoraLivrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.idLivroTextBox = new System.Windows.Forms.TextBox();
            this.títuloTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.ediçãoTextBox = new System.Windows.Forms.TextBox();
            this.filmesTableAdapter = new PAP.BDPAPDataSetTableAdapters.FilmesTableAdapter();
            this.livrosTableAdapter = new PAP.BDPAPDataSetTableAdapters.LivrosTableAdapter();
            this.tableAdapterManager = new PAP.BDPAPDataSetTableAdapters.TableAdapterManager();
            this.editoraLivrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.editoraLivrosTableAdapter = new PAP.BDPAPDataSetTableAdapters.EditoraLivrosTableAdapter();
            this.categoriaLivrosTableAdapter = new PAP.BDPAPDataSetTableAdapters.CategoriaLivrosTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            this.codigo_EANTextBox = new System.Windows.Forms.TextBox();
            idLivroLabel = new System.Windows.Forms.Label();
            idEditoraLabel = new System.Windows.Forms.Label();
            codigoISBNLabel = new System.Windows.Forms.Label();
            títuloLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            ediçãoLabel = new System.Windows.Forms.Label();
            iDCategoriaLivrosLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaLivrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraLivrosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraLivrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // idLivroLabel
            // 
            idLivroLabel.AutoSize = true;
            idLivroLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLivroLabel.Location = new System.Drawing.Point(28, 278);
            idLivroLabel.Name = "idLivroLabel";
            idLivroLabel.Size = new System.Drawing.Size(55, 16);
            idLivroLabel.TabIndex = 19;
            idLivroLabel.Text = "Código:";
            // 
            // idEditoraLabel
            // 
            idEditoraLabel.AutoSize = true;
            idEditoraLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idEditoraLabel.Location = new System.Drawing.Point(517, 67);
            idEditoraLabel.Name = "idEditoraLabel";
            idEditoraLabel.Size = new System.Drawing.Size(58, 16);
            idEditoraLabel.TabIndex = 21;
            idEditoraLabel.Text = "Editora:";
            // 
            // codigoISBNLabel
            // 
            codigoISBNLabel.AutoSize = true;
            codigoISBNLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoISBNLabel.Location = new System.Drawing.Point(517, 121);
            codigoISBNLabel.Name = "codigoISBNLabel";
            codigoISBNLabel.Size = new System.Drawing.Size(43, 16);
            codigoISBNLabel.TabIndex = 23;
            codigoISBNLabel.Text = "ISBN:";
            // 
            // títuloLabel
            // 
            títuloLabel.AutoSize = true;
            títuloLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            títuloLabel.Location = new System.Drawing.Point(278, 64);
            títuloLabel.Name = "títuloLabel";
            títuloLabel.Size = new System.Drawing.Size(49, 16);
            títuloLabel.TabIndex = 25;
            títuloLabel.Text = "Título:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autorLabel.Location = new System.Drawing.Point(278, 121);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(49, 16);
            autorLabel.TabIndex = 27;
            autorLabel.Text = "Autor:";
            // 
            // ediçãoLabel
            // 
            ediçãoLabel.AutoSize = true;
            ediçãoLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ediçãoLabel.Location = new System.Drawing.Point(278, 179);
            ediçãoLabel.Name = "ediçãoLabel";
            ediçãoLabel.Size = new System.Drawing.Size(54, 16);
            ediçãoLabel.TabIndex = 29;
            ediçãoLabel.Text = "Edição:";
            // 
            // iDCategoriaLivrosLabel
            // 
            iDCategoriaLivrosLabel.AutoSize = true;
            iDCategoriaLivrosLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDCategoriaLivrosLabel.Location = new System.Drawing.Point(517, 176);
            iDCategoriaLivrosLabel.Name = "iDCategoriaLivrosLabel";
            iDCategoriaLivrosLabel.Size = new System.Drawing.Size(71, 16);
            iDCategoriaLivrosLabel.TabIndex = 31;
            iDCategoriaLivrosLabel.Text = "Categoria:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.codigo_EANTextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.comboBox2);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(idLivroLabel);
            this.groupBox1.Controls.Add(this.idLivroTextBox);
            this.groupBox1.Controls.Add(idEditoraLabel);
            this.groupBox1.Controls.Add(codigoISBNLabel);
            this.groupBox1.Controls.Add(títuloLabel);
            this.groupBox1.Controls.Add(this.títuloTextBox);
            this.groupBox1.Controls.Add(autorLabel);
            this.groupBox1.Controls.Add(this.autorTextBox);
            this.groupBox1.Controls.Add(ediçãoLabel);
            this.groupBox1.Controls.Add(this.ediçãoTextBox);
            this.groupBox1.Controls.Add(iDCategoriaLivrosLabel);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(747, 352);
            this.groupBox1.TabIndex = 17;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Gerails";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Red;
            this.label5.Location = new System.Drawing.Point(499, 199);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(15, 20);
            this.label5.TabIndex = 43;
            this.label5.Text = "*";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Red;
            this.label4.Location = new System.Drawing.Point(499, 140);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(15, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "*";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Red;
            this.label3.Location = new System.Drawing.Point(257, 140);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 41;
            this.label3.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(499, 85);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 40;
            this.label1.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(257, 85);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 39;
            this.label2.Text = "*";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.livrosBindingSource, "IDCategoriaLivros", true));
            this.comboBox2.DataSource = this.categoriaLivrosBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(520, 198);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(168, 21);
            this.comboBox2.TabIndex = 38;
            this.comboBox2.ValueMember = "IDCategoriaLivros";
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // bDPAPDataSet
            // 
            this.bDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.bDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // categoriaLivrosBindingSource
            // 
            this.categoriaLivrosBindingSource.DataMember = "CategoriaLivros";
            this.categoriaLivrosBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.livrosBindingSource, "IdEditora", true));
            this.comboBox1.DataSource = this.editoraLivrosBindingSource1;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(520, 84);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(168, 21);
            this.comboBox1.TabIndex = 37;
            this.comboBox1.ValueMember = "IdEditora";
            // 
            // editoraLivrosBindingSource1
            // 
            this.editoraLivrosBindingSource1.DataMember = "EditoraLivros";
            this.editoraLivrosBindingSource1.DataSource = this.bDPAPDataSet;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(613, 295);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 36;
            this.button3.Text = "Novo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(520, 297);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 35;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(613, 297);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 34;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 48);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 33;
            this.pictureBox1.TabStop = false;
            // 
            // idLivroTextBox
            // 
            this.idLivroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "IdLivro", true));
            this.idLivroTextBox.Enabled = false;
            this.idLivroTextBox.Location = new System.Drawing.Point(31, 297);
            this.idLivroTextBox.Name = "idLivroTextBox";
            this.idLivroTextBox.Size = new System.Drawing.Size(104, 20);
            this.idLivroTextBox.TabIndex = 20;
            // 
            // títuloTextBox
            // 
            this.títuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Título", true));
            this.títuloTextBox.Location = new System.Drawing.Point(278, 84);
            this.títuloTextBox.Name = "títuloTextBox";
            this.títuloTextBox.Size = new System.Drawing.Size(171, 20);
            this.títuloTextBox.TabIndex = 26;
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(278, 140);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(171, 20);
            this.autorTextBox.TabIndex = 28;
            // 
            // ediçãoTextBox
            // 
            this.ediçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Edição", true));
            this.ediçãoTextBox.Location = new System.Drawing.Point(278, 198);
            this.ediçãoTextBox.Name = "ediçãoTextBox";
            this.ediçãoTextBox.Size = new System.Drawing.Size(168, 20);
            this.ediçãoTextBox.TabIndex = 30;
            // 
            // filmesTableAdapter
            // 
            this.filmesTableAdapter.ClearBeforeFill = true;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaFilmesTableAdapter = null;
            this.tableAdapterManager.CategoriaLivrosTableAdapter = null;
            this.tableAdapterManager.ComputadoresTableAdapter = null;
            this.tableAdapterManager.EditoraLivrosTableAdapter = null;
            this.tableAdapterManager.FichaAlunoTableAdapter = null;
            this.tableAdapterManager.FichaFuncionarioTableAdapter = null;
            this.tableAdapterManager.FichaProfessoresTableAdapter = null;
            this.tableAdapterManager.FilmesTableAdapter = this.filmesTableAdapter;
            this.tableAdapterManager.ItemRequisitadoComputadorTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoFilmesTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoLivrosTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoTabletTableAdapter = null;
            this.tableAdapterManager.LivrosTableAdapter = this.livrosTableAdapter;
            this.tableAdapterManager.RequisicaoComputadorTableAdapter = null;
            this.tableAdapterManager.RequisicaoTableAdapter = null;
            this.tableAdapterManager.RequisicaoTabletsTableAdapter = null;
            this.tableAdapterManager.RequisitacaoTableAdapter = null;
            this.tableAdapterManager.TabletsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.BDPAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitanteTableAdapter = null;
            // 
            // editoraLivrosBindingSource
            // 
            this.editoraLivrosBindingSource.DataMember = "EditoraLivros";
            this.editoraLivrosBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // editoraLivrosTableAdapter
            // 
            this.editoraLivrosTableAdapter.ClearBeforeFill = true;
            // 
            // categoriaLivrosTableAdapter
            // 
            this.categoriaLivrosTableAdapter.ClearBeforeFill = true;
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
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // codigo_EANTextBox
            // 
            this.codigo_EANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Codigo EAN", true));
            this.codigo_EANTextBox.Location = new System.Drawing.Point(520, 142);
            this.codigo_EANTextBox.Name = "codigo_EANTextBox";
            this.codigo_EANTextBox.Size = new System.Drawing.Size(168, 20);
            this.codigo_EANTextBox.TabIndex = 44;
            // 
            // Frm_RegistoLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(772, 375);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_RegistoLivros";
            this.Text = "Registo Livro";
            this.Load += new System.EventHandler(this.Frm_RegistoLivros_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaLivrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraLivrosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraLivrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private BDPAPDataSetTableAdapters.FilmesTableAdapter filmesTableAdapter;
        private BDPAPDataSet bDPAPDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private BDPAPDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private BDPAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idLivroTextBox;
        private System.Windows.Forms.TextBox títuloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox ediçãoTextBox;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource editoraLivrosBindingSource;
        private BDPAPDataSetTableAdapters.EditoraLivrosTableAdapter editoraLivrosTableAdapter;
        private System.Windows.Forms.BindingSource editoraLivrosBindingSource1;
        private System.Windows.Forms.BindingSource categoriaLivrosBindingSource;
        private BDPAPDataSetTableAdapters.CategoriaLivrosTableAdapter categoriaLivrosTableAdapter;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
        private System.Windows.Forms.TextBox codigo_EANTextBox;
    }
}