namespace AlmacenTech.Consultas
{
    partial class ReportingViewerEquipos
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ReportingViewerEquipos));
            this.RptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RptViewer
            // 
            this.RptViewer.Location = new System.Drawing.Point(16, 15);
            this.RptViewer.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.RptViewer.Name = "RptViewer";
            this.RptViewer.Size = new System.Drawing.Size(913, 516);
            this.RptViewer.TabIndex = 0;
            this.RptViewer.Load += new System.EventHandler(this.RptViewer_Load);
            // 
            // ReportingViewerEquipos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(940, 537);
            this.Controls.Add(this.RptViewer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(958, 584);
            this.MinimumSize = new System.Drawing.Size(958, 584);
            this.Name = "ReportingViewerEquipos";
            this.Text = "Reporte de Equipos";
            this.Load += new System.EventHandler(this.ReportingViewer_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RptViewer;
    }
}