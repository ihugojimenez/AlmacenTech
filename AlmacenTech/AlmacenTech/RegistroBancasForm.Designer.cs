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
            System.Windows.Forms.Label banqueraIdLabel;
            System.Windows.Forms.Label equipoIdLabel;
            System.Windows.Forms.Label rutaIdLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(RegistroBancasForm));
            this.banqueraIdTextBox = new System.Windows.Forms.TextBox();
            this.equipoIdTextBox = new System.Windows.Forms.TextBox();
            this.rutaIdTextBox = new System.Windows.Forms.TextBox();
            this.RegisterButton = new System.Windows.Forms.Button();
            banqueraIdLabel = new System.Windows.Forms.Label();
            equipoIdLabel = new System.Windows.Forms.Label();
            rutaIdLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // banqueraIdLabel
            // 
            banqueraIdLabel.AutoSize = true;
            banqueraIdLabel.Location = new System.Drawing.Point(12, 21);
            banqueraIdLabel.Name = "banqueraIdLabel";
            banqueraIdLabel.Size = new System.Drawing.Size(84, 16);
            banqueraIdLabel.TabIndex = 3;
            banqueraIdLabel.Text = "Banquera Id:";
            // 
            // banqueraIdTextBox
            // 
            this.banqueraIdTextBox.Location = new System.Drawing.Point(102, 21);
            this.banqueraIdTextBox.Name = "banqueraIdTextBox";
            this.banqueraIdTextBox.Size = new System.Drawing.Size(27, 22);
            this.banqueraIdTextBox.TabIndex = 4;
            // 
            // equipoIdLabel
            // 
            equipoIdLabel.AutoSize = true;
            equipoIdLabel.Location = new System.Drawing.Point(13, 68);
            equipoIdLabel.Name = "equipoIdLabel";
            equipoIdLabel.Size = new System.Drawing.Size(68, 16);
            equipoIdLabel.TabIndex = 5;
            equipoIdLabel.Text = "Equipo Id:";
            // 
            // equipoIdTextBox
            // 
            this.equipoIdTextBox.Location = new System.Drawing.Point(86, 65);
            this.equipoIdTextBox.Name = "equipoIdTextBox";
            this.equipoIdTextBox.Size = new System.Drawing.Size(56, 22);
            this.equipoIdTextBox.TabIndex = 6;
            // 
            // rutaIdLabel
            // 
            rutaIdLabel.AutoSize = true;
            rutaIdLabel.Location = new System.Drawing.Point(149, 21);
            rutaIdLabel.Name = "rutaIdLabel";
            rutaIdLabel.Size = new System.Drawing.Size(53, 16);
            rutaIdLabel.TabIndex = 7;
            rutaIdLabel.Text = "Ruta Id:";
            // 
            // rutaIdTextBox
            // 
            this.rutaIdTextBox.Location = new System.Drawing.Point(208, 18);
            this.rutaIdTextBox.Name = "rutaIdTextBox";
            this.rutaIdTextBox.Size = new System.Drawing.Size(24, 22);
            this.rutaIdTextBox.TabIndex = 8;
            // 
            // RegisterButton
            // 
            this.RegisterButton.Location = new System.Drawing.Point(41, 192);
            this.RegisterButton.Name = "RegisterButton";
            this.RegisterButton.Size = new System.Drawing.Size(75, 28);
            this.RegisterButton.TabIndex = 9;
            this.RegisterButton.Text = "Registrar";
            this.RegisterButton.UseVisualStyleBackColor = true;
            // 
            // RegistroBancasForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.ClientSize = new System.Drawing.Size(321, 250);
            this.Controls.Add(this.RegisterButton);
            this.Controls.Add(rutaIdLabel);
            this.Controls.Add(this.rutaIdTextBox);
            this.Controls.Add(equipoIdLabel);
            this.Controls.Add(this.equipoIdTextBox);
            this.Controls.Add(banqueraIdLabel);
            this.Controls.Add(this.banqueraIdTextBox);
            this.Name = "RegistroBancasForm";
            this.Text = "RegistroBancasForm";
            this.Load += new System.EventHandler(this.RegistroBancasForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox banqueraIdTextBox;
        private System.Windows.Forms.TextBox equipoIdTextBox;
        private System.Windows.Forms.TextBox rutaIdTextBox;
        private System.Windows.Forms.Button RegisterButton;
    }
}