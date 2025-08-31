
namespace PAP
{
    partial class Frm_RelatorioRequisicaoLivros
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RelatorioRequisicaoLivros));
            this.bDPAPDataSet = new PAP.BDPAPDataSet();
            this.requisicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requisicaoTableAdapter = new PAP.BDPAPDataSetTableAdapters.RequisicaoTableAdapter();
            this.tableAdapterManager = new PAP.BDPAPDataSetTableAdapters.TableAdapterManager();
            this.requisicaoDataGridView = new System.Windows.Forms.DataGridView();
            this.fichaAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fichaAlunoTableAdapter = new PAP.BDPAPDataSetTableAdapters.FichaAlunoTableAdapter();
            this.fichaFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fichaFuncionarioTableAdapter = new PAP.BDPAPDataSetTableAdapters.FichaFuncionarioTableAdapter();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.livrosTableAdapter = new PAP.BDPAPDataSetTableAdapters.LivrosTableAdapter();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bDPAPDataSet
            // 
            this.bDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.bDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requisicaoBindingSource
            // 
            this.requisicaoBindingSource.DataMember = "Requisicao";
            this.requisicaoBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // requisicaoTableAdapter
            // 
            this.requisicaoTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaFilmesTableAdapter = null;
            this.tableAdapterManager.CategoriaLivrosTableAdapter = null;
            this.tableAdapterManager.ComputadoresTableAdapter = null;
            this.tableAdapterManager.EditoraLivrosTableAdapter = null;
            this.tableAdapterManager.FichaAlunoTableAdapter = this.fichaAlunoTableAdapter;
            this.tableAdapterManager.FichaFuncionarioTableAdapter = this.fichaFuncionarioTableAdapter;
            this.tableAdapterManager.FichaProfessoresTableAdapter = null;
            this.tableAdapterManager.FilmesTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoComputadorTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoFilmesTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoLivrosTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoTabletTableAdapter = null;
            this.tableAdapterManager.LivrosTableAdapter = this.livrosTableAdapter;
            this.tableAdapterManager.RequisicaoComputadorTableAdapter = null;
            this.tableAdapterManager.RequisicaoTableAdapter = this.requisicaoTableAdapter;
            this.tableAdapterManager.RequisicaoTabletsTableAdapter = null;
            this.tableAdapterManager.RequisitacaoTableAdapter = null;
            this.tableAdapterManager.TabletsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.BDPAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitanteTableAdapter = null;
            // 
            // requisicaoDataGridView
            // 
            this.requisicaoDataGridView.AutoGenerateColumns = false;
            this.requisicaoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requisicaoDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.requisicaoDataGridView.DataSource = this.requisicaoBindingSource;
            this.requisicaoDataGridView.Location = new System.Drawing.Point(3, 1);
            this.requisicaoDataGridView.Name = "requisicaoDataGridView";
            this.requisicaoDataGridView.Size = new System.Drawing.Size(786, 407);
            this.requisicaoDataGridView.TabIndex = 1;
            // 
            // fichaAlunoBindingSource
            // 
            this.fichaAlunoBindingSource.DataMember = "FichaAluno";
            this.fichaAlunoBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // fichaAlunoTableAdapter
            // 
            this.fichaAlunoTableAdapter.ClearBeforeFill = true;
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
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDRequisicao";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdAluno";
            this.dataGridViewTextBoxColumn2.DataSource = this.fichaAlunoBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Aluno";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "IdAluno";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdFuncionário";
            this.dataGridViewTextBoxColumn3.DataSource = this.fichaFuncionarioBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Nome";
            this.dataGridViewTextBoxColumn3.HeaderText = "Funcionário";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IdFuncionário";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdLivro";
            this.dataGridViewTextBoxColumn4.DataSource = this.livrosBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Título";
            this.dataGridViewTextBoxColumn4.HeaderText = "Livro";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IdLivro";
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Requisitado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Requisitado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data de saída";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data de saída";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 110;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Data de entrega";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data de entrega";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 110;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(659, 414);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 32);
            this.button1.TabIndex = 4;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click_1);
            // 
            // Frm_RelatorioRequisicaoLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.requisicaoDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_RelatorioRequisicaoLivros";
            this.Text = "Requisição Livros";
            this.Load += new System.EventHandler(this.Frm_RelatorioRequisicaoLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BDPAPDataSet bDPAPDataSet;
        private System.Windows.Forms.BindingSource requisicaoBindingSource;
        private BDPAPDataSetTableAdapters.RequisicaoTableAdapter requisicaoTableAdapter;
        private BDPAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BDPAPDataSetTableAdapters.FichaAlunoTableAdapter fichaAlunoTableAdapter;
        private System.Windows.Forms.DataGridView requisicaoDataGridView;
        private System.Windows.Forms.BindingSource fichaAlunoBindingSource;
        private BDPAPDataSetTableAdapters.FichaFuncionarioTableAdapter fichaFuncionarioTableAdapter;
        private System.Windows.Forms.BindingSource fichaFuncionarioBindingSource;
        private BDPAPDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
    }
}