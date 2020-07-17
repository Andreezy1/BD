namespace Kursach
{
    partial class Otchet
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
            this.StoimostBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ATSDataSet = new Kursach.ATSDataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.StoimostTableAdapter = new Kursach.ATSDataSetTableAdapters.StoimostTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.StoimostBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATSDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // StoimostBindingSource
            // 
            this.StoimostBindingSource.DataMember = "Stoimost";
            this.StoimostBindingSource.DataSource = this.ATSDataSet;
            // 
            // ATSDataSet
            // 
            this.ATSDataSet.DataSetName = "ATSDataSet";
            this.ATSDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "DataSet1";
            reportDataSource1.Value = this.StoimostBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "Kursach.Report1.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(896, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // StoimostTableAdapter
            // 
            this.StoimostTableAdapter.ClearBeforeFill = true;
            // 
            // Otchet
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(896, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "Otchet";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Form5_Load);
            ((System.ComponentModel.ISupportInitialize)(this.StoimostBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ATSDataSet)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.BindingSource StoimostBindingSource;
        private ATSDataSet ATSDataSet;
        private ATSDataSetTableAdapters.StoimostTableAdapter StoimostTableAdapter;
    }
}