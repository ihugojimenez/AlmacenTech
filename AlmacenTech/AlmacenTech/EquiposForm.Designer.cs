namespace AlmacenTech
{
    partial class EquiposForm
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
            System.Windows.Forms.Label marcaEquipoLabel;
            System.Windows.Forms.Label serialNumLabel;
            System.Windows.Forms.Label equipoIdLabel;
            System.Windows.Forms.Label tipoEquipoLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EquiposForm));
            this.marcaEquipoTextBox = new System.Windows.Forms.TextBox();
            this.serialNumTextBox = new System.Windows.Forms.TextBox();
            this.equipoIdTextBox = new System.Windows.Forms.TextBox();
            this.tipoEquipoComboBox = new System.Windows.Forms.ComboBox();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.searchButton = new System.Windows.Forms.Button();
            this.Deletebutton = new System.Windows.Forms.Button();
            this.ButtonsgroupBox = new System.Windows.Forms.GroupBox();
            this.NewButton = new System.Windows.Forms.Button();
            this.SaveButton = new System.Windows.Forms.Button();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.MarcaerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.SerialerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            marcaEquipoLabel = new System.Windows.Forms.Label();
            serialNumLabel = new System.Windows.Forms.Label();
            equipoIdLabel = new System.Windows.Forms.Label();
            tipoEquipoLabel = new System.Windows.Forms.Label();
            this.ButtonsgroupBox.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaerrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.SerialerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // marcaEquipoLabel
            // 
            marcaEquipoLabel.AutoSize = true;
            marcaEquipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            marcaEquipoLabel.Location = new System.Drawing.Point(2, 60);
            marcaEquipoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            marcaEquipoLabel.Name = "marcaEquipoLabel";
            marcaEquipoLabel.Size = new System.Drawing.Size(95, 16);
            marcaEquipoLabel.TabIndex = 3;
            marcaEquipoLabel.Text = "Marca Equipo:";
            // 
            // serialNumLabel
            // 
            serialNumLabel.AutoSize = true;
            serialNumLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            serialNumLabel.Location = new System.Drawing.Point(1, 110);
            serialNumLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            serialNumLabel.Name = "serialNumLabel";
            serialNumLabel.Size = new System.Drawing.Size(77, 16);
            serialNumLabel.TabIndex = 5;
            serialNumLabel.Text = "Serial Num:";
            // 
            // equipoIdLabel
            // 
            equipoIdLabel.AutoSize = true;
            equipoIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            equipoIdLabel.Location = new System.Drawing.Point(5, 19);
            equipoIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            equipoIdLabel.Name = "equipoIdLabel";
            equipoIdLabel.Size = new System.Drawing.Size(68, 16);
            equipoIdLabel.TabIndex = 7;
            equipoIdLabel.Text = "Equipo Id:";
            // 
            // tipoEquipoLabel
            // 
            tipoEquipoLabel.AutoSize = true;
            tipoEquipoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            tipoEquipoLabel.Location = new System.Drawing.Point(2, 160);
            tipoEquipoLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            tipoEquipoLabel.Name = "tipoEquipoLabel";
            tipoEquipoLabel.Size = new System.Drawing.Size(85, 16);
            tipoEquipoLabel.TabIndex = 9;
            tipoEquipoLabel.Text = "Tipo Equipo:";
            // 
            // marcaEquipoTextBox
            // 
            this.marcaEquipoTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.marcaEquipoTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.marcaEquipoTextBox.Location = new System.Drawing.Point(101, 60);
            this.marcaEquipoTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.marcaEquipoTextBox.Name = "marcaEquipoTextBox";
            this.marcaEquipoTextBox.Size = new System.Drawing.Size(314, 22);
            this.marcaEquipoTextBox.TabIndex = 2;
            // 
            // serialNumTextBox
            // 
            this.serialNumTextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.serialNumTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.serialNumTextBox.Location = new System.Drawing.Point(101, 107);
            this.serialNumTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.serialNumTextBox.Name = "serialNumTextBox";
            this.serialNumTextBox.Size = new System.Drawing.Size(314, 22);
            this.serialNumTextBox.TabIndex = 3;
            // 
            // equipoIdTextBox
            // 
            this.equipoIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equipoIdTextBox.Location = new System.Drawing.Point(101, 13);
            this.equipoIdTextBox.Margin = new System.Windows.Forms.Padding(2);
            this.equipoIdTextBox.Name = "equipoIdTextBox";
            this.equipoIdTextBox.Size = new System.Drawing.Size(58, 22);
            this.equipoIdTextBox.TabIndex = 1;
            // 
            // tipoEquipoComboBox
            // 
            this.tipoEquipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoEquipoComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tipoEquipoComboBox.FormattingEnabled = true;
            this.tipoEquipoComboBox.Location = new System.Drawing.Point(91, 157);
            this.tipoEquipoComboBox.Margin = new System.Windows.Forms.Padding(2);
            this.tipoEquipoComboBox.Name = "tipoEquipoComboBox";
            this.tipoEquipoComboBox.Size = new System.Drawing.Size(324, 24);
            this.tipoEquipoComboBox.TabIndex = 4;
            this.tipoEquipoComboBox.SelectedIndexChanged += new System.EventHandler(this.tipoEquipoComboBox_SelectedIndexChanged);
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UpdateButton.Location = new System.Drawing.Point(218, 19);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(61, 52);
            this.UpdateButton.TabIndex = 8;
            this.UpdateButton.Text = "Actualizar";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchButton.Location = new System.Drawing.Point(192, 11);
            this.searchButton.Margin = new System.Windows.Forms.Padding(2);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(61, 29);
            this.searchButton.TabIndex = 5;
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchButton.UseVisualStyleBackColor = true;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("Deletebutton.Image")));
            this.Deletebutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Deletebutton.Location = new System.Drawing.Point(322, 18);
            this.Deletebutton.Margin = new System.Windows.Forms.Padding(2);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(60, 52);
            this.Deletebutton.TabIndex = 9;
            this.Deletebutton.Text = "Eliminar";
            this.Deletebutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Deletebutton.UseVisualStyleBackColor = true;
            this.Deletebutton.Click += new System.EventHandler(this.Deletebutton_Click);
            // 
            // ButtonsgroupBox
            // 
            this.ButtonsgroupBox.Controls.Add(this.NewButton);
            this.ButtonsgroupBox.Controls.Add(this.SaveButton);
            this.ButtonsgroupBox.Controls.Add(this.Deletebutton);
            this.ButtonsgroupBox.Controls.Add(this.UpdateButton);
            this.ButtonsgroupBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonsgroupBox.Location = new System.Drawing.Point(12, 211);
            this.ButtonsgroupBox.Margin = new System.Windows.Forms.Padding(2);
            this.ButtonsgroupBox.Name = "ButtonsgroupBox";
            this.ButtonsgroupBox.Padding = new System.Windows.Forms.Padding(2);
            this.ButtonsgroupBox.Size = new System.Drawing.Size(403, 80);
            this.ButtonsgroupBox.TabIndex = 15;
            this.ButtonsgroupBox.TabStop = false;
            this.ButtonsgroupBox.Text = "Opciones";
            // 
            // NewButton
            // 
            this.NewButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.NewButton.Image = ((System.Drawing.Image)(resources.GetObject("NewButton.Image")));
            this.NewButton.Location = new System.Drawing.Point(12, 19);
            this.NewButton.Margin = new System.Windows.Forms.Padding(2);
            this.NewButton.Name = "NewButton";
            this.NewButton.Size = new System.Drawing.Size(66, 51);
            this.NewButton.TabIndex = 6;
            this.NewButton.Text = "Nuevo";
            this.NewButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.NewButton.UseVisualStyleBackColor = true;
            this.NewButton.Click += new System.EventHandler(this.NewButton_Click);
            // 
            // SaveButton
            // 
            this.SaveButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.SaveButton.Location = new System.Drawing.Point(112, 18);
            this.SaveButton.Margin = new System.Windows.Forms.Padding(2);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(66, 52);
            this.SaveButton.TabIndex = 7;
            this.SaveButton.Text = "Guardar";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click_1);
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            // 
            // MarcaerrorProvider
            // 
            this.MarcaerrorProvider.ContainerControl = this;
            // 
            // SerialerrorProvider
            // 
            this.SerialerrorProvider.ContainerControl = this;
            // 
            // EquiposForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(439, 298);
            this.Controls.Add(this.ButtonsgroupBox);
            this.Controls.Add(this.searchButton);
            this.Controls.Add(tipoEquipoLabel);
            this.Controls.Add(this.tipoEquipoComboBox);
            this.Controls.Add(equipoIdLabel);
            this.Controls.Add(this.equipoIdTextBox);
            this.Controls.Add(serialNumLabel);
            this.Controls.Add(this.serialNumTextBox);
            this.Controls.Add(marcaEquipoLabel);
            this.Controls.Add(this.marcaEquipoTextBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(455, 337);
            this.MinimumSize = new System.Drawing.Size(455, 337);
            this.Name = "EquiposForm";
            this.Text = "Registro de Equipos";
            this.Load += new System.EventHandler(this.EquiposForm_Load);
            this.ButtonsgroupBox.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MarcaerrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.SerialerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox marcaEquipoTextBox;
        private System.Windows.Forms.TextBox serialNumTextBox;
        private System.Windows.Forms.TextBox equipoIdTextBox;
        private System.Windows.Forms.ComboBox tipoEquipoComboBox;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Button Deletebutton;
        private System.Windows.Forms.GroupBox ButtonsgroupBox;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.Button NewButton;
        private System.Windows.Forms.ErrorProvider MarcaerrorProvider;
        private System.Windows.Forms.ErrorProvider SerialerrorProvider;
    }
}