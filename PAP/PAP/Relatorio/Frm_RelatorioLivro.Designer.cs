
namespace PAP
{
    partial class Frm_RelatorioLivro
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource1 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RelatorioLivro));
            this.LivrosBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDPAPDataSet = new PAP.BDPAPDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.LivrosTableAdapter = new PAP.BDPAPDataSetTableAdapters.LivrosTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.LivrosBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDPAPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // LivrosBindingSource
            // 
            this.LivrosBindingSource.DataMember = "Livros";
            this.LivrosBindingSource.DataSource = this.BDPAPDataSet;
            // 
            // BDPAPDataSet
            // 
            this.BDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.BDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.WhiteSmoke;
            reportDataSource1.Name = "DSLivro";
            reportDataSource1.Value = this.LivrosBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PAP.Relatorio.Report_livro.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(841, 539);
            this.reportViewer1.TabIndex = 0;
            // 
            // LivrosTableAdapter
            // 
            this.LivrosTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_RelatorioLivro
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(845, 540);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_RelatorioLivro";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Livro";
            this.Load += new System.EventHandler(this.Frm_RelatorioLivro_Load);
            ((System.ComponentModel.ISupportInitialize)(this.LivrosBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDPAPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BDPAPDataSet BDPAPDataSet;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource LivrosBindingSource;
        private BDPAPDataSetTableAdapters.LivrosTableAdapter LivrosTableAdapter;
    }
}