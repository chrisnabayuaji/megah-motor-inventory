namespace Megah_Motor_Inventory
{
  partial class frmReport
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
      this.barangBindingSource = new System.Windows.Forms.BindingSource(this.components);
      this.dsReport = new Megah_Motor_Inventory.dsReport();
      this.barangTableAdapter = new Megah_Motor_Inventory.dsReportTableAdapters.barangTableAdapter();
      this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
      ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsReport)).BeginInit();
      this.SuspendLayout();
      // 
      // barangBindingSource
      // 
      this.barangBindingSource.DataMember = "barang";
      this.barangBindingSource.DataSource = this.dsReport;
      // 
      // dsReport
      // 
      this.dsReport.DataSetName = "dsReport";
      this.dsReport.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
      // 
      // barangTableAdapter
      // 
      this.barangTableAdapter.ClearBeforeFill = true;
      // 
      // reportViewer1
      // 
      this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
      reportDataSource1.Name = "dsReport";
      reportDataSource1.Value = this.barangBindingSource;
      this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
      this.reportViewer1.LocalReport.ReportEmbeddedResource = "Megah_Motor_Inventory.rptReport.rdlc";
      this.reportViewer1.Location = new System.Drawing.Point(0, 0);
      this.reportViewer1.Name = "reportViewer1";
      this.reportViewer1.ServerReport.BearerToken = null;
      this.reportViewer1.Size = new System.Drawing.Size(924, 562);
      this.reportViewer1.TabIndex = 0;
      // 
      // frmReport
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(924, 562);
      this.Controls.Add(this.reportViewer1);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmReport";
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "frmReport";
      this.TopMost = true;
      this.Load += new System.EventHandler(this.frmReport_Load);
      ((System.ComponentModel.ISupportInitialize)(this.barangBindingSource)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.dsReport)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.BindingSource barangBindingSource;
    private dsReport dsReport;
    private dsReportTableAdapters.barangTableAdapter barangTableAdapter;
    private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
  }
}