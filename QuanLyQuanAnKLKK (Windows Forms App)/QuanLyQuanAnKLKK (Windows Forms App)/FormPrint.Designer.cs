
namespace QuanLyQuanAnKLKK__Windows_Forms_App_
{
    partial class FormPrint
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
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.QuanLyQuanAnKLKKDataSet1 = new QuanLyQuanAnKLKK__Windows_Forms_App_.QuanLyQuanAnKLKKDataSet1();
            this.USP_ReportTable2BindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.USP_ReportTable2TableAdapter = new QuanLyQuanAnKLKK__Windows_Forms_App_.QuanLyQuanAnKLKKDataSet1TableAdapters.USP_ReportTable2TableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyQuanAnKLKKDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportTable2BindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.USP_ReportTable2BindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "QuanLyQuanAnKLKK__Windows_Forms_App_.rptBill.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(634, 636);
            this.reportViewer1.TabIndex = 0;
            // 
            // QuanLyQuanAnKLKKDataSet1
            // 
            this.QuanLyQuanAnKLKKDataSet1.DataSetName = "QuanLyQuanAnKLKKDataSet1";
            this.QuanLyQuanAnKLKKDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // USP_ReportTable2BindingSource
            // 
            this.USP_ReportTable2BindingSource.DataMember = "USP_ReportTable2";
            this.USP_ReportTable2BindingSource.DataSource = this.QuanLyQuanAnKLKKDataSet1;
            // 
            // USP_ReportTable2TableAdapter
            // 
            this.USP_ReportTable2TableAdapter.ClearBeforeFill = true;
            // 
            // FormPrint
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(634, 636);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormPrint";
            this.Text = "FormPrint";
            this.Load += new System.EventHandler(this.FormPrint_Load);
            ((System.ComponentModel.ISupportInitialize)(this.QuanLyQuanAnKLKKDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.USP_ReportTable2BindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource USP_ReportTable2BindingSource;
        private QuanLyQuanAnKLKKDataSet1 QuanLyQuanAnKLKKDataSet1;
        private QuanLyQuanAnKLKKDataSet1TableAdapters.USP_ReportTable2TableAdapter USP_ReportTable2TableAdapter;
    }
}