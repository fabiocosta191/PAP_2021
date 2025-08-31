
namespace PAP
{
    partial class Frm_RelatorioAluno
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RelatorioAluno));
            this.FichaAlunoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDPAPDataSet = new PAP.BDPAPDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FichaAlunoTableAdapter = new PAP.BDPAPDataSetTableAdapters.FichaAlunoTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FichaAlunoBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDPAPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // FichaAlunoBindingSource
            // 
            this.FichaAlunoBindingSource.DataMember = "FichaAluno";
            this.FichaAlunoBindingSource.DataSource = this.BDPAPDataSet;
            // 
            // BDPAPDataSet
            // 
            this.BDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.BDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.WhiteSmoke;
            reportDataSource1.Name = "DSAluno";
            reportDataSource1.Value = this.FichaAlunoBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PAP.Relatorio.Report_Aluno.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(3, -1);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(855, 578);
            this.reportViewer1.TabIndex = 0;
            // 
            // FichaAlunoTableAdapter
            // 
            this.FichaAlunoTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_RelatorioAluno
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(860, 576);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_RelatorioAluno";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Aluno";
            this.Load += new System.EventHandler(this.Frm_RelatorioAluno_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FichaAlunoBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDPAPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FichaAlunoBindingSource;
        private BDPAPDataSet BDPAPDataSet;
        private BDPAPDataSetTableAdapters.FichaAlunoTableAdapter FichaAlunoTableAdapter;
    }
}