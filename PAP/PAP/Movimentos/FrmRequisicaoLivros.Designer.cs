
namespace PAP
{
    partial class FrmRequisicaoLivros
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
            System.Windows.Forms.Label data_de_saídaLabel;
            System.Windows.Forms.Label data_de_entregaLabel;
            System.Windows.Forms.Label iDRequisicaoLabel;
            System.Windows.Forms.Label idFuncionárioLabel;
            System.Windows.Forms.Label idAlunoLabel;
            System.Windows.Forms.Label requisitadoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmRequisicaoLivros));
            this.bDPAPDataSet = new PAP.BDPAPDataSet();
            this.requisicaoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requisicaoTableAdapter = new PAP.BDPAPDataSetTableAdapters.RequisicaoTableAdapter();
            this.tableAdapterManager = new PAP.BDPAPDataSetTableAdapters.TableAdapterManager();
            this.iDRequisicaoTextBox = new System.Windows.Forms.TextBox();
            this.data_de_saídaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.data_de_entregaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.fichaAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fichaFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fichaAlunoTableAdapter = new PAP.BDPAPDataSetTableAdapters.FichaAlunoTableAdapter();
            this.fichaFuncionarioTableAdapter = new PAP.BDPAPDataSetTableAdapters.FichaFuncionarioTableAdapter();
            this.livrosTableAdapter = new PAP.BDPAPDataSetTableAdapters.LivrosTableAdapter();
            this.button1 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.requisitadoCheckBox = new System.Windows.Forms.CheckBox();
            idLivroLabel = new System.Windows.Forms.Label();
            data_de_saídaLabel = new System.Windows.Forms.Label();
            data_de_entregaLabel = new System.Windows.Forms.Label();
            iDRequisicaoLabel = new System.Windows.Forms.Label();
            idFuncionárioLabel = new System.Windows.Forms.Label();
            idAlunoLabel = new System.Windows.Forms.Label();
            requisitadoLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLivroLabel
            // 
            idLivroLabel.AutoSize = true;
            idLivroLabel.Location = new System.Drawing.Point(35, 247);
            idLivroLabel.Name = "idLivroLabel";
            idLivroLabel.Size = new System.Drawing.Size(33, 13);
            idLivroLabel.TabIndex = 7;
            idLivroLabel.Text = "Livro:";
            // 
            // data_de_saídaLabel
            // 
            data_de_saídaLabel.AutoSize = true;
            data_de_saídaLabel.Location = new System.Drawing.Point(477, 59);
            data_de_saídaLabel.Name = "data_de_saídaLabel";
            data_de_saídaLabel.Size = new System.Drawing.Size(78, 13);
            data_de_saídaLabel.TabIndex = 11;
            data_de_saídaLabel.Text = "Data de saída:";
            // 
            // data_de_entregaLabel
            // 
            data_de_entregaLabel.AutoSize = true;
            data_de_entregaLabel.Location = new System.Drawing.Point(480, 123);
            data_de_entregaLabel.Name = "data_de_entregaLabel";
            data_de_entregaLabel.Size = new System.Drawing.Size(87, 13);
            data_de_entregaLabel.TabIndex = 13;
            data_de_entregaLabel.Text = "Data de entrega:";
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
            this.tableAdapterManager.RequisicaoTableAdapter = this.requisicaoTableAdapter;
            this.tableAdapterManager.RequisicaoTabletsTableAdapter = null;
            this.tableAdapterManager.RequisitacaoTableAdapter = null;
            this.tableAdapterManager.TabletsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.BDPAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitanteTableAdapter = null;
            // 
            // iDRequisicaoTextBox
            // 
            this.iDRequisicaoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requisicaoBindingSource, "IDRequisicao", true));
            this.iDRequisicaoTextBox.Location = new System.Drawing.Point(38, 69);
            this.iDRequisicaoTextBox.Name = "iDRequisicaoTextBox";
            this.iDRequisicaoTextBox.Size = new System.Drawing.Size(148, 20);
            this.iDRequisicaoTextBox.TabIndex = 2;
            // 
            // data_de_saídaDateTimePicker
            // 
            this.data_de_saídaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requisicaoBindingSource, "Data de saída", true));
            this.data_de_saídaDateTimePicker.Location = new System.Drawing.Point(480, 75);
            this.data_de_saídaDateTimePicker.Name = "data_de_saídaDateTimePicker";
            this.data_de_saídaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_de_saídaDateTimePicker.TabIndex = 12;
            // 
            // data_de_entregaDateTimePicker
            // 
            this.data_de_entregaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requisicaoBindingSource, "Data de entrega", true));
            this.data_de_entregaDateTimePicker.Location = new System.Drawing.Point(483, 139);
            this.data_de_entregaDateTimePicker.Name = "data_de_entregaDateTimePicker";
            this.data_de_entregaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.data_de_entregaDateTimePicker.TabIndex = 14;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(483, 230);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(160, 47);
            this.btn_guardar.TabIndex = 15;
            this.btn_guardar.Text = "Concluir";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(244, 261);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(46, 23);
            this.button2.TabIndex = 17;
            this.button2.Text = "...";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // fichaAlunoBindingSource
            // 
            this.fichaAlunoBindingSource.DataMember = "FichaAluno";
            this.fichaAlunoBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // fichaFuncionarioBindingSource
            // 
            this.fichaFuncionarioBindingSource.DataMember = "FichaFuncionario";
            this.fichaFuncionarioBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.requisicaoBindingSource, "IdLivro", true));
            this.comboBox3.DataSource = this.livrosBindingSource;
            this.comboBox3.DisplayMember = "Título";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(38, 263);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 22;
            this.comboBox3.ValueMember = "IdLivro";
            // 
            // livrosBindingSource
            // 
            this.livrosBindingSource.DataMember = "Livros";
            this.livrosBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // fichaAlunoTableAdapter
            // 
            this.fichaAlunoTableAdapter.ClearBeforeFill = true;
            // 
            // fichaFuncionarioTableAdapter
            // 
            this.fichaFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(192, 67);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(46, 23);
            this.button1.TabIndex = 16;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // iDRequisicaoLabel
            // 
            iDRequisicaoLabel.AutoSize = true;
            iDRequisicaoLabel.Location = new System.Drawing.Point(35, 53);
            iDRequisicaoLabel.Name = "iDRequisicaoLabel";
            iDRequisicaoLabel.Size = new System.Drawing.Size(43, 13);
            iDRequisicaoLabel.TabIndex = 1;
            iDRequisicaoLabel.Text = "Código:";
            // 
            // idFuncionárioLabel
            // 
            idFuncionárioLabel.AutoSize = true;
            idFuncionárioLabel.Location = new System.Drawing.Point(35, 181);
            idFuncionárioLabel.Name = "idFuncionárioLabel";
            idFuncionárioLabel.Size = new System.Drawing.Size(65, 13);
            idFuncionárioLabel.TabIndex = 5;
            idFuncionárioLabel.Text = "Funcionário:";
            // 
            // idAlunoLabel
            // 
            idAlunoLabel.AutoSize = true;
            idAlunoLabel.Location = new System.Drawing.Point(35, 120);
            idAlunoLabel.Name = "idAlunoLabel";
            idAlunoLabel.Size = new System.Drawing.Size(37, 13);
            idAlunoLabel.TabIndex = 3;
            idAlunoLabel.Text = "Aluno:";
            // 
            // button4
            // 
            this.button4.Location = new System.Drawing.Point(244, 134);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(46, 23);
            this.button4.TabIndex = 19;
            this.button4.Text = "...";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.button4_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.requisicaoBindingSource, "IdAluno", true));
            this.comboBox1.DataSource = this.fichaAlunoBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(38, 137);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 20;
            this.comboBox1.ValueMember = "IdAluno";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.requisicaoBindingSource, "IdFuncionário", true));
            this.comboBox2.DataSource = this.fichaFuncionarioBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(38, 200);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 21;
            this.comboBox2.ValueMember = "IdFuncionário";
            // 
            // requisitadoCheckBox
            // 
            this.requisitadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.requisicaoBindingSource, "Requisitado", true));
            this.requisitadoCheckBox.Location = new System.Drawing.Point(483, 197);
            this.requisitadoCheckBox.Name = "requisitadoCheckBox";
            this.requisitadoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.requisitadoCheckBox.TabIndex = 10;
            this.requisitadoCheckBox.Text = "SIM";
            this.requisitadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // requisitadoLabel
            // 
            requisitadoLabel.AutoSize = true;
            requisitadoLabel.Location = new System.Drawing.Point(480, 181);
            requisitadoLabel.Name = "requisitadoLabel";
            requisitadoLabel.Size = new System.Drawing.Size(66, 13);
            requisitadoLabel.TabIndex = 9;
            requisitadoLabel.Text = "Requisitado:";
            // 
            // FrmRequisicaoLivros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(737, 305);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(iDRequisicaoLabel);
            this.Controls.Add(this.iDRequisicaoTextBox);
            this.Controls.Add(idAlunoLabel);
            this.Controls.Add(idFuncionárioLabel);
            this.Controls.Add(idLivroLabel);
            this.Controls.Add(requisitadoLabel);
            this.Controls.Add(this.requisitadoCheckBox);
            this.Controls.Add(data_de_saídaLabel);
            this.Controls.Add(this.data_de_saídaDateTimePicker);
            this.Controls.Add(data_de_entregaLabel);
            this.Controls.Add(this.data_de_entregaDateTimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "FrmRequisicaoLivros";
            this.Text = "Requisição Livros";
            this.Load += new System.EventHandler(this.FrmRequisicaoLivros_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDPAPDataSet bDPAPDataSet;
        private System.Windows.Forms.BindingSource requisicaoBindingSource;
        private BDPAPDataSetTableAdapters.RequisicaoTableAdapter requisicaoTableAdapter;
        private BDPAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDRequisicaoTextBox;
        private System.Windows.Forms.DateTimePicker data_de_saídaDateTimePicker;
        private System.Windows.Forms.DateTimePicker data_de_entregaDateTimePicker;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource fichaAlunoBindingSource;
        private BDPAPDataSetTableAdapters.FichaAlunoTableAdapter fichaAlunoTableAdapter;
        private System.Windows.Forms.BindingSource fichaFuncionarioBindingSource;
        private BDPAPDataSetTableAdapters.FichaFuncionarioTableAdapter fichaFuncionarioTableAdapter;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private BDPAPDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.CheckBox requisitadoCheckBox;
    }
}