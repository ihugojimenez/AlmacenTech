namespace AlmacenTech.Consultas
{
    partial class ConsultaEquiposForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEquiposForm));
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.EquiposdataGridView = new System.Windows.Forms.DataGridView();
            this.EquipoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EquiposdataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(342, 12);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 43);
            this.Buscarbutton.TabIndex = 30;
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
            this.FiltrotextBox.TabIndex = 29;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(13, 31);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 28;
            this.label1.Text = "Filtrar ID";
            // 
            // EquiposdataGridView
            // 
            this.EquiposdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquiposdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipoId,
            this.MarcaEquipo,
            this.SerialNum});
            this.EquiposdataGridView.Location = new System.Drawing.Point(12, 69);
            this.EquiposdataGridView.Name = "EquiposdataGridView";
            this.EquiposdataGridView.RowTemplate.Height = 24;
            this.EquiposdataGridView.Size = new System.Drawing.Size(515, 292);
            this.EquiposdataGridView.TabIndex = 31;
            // 
            // EquipoId
            // 
            this.EquipoId.DataPropertyName = "EquipoId";
            this.EquipoId.HeaderText = "Equipo ID";
            this.EquipoId.Name = "EquipoId";
            // 
            // MarcaEquipo
            // 
            this.MarcaEquipo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.MarcaEquipo.DataPropertyName = "MarcaEquipo";
            this.MarcaEquipo.HeaderText = "Marca";
            this.MarcaEquipo.Name = "MarcaEquipo";
            this.MarcaEquipo.Width = 76;
            // 
            // SerialNum
            // 
            this.SerialNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SerialNum.DataPropertyName = "SerialNum";
            this.SerialNum.HeaderText = "Serial";
            this.SerialNum.Name = "SerialNum";
            this.SerialNum.Width = 73;
            // 
            // ConsultaEquiposForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(541, 373);
            this.Controls.Add(this.EquiposdataGridView);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.label1);
            this.Name = "ConsultaEquiposForm";
            this.Text = "ConsultaEquiposForm";
            this.Load += new System.EventHandler(this.ConsultaEquiposForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EquiposdataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView EquiposdataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNum;
    }
}