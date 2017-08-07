namespace InvGen
{
    partial class PrintInvoice
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
            this.InvoiceGeneratorDataSet = new InvGen.InvoiceGeneratorDataSet();
            this.GenerateInvoicePrintBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.GenerateInvoicePrintTableAdapter = new InvGen.InvoiceGeneratorDataSetTableAdapters.GenerateInvoicePrintTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGeneratorDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateInvoicePrintBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.GenerateInvoicePrintBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "InvGen.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.Size = new System.Drawing.Size(799, 622);
            this.reportViewer1.TabIndex = 0;
            // 
            // InvoiceGeneratorDataSet
            // 
            this.InvoiceGeneratorDataSet.DataSetName = "InvoiceGeneratorDataSet";
            this.InvoiceGeneratorDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // GenerateInvoicePrintBindingSource
            // 
            this.GenerateInvoicePrintBindingSource.DataMember = "GenerateInvoicePrint";
            this.GenerateInvoicePrintBindingSource.DataSource = this.InvoiceGeneratorDataSet;
            // 
            // GenerateInvoicePrintTableAdapter
            // 
            this.GenerateInvoicePrintTableAdapter.ClearBeforeFill = true;
            // 
            // PrintInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(799, 622);
            this.Controls.Add(this.reportViewer1);
            this.Name = "PrintInvoice";
            this.Text = "PrintInvoice";
            this.Load += new System.EventHandler(this.PrintInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.InvoiceGeneratorDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.GenerateInvoicePrintBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource GenerateInvoicePrintBindingSource;
        private InvoiceGeneratorDataSet InvoiceGeneratorDataSet;
        private InvoiceGeneratorDataSetTableAdapters.GenerateInvoicePrintTableAdapter GenerateInvoicePrintTableAdapter;

    }
}