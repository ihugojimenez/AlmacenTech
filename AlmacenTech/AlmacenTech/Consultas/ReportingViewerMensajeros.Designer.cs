﻿namespace AlmacenTech.Consultas
{
    partial class ReportingViewerMensajeros
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
            this.RptViewer = new Microsoft.Reporting.WinForms.ReportViewer();
            this.SuspendLayout();
            // 
            // RptViewer
            // 
            this.RptViewer.Location = new System.Drawing.Point(12, 12);
            this.RptViewer.Name = "RptViewer";
            this.RptViewer.Size = new System.Drawing.Size(1186, 565);
            this.RptViewer.TabIndex = 0;
            // 
            // ReportingViewerMensajeros
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1210, 589);
            this.Controls.Add(this.RptViewer);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1228, 636);
            this.MinimumSize = new System.Drawing.Size(1228, 636);
            this.Name = "ReportingViewerMensajeros";
            this.ShowIcon = false;
            this.Load += new System.EventHandler(this.ReportingViewerMensajeros_Load);
            this.ResumeLayout(false);

        }

        #endregion

        public Microsoft.Reporting.WinForms.ReportViewer RptViewer;
    }
}