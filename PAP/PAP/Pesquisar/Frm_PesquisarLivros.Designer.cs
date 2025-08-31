
namespace PAP
{
    partial class Frm_PesquisarLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PesquisarLivros));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idLivroTextBox = new System.Windows.Forms.TextBox();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPAPDataSet = new PAP.BDPAPDataSet();
            this.idEditoraTextBox = new System.Windows.Forms.TextBox();
            this.títuloTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.ediçãoTextBox = new System.Windows.Forms.TextBox();
            this.iDCategoriaLivrosTextBox = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.livrosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.radiobtn_titulo_livro = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.livrosTableAdapter = new PAP.BDPAPDataSetTableAdapters.LivrosTableAdapter();
            this.tableAdapterManager = new PAP.BDPAPDataSetTableAdapters.TableAdapterManager();
            this.codigo_EANTextBox = new System.Windows.Forms.TextBox();
            idLivroLabel = new System.Windows.Forms.Label();
            idEditoraLabel = new System.Windows.Forms.Label();
            codigoISBNLabel = new System.Windows.Forms.Label();
            títuloLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            ediçãoLabel = new System.Windows.Forms.Label();
            iDCategoriaLivrosLabel = new System.Windows.Forms.Label();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).BeginInit();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idLivroLabel
            // 
            idLivroLabel.AutoSize = true;
            idLivroLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLivroLabel.Location = new System.Drawing.Point(75, 30);
            idLivroLabel.Name = "idLivroLabel";
            idLivroLabel.Size = new System.Drawing.Size(55, 16);
            idLivroLabel.TabIndex = 0;
            idLivroLabel.Text = "Código:";
            // 
            // idEditoraLabel
            // 
            idEditoraLabel.AutoSize = true;
            idEditoraLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idEditoraLabel.Location = new System.Drawing.Point(359, 143);
            idEditoraLabel.Name = "idEditoraLabel";
            idEditoraLabel.Size = new System.Drawing.Size(58, 16);
            idEditoraLabel.TabIndex = 2;
            idEditoraLabel.Text = "Editora:";
            // 
            // codigoISBNLabel
            // 
            codigoISBNLabel.AutoSize = true;
            codigoISBNLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigoISBNLabel.Location = new System.Drawing.Point(356, 30);
            codigoISBNLabel.Name = "codigoISBNLabel";
            codigoISBNLabel.Size = new System.Drawing.Size(43, 16);
            codigoISBNLabel.TabIndex = 4;
            codigoISBNLabel.Text = "ISBN:";
            // 
            // títuloLabel
            // 
            títuloLabel.AutoSize = true;
            títuloLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            títuloLabel.Location = new System.Drawing.Point(75, 85);
            títuloLabel.Name = "títuloLabel";
            títuloLabel.Size = new System.Drawing.Size(49, 16);
            títuloLabel.TabIndex = 6;
            títuloLabel.Text = "Título:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autorLabel.Location = new System.Drawing.Point(75, 143);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(49, 16);
            autorLabel.TabIndex = 8;
            autorLabel.Text = "Autor:";
            // 
            // ediçãoLabel
            // 
            ediçãoLabel.AutoSize = true;
            ediçãoLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ediçãoLabel.Location = new System.Drawing.Point(356, 85);
            ediçãoLabel.Name = "ediçãoLabel";
            ediçãoLabel.Size = new System.Drawing.Size(54, 16);
            ediçãoLabel.TabIndex = 10;
            ediçãoLabel.Text = "Edição:";
            // 
            // iDCategoriaLivrosLabel
            // 
            iDCategoriaLivrosLabel.AutoSize = true;
            iDCategoriaLivrosLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDCategoriaLivrosLabel.Location = new System.Drawing.Point(591, 30);
            iDCategoriaLivrosLabel.Name = "iDCategoriaLivrosLabel";
            iDCategoriaLivrosLabel.Size = new System.Drawing.Size(71, 16);
            iDCategoriaLivrosLabel.TabIndex = 12;
            iDCategoriaLivrosLabel.Text = "Categoria:";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(this.codigo_EANTextBox);
            this.groupBox2.Controls.Add(idLivroLabel);
            this.groupBox2.Controls.Add(this.idLivroTextBox);
            this.groupBox2.Controls.Add(idEditoraLabel);
            this.groupBox2.Controls.Add(this.idEditoraTextBox);
            this.groupBox2.Controls.Add(codigoISBNLabel);
            this.groupBox2.Controls.Add(títuloLabel);
            this.groupBox2.Controls.Add(this.títuloTextBox);
            this.groupBox2.Controls.Add(autorLabel);
            this.groupBox2.Controls.Add(this.autorTextBox);
            this.groupBox2.Controls.Add(ediçãoLabel);
            this.groupBox2.Controls.Add(this.ediçãoTextBox);
            this.groupBox2.Controls.Add(iDCategoriaLivrosLabel);
            this.groupBox2.Controls.Add(this.iDCategoriaLivrosTextBox);
            this.groupBox2.Location = new System.Drawing.Point(15, 429);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(828, 220);
            this.groupBox2.TabIndex = 5;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Dados Gerais";
            // 
            // idLivroTextBox
            // 
            this.idLivroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "IdLivro", true));
            this.idLivroTextBox.Location = new System.Drawing.Point(75, 49);
            this.idLivroTextBox.Name = "idLivroTextBox";
            this.idLivroTextBox.Size = new System.Drawing.Size(161, 20);
            this.idLivroTextBox.TabIndex = 1;
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
            // idEditoraTextBox
            // 
            this.idEditoraTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "IdEditora", true));
            this.idEditoraTextBox.Location = new System.Drawing.Point(362, 162);
            this.idEditoraTextBox.Name = "idEditoraTextBox";
            this.idEditoraTextBox.Size = new System.Drawing.Size(161, 20);
            this.idEditoraTextBox.TabIndex = 3;
            // 
            // títuloTextBox
            // 
            this.títuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Título", true));
            this.títuloTextBox.Location = new System.Drawing.Point(75, 104);
            this.títuloTextBox.Name = "títuloTextBox";
            this.títuloTextBox.Size = new System.Drawing.Size(161, 20);
            this.títuloTextBox.TabIndex = 7;
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(78, 162);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(161, 20);
            this.autorTextBox.TabIndex = 9;
            // 
            // ediçãoTextBox
            // 
            this.ediçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Edição", true));
            this.ediçãoTextBox.Location = new System.Drawing.Point(359, 104);
            this.ediçãoTextBox.Name = "ediçãoTextBox";
            this.ediçãoTextBox.Size = new System.Drawing.Size(161, 20);
            this.ediçãoTextBox.TabIndex = 11;
            // 
            // iDCategoriaLivrosTextBox
            // 
            this.iDCategoriaLivrosTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "IDCategoriaLivros", true));
            this.iDCategoriaLivrosTextBox.Location = new System.Drawing.Point(594, 49);
            this.iDCategoriaLivrosTextBox.Name = "iDCategoriaLivrosTextBox";
            this.iDCategoriaLivrosTextBox.Size = new System.Drawing.Size(161, 20);
            this.iDCategoriaLivrosTextBox.TabIndex = 13;
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.livrosDataGridView);
            this.groupBox1.Controls.Add(this.radiobtn_titulo_livro);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(15, 5);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(828, 418);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geral";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // livrosDataGridView
            // 
            this.livrosDataGridView.AutoGenerateColumns = false;
            this.livrosDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.livrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livrosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.livrosDataGridView.DataSource = this.livrosBindingSource;
            this.livrosDataGridView.Location = new System.Drawing.Point(0, 100);
            this.livrosDataGridView.Name = "livrosDataGridView";
            this.livrosDataGridView.Size = new System.Drawing.Size(828, 318);
            this.livrosDataGridView.TabIndex = 3;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdLivro";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Título";
            this.dataGridViewTextBoxColumn4.HeaderText = "Título";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Width = 150;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Autor";
            this.dataGridViewTextBoxColumn5.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 150;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdEditora";
            this.dataGridViewTextBoxColumn2.HeaderText = "Editora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Edição";
            this.dataGridViewTextBoxColumn6.HeaderText = "Edição";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "IDCategoriaLivros";
            this.dataGridViewTextBoxColumn7.HeaderText = "Categoria";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            this.dataGridViewTextBoxColumn7.Width = 150;
            // 
            // radiobtn_titulo_livro
            // 
            this.radiobtn_titulo_livro.AutoSize = true;
            this.radiobtn_titulo_livro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn_titulo_livro.Location = new System.Drawing.Point(9, 74);
            this.radiobtn_titulo_livro.Name = "radiobtn_titulo_livro";
            this.radiobtn_titulo_livro.Size = new System.Drawing.Size(55, 19);
            this.radiobtn_titulo_livro.TabIndex = 3;
            this.radiobtn_titulo_livro.TabStop = true;
            this.radiobtn_titulo_livro.Text = "Título";
            this.radiobtn_titulo_livro.UseVisualStyleBackColor = true;
            this.radiobtn_titulo_livro.CheckedChanged += new System.EventHandler(this.radiobtn_filme_titulo_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(8, 45);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
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
            this.tableAdapterManager.FilmesTableAdapter = null;
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
            // codigo_EANTextBox
            // 
            this.codigo_EANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Codigo EAN", true));
            this.codigo_EANTextBox.Location = new System.Drawing.Point(359, 49);
            this.codigo_EANTextBox.Name = "codigo_EANTextBox";
            this.codigo_EANTextBox.Size = new System.Drawing.Size(161, 20);
            this.codigo_EANTextBox.TabIndex = 14;
            // 
            // Frm_PesquisarLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(868, 653);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_PesquisarLivros";
            this.Text = "Pesquisar Livros";
            this.Load += new System.EventHandler(this.Frm_PesquisarLivros_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobtn_titulo_livro;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private BDPAPDataSet bDPAPDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private BDPAPDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private BDPAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idLivroTextBox;
        private System.Windows.Forms.TextBox idEditoraTextBox;
        private System.Windows.Forms.TextBox títuloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox ediçãoTextBox;
        private System.Windows.Forms.TextBox iDCategoriaLivrosTextBox;
        private System.Windows.Forms.DataGridView livrosDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        //private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.TextBox codigo_EANTextBox;
    }
}