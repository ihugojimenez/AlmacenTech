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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ConsultaEquiposForm));
            this.EquiposdataGridView = new System.Windows.Forms.DataGridView();
            this.FiltrotextBox = new System.Windows.Forms.TextBox();
            this.FiltrocomboBox = new System.Windows.Forms.ComboBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Imprimebutton = new System.Windows.Forms.Button();
            this.DesdeDateTimePicke = new System.Windows.Forms.DateTimePicker();
            this.HastadateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.EquipoId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.MarcaEquipo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SerialNum = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Fecha = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.EquiposdataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // EquiposdataGridView
            // 
            this.EquiposdataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EquiposdataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.EquipoId,
            this.MarcaEquipo,
            this.SerialNum,
            this.Fecha});
            this.EquiposdataGridView.Location = new System.Drawing.Point(9, 104);
            this.EquiposdataGridView.Margin = new System.Windows.Forms.Padding(2);
            this.EquiposdataGridView.Name = "EquiposdataGridView";
            this.EquiposdataGridView.RowTemplate.Height = 24;
            this.EquiposdataGridView.Size = new System.Drawing.Size(625, 237);
            this.EquiposdataGridView.TabIndex = 31;
            // 
            // FiltrotextBox
            // 
            this.FiltrotextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.FiltrotextBox.Location = new System.Drawing.Point(67, 21);
            this.FiltrotextBox.Name = "FiltrotextBox";
            this.FiltrotextBox.Size = new System.Drawing.Size(298, 20);
            this.FiltrotextBox.TabIndex = 1;
            // 
            // FiltrocomboBox
            // 
            this.FiltrocomboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.FiltrocomboBox.FormattingEnabled = true;
            this.FiltrocomboBox.Location = new System.Drawing.Point(403, 21);
            this.FiltrocomboBox.Name = "FiltrocomboBox";
            this.FiltrocomboBox.Size = new System.Drawing.Size(171, 21);
            this.FiltrocomboBox.TabIndex = 2;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(579, 15);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(55, 45);
            this.Buscarbutton.TabIndex = 3;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click_1);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 20);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(49, 18);
            this.label1.TabIndex = 32;
            this.label1.Text = "Filtrar ";
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            this.BuscarerrorProvider.Icon = ((System.Drawing.Icon)(resources.GetObject("BuscarerrorProvider.Icon")));
            // 
            // Imprimebutton
            // 
            this.Imprimebutton.Image = ((System.Drawing.Image)(resources.GetObject("Imprimebutton.Image")));
            this.Imprimebutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Imprimebutton.Location = new System.Drawing.Point(9, 346);
            this.Imprimebutton.Name = "Imprimebutton";
            this.Imprimebutton.Size = new System.Drawing.Size(75, 51);
            this.Imprimebutton.TabIndex = 33;
            this.Imprimebutton.Text = "Imprimir";
            this.Imprimebutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Imprimebutton.UseVisualStyleBackColor = true;
            this.Imprimebutton.Click += new System.EventHandler(this.Imprimebutton_Click);
            // 
            // DesdeDateTimePicke
            // 
            this.DesdeDateTimePicke.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicke.CustomFormat = "dd/MM/yyyy";
            this.DesdeDateTimePicke.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.DesdeDateTimePicke.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.DesdeDateTimePicke.Location = new System.Drawing.Point(66, 57);
            this.DesdeDateTimePicke.Margin = new System.Windows.Forms.Padding(2);
            this.DesdeDateTimePicke.Name = "DesdeDateTimePicke";
            this.DesdeDateTimePicke.Size = new System.Drawing.Size(114, 22);
            this.DesdeDateTimePicke.TabIndex = 49;
            // 
            // HastadateTimePicker
            // 
            this.HastadateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastadateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.HastadateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HastadateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.HastadateTimePicker.Location = new System.Drawing.Point(253, 57);
            this.HastadateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.HastadateTimePicker.Name = "HastadateTimePicker";
            this.HastadateTimePicker.Size = new System.Drawing.Size(112, 22);
            this.HastadateTimePicker.TabIndex = 50;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(201, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 18);
            this.label2.TabIndex = 51;
            this.label2.Text = "Hasta";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(12, 59);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(51, 18);
            this.label3.TabIndex = 52;
            this.label3.Text = "Desde";
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
            this.MarcaEquipo.Width = 62;
            // 
            // SerialNum
            // 
            this.SerialNum.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.SerialNum.DataPropertyName = "SerialNum";
            this.SerialNum.HeaderText = "Serial";
            this.SerialNum.Name = "SerialNum";
            this.SerialNum.Width = 58;
            // 
            // Fecha
            // 
            this.Fecha.AutoSizeMode = System.Windows.Forms.DataGridViewAutoSizeColumnMode.DisplayedCells;
            this.Fecha.DataPropertyName = "FechaIngreso";
            this.Fecha.HeaderText = "Fecha de registro";
            this.Fecha.Name = "Fecha";
            this.Fecha.Width = 105;
            // 
            // ConsultaEquiposForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(646, 406);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.HastadateTimePicker);
            this.Controls.Add(this.DesdeDateTimePicke);
            this.Controls.Add(this.Imprimebutton);
            this.Controls.Add(this.FiltrotextBox);
            this.Controls.Add(this.FiltrocomboBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.EquiposdataGridView);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(579, 416);
            this.Name = "ConsultaEquiposForm";
            this.Text = "Consulta de Equipo";
            this.Load += new System.EventHandler(this.ConsultaEquiposForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EquiposdataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView EquiposdataGridView;
        private System.Windows.Forms.TextBox FiltrotextBox;
        private System.Windows.Forms.ComboBox FiltrocomboBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
        private System.Windows.Forms.Button Imprimebutton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker HastadateTimePicker;
        private System.Windows.Forms.DateTimePicker DesdeDateTimePicke;
        private System.Windows.Forms.DataGridViewTextBoxColumn EquipoId;
        private System.Windows.Forms.DataGridViewTextBoxColumn MarcaEquipo;
        private System.Windows.Forms.DataGridViewTextBoxColumn SerialNum;
        private System.Windows.Forms.DataGridViewTextBoxColumn Fecha;
    }
}