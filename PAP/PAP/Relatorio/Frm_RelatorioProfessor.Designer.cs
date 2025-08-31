
namespace PAP
{
    partial class Frm_RelatorioProfessor
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RelatorioProfessor));
            this.FichaProfessoresBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDPAPDataSet = new PAP.BDPAPDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.FichaProfessoresTableAdapter = new PAP.BDPAPDataSetTableAdapters.FichaProfessoresTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.FichaProfessoresBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDPAPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // FichaProfessoresBindingSource
            // 
            this.FichaProfessoresBindingSource.DataMember = "FichaProfessores";
            this.FichaProfessoresBindingSource.DataSource = this.BDPAPDataSet;
            // 
            // BDPAPDataSet
            // 
            this.BDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.BDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.WhiteSmoke;
            reportDataSource1.Name = "DSProfessor";
            reportDataSource1.Value = this.FichaProfessoresBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PAP.Relatorio.Report_Professor.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(1, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(826, 540);
            this.reportViewer1.TabIndex = 0;
            // 
            // FichaProfessoresTableAdapter
            // 
            this.FichaProfessoresTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_RelatorioProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 541);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_RelatorioProfessor";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Professor";
            this.Load += new System.EventHandler(this.Frm_RelatorioProfessor_Load);
            ((System.ComponentModel.ISupportInitialize)(this.FichaProfessoresBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDPAPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource FichaProfessoresBindingSource;
        private BDPAPDataSet BDPAPDataSet;
        private BDPAPDataSetTableAdapters.FichaProfessoresTableAdapter FichaProfessoresTableAdapter;
    }
}