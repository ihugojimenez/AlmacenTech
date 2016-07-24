namespace AlmacenTech
{
    partial class PrestamosForm
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
            System.Windows.Forms.Label idPrestamoLabel;
            System.Windows.Forms.Label idEquipoLabel;
            System.Windows.Forms.Label idBancaLabel;
            System.Windows.Forms.Label idMEnsajeroLabel;
            System.Windows.Forms.Label fechaSalidaLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PrestamosForm));
            this.idPrestamoTextBox = new System.Windows.Forms.TextBox();
            this.idEquipoTextBox = new System.Windows.Forms.TextBox();
            this.idBancaTextBox = new System.Windows.Forms.TextBox();
            this.idMEnsajeroTextBox = new System.Windows.Forms.TextBox();
            this.fechaSalidaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.SaveButton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            idPrestamoLabel = new System.Windows.Forms.Label();
            idEquipoLabel = new System.Windows.Forms.Label();
            idBancaLabel = new System.Windows.Forms.Label();
            idMEnsajeroLabel = new System.Windows.Forms.Label();
            fechaSalidaLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // idPrestamoLabel
            // 
            idPrestamoLabel.AutoSize = true;
            idPrestamoLabel.Location = new System.Drawing.Point(11, 51);
            idPrestamoLabel.Name = "idPrestamoLabel";
            idPrestamoLabel.Size = new System.Drawing.Size(83, 16);
            idPrestamoLabel.TabIndex = 1;
            idPrestamoLabel.Text = "Id Prestamo:";
            // 
            // idPrestamoTextBox
            // 
            this.idPrestamoTextBox.Location = new System.Drawing.Point(100, 51);
            this.idPrestamoTextBox.Name = "idPrestamoTextBox";
            this.idPrestamoTextBox.Size = new System.Drawing.Size(44, 22);
            this.idPrestamoTextBox.TabIndex = 2;
            // 
            // idEquipoLabel
            // 
            idEquipoLabel.AutoSize = true;
            idEquipoLabel.Location = new System.Drawing.Point(12, 90);
            idEquipoLabel.Name = "idEquipoLabel";
            idEquipoLabel.Size = new System.Drawing.Size(68, 16);
            idEquipoLabel.TabIndex = 3;
            idEquipoLabel.Text = "Id Equipo:";
            // 
            // idEquipoTextBox
            // 
            this.idEquipoTextBox.Location = new System.Drawing.Point(86, 87);
            this.idEquipoTextBox.Name = "idEquipoTextBox";
            this.idEquipoTextBox.Size = new System.Drawing.Size(58, 22);
            this.idEquipoTextBox.TabIndex = 4;
            // 
            // idBancaLabel
            // 
            idBancaLabel.AutoSize = true;
            idBancaLabel.Location = new System.Drawing.Point(12, 127);
            idBancaLabel.Name = "idBancaLabel";
            idBancaLabel.Size = new System.Drawing.Size(64, 16);
            idBancaLabel.TabIndex = 5;
            idBancaLabel.Text = "Id Banca:";
            // 
            // idBancaTextBox
            // 
            this.idBancaTextBox.Location = new System.Drawing.Point(82, 124);
            this.idBancaTextBox.Name = "idBancaTextBox";
            this.idBancaTextBox.Size = new System.Drawing.Size(62, 22);
            this.idBancaTextBox.TabIndex = 6;
            // 
            // idMEnsajeroLabel
            // 
            idMEnsajeroLabel.AutoSize = true;
            idMEnsajeroLabel.Location = new System.Drawing.Point(10, 164);
            idMEnsajeroLabel.Name = "idMEnsajeroLabel";
            idMEnsajeroLabel.Size = new System.Drawing.Size(89, 16);
            idMEnsajeroLabel.TabIndex = 7;
            idMEnsajeroLabel.Text = "Id Mensajero:";
            // 
            // idMEnsajeroTextBox
            // 
            this.idMEnsajeroTextBox.Location = new System.Drawing.Point(106, 161);
            this.idMEnsajeroTextBox.Name = "idMEnsajeroTextBox";
            this.idMEnsajeroTextBox.Size = new System.Drawing.Size(38, 22);
            this.idMEnsajeroTextBox.TabIndex = 8;
            // 
            // fechaSalidaLabel
            // 
            fechaSalidaLabel.AutoSize = true;
            fechaSalidaLabel.Location = new System.Drawing.Point(10, 21);
            fechaSalidaLabel.Name = "fechaSalidaLabel";
            fechaSalidaLabel.Size = new System.Drawing.Size(91, 16);
            fechaSalidaLabel.TabIndex = 9;
            fechaSalidaLabel.Text = "Fecha Salida:";
            // 
            // fechaSalidaDateTimePicker
            // 
            this.fechaSalidaDateTimePicker.Location = new System.Drawing.Point(107, 17);
            this.fechaSalidaDateTimePicker.Name = "fechaSalidaDateTimePicker";
            this.fechaSalidaDateTimePicker.Size = new System.Drawing.Size(242, 22);
            this.fechaSalidaDateTimePicker.TabIndex = 10;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(270, 45);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(74, 58);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Agregar";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(150, 45);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 43);
            this.Buscarbutton.TabIndex = 26;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            // 
            // PrestamosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(356, 196);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(fechaSalidaLabel);
            this.Controls.Add(this.fechaSalidaDateTimePicker);
            this.Controls.Add(idMEnsajeroLabel);
            this.Controls.Add(this.idMEnsajeroTextBox);
            this.Controls.Add(idBancaLabel);
            this.Controls.Add(this.idBancaTextBox);
            this.Controls.Add(idEquipoLabel);
            this.Controls.Add(this.idEquipoTextBox);
            this.Controls.Add(idPrestamoLabel);
            this.Controls.Add(this.idPrestamoTextBox);
            this.Name = "PrestamosForm";
            this.Text = "PrestamosForm";
            this.Load += new System.EventHandler(this.PrestamosForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox idPrestamoTextBox;
        private System.Windows.Forms.TextBox idEquipoTextBox;
        private System.Windows.Forms.TextBox idBancaTextBox;
        private System.Windows.Forms.TextBox idMEnsajeroTextBox;
        private System.Windows.Forms.DateTimePicker fechaSalidaDateTimePicker;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button Buscarbutton;
    }
}