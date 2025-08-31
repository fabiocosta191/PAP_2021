
namespace PAP
{
    partial class Frm_PesquisarProfessor
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
            System.Windows.Forms.Label idProfessorLabel;
            System.Windows.Forms.Label nomeLabel;
            System.Windows.Forms.Label nCartãoLabel;
            System.Windows.Forms.Label contactoLabel;
            System.Windows.Forms.Label emailLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_PesquisarProfessor));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.fichaProfessoresDataGridView = new System.Windows.Forms.DataGridView();
            this.idProfessorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nomeDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nCartãoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.contactoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.emailDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fichaProfessoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPAPDataSet = new PAP.BDPAPDataSet();
            this.radiobtn_ncartao_prof = new System.Windows.Forms.RadioButton();
            this.radiobtn_nome_prof = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.idProfessorTextBox = new System.Windows.Forms.TextBox();
            this.nomeTextBox = new System.Windows.Forms.TextBox();
            this.nCartãoTextBox = new System.Windows.Forms.TextBox();
            this.contactoTextBox = new System.Windows.Forms.TextBox();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.fichaProfessoresTableAdapter = new PAP.BDPAPDataSetTableAdapters.FichaProfessoresTableAdapter();
            this.tableAdapterManager = new PAP.BDPAPDataSetTableAdapters.TableAdapterManager();
            idProfessorLabel = new System.Windows.Forms.Label();
            nomeLabel = new System.Windows.Forms.Label();
            nCartãoLabel = new System.Windows.Forms.Label();
            contactoLabel = new System.Windows.Forms.Label();
            emailLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fichaProfessoresDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaProfessoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // idProfessorLabel
            // 
            idProfessorLabel.AutoSize = true;
            idProfessorLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idProfessorLabel.Location = new System.Drawing.Point(129, 28);
            idProfessorLabel.Name = "idProfessorLabel";
            idProfessorLabel.Size = new System.Drawing.Size(55, 16);
            idProfessorLabel.TabIndex = 0;
            idProfessorLabel.Text = "Código:";
            // 
            // nomeLabel
            // 
            nomeLabel.AutoSize = true;
            nomeLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nomeLabel.Location = new System.Drawing.Point(129, 83);
            nomeLabel.Name = "nomeLabel";
            nomeLabel.Size = new System.Drawing.Size(49, 16);
            nomeLabel.TabIndex = 2;
            nomeLabel.Text = "Nome:";
            // 
            // nCartãoLabel
            // 
            nCartãoLabel.AutoSize = true;
            nCartãoLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nCartãoLabel.Location = new System.Drawing.Point(129, 139);
            nCartãoLabel.Name = "nCartãoLabel";
            nCartãoLabel.Size = new System.Drawing.Size(63, 16);
            nCartãoLabel.TabIndex = 4;
            nCartãoLabel.Text = "NCartão:";
            // 
            // contactoLabel
            // 
            contactoLabel.AutoSize = true;
            contactoLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            contactoLabel.Location = new System.Drawing.Point(459, 30);
            contactoLabel.Name = "contactoLabel";
            contactoLabel.Size = new System.Drawing.Size(68, 16);
            contactoLabel.TabIndex = 6;
            contactoLabel.Text = "Contacto:";
            // 
            // emailLabel
            // 
            emailLabel.AutoSize = true;
            emailLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            emailLabel.Location = new System.Drawing.Point(459, 83);
            emailLabel.Name = "emailLabel";
            emailLabel.Size = new System.Drawing.Size(47, 16);
            emailLabel.TabIndex = 8;
            emailLabel.Text = "Email:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.fichaProfessoresDataGridView);
            this.groupBox1.Controls.Add(this.radiobtn_ncartao_prof);
            this.groupBox1.Controls.Add(this.radiobtn_nome_prof);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.textBox1);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(812, 418);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Geral";
            // 
            // fichaProfessoresDataGridView
            // 
            this.fichaProfessoresDataGridView.AutoGenerateColumns = false;
            this.fichaProfessoresDataGridView.BackgroundColor = System.Drawing.Color.Silver;
            this.fichaProfessoresDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.fichaProfessoresDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idProfessorDataGridViewTextBoxColumn,
            this.nomeDataGridViewTextBoxColumn,
            this.nCartãoDataGridViewTextBoxColumn,
            this.contactoDataGridViewTextBoxColumn,
            this.emailDataGridViewTextBoxColumn});
            this.fichaProfessoresDataGridView.DataSource = this.fichaProfessoresBindingSource;
            this.fichaProfessoresDataGridView.Location = new System.Drawing.Point(0, 104);
            this.fichaProfessoresDataGridView.Name = "fichaProfessoresDataGridView";
            this.fichaProfessoresDataGridView.Size = new System.Drawing.Size(800, 308);
            this.fichaProfessoresDataGridView.TabIndex = 4;
            this.fichaProfessoresDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.fichaProfessoresDataGridView_CellContentClick);
            // 
            // idProfessorDataGridViewTextBoxColumn
            // 
            this.idProfessorDataGridViewTextBoxColumn.DataPropertyName = "IdProfessor";
            this.idProfessorDataGridViewTextBoxColumn.HeaderText = "Código";
            this.idProfessorDataGridViewTextBoxColumn.Name = "idProfessorDataGridViewTextBoxColumn";
            this.idProfessorDataGridViewTextBoxColumn.Width = 60;
            // 
            // nomeDataGridViewTextBoxColumn
            // 
            this.nomeDataGridViewTextBoxColumn.DataPropertyName = "Nome";
            this.nomeDataGridViewTextBoxColumn.HeaderText = "Nome";
            this.nomeDataGridViewTextBoxColumn.Name = "nomeDataGridViewTextBoxColumn";
            this.nomeDataGridViewTextBoxColumn.Width = 200;
            // 
            // nCartãoDataGridViewTextBoxColumn
            // 
            this.nCartãoDataGridViewTextBoxColumn.DataPropertyName = "NCartão";
            this.nCartãoDataGridViewTextBoxColumn.HeaderText = "NºCartão";
            this.nCartãoDataGridViewTextBoxColumn.Name = "nCartãoDataGridViewTextBoxColumn";
            this.nCartãoDataGridViewTextBoxColumn.Width = 150;
            // 
            // contactoDataGridViewTextBoxColumn
            // 
            this.contactoDataGridViewTextBoxColumn.DataPropertyName = "Contacto";
            this.contactoDataGridViewTextBoxColumn.HeaderText = "Contacto";
            this.contactoDataGridViewTextBoxColumn.Name = "contactoDataGridViewTextBoxColumn";
            this.contactoDataGridViewTextBoxColumn.Width = 150;
            // 
            // emailDataGridViewTextBoxColumn
            // 
            this.emailDataGridViewTextBoxColumn.DataPropertyName = "Email";
            this.emailDataGridViewTextBoxColumn.HeaderText = "Email";
            this.emailDataGridViewTextBoxColumn.Name = "emailDataGridViewTextBoxColumn";
            this.emailDataGridViewTextBoxColumn.Width = 200;
            // 
            // fichaProfessoresBindingSource
            // 
            this.fichaProfessoresBindingSource.DataMember = "FichaProfessores";
            this.fichaProfessoresBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // bDPAPDataSet
            // 
            this.bDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.bDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // radiobtn_ncartao_prof
            // 
            this.radiobtn_ncartao_prof.AutoSize = true;
            this.radiobtn_ncartao_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn_ncartao_prof.Location = new System.Drawing.Point(146, 75);
            this.radiobtn_ncartao_prof.Name = "radiobtn_ncartao_prof";
            this.radiobtn_ncartao_prof.Size = new System.Drawing.Size(74, 19);
            this.radiobtn_ncartao_prof.TabIndex = 4;
            this.radiobtn_ncartao_prof.TabStop = true;
            this.radiobtn_ncartao_prof.Text = "NºCartão";
            this.radiobtn_ncartao_prof.UseVisualStyleBackColor = true;
            this.radiobtn_ncartao_prof.CheckedChanged += new System.EventHandler(this.radiobtn_ncartao_prof_CheckedChanged);
            // 
            // radiobtn_nome_prof
            // 
            this.radiobtn_nome_prof.AutoSize = true;
            this.radiobtn_nome_prof.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.radiobtn_nome_prof.Location = new System.Drawing.Point(19, 75);
            this.radiobtn_nome_prof.Name = "radiobtn_nome_prof";
            this.radiobtn_nome_prof.Size = new System.Drawing.Size(59, 19);
            this.radiobtn_nome_prof.TabIndex = 3;
            this.radiobtn_nome_prof.TabStop = true;
            this.radiobtn_nome_prof.Text = "Nome";
            this.radiobtn_nome_prof.UseVisualStyleBackColor = true;
            this.radiobtn_nome_prof.CheckedChanged += new System.EventHandler(this.radiobtn_nome_prof_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(19, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(82, 18);
            this.label1.TabIndex = 2;
            this.label1.Text = "Pesquisar:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(19, 46);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(328, 23);
            this.textBox1.TabIndex = 1;
            this.textBox1.TextChanged += new System.EventHandler(this.textBox1_TextChanged);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox2.Controls.Add(idProfessorLabel);
            this.groupBox2.Controls.Add(this.idProfessorTextBox);
            this.groupBox2.Controls.Add(nomeLabel);
            this.groupBox2.Controls.Add(this.nomeTextBox);
            this.groupBox2.Controls.Add(nCartãoLabel);
            this.groupBox2.Controls.Add(this.nCartãoTextBox);
            this.groupBox2.Controls.Add(contactoLabel);
            this.groupBox2.Controls.Add(this.contactoTextBox);
            this.groupBox2.Controls.Add(emailLabel);
            this.groupBox2.Controls.Add(this.emailTextBox);
            this.groupBox2.Location = new System.Drawing.Point(13, 437);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(805, 210);
            this.groupBox2.TabIndex = 2;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Informações";
            // 
            // idProfessorTextBox
            // 
            this.idProfessorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fichaProfessoresBindingSource, "IdProfessor", true));
            this.idProfessorTextBox.Location = new System.Drawing.Point(132, 47);
            this.idProfessorTextBox.Name = "idProfessorTextBox";
            this.idProfessorTextBox.Size = new System.Drawing.Size(154, 20);
            this.idProfessorTextBox.TabIndex = 1;
            // 
            // nomeTextBox
            // 
            this.nomeTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fichaProfessoresBindingSource, "Nome", true));
            this.nomeTextBox.Location = new System.Drawing.Point(132, 104);
            this.nomeTextBox.Name = "nomeTextBox";
            this.nomeTextBox.Size = new System.Drawing.Size(154, 20);
            this.nomeTextBox.TabIndex = 3;
            // 
            // nCartãoTextBox
            // 
            this.nCartãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fichaProfessoresBindingSource, "NCartão", true));
            this.nCartãoTextBox.Location = new System.Drawing.Point(132, 158);
            this.nCartãoTextBox.Name = "nCartãoTextBox";
            this.nCartãoTextBox.Size = new System.Drawing.Size(154, 20);
            this.nCartãoTextBox.TabIndex = 5;
            // 
            // contactoTextBox
            // 
            this.contactoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fichaProfessoresBindingSource, "Contacto", true));
            this.contactoTextBox.Location = new System.Drawing.Point(462, 47);
            this.contactoTextBox.Name = "contactoTextBox";
            this.contactoTextBox.Size = new System.Drawing.Size(154, 20);
            this.contactoTextBox.TabIndex = 7;
            // 
            // emailTextBox
            // 
            this.emailTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.fichaProfessoresBindingSource, "Email", true));
            this.emailTextBox.Location = new System.Drawing.Point(462, 102);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(154, 20);
            this.emailTextBox.TabIndex = 9;
            // 
            // fichaProfessoresTableAdapter
            // 
            this.fichaProfessoresTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.FichaProfessoresTableAdapter = this.fichaProfessoresTableAdapter;
            this.tableAdapterManager.FilmesTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoComputadorTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoFilmesTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoLivrosTableAdapter = null;
            this.tableAdapterManager.ItemRequisitadoTabletTableAdapter = null;
            this.tableAdapterManager.LivrosTableAdapter = null;
            this.tableAdapterManager.RequisitacaoTableAdapter = null;
            this.tableAdapterManager.TabletsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.BDPAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitanteTableAdapter = null;
            // 
            // Frm_PesquisarProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(837, 649);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_PesquisarProfessor";
            this.Text = "Pesquisar Professor";
            this.Load += new System.EventHandler(this.Frm_PesquisarProfessor_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.fichaProfessoresDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fichaProfessoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radiobtn_ncartao_prof;
        private System.Windows.Forms.RadioButton radiobtn_nome_prof;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox textBox1;
        private BDPAPDataSet bDPAPDataSet;
        private System.Windows.Forms.BindingSource fichaProfessoresBindingSource;
        private BDPAPDataSetTableAdapters.FichaProfessoresTableAdapter fichaProfessoresTableAdapter;
        private BDPAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.DataGridView fichaProfessoresDataGridView;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox idProfessorTextBox;
        private System.Windows.Forms.TextBox nomeTextBox;
        private System.Windows.Forms.TextBox nCartãoTextBox;
        private System.Windows.Forms.TextBox contactoTextBox;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.DataGridViewTextBoxColumn idProfessorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nomeDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nCartãoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn contactoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn emailDataGridViewTextBoxColumn;
    }
}