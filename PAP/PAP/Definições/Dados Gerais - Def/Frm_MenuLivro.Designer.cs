
namespace PAP
{
    partial class Frm_MenuLivro
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
            System.Windows.Forms.Label codigo_EANLabel;
            System.Windows.Forms.Label títuloLabel;
            System.Windows.Forms.Label autorLabel;
            System.Windows.Forms.Label ediçãoLabel;
            System.Windows.Forms.Label iDCategoriaLivrosLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_MenuLivro));
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.livrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bDPAPDataSet = new PAP.BDPAPDataSet();
            this.editoraLivrosBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.bindingNavigator1 = new System.Windows.Forms.BindingNavigator(this.components);
            this.toolStripButton1 = new System.Windows.Forms.ToolStripButton();
            this.toolStripLabel1 = new System.Windows.Forms.ToolStripLabel();
            this.toolStripButton2 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton3 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton4 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripTextBox1 = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton5 = new System.Windows.Forms.ToolStripButton();
            this.toolStripButton6 = new System.Windows.Forms.ToolStripButton();
            this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripButton7 = new System.Windows.Forms.ToolStripButton();
            this.idLivroTextBox = new System.Windows.Forms.TextBox();
            this.codigo_EANTextBox = new System.Windows.Forms.TextBox();
            this.títuloTextBox = new System.Windows.Forms.TextBox();
            this.autorTextBox = new System.Windows.Forms.TextBox();
            this.ediçãoTextBox = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.livrosDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.editoraLivrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn8 = new System.Windows.Forms.DataGridViewComboBoxColumn();
            this.categoriaLivrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridViewCheckBoxColumn1 = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.livrosTableAdapter = new PAP.BDPAPDataSetTableAdapters.LivrosTableAdapter();
            this.tableAdapterManager = new PAP.BDPAPDataSetTableAdapters.TableAdapterManager();
            this.categoriaLivrosTableAdapter = new PAP.BDPAPDataSetTableAdapters.CategoriaLivrosTableAdapter();
            this.editoraLivrosTableAdapter = new PAP.BDPAPDataSetTableAdapters.EditoraLivrosTableAdapter();
            idLivroLabel = new System.Windows.Forms.Label();
            idEditoraLabel = new System.Windows.Forms.Label();
            codigo_EANLabel = new System.Windows.Forms.Label();
            títuloLabel = new System.Windows.Forms.Label();
            autorLabel = new System.Windows.Forms.Label();
            ediçãoLabel = new System.Windows.Forms.Label();
            iDCategoriaLivrosLabel = new System.Windows.Forms.Label();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraLivrosBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).BeginInit();
            this.bindingNavigator1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraLivrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaLivrosBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // idLivroLabel
            // 
            idLivroLabel.AutoSize = true;
            idLivroLabel.Font = new System.Drawing.Font("Georgia", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idLivroLabel.Location = new System.Drawing.Point(30, 58);
            idLivroLabel.Name = "idLivroLabel";
            idLivroLabel.Size = new System.Drawing.Size(60, 18);
            idLivroLabel.TabIndex = 0;
            idLivroLabel.Text = "Código:";
            // 
            // idEditoraLabel
            // 
            idEditoraLabel.AutoSize = true;
            idEditoraLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            idEditoraLabel.Location = new System.Drawing.Point(382, 111);
            idEditoraLabel.Name = "idEditoraLabel";
            idEditoraLabel.Size = new System.Drawing.Size(62, 18);
            idEditoraLabel.TabIndex = 2;
            idEditoraLabel.Text = "Editora:";
            // 
            // codigo_EANLabel
            // 
            codigo_EANLabel.AutoSize = true;
            codigo_EANLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            codigo_EANLabel.Location = new System.Drawing.Point(88, 114);
            codigo_EANLabel.Name = "codigo_EANLabel";
            codigo_EANLabel.Size = new System.Drawing.Size(50, 18);
            codigo_EANLabel.TabIndex = 4;
            codigo_EANLabel.Text = "ISBN:";
            // 
            // títuloLabel
            // 
            títuloLabel.AutoSize = true;
            títuloLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            títuloLabel.Location = new System.Drawing.Point(88, 150);
            títuloLabel.Name = "títuloLabel";
            títuloLabel.Size = new System.Drawing.Size(52, 18);
            títuloLabel.TabIndex = 6;
            títuloLabel.Text = "Título:";
            // 
            // autorLabel
            // 
            autorLabel.AutoSize = true;
            autorLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            autorLabel.Location = new System.Drawing.Point(87, 191);
            autorLabel.Name = "autorLabel";
            autorLabel.Size = new System.Drawing.Size(51, 18);
            autorLabel.TabIndex = 8;
            autorLabel.Text = "Autor:";
            // 
            // ediçãoLabel
            // 
            ediçãoLabel.AutoSize = true;
            ediçãoLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            ediçãoLabel.Location = new System.Drawing.Point(382, 150);
            ediçãoLabel.Name = "ediçãoLabel";
            ediçãoLabel.Size = new System.Drawing.Size(58, 18);
            ediçãoLabel.TabIndex = 10;
            ediçãoLabel.Text = "Edição:";
            // 
            // iDCategoriaLivrosLabel
            // 
            iDCategoriaLivrosLabel.AutoSize = true;
            iDCategoriaLivrosLabel.Font = new System.Drawing.Font("Georgia", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            iDCategoriaLivrosLabel.Location = new System.Drawing.Point(382, 190);
            iDCategoriaLivrosLabel.Name = "iDCategoriaLivrosLabel";
            iDCategoriaLivrosLabel.Size = new System.Drawing.Size(77, 18);
            iDCategoriaLivrosLabel.TabIndex = 12;
            iDCategoriaLivrosLabel.Text = "Categoria:";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 12);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(742, 285);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.AutoScroll = true;
            this.tabPage1.Controls.Add(this.comboBox2);
            this.tabPage1.Controls.Add(this.comboBox1);
            this.tabPage1.Controls.Add(this.bindingNavigator1);
            this.tabPage1.Controls.Add(idLivroLabel);
            this.tabPage1.Controls.Add(this.idLivroTextBox);
            this.tabPage1.Controls.Add(idEditoraLabel);
            this.tabPage1.Controls.Add(codigo_EANLabel);
            this.tabPage1.Controls.Add(this.codigo_EANTextBox);
            this.tabPage1.Controls.Add(títuloLabel);
            this.tabPage1.Controls.Add(this.títuloTextBox);
            this.tabPage1.Controls.Add(autorLabel);
            this.tabPage1.Controls.Add(this.autorTextBox);
            this.tabPage1.Controls.Add(ediçãoLabel);
            this.tabPage1.Controls.Add(this.ediçãoTextBox);
            this.tabPage1.Controls.Add(iDCategoriaLivrosLabel);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(734, 259);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Dados";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(485, 188);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(147, 21);
            this.comboBox2.TabIndex = 16;
            // 
            // comboBox1
            // 
            this.comboBox1.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.livrosBindingSource, "IdEditora", true));
            this.comboBox1.DataSource = this.editoraLivrosBindingSource1;
            this.comboBox1.DisplayMember = "Nome";
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(485, 112);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(147, 21);
            this.comboBox1.TabIndex = 15;
            this.comboBox1.ValueMember = "IdEditora";
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
            // editoraLivrosBindingSource1
            // 
            this.editoraLivrosBindingSource1.DataMember = "EditoraLivros";
            this.editoraLivrosBindingSource1.DataSource = this.bDPAPDataSet;
            // 
            // bindingNavigator1
            // 
            this.bindingNavigator1.AddNewItem = this.toolStripButton1;
            this.bindingNavigator1.BindingSource = this.livrosBindingSource;
            this.bindingNavigator1.CountItem = this.toolStripLabel1;
            this.bindingNavigator1.DeleteItem = this.toolStripButton2;
            this.bindingNavigator1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripButton3,
            this.toolStripButton4,
            this.toolStripSeparator1,
            this.toolStripTextBox1,
            this.toolStripLabel1,
            this.toolStripSeparator2,
            this.toolStripButton5,
            this.toolStripButton6,
            this.toolStripSeparator3,
            this.toolStripButton1,
            this.toolStripButton2,
            this.toolStripButton7});
            this.bindingNavigator1.Location = new System.Drawing.Point(3, 3);
            this.bindingNavigator1.MoveFirstItem = this.toolStripButton3;
            this.bindingNavigator1.MoveLastItem = this.toolStripButton6;
            this.bindingNavigator1.MoveNextItem = this.toolStripButton5;
            this.bindingNavigator1.MovePreviousItem = this.toolStripButton4;
            this.bindingNavigator1.Name = "bindingNavigator1";
            this.bindingNavigator1.PositionItem = this.toolStripTextBox1;
            this.bindingNavigator1.Size = new System.Drawing.Size(728, 38);
            this.bindingNavigator1.TabIndex = 14;
            this.bindingNavigator1.Text = "bindingNavigator1";
            // 
            // toolStripButton1
            // 
            this.toolStripButton1.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton1.Image")));
            this.toolStripButton1.Name = "toolStripButton1";
            this.toolStripButton1.RightToLeftAutoMirrorImage = true;
            this.toolStripButton1.Size = new System.Drawing.Size(40, 35);
            this.toolStripButton1.Text = "Novo";
            this.toolStripButton1.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripLabel1
            // 
            this.toolStripLabel1.Name = "toolStripLabel1";
            this.toolStripLabel1.Size = new System.Drawing.Size(35, 35);
            this.toolStripLabel1.Text = "of {0}";
            this.toolStripLabel1.ToolTipText = "Total number of items";
            // 
            // toolStripButton2
            // 
            this.toolStripButton2.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton2.Image")));
            this.toolStripButton2.Name = "toolStripButton2";
            this.toolStripButton2.RightToLeftAutoMirrorImage = true;
            this.toolStripButton2.Size = new System.Drawing.Size(54, 35);
            this.toolStripButton2.Text = "Eliminar";
            this.toolStripButton2.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            // 
            // toolStripButton3
            // 
            this.toolStripButton3.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton3.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton3.Image")));
            this.toolStripButton3.Name = "toolStripButton3";
            this.toolStripButton3.RightToLeftAutoMirrorImage = true;
            this.toolStripButton3.Size = new System.Drawing.Size(23, 35);
            this.toolStripButton3.Text = "Move first";
            // 
            // toolStripButton4
            // 
            this.toolStripButton4.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton4.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton4.Image")));
            this.toolStripButton4.Name = "toolStripButton4";
            this.toolStripButton4.RightToLeftAutoMirrorImage = true;
            this.toolStripButton4.Size = new System.Drawing.Size(23, 35);
            this.toolStripButton4.Text = "Move previous";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripTextBox1
            // 
            this.toolStripTextBox1.AccessibleName = "Position";
            this.toolStripTextBox1.AutoSize = false;
            this.toolStripTextBox1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.toolStripTextBox1.Name = "toolStripTextBox1";
            this.toolStripTextBox1.Size = new System.Drawing.Size(50, 23);
            this.toolStripTextBox1.Text = "0";
            this.toolStripTextBox1.ToolTipText = "Current position";
            // 
            // toolStripSeparator2
            // 
            this.toolStripSeparator2.Name = "toolStripSeparator2";
            this.toolStripSeparator2.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButton5
            // 
            this.toolStripButton5.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton5.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton5.Image")));
            this.toolStripButton5.Name = "toolStripButton5";
            this.toolStripButton5.RightToLeftAutoMirrorImage = true;
            this.toolStripButton5.Size = new System.Drawing.Size(23, 35);
            this.toolStripButton5.Text = "Move next";
            // 
            // toolStripButton6
            // 
            this.toolStripButton6.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripButton6.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton6.Image")));
            this.toolStripButton6.Name = "toolStripButton6";
            this.toolStripButton6.RightToLeftAutoMirrorImage = true;
            this.toolStripButton6.Size = new System.Drawing.Size(23, 35);
            this.toolStripButton6.Text = "Move last";
            // 
            // toolStripSeparator3
            // 
            this.toolStripSeparator3.Name = "toolStripSeparator3";
            this.toolStripSeparator3.Size = new System.Drawing.Size(6, 38);
            // 
            // toolStripButton7
            // 
            this.toolStripButton7.Image = ((System.Drawing.Image)(resources.GetObject("toolStripButton7.Image")));
            this.toolStripButton7.Name = "toolStripButton7";
            this.toolStripButton7.Size = new System.Drawing.Size(53, 35);
            this.toolStripButton7.Text = "Guardar";
            this.toolStripButton7.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageAboveText;
            this.toolStripButton7.Click += new System.EventHandler(this.toolStripButton7_Click_1);
            // 
            // idLivroTextBox
            // 
            this.idLivroTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "IdLivro", true));
            this.idLivroTextBox.Enabled = false;
            this.idLivroTextBox.Location = new System.Drawing.Point(107, 59);
            this.idLivroTextBox.Name = "idLivroTextBox";
            this.idLivroTextBox.Size = new System.Drawing.Size(104, 20);
            this.idLivroTextBox.TabIndex = 1;
            // 
            // codigo_EANTextBox
            // 
            this.codigo_EANTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Codigo EAN", true));
            this.codigo_EANTextBox.Location = new System.Drawing.Point(156, 112);
            this.codigo_EANTextBox.Name = "codigo_EANTextBox";
            this.codigo_EANTextBox.Size = new System.Drawing.Size(147, 20);
            this.codigo_EANTextBox.TabIndex = 5;
            // 
            // títuloTextBox
            // 
            this.títuloTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Título", true));
            this.títuloTextBox.Location = new System.Drawing.Point(156, 150);
            this.títuloTextBox.Name = "títuloTextBox";
            this.títuloTextBox.Size = new System.Drawing.Size(147, 20);
            this.títuloTextBox.TabIndex = 7;
            // 
            // autorTextBox
            // 
            this.autorTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Autor", true));
            this.autorTextBox.Location = new System.Drawing.Point(156, 188);
            this.autorTextBox.Name = "autorTextBox";
            this.autorTextBox.Size = new System.Drawing.Size(147, 20);
            this.autorTextBox.TabIndex = 9;
            // 
            // ediçãoTextBox
            // 
            this.ediçãoTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.livrosBindingSource, "Edição", true));
            this.ediçãoTextBox.Location = new System.Drawing.Point(485, 152);
            this.ediçãoTextBox.Name = "ediçãoTextBox";
            this.ediçãoTextBox.Size = new System.Drawing.Size(147, 20);
            this.ediçãoTextBox.TabIndex = 11;
            // 
            // tabPage2
            // 
            this.tabPage2.AutoScroll = true;
            this.tabPage2.Controls.Add(this.livrosDataGridView);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(734, 259);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Tabela";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // livrosDataGridView
            // 
            this.livrosDataGridView.AutoGenerateColumns = false;
            this.livrosDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.livrosDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn7,
            this.dataGridViewTextBoxColumn8,
            this.dataGridViewCheckBoxColumn1});
            this.livrosDataGridView.DataSource = this.livrosBindingSource;
            this.livrosDataGridView.Location = new System.Drawing.Point(0, 0);
            this.livrosDataGridView.Name = "livrosDataGridView";
            this.livrosDataGridView.Size = new System.Drawing.Size(735, 256);
            this.livrosDataGridView.TabIndex = 0;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "IdLivro";
            this.dataGridViewTextBoxColumn1.HeaderText = "Código";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.Width = 80;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "Título";
            this.dataGridViewTextBoxColumn5.HeaderText = "Título";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "IdEditora";
            this.dataGridViewTextBoxColumn2.DataSource = this.editoraLivrosBindingSource;
            this.dataGridViewTextBoxColumn2.DisplayMember = "Nome";
            this.dataGridViewTextBoxColumn2.HeaderText = "Editora";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn2.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn2.ValueMember = "IdEditora";
            // 
            // editoraLivrosBindingSource
            // 
            this.editoraLivrosBindingSource.DataMember = "EditoraLivros";
            this.editoraLivrosBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Autor";
            this.dataGridViewTextBoxColumn6.HeaderText = "Autor";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Codigo EAN";
            this.dataGridViewTextBoxColumn4.HeaderText = "ISBN";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Edição";
            this.dataGridViewTextBoxColumn7.HeaderText = "Edição";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // dataGridViewTextBoxColumn8
            // 
            this.dataGridViewTextBoxColumn8.DataPropertyName = "IDCategoriaLivros";
            this.dataGridViewTextBoxColumn8.DataSource = this.categoriaLivrosBindingSource;
            this.dataGridViewTextBoxColumn8.DisplayMember = "Nome";
            this.dataGridViewTextBoxColumn8.HeaderText = "Categoria Livros";
            this.dataGridViewTextBoxColumn8.Name = "dataGridViewTextBoxColumn8";
            this.dataGridViewTextBoxColumn8.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewTextBoxColumn8.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.dataGridViewTextBoxColumn8.ValueMember = "IDCategoriaLivros";
            // 
            // categoriaLivrosBindingSource
            // 
            this.categoriaLivrosBindingSource.DataMember = "CategoriaLivros";
            this.categoriaLivrosBindingSource.DataSource = this.bDPAPDataSet;
            // 
            // dataGridViewCheckBoxColumn1
            // 
            this.dataGridViewCheckBoxColumn1.DataPropertyName = "Requisitado";
            this.dataGridViewCheckBoxColumn1.HeaderText = "Requisitado";
            this.dataGridViewCheckBoxColumn1.Name = "dataGridViewCheckBoxColumn1";
            // 
            // livrosTableAdapter
            // 
            this.livrosTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CategoriaFilmesTableAdapter = null;
            this.tableAdapterManager.CategoriaLivrosTableAdapter = this.categoriaLivrosTableAdapter;
            this.tableAdapterManager.ComputadoresTableAdapter = null;
            this.tableAdapterManager.EditoraLivrosTableAdapter = this.editoraLivrosTableAdapter;
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
            // categoriaLivrosTableAdapter
            // 
            this.categoriaLivrosTableAdapter.ClearBeforeFill = true;
            // 
            // editoraLivrosTableAdapter
            // 
            this.editoraLivrosTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_MenuLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(763, 302);
            this.Controls.Add(this.tabControl1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "Frm_MenuLivro";
            this.Text = "Menu Livro";
            this.Load += new System.EventHandler(this.Frm_MenuLivro_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.livrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDPAPDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraLivrosBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bindingNavigator1)).EndInit();
            this.bindingNavigator1.ResumeLayout(false);
            this.bindingNavigator1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.livrosDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.editoraLivrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.categoriaLivrosBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private BDPAPDataSet bDPAPDataSet;
        private System.Windows.Forms.BindingSource livrosBindingSource;
        private BDPAPDataSetTableAdapters.LivrosTableAdapter livrosTableAdapter;
        private BDPAPDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator bindingNavigator1;
        private System.Windows.Forms.ToolStripButton toolStripButton1;
        private System.Windows.Forms.ToolStripLabel toolStripLabel1;
        private System.Windows.Forms.ToolStripButton toolStripButton2;
        private System.Windows.Forms.ToolStripButton toolStripButton3;
        private System.Windows.Forms.ToolStripButton toolStripButton4;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripTextBox toolStripTextBox1;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator2;
        private System.Windows.Forms.ToolStripButton toolStripButton5;
        private System.Windows.Forms.ToolStripButton toolStripButton6;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator3;
        private System.Windows.Forms.ToolStripButton toolStripButton7;
        private System.Windows.Forms.TextBox idLivroTextBox;
        private System.Windows.Forms.TextBox codigo_EANTextBox;
        private System.Windows.Forms.TextBox títuloTextBox;
        private System.Windows.Forms.TextBox autorTextBox;
        private System.Windows.Forms.TextBox ediçãoTextBox;
        private System.Windows.Forms.DataGridView livrosDataGridView;
        private BDPAPDataSetTableAdapters.EditoraLivrosTableAdapter editoraLivrosTableAdapter;
        private System.Windows.Forms.BindingSource editoraLivrosBindingSource;
        private BDPAPDataSetTableAdapters.CategoriaLivrosTableAdapter categoriaLivrosTableAdapter;
        private System.Windows.Forms.BindingSource categoriaLivrosBindingSource;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.BindingSource editoraLivrosBindingSource1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;
        private System.Windows.Forms.DataGridViewComboBoxColumn dataGridViewTextBoxColumn8;
        private System.Windows.Forms.DataGridViewCheckBoxColumn dataGridViewCheckBoxColumn1;
    }
}