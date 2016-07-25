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
            this.SaveButton = new System.Windows.Forms.Button();
            this.ButtonsgroupBox = new System.Windows.Forms.GroupBox();
            marcaEquipoLabel = new System.Windows.Forms.Label();
            serialNumLabel = new System.Windows.Forms.Label();
            equipoIdLabel = new System.Windows.Forms.Label();
            tipoEquipoLabel = new System.Windows.Forms.Label();
            this.ButtonsgroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // marcaEquipoLabel
            // 
            marcaEquipoLabel.AutoSize = true;
            marcaEquipoLabel.Location = new System.Drawing.Point(12, 97);
            marcaEquipoLabel.Name = "marcaEquipoLabel";
            marcaEquipoLabel.Size = new System.Drawing.Size(99, 17);
            marcaEquipoLabel.TabIndex = 3;
            marcaEquipoLabel.Text = "Marca Equipo:";
            // 
            // serialNumLabel
            // 
            serialNumLabel.AutoSize = true;
            serialNumLabel.Location = new System.Drawing.Point(12, 57);
            serialNumLabel.Name = "serialNumLabel";
            serialNumLabel.Size = new System.Drawing.Size(81, 17);
            serialNumLabel.TabIndex = 5;
            serialNumLabel.Text = "Serial Num:";
            // 
            // equipoIdLabel
            // 
            equipoIdLabel.AutoSize = true;
            equipoIdLabel.Location = new System.Drawing.Point(11, 9);
            equipoIdLabel.Name = "equipoIdLabel";
            equipoIdLabel.Size = new System.Drawing.Size(71, 17);
            equipoIdLabel.TabIndex = 7;
            equipoIdLabel.Text = "Equipo Id:";
            // 
            // tipoEquipoLabel
            // 
            tipoEquipoLabel.AutoSize = true;
            tipoEquipoLabel.Location = new System.Drawing.Point(12, 137);
            tipoEquipoLabel.Name = "tipoEquipoLabel";
            tipoEquipoLabel.Size = new System.Drawing.Size(88, 17);
            tipoEquipoLabel.TabIndex = 9;
            tipoEquipoLabel.Text = "Tipo Equipo:";
            // 
            // marcaEquipoTextBox
            // 
            this.marcaEquipoTextBox.Location = new System.Drawing.Point(113, 91);
            this.marcaEquipoTextBox.Name = "marcaEquipoTextBox";
            this.marcaEquipoTextBox.Size = new System.Drawing.Size(210, 22);
            this.marcaEquipoTextBox.TabIndex = 4;
            // 
            // serialNumTextBox
            // 
            this.serialNumTextBox.Location = new System.Drawing.Point(95, 54);
            this.serialNumTextBox.Name = "serialNumTextBox";
            this.serialNumTextBox.Size = new System.Drawing.Size(228, 22);
            this.serialNumTextBox.TabIndex = 6;
            // 
            // equipoIdTextBox
            // 
            this.equipoIdTextBox.Location = new System.Drawing.Point(85, 6);
            this.equipoIdTextBox.Name = "equipoIdTextBox";
            this.equipoIdTextBox.Size = new System.Drawing.Size(22, 22);
            this.equipoIdTextBox.TabIndex = 8;
            // 
            // tipoEquipoComboBox
            // 
            this.tipoEquipoComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.tipoEquipoComboBox.FormattingEnabled = true;
            this.tipoEquipoComboBox.Location = new System.Drawing.Point(103, 136);
            this.tipoEquipoComboBox.Name = "tipoEquipoComboBox";
            this.tipoEquipoComboBox.Size = new System.Drawing.Size(220, 24);
            this.tipoEquipoComboBox.TabIndex = 10;
            // 
            // UpdateButton
            // 
            this.UpdateButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.UpdateButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UpdateButton.Location = new System.Drawing.Point(128, 15);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(77, 49);
            this.UpdateButton.TabIndex = 11;
            this.UpdateButton.Text = "Guardar";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdateButton.UseVisualStyleBackColor = true;
            // 
            // searchButton
            // 
            this.searchButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.searchButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.Image = ((System.Drawing.Image)(resources.GetObject("searchButton.Image")));
            this.searchButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.searchButton.Location = new System.Drawing.Point(143, 6);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(81, 36);
            this.searchButton.TabIndex = 12;
            this.searchButton.Text = "Buscar";
            this.searchButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.searchButton.UseVisualStyleBackColor = true;
            // 
            // Deletebutton
            // 
            this.Deletebutton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.Deletebutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Deletebutton.Image = ((System.Drawing.Image)(resources.GetObject("Deletebutton.Image")));
            this.Deletebutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Deletebutton.Location = new System.Drawing.Point(12, 16);
            this.Deletebutton.Name = "Deletebutton";
            this.Deletebutton.Size = new System.Drawing.Size(80, 48);
            this.Deletebutton.TabIndex = 13;
            this.Deletebutton.Text = "Eliminar";
            this.Deletebutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Deletebutton.UseVisualStyleBackColor = true;
            // 
            // SaveButton
            // 
            this.SaveButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SaveButton.Image = ((System.Drawing.Image)(resources.GetObject("SaveButton.Image")));
            this.SaveButton.Location = new System.Drawing.Point(234, 15);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(74, 49);
            this.SaveButton.TabIndex = 14;
            this.SaveButton.Text = "Agregar";
            this.SaveButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // ButtonsgroupBox
            // 
            this.ButtonsgroupBox.Controls.Add(this.Deletebutton);
            this.ButtonsgroupBox.Controls.Add(this.SaveButton);
            this.ButtonsgroupBox.Controls.Add(this.UpdateButton);
            this.ButtonsgroupBox.Location = new System.Drawing.Point(15, 181);
            this.ButtonsgroupBox.Name = "ButtonsgroupBox";
            this.ButtonsgroupBox.Size = new System.Drawing.Size(330, 74);
            this.ButtonsgroupBox.TabIndex = 15;
            this.ButtonsgroupBox.TabStop = false;
            this.ButtonsgroupBox.Text = "Opciones";
            // 
            // EquiposForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.ClientSize = new System.Drawing.Size(357, 275);
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
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(373, 314);
            this.Name = "EquiposForm";
            this.Text = "Registro de Equipos";
            this.Load += new System.EventHandler(this.EquiposForm_Load);
            this.ButtonsgroupBox.ResumeLayout(false);
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
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.GroupBox ButtonsgroupBox;
    }
}