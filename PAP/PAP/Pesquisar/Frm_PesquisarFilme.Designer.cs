
namespace PAP
{
    partial class Frm_PesquisarFilme
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PesquisarFilme));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.filmesDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoriaFilmesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPAPDataSet = new PAP.BDPAPDataSet();
            this.filmesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.radiobtn_filme_produtora = new System.Windows.Forms.RadioButton();
            this.radiobtn_filme_titulo = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.filmesTableAdapter = new PAP.BDPAPDataSetTableAdapters.FilmesTableAdapter();
            this.tableAdapterManager = new PAP.BDPAPDataSetTableAdapters.TableAdapterManager();
            this.categoriaFilmesTableAdapter = new PAP.BDPAPDataSetTableAdapters.CategoriaFilmesTableAdapter();
            this.iDFilmesTextBox = new System.Windows.Forms.TextBox();
            this.iDCategoriafilmeTextBox = new System.Windows.Forms.TextBox();
            this.tituloTextBox = new System.Windows.Forms.TextBox();
            this.produtoraTextBox = new System.Windows.Forms.TextBox();
            iDFilmesLabel = new System.Windows.Forms.Label();
            iDCategoriafilmeLabel = new System.Windows.Forms.Label();
            tituloLabel = new System.Windows.Forms.Label();
            produtoraLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaFilmesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmesBindingSource)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.filmesDataGridView);
            this.groupBox1.Controls.Add(this.radiobtn_filme_produtora);
            this.groupBox1.Controls.Add(this.radiobtn_filme_titulo);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 422);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geral";
            // 
            // filmesDataGridView
            // 
            this.filmesDataGridView.AutoGenerateColumns = false;
            this.filmesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.filmesDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn2});
            this.filmesDataGridView.DataSource = this.filmesBindingSource;
            this.filmesDataGridView.Location = new System.Drawing.Point(0, 104);
            this.filmesDataGridView.Name = "filmesDataGridView";
            this.filmesDataGridView.Size = new System.Drawing.Size(812, 318);
            this.filmesDataGridView.TabIndex = 4;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDFilmes";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Titulo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Titulo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Produtora";
            this.dataGridViewTextBoxColumn6.HeaderText = "Produtora";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IDCategoriafilme";
            this.dataGridViewTextBoxColumn2.DataSource = this.categoriaFilmesBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "IDCategoriafilme";
            // 
            // categoriaFilmesBindingSource
            // 
            this.categoriaFilmesBindingSource.DataMember = "CategoriaFilmes";
            this.categoriaFilmesBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // bDPAPDataSet
            // 
            this.bDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.bDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // filmesBindingSource
            // 
            this.filmesBindingSource.DataMember = "Filmes";
            this.filmesBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // radiobtn_filme_produtora
            // 
            this.radiobtn_filme_produtora.AutoSize = true;
            this.radiobtn_filme_produtora.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn_filme_produtora.Location = new System.Drawing.Point(114, 79);
            this.radiobtn_filme_produtora.Name = "radiobtn_filme_produtora";
            this.radiobtn_filme_produtora.Size = new System.Drawing.Size(79, 19);
            this.radiobtn_filme_produtora.TabIndex = 4;
            this.radiobtn_filme_produtora.TabStop = true;
            this.radiobtn_filme_produtora.Text = "Produtora";
            this.radiobtn_filme_produtora.UseVisualStyleBackColor = true;
            // 
            // radiobtn_filme_titulo
            // 
            this.radiobtn_filme_titulo.AutoSize = true;
            this.radiobtn_filme_titulo.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn_filme_titulo.Location = new System.Drawing.Point(18, 79);
            this.radiobtn_filme_titulo.Name = "radiobtn_filme_titulo";
            this.radiobtn_filme_titulo.Size = new System.Drawing.Size(55, 19);
            this.radiobtn_filme_titulo.TabIndex = 3;
            this.radiobtn_filme_titulo.TabStop = true;
            this.radiobtn_filme_titulo.Text = "Título";
            this.radiobtn_filme_titulo.UseVisualStyleBackColor = true;
            this.radiobtn_filme_titulo.CheckedChanged += new System.EventHandler(this.radiobtn_filme_titulo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(14, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(17, 49);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(363, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(iDFilmesLabel);
            this.groupBox2.Controls.Add(this.iDFilmesTextBox);
            this.groupBox2.Controls.Add(iDCategoriafilmeLabel);
            this.groupBox2.Controls.Add(this.iDCategoriafilmeTextBox);
            this.groupBox2.Controls.Add(tituloLabel);
            this.groupBox2.Controls.Add(this.tituloTextBox);
            this.groupBox2.Controls.Add(produtoraLabel);
            this.groupBox2.Controls.Add(this.produtoraTextBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 446);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 222);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Gerais";
            // 
            // filmesTableAdapter
            // 
            this.filmesTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaFilmesTableAdapter = this.categoriaFilmesTableAdapter;
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
            // categoriaFilmesTableAdapter
            // 
            this.categoriaFilmesTableAdapter.ClearBeforeFill = true;
            // 
            // iDFilmesLabel
            // 
            iDFilmesLabel.AutoSize = true;
            iDFilmesLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDFilmesLabel.Location = new System.Drawing.Point(124, 49);
            iDFilmesLabel.Name = "iDFilmesLabel";
            iDFilmesLabel.Size = new System.Drawing.Size(59, 18);
            iDFilmesLabel.TabIndex = 0;
            iDFilmesLabel.Text = "Código:";
            // 
            // iDFilmesTextBox
            // 
            this.iDFilmesTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmesBindingSource, "IDFilmes", true));
            this.iDFilmesTextBox.Location = new System.Drawing.Point(127, 70);
            this.iDFilmesTextBox.Name = "iDFilmesTextBox";
            this.iDFilmesTextBox.Size = new System.Drawing.Size(144, 20);
            this.iDFilmesTextBox.TabIndex = 1;
            // 
            // iDCategoriafilmeLabel
            // 
            iDCategoriafilmeLabel.AutoSize = true;
            iDCategoriafilmeLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDCategoriafilmeLabel.Location = new System.Drawing.Point(465, 50);
            iDCategoriafilmeLabel.Name = "iDCategoriafilmeLabel";
            iDCategoriafilmeLabel.Size = new System.Drawing.Size(77, 18);
            iDCategoriafilmeLabel.TabIndex = 2;
            iDCategoriafilmeLabel.Text = "Categoria:";
            // 
            // iDCategoriafilmeTextBox
            // 
            this.iDCategoriafilmeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmesBindingSource, "IDCategoriafilme", true));
            this.iDCategoriafilmeTextBox.Location = new System.Drawing.Point(468, 71);
            this.iDCategoriafilmeTextBox.Name = "iDCategoriafilmeTextBox";
            this.iDCategoriafilmeTextBox.Size = new System.Drawing.Size(146, 20);
            this.iDCategoriafilmeTextBox.TabIndex = 3;
            // 
            // tituloLabel
            // 
            tituloLabel.AutoSize = true;
            tituloLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tituloLabel.Location = new System.Drawing.Point(124, 126);
            tituloLabel.Name = "tituloLabel";
            tituloLabel.Size = new System.Drawing.Size(52, 18);
            tituloLabel.TabIndex = 4;
            tituloLabel.Text = "Titulo:";
            // 
            // tituloTextBox
            // 
            this.tituloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmesBindingSource, "Titulo", true));
            this.tituloTextBox.Location = new System.Drawing.Point(127, 148);
            this.tituloTextBox.Name = "tituloTextBox";
            this.tituloTextBox.Size = new System.Drawing.Size(144, 20);
            this.tituloTextBox.TabIndex = 5;
            // 
            // produtoraLabel
            // 
            produtoraLabel.AutoSize = true;
            produtoraLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            produtoraLabel.Location = new System.Drawing.Point(465, 127);
            produtoraLabel.Name = "produtoraLabel";
            produtoraLabel.Size = new System.Drawing.Size(80, 18);
            produtoraLabel.TabIndex = 8;
            produtoraLabel.Text = "Produtora:";
            // 
            // produtoraTextBox
            // 
            this.produtoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.filmesBindingSource, "Produtora", true));
            this.produtoraTextBox.Location = new System.Drawing.Point(468, 148);
            this.produtoraTextBox.Name = "produtoraTextBox";
            this.produtoraTextBox.Size = new System.Drawing.Size(146, 20);
            this.produtoraTextBox.TabIndex = 9;
            // 
            // Frm_PesquisarFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 668);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_PesquisarFilme";
            this.Text = "Pesquisar Filme";
            this.Load += new System.EventHandler(this.Frm_PesquisarFilme_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.filmesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaFilmesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.filmesBindingSource)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobtn_filme_produtora;
        private System.Windows.Forms.RadioButton radiobtn_filme_titulo;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private BDPAPDataSet bDPAPDataSet;
        private System.Windows.Forms.BindingSource filmesBindingSource;
        private BDPAPDataSetTableAdapters.FilmesTableAdapter filmesTableAdapter;
        private BDPAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView filmesDataGridView;
        private BDPAPDataSetTableAdapters.CategoriaFilmesTableAdapter categoriaFilmesTableAdapter;
        private System.Windows.Forms.BindingSource categoriaFilmesBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.TextBox iDFilmesTextBox;
        private System.Windows.Forms.TextBox iDCategoriafilmeTextBox;
        private System.Windows.Forms.TextBox tituloTextBox;
        private System.Windows.Forms.TextBox produtoraTextBox;
    }
}