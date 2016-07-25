namespace AlmacenTech
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.archivoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarMensajeroToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarBanqueraToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarBancaToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registrarEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.registroDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // archivoToolStripMenuItem
            // 
            this.archivoToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.registrarMensajeroToolStripMenuItem,
            this.registrarBanqueraToolStripMenuItem,
            this.registrarBancaToolStripMenuItem,
            this.registrarEquiposToolStripMenuItem,
            this.registroDeUsuariosToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registrarMensajeroToolStripMenuItem
            // 
            this.registrarMensajeroToolStripMenuItem.Name = "registrarMensajeroToolStripMenuItem";
            this.registrarMensajeroToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registrarMensajeroToolStripMenuItem.Text = "Registrar Mensajeros";
            this.registrarMensajeroToolStripMenuItem.Click += new System.EventHandler(this.registrarMensajeroToolStripMenuItem_Click);
            // 
            // registrarBanqueraToolStripMenuItem
            // 
            this.registrarBanqueraToolStripMenuItem.Name = "registrarBanqueraToolStripMenuItem";
            this.registrarBanqueraToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registrarBanqueraToolStripMenuItem.Text = "Registrar Banqueras";
            this.registrarBanqueraToolStripMenuItem.Click += new System.EventHandler(this.registrarBanqueraToolStripMenuItem_Click);
            // 
            // registrarBancaToolStripMenuItem
            // 
            this.registrarBancaToolStripMenuItem.Name = "registrarBancaToolStripMenuItem";
            this.registrarBancaToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registrarBancaToolStripMenuItem.Text = "Registrar Bancas";
            this.registrarBancaToolStripMenuItem.Click += new System.EventHandler(this.registrarBancaToolStripMenuItem_Click);
            // 
            // registrarEquiposToolStripMenuItem
            // 
            this.registrarEquiposToolStripMenuItem.Name = "registrarEquiposToolStripMenuItem";
            this.registrarEquiposToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registrarEquiposToolStripMenuItem.Text = "Registrar Equipos";
            this.registrarEquiposToolStripMenuItem.Click += new System.EventHandler(this.registrarEquiposToolStripMenuItem_Click);
            // 
            // registroDeUsuariosToolStripMenuItem
            // 
            this.registroDeUsuariosToolStripMenuItem.Name = "registroDeUsuariosToolStripMenuItem";
            this.registroDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(183, 22);
            this.registroDeUsuariosToolStripMenuItem.Text = "Registro de Usuarios";
            this.registroDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registroDeUsuariosToolStripMenuItem_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(911, 544);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.MinimumSize = new System.Drawing.Size(927, 583);
            this.Name = "MainForm";
            this.Text = "MainForm";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem archivoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarMensajeroToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarBanqueraToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarBancaToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registrarEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem registroDeUsuariosToolStripMenuItem;
    }
}