
namespace PAP
{
    partial class Frm_PesquisarTablet
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
            System.Windows.Forms.Label idTabletsLabel;
            System.Windows.Forms.Label númeroLabel;
            System.Windows.Forms.Label modeloLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PesquisarTablet));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idTabletsTextBox = new System.Windows.Forms.TextBox();
            this.númeroTextBox = new System.Windows.Forms.TextBox();
            this.modeloTextBox = new System.Windows.Forms.TextBox();
            this.bDPAPDataSet = new PAP.BDPAPDataSet();
            this.tabletsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tableAdapterManager = new PAP.BDPAPDataSetTableAdapters.TableAdapterManager();
            this.tabletsTableAdapter = new PAP.BDPAPDataSetTableAdapters.TabletsTableAdapter();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabletsDataGridView = new System.Windows.Forms.DataGridView();
            idTabletsLabel = new System.Windows.Forms.Label();
            númeroLabel = new System.Windows.Forms.Label();
            modeloLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // idTabletsLabel
            // 
            idTabletsLabel.AutoSize = true;
            idTabletsLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idTabletsLabel.Location = new System.Drawing.Point(53, 42);
            idTabletsLabel.Name = "idTabletsLabel";
            idTabletsLabel.Size = new System.Drawing.Size(55, 16);
            idTabletsLabel.TabIndex = 0;
            idTabletsLabel.Text = "Código:";
            // 
            // númeroLabel
            // 
            númeroLabel.AutoSize = true;
            númeroLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            númeroLabel.Location = new System.Drawing.Point(53, 105);
            númeroLabel.Name = "númeroLabel";
            númeroLabel.Size = new System.Drawing.Size(63, 16);
            númeroLabel.TabIndex = 2;
            númeroLabel.Text = "Número:";
            // 
            // modeloLabel
            // 
            modeloLabel.AutoSize = true;
            modeloLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            modeloLabel.Location = new System.Drawing.Point(322, 44);
            modeloLabel.Name = "modeloLabel";
            modeloLabel.Size = new System.Drawing.Size(59, 16);
            modeloLabel.TabIndex = 4;
            modeloLabel.Text = "Modelo:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.tabletsDataGridView);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(650, 217);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geral";
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(idTabletsLabel);
            this.groupBox2.Controls.Add(this.idTabletsTextBox);
            this.groupBox2.Controls.Add(númeroLabel);
            this.groupBox2.Controls.Add(this.númeroTextBox);
            this.groupBox2.Controls.Add(modeloLabel);
            this.groupBox2.Controls.Add(this.modeloTextBox);
            this.groupBox2.Location = new System.Drawing.Point(12, 261);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(650, 183);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // idTabletsTextBox
            // 
            this.idTabletsTextBox.Location = new System.Drawing.Point(56, 61);
            this.idTabletsTextBox.Name = "idTabletsTextBox";
            this.idTabletsTextBox.Size = new System.Drawing.Size(168, 20);
            this.idTabletsTextBox.TabIndex = 1;
            // 
            // númeroTextBox
            // 
            this.númeroTextBox.Location = new System.Drawing.Point(56, 124);
            this.númeroTextBox.Name = "númeroTextBox";
            this.númeroTextBox.Size = new System.Drawing.Size(168, 20);
            this.númeroTextBox.TabIndex = 3;
            // 
            // modeloTextBox
            // 
            this.modeloTextBox.Location = new System.Drawing.Point(325, 61);
            this.modeloTextBox.Name = "modeloTextBox";
            this.modeloTextBox.Size = new System.Drawing.Size(168, 20);
            this.modeloTextBox.TabIndex = 5;
            // 
            // bDPAPDataSet
            // 
            this.bDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.bDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tabletsBindingSource
            // 
            this.tabletsBindingSource.DataMember = "Tablets";
            this.tabletsBindingSource.DataSource = this.bDPAPDataSet;
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
            this.tableAdapterManager.RequisicaoTabletsTableAdapter = null;
            this.tableAdapterManager.RequisitacaoTableAdapter = null;
            this.tableAdapterManager.TabletsTableAdapter = this.tabletsTableAdapter;
            this.tableAdapterManager.UpdateOrder = PAP.BDPAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitanteTableAdapter = null;
            // 
            // tabletsTableAdapter
            // 
            this.tabletsTableAdapter.ClearBeforeFill = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Modelo";
            this.dataGridViewTextBoxColumn3.HeaderText = "Modelo";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.Width = 250;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Número";
            this.dataGridViewTextBoxColumn2.HeaderText = "Número";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Width = 150;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdTablets";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 60;
            // 
            // tabletsDataGridView
            // 
            this.tabletsDataGridView.AutoGenerateColumns = false;
            this.tabletsDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.tabletsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tabletsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3});
            this.tabletsDataGridView.DataSource = this.tabletsBindingSource;
            this.tabletsDataGridView.Location = new System.Drawing.Point(6, 19);
            this.tabletsDataGridView.Name = "tabletsDataGridView";
            this.tabletsDataGridView.Size = new System.Drawing.Size(638, 193);
            this.tabletsDataGridView.TabIndex = 4;
            // 
            // Frm_PesquisarTablet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(676, 450);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_PesquisarTablet";
            this.Text = "Pesquisar Tablet";
            this.Load += new System.EventHandler(this.Frm_PesquisarTablet_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletsDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox idTabletsTextBox;
        private System.Windows.Forms.TextBox númeroTextBox;
        private System.Windows.Forms.TextBox modeloTextBox;
        private System.Windows.Forms.DataGridView tabletsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.BindingSource tabletsBindingSource;
        private BDPAPDataSet bDPAPDataSet;
        private BDPAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private BDPAPDataSetTableAdapters.TabletsTableAdapter tabletsTableAdapter;
    }
}