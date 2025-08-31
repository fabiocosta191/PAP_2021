
namespace PAP
{
    partial class Frm_RegistoFilme
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
            System.Windows.Forms.Label iDFilmesLabel;
            System.Windows.Forms.Label iDCategoriafilmeLabel;
            System.Windows.Forms.Label tituloLabel;
            System.Windows.Forms.Label produtoraLabel;
            System.Windows.Forms.Label observacoesLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistoFilme));
            this.bDPAPDataSet = new PAP.BDPAPDataSet();
            this.filmesTableAdapter = new PAP.BDPAPDataSetTableAdapters.FilmesTableAdapter();
            this.tableAdapterManager = new PAP.BDPAPDataSetTableAdapters.TableAdapterManager();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.filmesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.categoriaFilmesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.button3 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.iDFilmesTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.produtoraTextBox = new System.Windows.Forms.TextBox();
            this.observacoesTextBox = new System.Windows.Forms.TextBox();
            this.categoriaFilmesTableAdapter = new PAP.BDPAPDataSetTableAdapters.CategoriaFilmesTableAdapter();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            iDFilmesLabel = new System.Windows.Forms.Label();
            iDCategoriafilmeLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            produtoraLabel = new System.Windows.Forms.Label();
            observacoesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaFilmesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            this.SuspendLayout();
            // 
            // iDFilmesLabel
            // 
            iDFilmesLabel.AutoSize = true;
            iDFilmesLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDFilmesLabel.Location = new System.Drawing.Point(20, 275);
            iDFilmesLabel.Name = "iDFilmesLabel";
            iDFilmesLabel.Size = new System.Drawing.Size(55, 16);
            iDFilmesLabel.TabIndex = 0;
            iDFilmesLabel.Text = "Código:";
            // 
            // iDCategoriafilmeLabel
            // 
            iDCategoriafilmeLabel.AutoSize = true;
            iDCategoriafilmeLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDCategoriafilmeLabel.Location = new System.Drawing.Point(552, 42);
            iDCategoriafilmeLabel.Name = "iDCategoriafilmeLabel";
            iDCategoriafilmeLabel.Size = new System.Drawing.Size(71, 16);
            iDCategoriafilmeLabel.TabIndex = 2;
            iDCategoriafilmeLabel.Text = "Categoria:";
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloLabel.Location = new System.Drawing.Point(322, 42);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(49, 16);
            tituloLabel.TabIndex = 4;
            tituloLabel.Text = "Titulo:";
            // 
            // produtoraLabel
            // 
            produtoraLabel.AutoSize = true;
            produtoraLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            produtoraLabel.Location = new System.Drawing.Point(322, 98);
            produtoraLabel.Name = "produtoraLabel";
            produtoraLabel.Size = new System.Drawing.Size(76, 16);
            produtoraLabel.TabIndex = 6;
            produtoraLabel.Text = "Produtora:";
            // 
            // observacoesLabel
            // 
            observacoesLabel.AutoSize = true;
            observacoesLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            observacoesLabel.Location = new System.Drawing.Point(322, 156);
            observacoesLabel.Name = "observacoesLabel";
            observacoesLabel.Size = new System.Drawing.Size(91, 16);
            observacoesLabel.TabIndex = 8;
            observacoesLabel.Text = "Observacoes:";
            // 
            // bDPAPDataSet
            // 
            this.bDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.bDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmesTableAdapter
            // 
            this.filmesTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LivrosTableAdapter = null;
            this.tableAdapterManager.RequisicaoComputadorTableAdapter = null;
            this.tableAdapterManager.RequisicaoTableAdapter = null;
            this.tableAdapterManager.RequisicaoTabletsTableAdapter = null;
            this.tableAdapterManager.RequisitacaoTableAdapter = null;
            this.tableAdapterManager.TabletsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.BDPAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitanteTableAdapter = null;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.button3);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(iDFilmesLabel);
            this.groupBox1.Controls.Add(this.iDFilmesTextBox);
            this.groupBox1.Controls.Add(iDCategoriafilmeLabel);
            this.groupBox1.Controls.Add(tituloLabel);
            this.groupBox1.Controls.Add(this.tituloTextBox);
            this.groupBox1.Controls.Add(produtoraLabel);
            this.groupBox1.Controls.Add(this.produtoraTextBox);
            this.groupBox1.Controls.Add(observacoesLabel);
            this.groupBox1.Controls.Add(this.observacoesTextBox);
            this.groupBox1.Location = new System.Drawing.Point(13, 13);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(781, 353);
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
            this.label3.Location = new System.Drawing.Point(304, 117);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(15, 20);
            this.label3.TabIndex = 21;
            this.label3.Text = "*";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Red;
            this.label2.Location = new System.Drawing.Point(534, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(15, 20);
            this.label2.TabIndex = 20;
            this.label2.Text = "*";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(304, 63);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 19;
            this.label1.Text = "*";
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.filmesBindingSource, "IDCategoriafilme", true));
            this.comboBox1.DataSource = this.categoriaFilmesBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(555, 62);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(169, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "IDCategoriafilme";
            // 
            // filmesBindingSource
            // 
            this.filmesBindingSource.DataMember = "Filmes";
            this.filmesBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // categoriaFilmesBindingSource
            // 
            this.categoriaFilmesBindingSource.DataMember = "CategoriaFilmes";
            this.categoriaFilmesBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // button3
            // 
            this.button3.Location = new System.Drawing.Point(649, 294);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(75, 23);
            this.button3.TabIndex = 17;
            this.button3.Text = "Novo";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.button3_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(558, 294);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(649, 294);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Pesquisar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 44);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 14;
            this.pictureBox1.TabStop = false;
            // 
            // iDFilmesTextBox
            // 
            this.iDFilmesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmesBindingSource, "IDFilmes", true));
            this.iDFilmesTextBox.Enabled = false;
            this.iDFilmesTextBox.Location = new System.Drawing.Point(23, 294);
            this.iDFilmesTextBox.Name = "iDFilmesTextBox";
            this.iDFilmesTextBox.Size = new System.Drawing.Size(100, 20);
            this.iDFilmesTextBox.TabIndex = 1;
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmesBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(325, 61);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(169, 20);
            this.tituloTextBox.TabIndex = 5;
            // 
            // produtoraTextBox
            // 
            this.produtoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmesBindingSource, "Produtora", true));
            this.produtoraTextBox.Location = new System.Drawing.Point(325, 117);
            this.produtoraTextBox.Name = "produtoraTextBox";
            this.produtoraTextBox.Size = new System.Drawing.Size(169, 20);
            this.produtoraTextBox.TabIndex = 7;
            // 
            // observacoesTextBox
            // 
            this.observacoesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmesBindingSource, "Observacoes", true));
            this.observacoesTextBox.Location = new System.Drawing.Point(325, 175);
            this.observacoesTextBox.Multiline = true;
            this.observacoesTextBox.Name = "observacoesTextBox";
            this.observacoesTextBox.Size = new System.Drawing.Size(399, 70);
            this.observacoesTextBox.TabIndex = 9;
            // 
            // categoriaFilmesTableAdapter
            // 
            this.categoriaFilmesTableAdapter.ClearBeforeFill = true;
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
            // Frm_RegistoFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(808, 376);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_RegistoFilme";
            this.Text = "Registo Filme";
            this.Load += new System.EventHandler(this.Frm_RegistoFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaFilmesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BDPAPDataSet bDPAPDataSet;
        private BDPAPDataSetTableAdapters.FilmesTableAdapter filmesTableAdapter;
        private BDPAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.BindingSource filmesBindingSource;
        private System.Windows.Forms.TextBox iDFilmesTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox produtoraTextBox;
        private System.Windows.Forms.TextBox observacoesTextBox;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource categoriaFilmesBindingSource;
        private BDPAPDataSetTableAdapters.CategoriaFilmesTableAdapter categoriaFilmesTableAdapter;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}