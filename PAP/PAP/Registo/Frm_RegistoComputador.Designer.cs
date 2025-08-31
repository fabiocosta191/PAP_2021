
namespace PAP
{
    partial class Frm_RegistoComputador
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
            System.Windows.Forms.Label idComputadorLabel;
            System.Windows.Forms.Label númeroLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RegistoComputador));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.button2 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.idComputadorTextBox = new System.Windows.Forms.TextBox();
            this.computadoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPAPDataSet = new PAP.BDPAPDataSet();
            this.númeroTextBox = new System.Windows.Forms.TextBox();
            this.computadoresTableAdapter = new PAP.BDPAPDataSetTableAdapters.ComputadoresTableAdapter();
            this.tableAdapterManager = new PAP.BDPAPDataSetTableAdapters.TableAdapterManager();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            idComputadorLabel = new System.Windows.Forms.Label();
            númeroLabel = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // idComputadorLabel
            // 
            idComputadorLabel.AutoSize = true;
            idComputadorLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idComputadorLabel.Location = new System.Drawing.Point(292, 66);
            idComputadorLabel.Name = "idComputadorLabel";
            idComputadorLabel.Size = new System.Drawing.Size(55, 16);
            idComputadorLabel.TabIndex = 0;
            idComputadorLabel.Text = "Código:";
            // 
            // númeroLabel
            // 
            númeroLabel.AutoSize = true;
            númeroLabel.Font = new System.Drawing.Font("Georgia", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            númeroLabel.Location = new System.Drawing.Point(292, 126);
            númeroLabel.Name = "númeroLabel";
            númeroLabel.Size = new System.Drawing.Size(63, 16);
            númeroLabel.TabIndex = 2;
            númeroLabel.Text = "Número:";
            // 
            // groupBox1
            // 
            this.groupBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.pictureBox1);
            this.groupBox1.Controls.Add(this.button2);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(idComputadorLabel);
            this.groupBox1.Controls.Add(this.idComputadorTextBox);
            this.groupBox1.Controls.Add(númeroLabel);
            this.groupBox1.Controls.Add(this.númeroTextBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(578, 301);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Dados Gerais";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Red;
            this.label1.Location = new System.Drawing.Point(274, 145);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(15, 20);
            this.label1.TabIndex = 18;
            this.label1.Text = "*";
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.WhiteSmoke;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(6, 36);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(195, 191);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 17;
            this.pictureBox1.TabStop = false;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(431, 239);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 16;
            this.button2.Text = "Guardar";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(431, 239);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 15;
            this.button1.Text = "Novo";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // idComputadorTextBox
            // 
            this.idComputadorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.computadoresBindingSource, "IdComputador", true));
            this.idComputadorTextBox.Enabled = false;
            this.idComputadorTextBox.Location = new System.Drawing.Point(295, 85);
            this.idComputadorTextBox.Name = "idComputadorTextBox";
            this.idComputadorTextBox.Size = new System.Drawing.Size(134, 20);
            this.idComputadorTextBox.TabIndex = 1;
            // 
            // computadoresBindingSource
            // 
            this.computadoresBindingSource.DataMember = "Computadores";
            this.computadoresBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // bDPAPDataSet
            // 
            this.bDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.bDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // númeroTextBox
            // 
            this.númeroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.computadoresBindingSource, "Número", true));
            this.númeroTextBox.Location = new System.Drawing.Point(295, 145);
            this.númeroTextBox.Name = "númeroTextBox";
            this.númeroTextBox.Size = new System.Drawing.Size(171, 20);
            this.númeroTextBox.TabIndex = 3;
            this.númeroTextBox.TextChanged += new System.EventHandler(this.númeroTextBox_TextChanged);
            // 
            // computadoresTableAdapter
            // 
            this.computadoresTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaFilmesTableAdapter = null;
            this.tableAdapterManager.CategoriaLivrosTableAdapter = null;
            this.tableAdapterManager.ComputadoresTableAdapter = this.computadoresTableAdapter;
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
            this.tableAdapterManager.TabletsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = PAP.BDPAPDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.VisitanteTableAdapter = null;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Frm_RegistoComputador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(604, 320);
            this.Controls.Add(this.groupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_RegistoComputador";
            this.Text = "Registo Computador";
            this.Load += new System.EventHandler(this.Frm_RegistoComputador_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.computadoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private BDPAPDataSet bDPAPDataSet;
        private System.Windows.Forms.BindingSource computadoresBindingSource;
        private BDPAPDataSetTableAdapters.ComputadoresTableAdapter computadoresTableAdapter;
        private BDPAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.TextBox idComputadorTextBox;
        private System.Windows.Forms.TextBox númeroTextBox;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}