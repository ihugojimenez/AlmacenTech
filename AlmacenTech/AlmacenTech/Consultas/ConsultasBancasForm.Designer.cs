namespace AlmacenTech.Consultas
{
    partial class ConsultasBancasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultasBancasForm));
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.BancasdataGridView = new System.Windows.Forms.DataGridView();
            this.BancaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.EquipoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.RutaId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.BancasdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(298, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 43);
            this.Buscarbutton.TabIndex = 33;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.Location = new System.Drawing.Point(98, 31);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(45, 22);
            this.FiltrotextBox.TabIndex = 32;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 29);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "Filtrar ID";
            // 
            // BancasdataGridView
            // 
            this.BancasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BancasdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BancaId,
            this.EquipoId,
            this.RutaId});
            this.BancasdataGridView.Location = new System.Drawing.Point(12, 69);
            this.BancasdataGridView.Name = "BancasdataGridView";
            this.BancasdataGridView.RowTemplate.Height = 24;
            this.BancasdataGridView.Size = new System.Drawing.Size(543, 244);
            this.BancasdataGridView.TabIndex = 34;
            // 
            // BancaId
            // 
            this.BancaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.BancaId.DataPropertyName = "BancaId";
            this.BancaId.HeaderText = "Banca ID";
            this.BancaId.Name = "BancaId";
            this.BancaId.Width = 94;
            // 
            // EquipoId
            // 
            this.EquipoId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.EquipoId.DataPropertyName = "EquipoId";
            this.EquipoId.HeaderText = "Equipos";
            this.EquipoId.Name = "EquipoId";
            this.EquipoId.Width = 88;
            // 
            // RutaId
            // 
            this.RutaId.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.RutaId.DataPropertyName = "RutaId";
            this.RutaId.HeaderText = "Ruta";
            this.RutaId.Name = "RutaId";
            // 
            // ConsultasBancasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(567, 324);
            this.Controls.Add(this.BancasdataGridView);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.label1);
            this.Name = "ConsultasBancasForm";
            this.Text = "ConsultasBancasForm";
            this.Load += new System.EventHandler(this.ConsultasBancasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BancasdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView BancasdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn BancaId;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn RutaId;
    }
}