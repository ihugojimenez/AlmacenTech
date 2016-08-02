namespace AlmacenTech.Consultas
{
    partial class ConsultaBanquerasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaBanquerasForm));
            this.BanquerasdataGridView = new System.Windows.Forms.DataGridView();
            this.BanqueraId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombres = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Apellidos = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Direccion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Cedula = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Celular = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Telefono = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Sexo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Imprimebutton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.BanquerasdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // BanquerasdataGridView
            // 
            this.BanquerasdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.BanquerasdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.BanqueraId,
            this.Nombres,
            this.Apellidos,
            this.Direccion,
            this.Cedula,
            this.Celular,
            this.Telefono,
            this.Fecha,
            this.Sexo});
            this.BanquerasdataGridView.Location = new System.Drawing.Point(11, 103);
            this.BanquerasdataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.BanquerasdataGridView.Name = "BanquerasdataGridView";
            this.BanquerasdataGridView.RowTemplate.Height = 24;
            this.BanquerasdataGridView.Size = new System.Drawing.Size(1213, 357);
            this.BanquerasdataGridView.TabIndex = 34;
            // 
            // BanqueraId
            // 
            this.BanqueraId.DataPropertyName = "BanqueraId";
            this.BanqueraId.HeaderText = "Banquera ID";
            this.BanqueraId.Name = "BanqueraId";
            // 
            // Nombres
            // 
            this.Nombres.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Nombres.DataPropertyName = "Nombres";
            this.Nombres.HeaderText = "Nombres";
            this.Nombres.Name = "Nombres";
            this.Nombres.Width = 94;
            // 
            // Apellidos
            // 
            this.Apellidos.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Apellidos.DataPropertyName = "Apellidos";
            this.Apellidos.HeaderText = "Apellidos";
            this.Apellidos.Name = "Apellidos";
            this.Apellidos.Width = 94;
            // 
            // Direccion
            // 
            this.Direccion.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Direccion.DataPropertyName = "Direccion";
            this.Direccion.HeaderText = "Direccion";
            this.Direccion.Name = "Direccion";
            this.Direccion.Width = 96;
            // 
            // Cedula
            // 
            this.Cedula.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Cedula.DataPropertyName = "Cedula";
            this.Cedula.HeaderText = "Cedula";
            this.Cedula.Name = "Cedula";
            this.Cedula.Width = 81;
            // 
            // Celular
            // 
            this.Celular.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Celular.DataPropertyName = "Celular";
            this.Celular.HeaderText = "Celular";
            this.Celular.Name = "Celular";
            this.Celular.Width = 81;
            // 
            // Telefono
            // 
            this.Telefono.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Telefono.DataPropertyName = "Telefono";
            this.Telefono.HeaderText = "Telefono";
            this.Telefono.Name = "Telefono";
            this.Telefono.Width = 93;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fecha.DataPropertyName = "Fecha";
            this.Fecha.HeaderText = "Fecha";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 76;
            // 
            // Sexo
            // 
            this.Sexo.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.Fill;
            this.Sexo.DataPropertyName = "Sexo";
            this.Sexo.HeaderText = "Sexo";
            this.Sexo.Name = "Sexo";
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FiltrotextBox.Location = new System.Drawing.Point(83, 36);
            this.FiltrotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(640, 22);
            this.FiltrotextBox.TabIndex = 35;
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Location = new System.Drawing.Point(796, 34);
            this.FiltrocomboBox.Margin = new System.Windows.Forms.Padding(4);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(324, 24);
            this.FiltrocomboBox.TabIndex = 36;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(1151, 14);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(73, 55);
            this.Buscarbutton.TabIndex = 37;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(61, 24);
            this.label1.TabIndex = 38;
            this.label1.Text = "Filtrar ";
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            // 
            // Imprimebutton
            // 
            this.Imprimebutton.Image = ((System.Drawing.Image)(resources.GetObject("Imprimebutton.Image")));
            this.Imprimebutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Imprimebutton.Location = new System.Drawing.Point(13, 466);
            this.Imprimebutton.Margin = new System.Windows.Forms.Padding(4);
            this.Imprimebutton.Name = "Imprimebutton";
            this.Imprimebutton.Size = new System.Drawing.Size(100, 63);
            this.Imprimebutton.TabIndex = 39;
            this.Imprimebutton.Text = "Imprimir";
            this.Imprimebutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imprimebutton.UseVisualStyleBackColor = true;
            this.Imprimebutton.Click += new System.EventHandler(this.Imprimebutton_Click);
            // 
            // ConsultaBanquerasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1236, 534);
            this.Controls.Add(this.Imprimebutton);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.BanquerasdataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(1254, 581);
            this.MinimumSize = new System.Drawing.Size(1254, 581);
            this.Name = "ConsultaBanquerasForm";
            this.Text = "Consulta de Banqueras";
            this.Load += new System.EventHandler(this.ConsultaBanquerasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BanquerasdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView BanquerasdataGridView;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
        private System.Windows.Forms.DataGridViewTextBoxColumn BanqueraId;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombres;
        private System.Windows.Forms.DataGridViewTextBoxColumn Apellidos;
        private System.Windows.Forms.DataGridViewTextBoxColumn Direccion;
        private System.Windows.Forms.DataGridViewTextBoxColumn Cedula;
        private System.Windows.Forms.DataGridViewTextBoxColumn Celular;
        private System.Windows.Forms.DataGridViewTextBoxColumn Telefono;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
        private System.Windows.Forms.DataGridViewTextBoxColumn Sexo;
        private System.Windows.Forms.Button Imprimebutton;
    }
}