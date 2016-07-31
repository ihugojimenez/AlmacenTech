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
            System.Windows.Forms.Label banqueraIdLabel;
            System.Windows.Forms.Label rutaIdLabel;
            System.Windows.Forms.Label bancaIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroBancasForm));
            this.banqueraIdComboBox = new System.Windows.Forms.ComboBox();
            this.rutaIdComboBox = new System.Windows.Forms.ComboBox();
            this.bancaIdTextBox = new System.Windows.Forms.TextBox();
            this.Buscarbutton = new System.Windows.Forms.Button();
            this.BuscarerrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            banqueraIdLabel = new System.Windows.Forms.Label();
            rutaIdLabel = new System.Windows.Forms.Label();
            bancaIdLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // banqueraIdLabel
            // 
            banqueraIdLabel.AutoSize = true;
            banqueraIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            banqueraIdLabel.Location = new System.Drawing.Point(310, 26);
            banqueraIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            banqueraIdLabel.Name = "banqueraIdLabel";
            banqueraIdLabel.Size = new System.Drawing.Size(84, 16);
            banqueraIdLabel.TabIndex = 11;
            banqueraIdLabel.Text = "Banquera Id:";
            // 
            // rutaIdLabel
            // 
            rutaIdLabel.AutoSize = true;
            rutaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            rutaIdLabel.Location = new System.Drawing.Point(294, 126);
            rutaIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            rutaIdLabel.Name = "rutaIdLabel";
            rutaIdLabel.Size = new System.Drawing.Size(53, 16);
            rutaIdLabel.TabIndex = 13;
            rutaIdLabel.Text = "Ruta Id:";
            // 
            // bancaIdLabel
            // 
            bancaIdLabel.AutoSize = true;
            bancaIdLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            bancaIdLabel.Location = new System.Drawing.Point(9, 26);
            bancaIdLabel.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            bancaIdLabel.Name = "bancaIdLabel";
            bancaIdLabel.Size = new System.Drawing.Size(64, 16);
            bancaIdLabel.TabIndex = 14;
            bancaIdLabel.Text = "Banca Id:";
            // 
            // banqueraIdComboBox
            // 
            this.banqueraIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.banqueraIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.banqueraIdComboBox.FormattingEnabled = true;
            this.banqueraIdComboBox.Location = new System.Drawing.Point(398, 23);
            this.banqueraIdComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.banqueraIdComboBox.Name = "banqueraIdComboBox";
            this.banqueraIdComboBox.Size = new System.Drawing.Size(132, 24);
            this.banqueraIdComboBox.TabIndex = 12;
            // 
            // rutaIdComboBox
            // 
            this.rutaIdComboBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.rutaIdComboBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rutaIdComboBox.FormattingEnabled = true;
            this.rutaIdComboBox.Location = new System.Drawing.Point(351, 126);
            this.rutaIdComboBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.rutaIdComboBox.Name = "rutaIdComboBox";
            this.rutaIdComboBox.Size = new System.Drawing.Size(132, 24);
            this.rutaIdComboBox.TabIndex = 14;
            // 
            // bancaIdTextBox
            // 
            this.bancaIdTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bancaIdTextBox.Location = new System.Drawing.Point(81, 26);
            this.bancaIdTextBox.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.bancaIdTextBox.Name = "bancaIdTextBox";
            this.bancaIdTextBox.Size = new System.Drawing.Size(132, 22);
            this.bancaIdTextBox.TabIndex = 15;
            // 
            // Buscarbutton
            // 
            this.Buscarbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Buscarbutton.Image = ((System.Drawing.Image)(resources.GetObject("Buscarbutton.Image")));
            this.Buscarbutton.ImageAlign = System.Drawing.ContentAlignment.TopCenter;
            this.Buscarbutton.Location = new System.Drawing.Point(250, 12);
            this.Buscarbutton.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Buscarbutton.Name = "Buscarbutton";
            this.Buscarbutton.Size = new System.Drawing.Size(56, 37);
            this.Buscarbutton.TabIndex = 28;
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
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(549, 271);
            this.Controls.Add(this.Buscarbutton);
            this.Controls.Add(bancaIdLabel);
            this.Controls.Add(this.bancaIdTextBox);
            this.Controls.Add(rutaIdLabel);
            this.Controls.Add(this.rutaIdComboBox);
            this.Controls.Add(banqueraIdLabel);
            this.Controls.Add(this.banqueraIdComboBox);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(458, 252);
            this.Name = "RegistroBancasForm";
            this.Text = "Bancas";
            this.Load += new System.EventHandler(this.RegistroBancasForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.BuscarerrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox banqueraIdComboBox;
        private System.Windows.Forms.ComboBox rutaIdComboBox;
        private System.Windows.Forms.TextBox bancaIdTextBox;
        private System.Windows.Forms.Button Buscarbutton;
        private System.Windows.Forms.ErrorProvider BuscarerrorProvider;
    }
}