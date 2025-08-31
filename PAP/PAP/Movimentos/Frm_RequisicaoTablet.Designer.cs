
namespace PAP
{
    partial class Frm_RequisicaoTablet
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
            System.Windows.Forms.Label iDRequisicaoTabletLabel;
            System.Windows.Forms.Label idTabletsLabel;
            System.Windows.Forms.Label idAlunoLabel;
            System.Windows.Forms.Label idFuncionárioLabel;
            System.Windows.Forms.Label requisitadoLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label horaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RequisicaoTablet));
            this.bDPAPDataSet = new PAP.BDPAPDataSet();
            this.requisicaoTabletsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requisicaoTabletsTableAdapter = new PAP.BDPAPDataSetTableAdapters.RequisicaoTabletsTableAdapter();
            this.tableAdapterManager = new PAP.BDPAPDataSetTableAdapters.TableAdapterManager();
            this.iDRequisicaoTabletTextBox = new System.Windows.Forms.TextBox();
            this.requisitadoCheckBox = new System.Windows.Forms.CheckBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.fichaAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fichaAlunoTableAdapter = new PAP.BDPAPDataSetTableAdapters.FichaAlunoTableAdapter();
            this.fichaFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.fichaFuncionarioTableAdapter = new PAP.BDPAPDataSetTableAdapters.FichaFuncionarioTableAdapter();
            this.tabletsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.tabletsTableAdapter = new PAP.BDPAPDataSetTableAdapters.TabletsTableAdapter();
            this.btn_guardar = new System.Windows.Forms.Button();
            iDRequisicaoTabletLabel = new System.Windows.Forms.Label();
            idTabletsLabel = new System.Windows.Forms.Label();
            idAlunoLabel = new System.Windows.Forms.Label();
            idFuncionárioLabel = new System.Windows.Forms.Label();
            requisitadoLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoTabletsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletsBindingSource)).BeginInit();
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
            this.tableAdapterManager.FichaAlunoTableAdapter = this.fichaAlunoTableAdapter;
            this.tableAdapterManager.FichaFuncionarioTableAdapter = this.fichaFuncionarioTableAdapter;
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
            this.tableAdapterManager.TabletsTableAdapter = this.tabletsTableAdapter;
            this.tableAdapterManager.UpdateOrder = PAP.BDPAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitanteTableAdapter = null;
            // 
            // iDRequisicaoTabletLabel
            // 
            iDRequisicaoTabletLabel.AutoSize = true;
            iDRequisicaoTabletLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDRequisicaoTabletLabel.Location = new System.Drawing.Point(32, 55);
            iDRequisicaoTabletLabel.Name = "iDRequisicaoTabletLabel";
            iDRequisicaoTabletLabel.Size = new System.Drawing.Size(55, 16);
            iDRequisicaoTabletLabel.TabIndex = 1;
            iDRequisicaoTabletLabel.Text = "Código:";
            // 
            // iDRequisicaoTabletTextBox
            // 
            this.iDRequisicaoTabletTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requisicaoTabletsBindingSource, "IDRequisicaoTablet", true));
            this.iDRequisicaoTabletTextBox.Location = new System.Drawing.Point(35, 74);
            this.iDRequisicaoTabletTextBox.Name = "iDRequisicaoTabletTextBox";
            this.iDRequisicaoTabletTextBox.Size = new System.Drawing.Size(139, 20);
            this.iDRequisicaoTabletTextBox.TabIndex = 2;
            // 
            // idTabletsLabel
            // 
            idTabletsLabel.AutoSize = true;
            idTabletsLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idTabletsLabel.Location = new System.Drawing.Point(32, 229);
            idTabletsLabel.Name = "idTabletsLabel";
            idTabletsLabel.Size = new System.Drawing.Size(50, 16);
            idTabletsLabel.TabIndex = 3;
            idTabletsLabel.Text = "Tablet:";
            // 
            // idAlunoLabel
            // 
            idAlunoLabel.AutoSize = true;
            idAlunoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idAlunoLabel.Location = new System.Drawing.Point(32, 122);
            idAlunoLabel.Name = "idAlunoLabel";
            idAlunoLabel.Size = new System.Drawing.Size(45, 16);
            idAlunoLabel.TabIndex = 5;
            idAlunoLabel.Text = "Aluno:";
            // 
            // idFuncionárioLabel
            // 
            idFuncionárioLabel.AutoSize = true;
            idFuncionárioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idFuncionárioLabel.Location = new System.Drawing.Point(32, 176);
            idFuncionárioLabel.Name = "idFuncionárioLabel";
            idFuncionárioLabel.Size = new System.Drawing.Size(81, 16);
            idFuncionárioLabel.TabIndex = 7;
            idFuncionárioLabel.Text = "Funcionário:";
            // 
            // requisitadoLabel
            // 
            requisitadoLabel.AutoSize = true;
            requisitadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            requisitadoLabel.Location = new System.Drawing.Point(336, 176);
            requisitadoLabel.Name = "requisitadoLabel";
            requisitadoLabel.Size = new System.Drawing.Size(84, 16);
            requisitadoLabel.TabIndex = 9;
            requisitadoLabel.Text = "Requisitado:";
            // 
            // requisitadoCheckBox
            // 
            this.requisitadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.requisicaoTabletsBindingSource, "Requisitado", true));
            this.requisitadoCheckBox.Location = new System.Drawing.Point(339, 192);
            this.requisitadoCheckBox.Name = "requisitadoCheckBox";
            this.requisitadoCheckBox.Size = new System.Drawing.Size(63, 24);
            this.requisitadoCheckBox.TabIndex = 10;
            this.requisitadoCheckBox.Text = "SIM";
            this.requisitadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLabel.Location = new System.Drawing.Point(336, 55);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(96, 16);
            dataLabel.TabIndex = 11;
            dataLabel.Text = "Data de saída:";
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requisicaoTabletsBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(339, 71);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 12;
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horaLabel.Location = new System.Drawing.Point(336, 122);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(105, 16);
            horaLabel.TabIndex = 13;
            horaLabel.Text = "Data de entrega";
            // 
            // horaDateTimePicker
            // 
            this.horaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requisicaoTabletsBindingSource, "Hora", true));
            this.horaDateTimePicker.Location = new System.Drawing.Point(339, 138);
            this.horaDateTimePicker.Name = "horaDateTimePicker";
            this.horaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.horaDateTimePicker.TabIndex = 14;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(180, 74);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(54, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.requisicaoTabletsBindingSource, "IdFuncionário", true));
            this.comboBox1.DataSource = this.fichaFuncionarioBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(35, 192);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 16;
            this.comboBox1.ValueMember = "IdFuncionário";
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.requisicaoTabletsBindingSource, "IdAluno", true));
            this.comboBox2.DataSource = this.fichaAlunoBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(35, 141);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(199, 21);
            this.comboBox2.TabIndex = 17;
            this.comboBox2.ValueMember = "IdAluno";
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.requisicaoTabletsBindingSource, "IdTablets", true));
            this.comboBox3.DataSource = this.tabletsBindingSource;
            this.comboBox3.DisplayMember = "Número";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(35, 248);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 18;
            this.comboBox3.ValueMember = "IdTablets";
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
            // tabletsBindingSource
            // 
            this.tabletsBindingSource.DataMember = "Tablets";
            this.tabletsBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // tabletsTableAdapter
            // 
            this.tabletsTableAdapter.ClearBeforeFill = true;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(365, 229);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(160, 47);
            this.btn_guardar.TabIndex = 19;
            this.btn_guardar.Text = "Concluir";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Frm_RequisicaoTablet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(655, 305);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(iDRequisicaoTabletLabel);
            this.Controls.Add(this.iDRequisicaoTabletTextBox);
            this.Controls.Add(idTabletsLabel);
            this.Controls.Add(idAlunoLabel);
            this.Controls.Add(idFuncionárioLabel);
            this.Controls.Add(requisitadoLabel);
            this.Controls.Add(this.requisitadoCheckBox);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.horaDateTimePicker);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Frm_RequisicaoTablet";
            this.Text = "Requisição Tablet";
            this.Load += new System.EventHandler(this.Frm_RequisicaoTablet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoTabletsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tabletsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDPAPDataSet bDPAPDataSet;
        private System.Windows.Forms.BindingSource requisicaoTabletsBindingSource;
        private BDPAPDataSetTableAdapters.RequisicaoTabletsTableAdapter requisicaoTabletsTableAdapter;
        private BDPAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDRequisicaoTabletTextBox;
        private System.Windows.Forms.CheckBox requisitadoCheckBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.DateTimePicker horaDateTimePicker;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private BDPAPDataSetTableAdapters.FichaAlunoTableAdapter fichaAlunoTableAdapter;
        private System.Windows.Forms.BindingSource fichaAlunoBindingSource;
        private BDPAPDataSetTableAdapters.FichaFuncionarioTableAdapter fichaFuncionarioTableAdapter;
        private System.Windows.Forms.BindingSource fichaFuncionarioBindingSource;
        private BDPAPDataSetTableAdapters.TabletsTableAdapter tabletsTableAdapter;
        private System.Windows.Forms.BindingSource tabletsBindingSource;
        private System.Windows.Forms.Button btn_guardar;
    }
}