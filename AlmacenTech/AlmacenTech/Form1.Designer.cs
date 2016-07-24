namespace AlmacenTech
{
    partial class Form1
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
            System.Windows.Forms.Label equipoIdLabel;
            System.Windows.Forms.Label marcaEquipoLabel;
            System.Windows.Forms.Label tipoEquipoLabel;
            System.Windows.Forms.Label serialNumLabel;
            this.equipoIdTextBox = new System.Windows.Forms.TextBox();
            this.marcaEquipoTextBox = new System.Windows.Forms.TextBox();
            this.tipoEquipoTextBox = new System.Windows.Forms.TextBox();
            this.serialNumTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            equipoIdLabel = new System.Windows.Forms.Label();
            marcaEquipoLabel = new System.Windows.Forms.Label();
            tipoEquipoLabel = new System.Windows.Forms.Label();
            serialNumLabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // equipoIdLabel
            // 
            equipoIdLabel.AutoSize = true;
            equipoIdLabel.Location = new System.Drawing.Point(6, 25);
            equipoIdLabel.Name = "equipoIdLabel";
            equipoIdLabel.Size = new System.Drawing.Size(71, 17);
            equipoIdLabel.TabIndex = 1;
            equipoIdLabel.Text = "Equipo Id:";
            // 
            // equipoIdTextBox
            // 
            this.equipoIdTextBox.Location = new System.Drawing.Point(112, 22);
            this.equipoIdTextBox.Name = "equipoIdTextBox";
            this.equipoIdTextBox.Size = new System.Drawing.Size(100, 22);
            this.equipoIdTextBox.TabIndex = 2;
            // 
            // marcaEquipoLabel
            // 
            marcaEquipoLabel.AutoSize = true;
            marcaEquipoLabel.Location = new System.Drawing.Point(7, 54);
            marcaEquipoLabel.Name = "marcaEquipoLabel";
            marcaEquipoLabel.Size = new System.Drawing.Size(99, 17);
            marcaEquipoLabel.TabIndex = 3;
            marcaEquipoLabel.Text = "Marca Equipo:";
            // 
            // marcaEquipoTextBox
            // 
            this.marcaEquipoTextBox.Location = new System.Drawing.Point(112, 54);
            this.marcaEquipoTextBox.Name = "marcaEquipoTextBox";
            this.marcaEquipoTextBox.Size = new System.Drawing.Size(100, 22);
            this.marcaEquipoTextBox.TabIndex = 4;
            // 
            // tipoEquipoLabel
            // 
            tipoEquipoLabel.AutoSize = true;
            tipoEquipoLabel.Location = new System.Drawing.Point(255, 59);
            tipoEquipoLabel.Name = "tipoEquipoLabel";
            tipoEquipoLabel.Size = new System.Drawing.Size(88, 17);
            tipoEquipoLabel.TabIndex = 5;
            tipoEquipoLabel.Text = "Tipo Equipo:";
            // 
            // tipoEquipoTextBox
            // 
            this.tipoEquipoTextBox.Location = new System.Drawing.Point(349, 59);
            this.tipoEquipoTextBox.Name = "tipoEquipoTextBox";
            this.tipoEquipoTextBox.Size = new System.Drawing.Size(100, 22);
            this.tipoEquipoTextBox.TabIndex = 6;
            // 
            // serialNumLabel
            // 
            serialNumLabel.AutoSize = true;
            serialNumLabel.Location = new System.Drawing.Point(255, 27);
            serialNumLabel.Name = "serialNumLabel";
            serialNumLabel.Size = new System.Drawing.Size(81, 17);
            serialNumLabel.TabIndex = 7;
            serialNumLabel.Text = "Serial Num:";
            // 
            // serialNumTextBox
            // 
            this.serialNumTextBox.Location = new System.Drawing.Point(349, 25);
            this.serialNumTextBox.Name = "serialNumTextBox";
            this.serialNumTextBox.Size = new System.Drawing.Size(100, 22);
            this.serialNumTextBox.TabIndex = 8;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(136, 165);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 9;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(647, 253);
            this.Controls.Add(this.button1);
            this.Controls.Add(serialNumLabel);
            this.Controls.Add(this.serialNumTextBox);
            this.Controls.Add(tipoEquipoLabel);
            this.Controls.Add(this.tipoEquipoTextBox);
            this.Controls.Add(marcaEquipoLabel);
            this.Controls.Add(this.marcaEquipoTextBox);
            this.Controls.Add(equipoIdLabel);
            this.Controls.Add(this.equipoIdTextBox);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox equipoIdTextBox;
        private System.Windows.Forms.TextBox marcaEquipoTextBox;
        private System.Windows.Forms.TextBox tipoEquipoTextBox;
        private System.Windows.Forms.TextBox serialNumTextBox;
        private System.Windows.Forms.Button button1;
    }
}