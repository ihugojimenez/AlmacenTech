namespace AlmacenTech
{
    partial class RegistroBancasForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroBancasForm));
            System.Windows.Forms.Label banqueraIdLabel;
            System.Windows.Forms.Label equipoIdLabel;
            System.Windows.Forms.Label rutaIdLabel;
            System.Windows.Forms.Label bancaIdLabel;
            this.UpdateButton = new System.Windows.Forms.Button();
            this.EliminarButton = new System.Windows.Forms.Button();
            this.banqueraIdComboBox = new System.Windows.Forms.ComboBox();
            this.equipoIdComboBox = new System.Windows.Forms.ComboBox();
            this.rutaIdComboBox = new System.Windows.Forms.ComboBox();
            this.bancaIdTextBox = new System.Windows.Forms.TextBox();
            this.Addbutton = new System.Windows.Forms.Button();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            banqueraIdLabel = new System.Windows.Forms.Label();
            equipoIdLabel = new System.Windows.Forms.Label();
            rutaIdLabel = new System.Windows.Forms.Label();
            bancaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // UpdateButton
            // 
            this.UpdateButton.Image = ((System.Drawing.Image)(resources.GetObject("UpdateButton.Image")));
            this.UpdateButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.UpdateButton.Location = new System.Drawing.Point(379, 191);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(84, 51);
            this.UpdateButton.TabIndex = 9;
            this.UpdateButton.Text = "Guardar";
            this.UpdateButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // EliminarButton
            // 
            this.EliminarButton.Image = ((System.Drawing.Image)(resources.GetObject("EliminarButton.Image")));
            this.EliminarButton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.EliminarButton.Location = new System.Drawing.Point(507, 191);
            this.EliminarButton.Name = "EliminarButton";
            this.EliminarButton.Size = new System.Drawing.Size(69, 51);
            this.EliminarButton.TabIndex = 10;
            this.EliminarButton.Text = "Eliminar";
            this.EliminarButton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.EliminarButton.UseVisualStyleBackColor = true;
            this.EliminarButton.Click += new System.EventHandler(this.EliminarButton_Click);
            // 
            // banqueraIdLabel
            // 
            banqueraIdLabel.AutoSize = true;
            banqueraIdLabel.Location = new System.Drawing.Point(337, 14);
            banqueraIdLabel.Name = "banqueraIdLabel";
            banqueraIdLabel.Size = new System.Drawing.Size(89, 17);
            banqueraIdLabel.TabIndex = 11;
            banqueraIdLabel.Text = "Banquera Id:";
            // 
            // banqueraIdComboBox
            // 
            this.banqueraIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.banqueraIdComboBox.FormattingEnabled = true;
            this.banqueraIdComboBox.Location = new System.Drawing.Point(432, 11);
            this.banqueraIdComboBox.Name = "banqueraIdComboBox";
            this.banqueraIdComboBox.Size = new System.Drawing.Size(121, 24);
            this.banqueraIdComboBox.TabIndex = 12;
            // 
            // equipoIdLabel
            // 
            equipoIdLabel.AutoSize = true;
            equipoIdLabel.Location = new System.Drawing.Point(337, 77);
            equipoIdLabel.Name = "equipoIdLabel";
            equipoIdLabel.Size = new System.Drawing.Size(71, 17);
            equipoIdLabel.TabIndex = 12;
            equipoIdLabel.Text = "Equipo Id:";
            // 
            // equipoIdComboBox
            // 
            this.equipoIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.equipoIdComboBox.FormattingEnabled = true;
            this.equipoIdComboBox.Location = new System.Drawing.Point(414, 74);
            this.equipoIdComboBox.Name = "equipoIdComboBox";
            this.equipoIdComboBox.Size = new System.Drawing.Size(139, 24);
            this.equipoIdComboBox.TabIndex = 13;
            // 
            // rutaIdLabel
            // 
            rutaIdLabel.AutoSize = true;
            rutaIdLabel.Location = new System.Drawing.Point(337, 154);
            rutaIdLabel.Name = "rutaIdLabel";
            rutaIdLabel.Size = new System.Drawing.Size(57, 17);
            rutaIdLabel.TabIndex = 13;
            rutaIdLabel.Text = "Ruta Id:";
            // 
            // rutaIdComboBox
            // 
            this.rutaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rutaIdComboBox.FormattingEnabled = true;
            this.rutaIdComboBox.Location = new System.Drawing.Point(400, 151);
            this.rutaIdComboBox.Name = "rutaIdComboBox";
            this.rutaIdComboBox.Size = new System.Drawing.Size(153, 24);
            this.rutaIdComboBox.TabIndex = 14;
            // 
            // bancaIdLabel
            // 
            bancaIdLabel.AutoSize = true;
            bancaIdLabel.Location = new System.Drawing.Point(12, 32);
            bancaIdLabel.Name = "bancaIdLabel";
            bancaIdLabel.Size = new System.Drawing.Size(67, 17);
            bancaIdLabel.TabIndex = 14;
            bancaIdLabel.Text = "Banca Id:";
            // 
            // bancaIdTextBox
            // 
            this.bancaIdTextBox.Location = new System.Drawing.Point(85, 32);
            this.bancaIdTextBox.Name = "bancaIdTextBox";
            this.bancaIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.bancaIdTextBox.TabIndex = 15;
            // 
            // Addbutton
            // 
            this.Addbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Addbutton.Image = ((System.Drawing.Image)(resources.GetObject("Addbutton.Image")));
            this.Addbutton.Location = new System.Drawing.Point(258, 191);
            this.Addbutton.Name = "Addbutton";
            this.Addbutton.Size = new System.Drawing.Size(74, 51);
            this.Addbutton.TabIndex = 27;
            this.Addbutton.Text = "Agregar";
            this.Addbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Addbutton.UseVisualStyleBackColor = true;
            this.Addbutton.Click += new System.EventHandler(this.button1_Click);
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(218, 14);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(75, 43);
            this.Buscarbutton.TabIndex = 28;
            this.Buscarbutton.Text = "Buscar";
            this.Buscarbutton.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.Buscarbutton.UseVisualStyleBackColor = true;
            this.Buscarbutton.Click += new System.EventHandler(this.Buscarbutton_Click);
            // 
            // BuscarerrorProvider
            // 
            this.BuscarerrorProvider.ContainerControl = this;
            // 
            // RegistroBancasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(588, 254);
            this.Controls.Add(this.Addbutton);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(bancaIdLabel);
            this.Controls.Add(this.bancaIdTextBox);
            this.Controls.Add(rutaIdLabel);
            this.Controls.Add(this.rutaIdComboBox);
            this.Controls.Add(equipoIdLabel);
            this.Controls.Add(this.equipoIdComboBox);
            this.Controls.Add(banqueraIdLabel);
            this.Controls.Add(this.banqueraIdComboBox);
            this.Controls.Add(this.EliminarButton);
            this.Controls.Add(this.UpdateButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(606, 301);
            this.Name = "RegistroBancasForm";
            this.Text = "Bancas";
            this.Load += new System.EventHandler(this.RegistroBancasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Button EliminarButton;
        private System.Windows.Forms.ComboBox banqueraIdComboBox;
        private System.Windows.Forms.ComboBox equipoIdComboBox;
        private System.Windows.Forms.ComboBox rutaIdComboBox;
        private System.Windows.Forms.TextBox bancaIdTextBox;
        private System.Windows.Forms.Button Addbutton;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
    }
}