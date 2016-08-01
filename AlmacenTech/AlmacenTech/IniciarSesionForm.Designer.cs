namespace AlmacenTech
{
    partial class IniciarSesionForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(IniciarSesionForm));
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.UserNametextBox = new System.Windows.Forms.TextBox();
            this.PasstextBox = new System.Windows.Forms.TextBox();
            this.Loginbutton = new System.Windows.Forms.Button();
            this.Registerbutton = new System.Windows.Forms.Button();
            this.UsererrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.PasserrorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.UsererrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasserrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Times New Roman", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(161, 9);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 21);
            this.label1.TabIndex = 0;
            this.label1.Text = "AlmacenTech";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(167, 50);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 17);
            this.label2.TabIndex = 1;
            this.label2.Text = "Usuario";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(164, 85);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 17);
            this.label3.TabIndex = 2;
            this.label3.Text = "Contraseña";
            // 
            // UserNametextBox
            // 
            this.UserNametextBox.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.UserNametextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.UserNametextBox.Location = new System.Drawing.Point(249, 48);
            this.UserNametextBox.Margin = new System.Windows.Forms.Padding(2);
            this.UserNametextBox.Name = "UserNametextBox";
            this.UserNametextBox.Size = new System.Drawing.Size(147, 22);
            this.UserNametextBox.TabIndex = 3;
            this.UserNametextBox.TextChanged += new System.EventHandler(this.UserNametextBox_TextChanged);
            // 
            // PasstextBox
            // 
            this.PasstextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PasstextBox.Location = new System.Drawing.Point(249, 84);
            this.PasstextBox.Margin = new System.Windows.Forms.Padding(2);
            this.PasstextBox.Name = "PasstextBox";
            this.PasstextBox.PasswordChar = '*';
            this.PasstextBox.Size = new System.Drawing.Size(147, 22);
            this.PasstextBox.TabIndex = 4;
            // 
            // Loginbutton
            // 
            this.Loginbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Loginbutton.Location = new System.Drawing.Point(202, 123);
            this.Loginbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Loginbutton.Name = "Loginbutton";
            this.Loginbutton.Size = new System.Drawing.Size(71, 25);
            this.Loginbutton.TabIndex = 5;
            this.Loginbutton.Text = "Ingresar";
            this.Loginbutton.UseVisualStyleBackColor = true;
            this.Loginbutton.Click += new System.EventHandler(this.Loginbutton_Click);
            // 
            // Registerbutton
            // 
            this.Registerbutton.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Registerbutton.Location = new System.Drawing.Point(291, 123);
            this.Registerbutton.Margin = new System.Windows.Forms.Padding(2);
            this.Registerbutton.Name = "Registerbutton";
            this.Registerbutton.Size = new System.Drawing.Size(74, 25);
            this.Registerbutton.TabIndex = 6;
            this.Registerbutton.Text = "Registrarse";
            this.Registerbutton.UseVisualStyleBackColor = true;
            this.Registerbutton.Click += new System.EventHandler(this.Registerbutton_Click);
            // 
            // UsererrorProvider
            // 
            this.UsererrorProvider.ContainerControl = this;
            // 
            // PasserrorProvider
            // 
            this.PasserrorProvider.ContainerControl = this;
            // 
            // IniciarSesionForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Menu;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(414, 158);
            this.Controls.Add(this.Registerbutton);
            this.Controls.Add(this.Loginbutton);
            this.Controls.Add(this.PasstextBox);
            this.Controls.Add(this.UserNametextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.DoubleBuffered = true;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(430, 197);
            this.MinimumSize = new System.Drawing.Size(430, 197);
            this.Name = "IniciarSesionForm";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.UsererrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasserrorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox UserNametextBox;
        private System.Windows.Forms.TextBox PasstextBox;
        private System.Windows.Forms.Button Loginbutton;
        private System.Windows.Forms.Button Registerbutton;
        private System.Windows.Forms.ErrorProvider UsererrorProvider;
        private System.Windows.Forms.ErrorProvider PasserrorProvider;
    }
}

