
namespace PAP
{
    partial class Frm_RelatorioFilme
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
            Microsoft.Reporting.WinForms.ReportDataSource reportDataSource2 = new Microsoft.Reporting.WinForms.ReportDataSource();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RelatorioFilme));
            this.FilmesBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDPAPDataSet = new PAP.BDPAPDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FilmesTableAdapter = new PAP.BDPAPDataSetTableAdapters.FilmesTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FilmesBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDPAPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // FilmesBindingSource
            // 
            this.FilmesBindingSource.DataMember = "Filmes";
            this.FilmesBindingSource.DataSource = this.BDPAPDataSet;
            // 
            // BDPAPDataSet
            // 
            this.BDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.BDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.WhiteSmoke;
            reportDataSource2.Name = "DSFilme";
            reportDataSource2.Value = this.FilmesBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource2);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PAP.Relatorio.Report_Filme.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(857, 575);
            this.reportViewer1.TabIndex = 0;
            // 
            // FilmesTableAdapter
            // 
            this.FilmesTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_RelatorioFilme
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 576);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_RelatorioFilme";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Filme";
            this.Load += new System.EventHandler(this.Frm_RelatorioFilme_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FilmesBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDPAPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FilmesBindingSource;
        private BDPAPDataSet BDPAPDataSet;
        private BDPAPDataSetTableAdapters.FilmesTableAdapter FilmesTableAdapter;
    }
}