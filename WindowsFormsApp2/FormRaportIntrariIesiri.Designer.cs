namespace WindowsFormsApp2
{
    partial class FormRaportIntrariIesiri
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
            this.intrariBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dB_Project1DataSet = new WindowsFormsApp2.DB_Project1DataSet();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.dBProject1DataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.intrariTableAdapter = new WindowsFormsApp2.DB_Project1DataSetTableAdapters.intrariTableAdapter();
            ((System.ComponentModel.ISupportInitialize)(this.intrariBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Project1DataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProject1DataSetBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // intrariBindingSource
            // 
            this.intrariBindingSource.DataMember = "intrari";
            this.intrariBindingSource.DataSource = this.dB_Project1DataSet;
            // 
            // dB_Project1DataSet
            // 
            this.dB_Project1DataSet.DataSetName = "DB_Project1DataSet";
            this.dB_Project1DataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // reportViewer1
            // 
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            reportDataSource1.Name = "intrari";
            reportDataSource1.Value = this.intrariBindingSource;
            this.reportViewer1.LocalReport.DataSources.Add(reportDataSource1);
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "WindowsFormsApp2.ReportIntrari.rdlc";
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "reportViewer1";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(800, 450);
            this.reportViewer1.TabIndex = 0;
            // 
            // dBProject1DataSetBindingSource
            // 
            this.dBProject1DataSetBindingSource.DataSource = this.dB_Project1DataSet;
            this.dBProject1DataSetBindingSource.Position = 0;
            // 
            // intrariTableAdapter
            // 
            this.intrariTableAdapter.ClearBeforeFill = true;
            // 
            // FormRaportIntrariIesiri
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.reportViewer1);
            this.Name = "FormRaportIntrariIesiri";
            this.Text = "FormRaportIntrariIesiri";
            this.Load += new System.EventHandler(this.FormRaportIntrari_Load);
            ((System.ComponentModel.ISupportInitialize)(this.intrariBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dB_Project1DataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dBProject1DataSetBindingSource)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.BindingSource dBProject1DataSetBindingSource;
        private DB_Project1DataSet dB_Project1DataSet;
        private System.Windows.Forms.BindingSource intrariBindingSource;
        private DB_Project1DataSetTableAdapters.intrariTableAdapter intrariTableAdapter;
        public Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
    }
}