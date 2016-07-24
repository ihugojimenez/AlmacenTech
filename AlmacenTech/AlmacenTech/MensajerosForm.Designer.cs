namespace AlmacenTech
{
    partial class MensajerosForm
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
            System.Windows.Forms.Label mensajeroIdLabel;
            System.Windows.Forms.Label nombreLabel;
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label sexoLabel;
            System.Windows.Forms.Label fechaNacimientoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MensajerosForm));
            this.mensajeroIdTextBox = new System.Windows.Forms.TextBox();
            this.nombreTextBox = new System.Windows.Forms.TextBox();
            this.cedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.sexoCheckBox = new System.Windows.Forms.CheckBox();
            this.fechaNacimientoDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.ButtonsgroupBox = new System.Windows.Forms.GroupBox();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            mensajeroIdLabel = new System.Windows.Forms.Label();
            nombreLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            sexoLabel = new System.Windows.Forms.Label();
            fechaNacimientoLabel = new System.Windows.Forms.Label();
            this.ButtonsgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // mensajeroIdLabel
            // 
            mensajeroIdLabel.AutoSize = true;
            mensajeroIdLabel.Location = new System.Drawing.Point(12, 21);
            mensajeroIdLabel.Name = "mensajeroIdLabel";
            mensajeroIdLabel.Size = new System.Drawing.Size(89, 16);
            mensajeroIdLabel.TabIndex = 1;
            mensajeroIdLabel.Text = "Mensajero Id:";
            // 
            // mensajeroIdTextBox
            // 
            this.mensajeroIdTextBox.Location = new System.Drawing.Point(107, 18);
            this.mensajeroIdTextBox.Name = "mensajeroIdTextBox";
            this.mensajeroIdTextBox.Size = new System.Drawing.Size(28, 22);
            this.mensajeroIdTextBox.TabIndex = 2;
            // 
            // nombreLabel
            // 
            nombreLabel.AutoSize = true;
            nombreLabel.Location = new System.Drawing.Point(12, 55);
            nombreLabel.Name = "nombreLabel";
            nombreLabel.Size = new System.Drawing.Size(60, 16);
            nombreLabel.TabIndex = 3;
            nombreLabel.Text = "Nombre:";
            // 
            // nombreTextBox
            // 
            this.nombreTextBox.Location = new System.Drawing.Point(78, 52);
            this.nombreTextBox.Name = "nombreTextBox";
            this.nombreTextBox.Size = new System.Drawing.Size(301, 22);
            this.nombreTextBox.TabIndex = 4;
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Location = new System.Drawing.Point(12, 132);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(54, 16);
            cedulaLabel.TabIndex = 5;
            cedulaLabel.Text = "Cedula:";
            // 
            // cedulaMaskedTextBox
            // 
            this.cedulaMaskedTextBox.Location = new System.Drawing.Point(72, 132);
            this.cedulaMaskedTextBox.Mask = "999-9999999-9";
            this.cedulaMaskedTextBox.Name = "cedulaMaskedTextBox";
            this.cedulaMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.cedulaMaskedTextBox.TabIndex = 6;
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Location = new System.Drawing.Point(12, 169);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(53, 16);
            celularLabel.TabIndex = 7;
            celularLabel.Text = "Celular:";
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.Location = new System.Drawing.Point(71, 166);
            this.celularMaskedTextBox.Mask = "999-999-9999";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(100, 22);
            this.celularMaskedTextBox.TabIndex = 8;
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Location = new System.Drawing.Point(12, 203);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(65, 16);
            telefonoLabel.TabIndex = 9;
            telefonoLabel.Text = "Telefono:";
            // 
            // telefonoMaskedTextBox
            // 
            this.telefonoMaskedTextBox.Location = new System.Drawing.Point(83, 200);
            this.telefonoMaskedTextBox.Mask = "999-999-9999";
            this.telefonoMaskedTextBox.Name = "telefonoMaskedTextBox";
            this.telefonoMaskedTextBox.Size = new System.Drawing.Size(89, 22);
            this.telefonoMaskedTextBox.TabIndex = 10;
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Location = new System.Drawing.Point(12, 92);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(68, 16);
            direccionLabel.TabIndex = 11;
            direccionLabel.Text = "Direccion:";
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.Location = new System.Drawing.Point(86, 89);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(293, 22);
            this.direccionTextBox.TabIndex = 12;
            // 
            // sexoLabel
            // 
            sexoLabel.AutoSize = true;
            sexoLabel.Location = new System.Drawing.Point(12, 245);
            sexoLabel.Name = "sexoLabel";
            sexoLabel.Size = new System.Drawing.Size(42, 16);
            sexoLabel.TabIndex = 13;
            sexoLabel.Text = "Sexo:";
            // 
            // sexoCheckBox
            // 
            this.sexoCheckBox.Location = new System.Drawing.Point(60, 240);
            this.sexoCheckBox.Name = "sexoCheckBox";
            this.sexoCheckBox.Size = new System.Drawing.Size(104, 24);
            this.sexoCheckBox.TabIndex = 14;
            this.sexoCheckBox.Text = "checkBox1";
            this.sexoCheckBox.UseVisualStyleBackColor = true;
            // 
            // fechaNacimientoLabel
            // 
            fechaNacimientoLabel.AutoSize = true;
            fechaNacimientoLabel.Location = new System.Drawing.Point(12, 282);
            fechaNacimientoLabel.Name = "fechaNacimientoLabel";
            fechaNacimientoLabel.Size = new System.Drawing.Size(120, 16);
            fechaNacimientoLabel.TabIndex = 15;
            fechaNacimientoLabel.Text = "Fecha Nacimiento:";
            // 
            // fechaNacimientoDateTimePicker
            // 
            this.fechaNacimientoDateTimePicker.Location = new System.Drawing.Point(141, 282);
            this.fechaNacimientoDateTimePicker.Name = "fechaNacimientoDateTimePicker";
            this.fechaNacimientoDateTimePicker.Size = new System.Drawing.Size(241, 22);
            this.fechaNacimientoDateTimePicker.TabIndex = 16;
            // 
            // ButtonsgroupBox
            // 
            this.ButtonsgroupBox.Controls.Add(this.Deletebutton);
            this.ButtonsgroupBox.Controls.Add(this.SaveButton);
            this.ButtonsgroupBox.Controls.Add(this.UpdateButton);
            this.ButtonsgroupBox.Location = new System.Drawing.Point(12, 310);
            this.ButtonsgroupBox.Name = "ButtonsgroupBox";
            this.ButtonsgroupBox.Size = new System.Drawing.Size(394, 83);
            this.ButtonsgroupBox.TabIndex = 23;
            this.ButtonsgroupBox.TabStop = false;
            this.ButtonsgroupBox.Text = "Opciones";
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("Deletebutton.Image")));
            this.Deletebutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Deletebutton.Location = new System.Drawing.Point(12, 16);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(74, 54);
            this.Deletebutton.TabIndex = 13;
            this.Deletebutton.Text = "Eliminar";
            this.Deletebutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Deletebutton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(293, 16);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(74, 58);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Agregar";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UpdateButton.Location = new System.Drawing.Point(152, 16);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(77, 54);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "Guardar";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(141, 3);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 43);
            this.Buscarbutton.TabIndex = 26;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // MensajerosForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(418, 415);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(this.ButtonsgroupBox);
            this.Controls.Add(fechaNacimientoLabel);
            this.Controls.Add(this.fechaNacimientoDateTimePicker);
            this.Controls.Add(sexoLabel);
            this.Controls.Add(this.sexoCheckBox);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoMaskedTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularMaskedTextBox);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaMaskedTextBox);
            this.Controls.Add(nombreLabel);
            this.Controls.Add(this.nombreTextBox);
            this.Controls.Add(mensajeroIdLabel);
            this.Controls.Add(this.mensajeroIdTextBox);
            this.Name = "MensajerosForm";
            this.Text = "Mensajeros";
            this.Load += new System.EventHandler(this.MensajerosForm_Load);
            this.ButtonsgroupBox.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox mensajeroIdTextBox;
        private System.Windows.Forms.TextBox nombreTextBox;
        private System.Windows.Forms.MaskedTextBox cedulaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox telefonoMaskedTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.CheckBox sexoCheckBox;
        private System.Windows.Forms.DateTimePicker fechaNacimientoDateTimePicker;
        private System.Windows.Forms.GroupBox ButtonsgroupBox;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button Buscarbutton;
    }
}