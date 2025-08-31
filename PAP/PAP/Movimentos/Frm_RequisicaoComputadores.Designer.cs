
namespace PAP
{
    partial class Frm_RequisicaoComputadores
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
            System.Windows.Forms.Label iDRequisicaoComputadorLabel;
            System.Windows.Forms.Label idComputadorLabel;
            System.Windows.Forms.Label idAlunoLabel;
            System.Windows.Forms.Label requisitadoLabel;
            System.Windows.Forms.Label idFuncionárioLabel;
            System.Windows.Forms.Label dataLabel;
            System.Windows.Forms.Label horaLabel;
            this.bDPAPDataSet = new PAP.BDPAPDataSet();
            this.requisicaoComputadorBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requisicaoComputadorTableAdapter = new PAP.BDPAPDataSetTableAdapters.RequisicaoComputadorTableAdapter();
            this.tableAdapterManager = new PAP.BDPAPDataSetTableAdapters.TableAdapterManager();
            this.computadoresTableAdapter = new PAP.BDPAPDataSetTableAdapters.ComputadoresTableAdapter();
            this.fichaAlunoTableAdapter = new PAP.BDPAPDataSetTableAdapters.FichaAlunoTableAdapter();
            this.fichaFuncionarioTableAdapter = new PAP.BDPAPDataSetTableAdapters.FichaFuncionarioTableAdapter();
            this.iDRequisicaoComputadorTextBox = new System.Windows.Forms.TextBox();
            this.requisitadoCheckBox = new System.Windows.Forms.CheckBox();
            this.dataDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.horaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.fichaAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.requisicaoComputadorBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.fichaFuncionarioBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.computadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            iDRequisicaoComputadorLabel = new System.Windows.Forms.Label();
            idComputadorLabel = new System.Windows.Forms.Label();
            idAlunoLabel = new System.Windows.Forms.Label();
            requisitadoLabel = new System.Windows.Forms.Label();
            idFuncionárioLabel = new System.Windows.Forms.Label();
            dataLabel = new System.Windows.Forms.Label();
            horaLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoComputadorBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoComputadorBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaFuncionarioBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadoresBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // iDRequisicaoComputadorLabel
            // 
            iDRequisicaoComputadorLabel.AutoSize = true;
            iDRequisicaoComputadorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDRequisicaoComputadorLabel.Location = new System.Drawing.Point(36, 29);
            iDRequisicaoComputadorLabel.Name = "iDRequisicaoComputadorLabel";
            iDRequisicaoComputadorLabel.Size = new System.Drawing.Size(55, 16);
            iDRequisicaoComputadorLabel.TabIndex = 1;
            iDRequisicaoComputadorLabel.Text = "Código:";
            // 
            // idComputadorLabel
            // 
            idComputadorLabel.AutoSize = true;
            idComputadorLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idComputadorLabel.Location = new System.Drawing.Point(36, 213);
            idComputadorLabel.Name = "idComputadorLabel";
            idComputadorLabel.Size = new System.Drawing.Size(85, 16);
            idComputadorLabel.TabIndex = 3;
            idComputadorLabel.Text = "Computador:";
            // 
            // idAlunoLabel
            // 
            idAlunoLabel.AutoSize = true;
            idAlunoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idAlunoLabel.Location = new System.Drawing.Point(36, 95);
            idAlunoLabel.Name = "idAlunoLabel";
            idAlunoLabel.Size = new System.Drawing.Size(45, 16);
            idAlunoLabel.TabIndex = 5;
            idAlunoLabel.Text = "Aluno:";
            // 
            // requisitadoLabel
            // 
            requisitadoLabel.AutoSize = true;
            requisitadoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            requisitadoLabel.Location = new System.Drawing.Point(396, 157);
            requisitadoLabel.Name = "requisitadoLabel";
            requisitadoLabel.Size = new System.Drawing.Size(84, 16);
            requisitadoLabel.TabIndex = 7;
            requisitadoLabel.Text = "Requisitado:";
            // 
            // idFuncionárioLabel
            // 
            idFuncionárioLabel.AutoSize = true;
            idFuncionárioLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idFuncionárioLabel.Location = new System.Drawing.Point(36, 157);
            idFuncionárioLabel.Name = "idFuncionárioLabel";
            idFuncionárioLabel.Size = new System.Drawing.Size(81, 16);
            idFuncionárioLabel.TabIndex = 9;
            idFuncionárioLabel.Text = "Funcionário:";
            // 
            // dataLabel
            // 
            dataLabel.AutoSize = true;
            dataLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataLabel.Location = new System.Drawing.Point(396, 29);
            dataLabel.Name = "dataLabel";
            dataLabel.Size = new System.Drawing.Size(96, 16);
            dataLabel.TabIndex = 11;
            dataLabel.Text = "Data de saída:";
            // 
            // horaLabel
            // 
            horaLabel.AutoSize = true;
            horaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            horaLabel.Location = new System.Drawing.Point(396, 95);
            horaLabel.Name = "horaLabel";
            horaLabel.Size = new System.Drawing.Size(108, 16);
            horaLabel.TabIndex = 13;
            horaLabel.Text = "Data de entrega:";
            // 
            // bDPAPDataSet
            // 
            this.bDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.bDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // requisicaoComputadorBindingSource
            // 
            this.requisicaoComputadorBindingSource.DataMember = "RequisicaoComputador";
            this.requisicaoComputadorBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // requisicaoComputadorTableAdapter
            // 
            this.requisicaoComputadorTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaFilmesTableAdapter = null;
            this.tableAdapterManager.CategoriaLivrosTableAdapter = null;
            this.tableAdapterManager.ComputadoresTableAdapter = this.computadoresTableAdapter;
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
            this.tableAdapterManager.RequisicaoComputadorTableAdapter = this.requisicaoComputadorTableAdapter;
            this.tableAdapterManager.RequisicaoTableAdapter = null;
            this.tableAdapterManager.RequisicaoTabletsTableAdapter = null;
            this.tableAdapterManager.RequisitacaoTableAdapter = null;
            this.tableAdapterManager.TabletsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.BDPAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitanteTableAdapter = null;
            // 
            // computadoresTableAdapter
            // 
            this.computadoresTableAdapter.ClearBeforeFill = true;
            // 
            // fichaAlunoTableAdapter
            // 
            this.fichaAlunoTableAdapter.ClearBeforeFill = true;
            // 
            // fichaFuncionarioTableAdapter
            // 
            this.fichaFuncionarioTableAdapter.ClearBeforeFill = true;
            // 
            // iDRequisicaoComputadorTextBox
            // 
            this.iDRequisicaoComputadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.requisicaoComputadorBindingSource, "IDRequisicaoComputador", true));
            this.iDRequisicaoComputadorTextBox.Location = new System.Drawing.Point(39, 48);
            this.iDRequisicaoComputadorTextBox.Name = "iDRequisicaoComputadorTextBox";
            this.iDRequisicaoComputadorTextBox.Size = new System.Drawing.Size(138, 20);
            this.iDRequisicaoComputadorTextBox.TabIndex = 2;
            // 
            // requisitadoCheckBox
            // 
            this.requisitadoCheckBox.DataBindings.Add(new System.Windows.Forms.Binding("CheckState", this.requisicaoComputadorBindingSource, "Requisitado", true));
            this.requisitadoCheckBox.Location = new System.Drawing.Point(399, 173);
            this.requisitadoCheckBox.Name = "requisitadoCheckBox";
            this.requisitadoCheckBox.Size = new System.Drawing.Size(200, 24);
            this.requisitadoCheckBox.TabIndex = 8;
            this.requisitadoCheckBox.Text = "SIM";
            this.requisitadoCheckBox.UseVisualStyleBackColor = true;
            // 
            // dataDateTimePicker
            // 
            this.dataDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requisicaoComputadorBindingSource, "Data", true));
            this.dataDateTimePicker.Location = new System.Drawing.Point(399, 45);
            this.dataDateTimePicker.Name = "dataDateTimePicker";
            this.dataDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.dataDateTimePicker.TabIndex = 12;
            // 
            // horaDateTimePicker
            // 
            this.horaDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.requisicaoComputadorBindingSource, "Hora", true));
            this.horaDateTimePicker.Location = new System.Drawing.Point(399, 111);
            this.horaDateTimePicker.Name = "horaDateTimePicker";
            this.horaDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.horaDateTimePicker.TabIndex = 14;
            // 
            // btn_guardar
            // 
            this.btn_guardar.Location = new System.Drawing.Point(414, 205);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(160, 47);
            this.btn_guardar.TabIndex = 16;
            this.btn_guardar.Text = "Concluir";
            this.btn_guardar.UseVisualStyleBackColor = true;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(183, 48);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(56, 23);
            this.button1.TabIndex = 17;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.requisicaoComputadorBindingSource, "IdAluno", true));
            this.comboBox1.DataSource = this.fichaAlunoBindingSource;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(39, 114);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(200, 21);
            this.comboBox1.TabIndex = 18;
            this.comboBox1.ValueMember = "IdAluno";
            // 
            // fichaAlunoBindingSource
            // 
            this.fichaAlunoBindingSource.DataMember = "FichaAluno";
            this.fichaAlunoBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // requisicaoComputadorBindingSource1
            // 
            this.requisicaoComputadorBindingSource1.DataMember = "RequisicaoComputador";
            this.requisicaoComputadorBindingSource1.DataSource = this.bDPAPDataSet;
            // 
            // comboBox2
            // 
            this.comboBox2.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.requisicaoComputadorBindingSource, "IdFuncionário", true));
            this.comboBox2.DataSource = this.fichaFuncionarioBindingSource;
            this.comboBox2.DisplayMember = "Nome";
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(39, 175);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(200, 21);
            this.comboBox2.TabIndex = 19;
            this.comboBox2.ValueMember = "IdFuncionário";
            // 
            // fichaFuncionarioBindingSource
            // 
            this.fichaFuncionarioBindingSource.DataMember = "FichaFuncionario";
            this.fichaFuncionarioBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // comboBox3
            // 
            this.comboBox3.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.requisicaoComputadorBindingSource, "IdComputador", true));
            this.comboBox3.DataSource = this.computadoresBindingSource;
            this.comboBox3.DisplayMember = "Número";
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(39, 230);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(200, 21);
            this.comboBox3.TabIndex = 20;
            this.comboBox3.ValueMember = "IdComputador";
            // 
            // computadoresBindingSource
            // 
            this.computadoresBindingSource.DataMember = "Computadores";
            this.computadoresBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // Frm_RequisicaoComputadores
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(654, 271);
            this.Controls.Add(this.comboBox3);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(iDRequisicaoComputadorLabel);
            this.Controls.Add(this.iDRequisicaoComputadorTextBox);
            this.Controls.Add(idComputadorLabel);
            this.Controls.Add(idAlunoLabel);
            this.Controls.Add(requisitadoLabel);
            this.Controls.Add(this.requisitadoCheckBox);
            this.Controls.Add(idFuncionárioLabel);
            this.Controls.Add(dataLabel);
            this.Controls.Add(this.dataDateTimePicker);
            this.Controls.Add(horaLabel);
            this.Controls.Add(this.horaDateTimePicker);
            this.Name = "Frm_RequisicaoComputadores";
            this.Text = "Frm_RequisicaoComputadores";
            this.Load += new System.EventHandler(this.Frm_RequisicaoComputadores_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoComputadorBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.requisicaoComputadorBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaFuncionarioBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadoresBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private BDPAPDataSet bDPAPDataSet;
        private System.Windows.Forms.BindingSource requisicaoComputadorBindingSource;
        private BDPAPDataSetTableAdapters.RequisicaoComputadorTableAdapter requisicaoComputadorTableAdapter;
        private BDPAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox iDRequisicaoComputadorTextBox;
        private System.Windows.Forms.CheckBox requisitadoCheckBox;
        private System.Windows.Forms.DateTimePicker dataDateTimePicker;
        private System.Windows.Forms.DateTimePicker horaDateTimePicker;
        private System.Windows.Forms.Button btn_guardar;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource requisicaoComputadorBindingSource1;
        private BDPAPDataSetTableAdapters.FichaAlunoTableAdapter fichaAlunoTableAdapter;
        private System.Windows.Forms.BindingSource fichaAlunoBindingSource;
        private BDPAPDataSetTableAdapters.FichaFuncionarioTableAdapter fichaFuncionarioTableAdapter;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.BindingSource fichaFuncionarioBindingSource;
        private BDPAPDataSetTableAdapters.ComputadoresTableAdapter computadoresTableAdapter;
        private System.Windows.Forms.BindingSource computadoresBindingSource;
    }
}