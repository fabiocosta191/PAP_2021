
namespace PAP
{
    partial class Frm_RelatorioRequisicaoTablet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RelatorioRequisicaoTablet));
            this.bDPAPDataSet = new PAP.BDPAPDataSet();
            this.requisicaoTabletsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requisicaoTabletsTableAdapter = new PAP.BDPAPDataSetTableAdapters.RequisicaoTabletsTableAdapter();
            this.tableAdapterManager = new PAP.BDPAPDataSetTableAdapters.TableAdapterManager();
            this.requisicaoTabletsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.tabletsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.fichaFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabletsTableAdapter = new PAP.BDPAPDataSetTableAdapters.TabletsTableAdapter();
            this.fichaFuncionarioTableAdapter = new PAP.BDPAPDataSetTableAdapters.FichaFuncionarioTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoTabletsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoTabletsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaFuncionarioBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // bDPAPDataSet
            // 
            this.bDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.bDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requisicaoTabletsBindingSource
            // 
            this.requisicaoTabletsBindingSource.DataMember = "RequisicaoTablets";
            this.requisicaoTabletsBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // requisicaoTabletsTableAdapter
            // 
            this.requisicaoTabletsTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.LivrosTableAdapter = null;
            this.tableAdapterManager.RequisicaoComputadorTableAdapter = null;
            this.tableAdapterManager.RequisicaoTableAdapter = null;
            this.tableAdapterManager.RequisicaoTabletsTableAdapter = this.requisicaoTabletsTableAdapter;
            this.tableAdapterManager.RequisitacaoTableAdapter = null;
            this.tableAdapterManager.TabletsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.BDPAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitanteTableAdapter = null;
            // 
            // requisicaoTabletsDataGridView
            // 
            this.requisicaoTabletsDataGridView.AutoGenerateColumns = false;
            this.requisicaoTabletsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.requisicaoTabletsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewCheckBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.requisicaoTabletsDataGridView.DataSource = this.requisicaoTabletsBindingSource;
            this.requisicaoTabletsDataGridView.Location = new System.Drawing.Point(0, 0);
            this.requisicaoTabletsDataGridView.Name = "requisicaoTabletsDataGridView";
            this.requisicaoTabletsDataGridView.Size = new System.Drawing.Size(805, 409);
            this.requisicaoTabletsDataGridView.TabIndex = 1;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IDRequisicaoTablet";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdTablets";
            this.dataGridViewTextBoxColumn2.HeaderText = "Tablet";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "IdAluno";
            this.dataGridViewTextBoxColumn3.DataSource = this.tabletsBindingSource;
            this.dataGridViewTextBoxColumn3.DisplayMember = "Número";
            this.dataGridViewTextBoxColumn3.HeaderText = "Aluno";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn3.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn3.ValueMember = "IdTablets";
            // 
            // tabletsBindingSource
            // 
            this.tabletsBindingSource.DataMember = "Tablets";
            this.tabletsBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "IdFuncionário";
            this.dataGridViewTextBoxColumn4.DataSource = this.fichaFuncionarioBindingSource;
            this.dataGridViewTextBoxColumn4.DisplayMember = "Nome";
            this.dataGridViewTextBoxColumn4.HeaderText = "Funcionário";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn4.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn4.ValueMember = "IdFuncionário";
            // 
            // fichaFuncionarioBindingSource
            // 
            this.fichaFuncionarioBindingSource.DataMember = "FichaFuncionario";
            this.fichaFuncionarioBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Requisitado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Requisitado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Data";
            this.dataGridViewTextBoxColumn5.HeaderText = "Data de saída";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.Width = 120;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Hora";
            this.dataGridViewTextBoxColumn6.HeaderText = "Data de entrega";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.Width = 120;
            // 
            // tabletsTableAdapter
            // 
            this.tabletsTableAdapter.ClearBeforeFill = true;
            // 
            // fichaFuncionarioTableAdapter
            // 
            this.fichaFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(669, 415);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(119, 32);
            this.button1.TabIndex = 3;
            this.button1.Text = "Guardar";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Frm_RelatorioRequisicaoTablet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.requisicaoTabletsDataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_RelatorioRequisicaoTablet";
            this.Text = "Requisição Tablet";
            this.Load += new System.EventHandler(this.Frm_RelatorioRequisicaoTablet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoTabletsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoTabletsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaFuncionarioBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private BDPAPDataSet bDPAPDataSet;
        private System.Windows.Forms.BindingSource requisicaoTabletsBindingSource;
        private BDPAPDataSetTableAdapters.RequisicaoTabletsTableAdapter requisicaoTabletsTableAdapter;
        private BDPAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView requisicaoTabletsDataGridView;
        private System.Windows.Forms.BindingSource tabletsBindingSource;
        private BDPAPDataSetTableAdapters.TabletsTableAdapter tabletsTableAdapter;
        private System.Windows.Forms.BindingSource fichaFuncionarioBindingSource;
        private BDPAPDataSetTableAdapters.FichaFuncionarioTableAdapter fichaFuncionarioTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.Button button1;
    }
}