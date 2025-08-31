
namespace PAP
{
    partial class Frm_RelatorioTablet
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_RelatorioTablet));
            this.TabletsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.BDPAPDataSet = new PAP.BDPAPDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.TabletsTableAdapter = new PAP.BDPAPDataSetTableAdapters.TabletsTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.TabletsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDPAPDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // TabletsBindingSource
            // 
            this.TabletsBindingSource.DataMember = "Tablets";
            this.TabletsBindingSource.DataSource = this.BDPAPDataSet;
            // 
            // BDPAPDataSet
            // 
            this.BDPAPDataSet.DataSetName = "BDPAPDataSet";
            this.BDPAPDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.BackColor = System.Drawing.Color.WhiteSmoke;
            reportDataSource1.Name = "DSTablet";
            reportDataSource1.Value = this.TabletsBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "PAP.Relatorio.Report_Tablet.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(2, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(825, 551);
            this.reportViewer1.TabIndex = 0;
            // 
            // TabletsTableAdapter
            // 
            this.TabletsTableAdapter.ClearBeforeFill = true;
            // 
            // Frm_RelatorioTablet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(830, 549);
            this.Controls.Add(this.reportViewer1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Frm_RelatorioTablet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Relatório Tablet";
            this.Load += new System.EventHandler(this.Frm_RelatorioTablet_Load);
            ((System.ComponentModel.ISupportInitialize)(this.TabletsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BDPAPDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource TabletsBindingSource;
        private BDPAPDataSet BDPAPDataSet;
        private BDPAPDataSetTableAdapters.TabletsTableAdapter TabletsTableAdapter;
    }
}