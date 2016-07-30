namespace AlmacenTech
{
    partial class RegistroBanquerasForm
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
            System.Windows.Forms.Label nombresLabel;
            System.Windows.Forms.Label fechaLabel;
            System.Windows.Forms.Label cedulaLabel;
            System.Windows.Forms.Label celularLabel;
            System.Windows.Forms.Label telefonoLabel;
            System.Windows.Forms.Label banqueraIdLabel;
            System.Windows.Forms.Label direccionLabel;
            System.Windows.Forms.Label label2;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroBanquerasForm));
            this.nombresTextBox = new System.Windows.Forms.TextBox();
            this.direccionTextBox = new System.Windows.Forms.TextBox();
            this.fechaDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.cedulaMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.celularMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.telefonoMaskedTextBox = new System.Windows.Forms.MaskedTextBox();
            this.banqueraIdTextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MasculinoradioButton = new System.Windows.Forms.RadioButton();
            this.FemeninoradioButton = new System.Windows.Forms.RadioButton();
            this.ButtonsgroupBox = new System.Windows.Forms.GroupBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.NewButton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.NombreerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CedulaerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.CelularerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ApellidotextBox = new System.Windows.Forms.TextBox();
            this.SexogroupBox = new System.Windows.Forms.GroupBox();
            this.ApellidoerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            nombresLabel = new System.Windows.Forms.Label();
            fechaLabel = new System.Windows.Forms.Label();
            cedulaLabel = new System.Windows.Forms.Label();
            celularLabel = new System.Windows.Forms.Label();
            telefonoLabel = new System.Windows.Forms.Label();
            banqueraIdLabel = new System.Windows.Forms.Label();
            direccionLabel = new System.Windows.Forms.Label();
            label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            this.ButtonsgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CedulaerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CelularerrorProvider)).BeginInit();
            this.SexogroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApellidoerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // nombresLabel
            // 
            nombresLabel.AutoSize = true;
            nombresLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            nombresLabel.Location = new System.Drawing.Point(9, 67);
            nombresLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            nombresLabel.Name = "nombresLabel";
            nombresLabel.Size = new System.Drawing.Size(67, 16);
            nombresLabel.TabIndex = 1;
            nombresLabel.Text = "Nombres:";
            // 
            // fechaLabel
            // 
            fechaLabel.AutoSize = true;
            fechaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            fechaLabel.Location = new System.Drawing.Point(370, 20);
            fechaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            fechaLabel.Name = "fechaLabel";
            fechaLabel.Size = new System.Drawing.Size(49, 16);
            fechaLabel.TabIndex = 13;
            fechaLabel.Text = "Fecha:";
            // 
            // cedulaLabel
            // 
            cedulaLabel.AutoSize = true;
            cedulaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            cedulaLabel.Location = new System.Drawing.Point(370, 67);
            cedulaLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            cedulaLabel.Name = "cedulaLabel";
            cedulaLabel.Size = new System.Drawing.Size(54, 16);
            cedulaLabel.TabIndex = 17;
            cedulaLabel.Text = "Cedula:";
            // 
            // celularLabel
            // 
            celularLabel.AutoSize = true;
            celularLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            celularLabel.Location = new System.Drawing.Point(370, 156);
            celularLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            celularLabel.Name = "celularLabel";
            celularLabel.Size = new System.Drawing.Size(56, 16);
            celularLabel.TabIndex = 19;
            celularLabel.Text = "Celular :";
            // 
            // telefonoLabel
            // 
            telefonoLabel.AutoSize = true;
            telefonoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            telefonoLabel.Location = new System.Drawing.Point(370, 111);
            telefonoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            telefonoLabel.Name = "telefonoLabel";
            telefonoLabel.Size = new System.Drawing.Size(65, 16);
            telefonoLabel.TabIndex = 20;
            telefonoLabel.Text = "Telefono:";
            // 
            // banqueraIdLabel
            // 
            banqueraIdLabel.AutoSize = true;
            banqueraIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            banqueraIdLabel.Location = new System.Drawing.Point(9, 26);
            banqueraIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            banqueraIdLabel.Name = "banqueraIdLabel";
            banqueraIdLabel.Size = new System.Drawing.Size(27, 16);
            banqueraIdLabel.TabIndex = 23;
            banqueraIdLabel.Text = "ID: ";
            // 
            // direccionLabel
            // 
            direccionLabel.AutoSize = true;
            direccionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            direccionLabel.Location = new System.Drawing.Point(9, 156);
            direccionLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            direccionLabel.Name = "direccionLabel";
            direccionLabel.Size = new System.Drawing.Size(68, 16);
            direccionLabel.TabIndex = 3;
            direccionLabel.Text = "Direccion:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            label2.Location = new System.Drawing.Point(9, 111);
            label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            label2.Name = "label2";
            label2.Size = new System.Drawing.Size(68, 16);
            label2.TabIndex = 30;
            label2.Text = "Apellidos:";
            // 
            // nombresTextBox
            // 
            this.nombresTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.nombresTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nombresTextBox.Location = new System.Drawing.Point(83, 64);
            this.nombresTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.nombresTextBox.Name = "nombresTextBox";
            this.nombresTextBox.Size = new System.Drawing.Size(245, 22);
            this.nombresTextBox.TabIndex = 3;
            // 
            // direccionTextBox
            // 
            this.direccionTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.direccionTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.direccionTextBox.Location = new System.Drawing.Point(83, 153);
            this.direccionTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.direccionTextBox.Name = "direccionTextBox";
            this.direccionTextBox.Size = new System.Drawing.Size(245, 22);
            this.direccionTextBox.TabIndex = 5;
            // 
            // fechaDateTimePicker
            // 
            this.fechaDateTimePicker.CalendarFont = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.CustomFormat = "dd/MM/yyyy";
            this.fechaDateTimePicker.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.fechaDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            this.fechaDateTimePicker.Location = new System.Drawing.Point(440, 15);
            this.fechaDateTimePicker.Margin = new System.Windows.Forms.Padding(2);
            this.fechaDateTimePicker.Name = "fechaDateTimePicker";
            this.fechaDateTimePicker.Size = new System.Drawing.Size(137, 22);
            this.fechaDateTimePicker.TabIndex = 6;
            this.fechaDateTimePicker.ValueChanged += new System.EventHandler(this.fechaDateTimePicker_ValueChanged);
            // 
            // cedulaMaskedTextBox
            // 
            this.cedulaMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cedulaMaskedTextBox.Location = new System.Drawing.Point(440, 64);
            this.cedulaMaskedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.cedulaMaskedTextBox.Mask = "999-9999999-9";
            this.cedulaMaskedTextBox.Name = "cedulaMaskedTextBox";
            this.cedulaMaskedTextBox.Size = new System.Drawing.Size(137, 22);
            this.cedulaMaskedTextBox.TabIndex = 7;
            // 
            // celularMaskedTextBox
            // 
            this.celularMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.celularMaskedTextBox.Location = new System.Drawing.Point(444, 153);
            this.celularMaskedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.celularMaskedTextBox.Mask = "999-999-9999";
            this.celularMaskedTextBox.Name = "celularMaskedTextBox";
            this.celularMaskedTextBox.Size = new System.Drawing.Size(133, 22);
            this.celularMaskedTextBox.TabIndex = 9;
            // 
            // telefonoMaskedTextBox
            // 
            this.telefonoMaskedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.telefonoMaskedTextBox.Location = new System.Drawing.Point(440, 108);
            this.telefonoMaskedTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.telefonoMaskedTextBox.Mask = "999-999-9999";
            this.telefonoMaskedTextBox.Name = "telefonoMaskedTextBox";
            this.telefonoMaskedTextBox.Size = new System.Drawing.Size(137, 22);
            this.telefonoMaskedTextBox.TabIndex = 8;
            // 
            // banqueraIdTextBox
            // 
            this.banqueraIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banqueraIdTextBox.Location = new System.Drawing.Point(83, 20);
            this.banqueraIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.banqueraIdTextBox.Name = "banqueraIdTextBox";
            this.banqueraIdTextBox.Size = new System.Drawing.Size(111, 22);
            this.banqueraIdTextBox.TabIndex = 1;
            this.banqueraIdTextBox.TextChanged += new System.EventHandler(this.banqueraIdTextBox_TextChanged);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(218, 5);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(56, 41);
            this.Buscarbutton.TabIndex = 2;
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            // 
            // MasculinoradioButton
            // 
            this.MasculinoradioButton.AutoSize = true;
            this.MasculinoradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MasculinoradioButton.Location = new System.Drawing.Point(73, 18);
            this.MasculinoradioButton.Name = "MasculinoradioButton";
            this.MasculinoradioButton.Size = new System.Drawing.Size(87, 20);
            this.MasculinoradioButton.TabIndex = 10;
            this.MasculinoradioButton.TabStop = true;
            this.MasculinoradioButton.Text = "Masculino";
            this.MasculinoradioButton.UseVisualStyleBackColor = true;
            // 
            // FemeninoradioButton
            // 
            this.FemeninoradioButton.AutoSize = true;
            this.FemeninoradioButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FemeninoradioButton.Location = new System.Drawing.Point(207, 18);
            this.FemeninoradioButton.Name = "FemeninoradioButton";
            this.FemeninoradioButton.Size = new System.Drawing.Size(86, 20);
            this.FemeninoradioButton.TabIndex = 11;
            this.FemeninoradioButton.TabStop = true;
            this.FemeninoradioButton.Text = "Femenino";
            this.FemeninoradioButton.UseVisualStyleBackColor = true;
            // 
            // ButtonsgroupBox
            // 
            this.ButtonsgroupBox.Controls.Add(this.UpdateButton);
            this.ButtonsgroupBox.Controls.Add(this.SaveButton);
            this.ButtonsgroupBox.Controls.Add(this.NewButton);
            this.ButtonsgroupBox.Controls.Add(this.Deletebutton);
            this.ButtonsgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonsgroupBox.Location = new System.Drawing.Point(47, 278);
            this.ButtonsgroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonsgroupBox.Name = "ButtonsgroupBox";
            this.ButtonsgroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ButtonsgroupBox.Size = new System.Drawing.Size(544, 80);
            this.ButtonsgroupBox.TabIndex = 12;
            this.ButtonsgroupBox.TabStop = false;
            this.ButtonsgroupBox.Text = "Opciones";
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UpdateButton.Location = new System.Drawing.Point(293, 17);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(66, 59);
            this.UpdateButton.TabIndex = 14;
            this.UpdateButton.Text = "Actualizar";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveButton.Location = new System.Drawing.Point(160, 15);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(66, 59);
            this.SaveButton.TabIndex = 13;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.Location = new System.Drawing.Point(41, 17);
            this.NewButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(66, 58);
            this.NewButton.TabIndex = 12;
            this.NewButton.Text = "Nuevo";
            this.NewButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("Deletebutton.Image")));
            this.Deletebutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Deletebutton.Location = new System.Drawing.Point(427, 16);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(68, 58);
            this.Deletebutton.TabIndex = 15;
            this.Deletebutton.Text = "Eliminar";
            this.Deletebutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click_1);
            // 
            // NombreerrorProvider
            // 
            this.NombreerrorProvider.ContainerControl = this;
            // 
            // CedulaerrorProvider
            // 
            this.CedulaerrorProvider.ContainerControl = this;
            // 
            // CelularerrorProvider
            // 
            this.CelularerrorProvider.ContainerControl = this;
            // 
            // ApellidotextBox
            // 
            this.ApellidotextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.ApellidotextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ApellidotextBox.Location = new System.Drawing.Point(83, 108);
            this.ApellidotextBox.Margin = new System.Windows.Forms.Padding(2);
            this.ApellidotextBox.Name = "ApellidotextBox";
            this.ApellidotextBox.Size = new System.Drawing.Size(245, 22);
            this.ApellidotextBox.TabIndex = 4;
            // 
            // SexogroupBox
            // 
            this.SexogroupBox.Controls.Add(this.MasculinoradioButton);
            this.SexogroupBox.Controls.Add(this.FemeninoradioButton);
            this.SexogroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SexogroupBox.Location = new System.Drawing.Point(12, 202);
            this.SexogroupBox.Name = "SexogroupBox";
            this.SexogroupBox.Size = new System.Drawing.Size(316, 45);
            this.SexogroupBox.TabIndex = 10;
            this.SexogroupBox.TabStop = false;
            this.SexogroupBox.Text = "Sexo";
            // 
            // ApellidoerrorProvider
            // 
            this.ApellidoerrorProvider.ContainerControl = this;
            // 
            // RegistroBanquerasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 392);
            this.Controls.Add(this.SexogroupBox);
            this.Controls.Add(label2);
            this.Controls.Add(this.ApellidotextBox);
            this.Controls.Add(this.ButtonsgroupBox);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(banqueraIdLabel);
            this.Controls.Add(this.banqueraIdTextBox);
            this.Controls.Add(telefonoLabel);
            this.Controls.Add(this.telefonoMaskedTextBox);
            this.Controls.Add(celularLabel);
            this.Controls.Add(this.celularMaskedTextBox);
            this.Controls.Add(cedulaLabel);
            this.Controls.Add(this.cedulaMaskedTextBox);
            this.Controls.Add(fechaLabel);
            this.Controls.Add(this.fechaDateTimePicker);
            this.Controls.Add(direccionLabel);
            this.Controls.Add(this.direccionTextBox);
            this.Controls.Add(nombresLabel);
            this.Controls.Add(this.nombresTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(647, 431);
            this.MinimumSize = new System.Drawing.Size(647, 431);
            this.Name = "RegistroBanquerasForm";
            this.Text = "Registro de Banqueras";
            this.Load += new System.EventHandler(this.RegistroBanquerasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            this.ButtonsgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.NombreerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CedulaerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CelularerrorProvider)).EndInit();
            this.SexogroupBox.ResumeLayout(false);
            this.SexogroupBox.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ApellidoerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox nombresTextBox;
        private System.Windows.Forms.TextBox direccionTextBox;
        private System.Windows.Forms.DateTimePicker fechaDateTimePicker;
        private System.Windows.Forms.MaskedTextBox cedulaMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox celularMaskedTextBox;
        private System.Windows.Forms.MaskedTextBox telefonoMaskedTextBox;
        private System.Windows.Forms.TextBox banqueraIdTextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
        private System.Windows.Forms.RadioButton FemeninoradioButton;
        private System.Windows.Forms.RadioButton MasculinoradioButton;
        private System.Windows.Forms.GroupBox ButtonsgroupBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.ErrorProvider NombreerrorProvider;
        private System.Windows.Forms.ErrorProvider CedulaerrorProvider;
        private System.Windows.Forms.ErrorProvider CelularerrorProvider;
        private System.Windows.Forms.TextBox ApellidotextBox;
        private System.Windows.Forms.GroupBox SexogroupBox;
        private System.Windows.Forms.ErrorProvider ApellidoerrorProvider;
    }
}