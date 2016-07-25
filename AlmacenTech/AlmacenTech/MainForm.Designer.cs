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
            this.registroDeTiposDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeUsuariosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeMensajerosToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeEquiposToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.consultaDeBanquerasToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.archivoToolStripMenuItem,
            this.consultasToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(911, 28);
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
            this.registroDeUsuariosToolStripMenuItem,
            this.registroDeTiposDeEquiposToolStripMenuItem});
            this.archivoToolStripMenuItem.Name = "archivoToolStripMenuItem";
            this.archivoToolStripMenuItem.Size = new System.Drawing.Size(71, 24);
            this.archivoToolStripMenuItem.Text = "Archivo";
            // 
            // registrarMensajeroToolStripMenuItem
            // 
            this.registrarMensajeroToolStripMenuItem.Name = "registrarMensajeroToolStripMenuItem";
            this.registrarMensajeroToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.registrarMensajeroToolStripMenuItem.Text = "Registrar Mensajeros";
            this.registrarMensajeroToolStripMenuItem.Click += new System.EventHandler(this.registrarMensajeroToolStripMenuItem_Click);
            // 
            // registrarBanqueraToolStripMenuItem
            // 
            this.registrarBanqueraToolStripMenuItem.Name = "registrarBanqueraToolStripMenuItem";
            this.registrarBanqueraToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.registrarBanqueraToolStripMenuItem.Text = "Registrar Banqueras";
            this.registrarBanqueraToolStripMenuItem.Click += new System.EventHandler(this.registrarBanqueraToolStripMenuItem_Click);
            // 
            // registrarBancaToolStripMenuItem
            // 
            this.registrarBancaToolStripMenuItem.Name = "registrarBancaToolStripMenuItem";
            this.registrarBancaToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.registrarBancaToolStripMenuItem.Text = "Registrar Bancas";
            this.registrarBancaToolStripMenuItem.Click += new System.EventHandler(this.registrarBancaToolStripMenuItem_Click);
            // 
            // registrarEquiposToolStripMenuItem
            // 
            this.registrarEquiposToolStripMenuItem.Name = "registrarEquiposToolStripMenuItem";
            this.registrarEquiposToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.registrarEquiposToolStripMenuItem.Text = "Registrar Equipos";
            this.registrarEquiposToolStripMenuItem.Click += new System.EventHandler(this.registrarEquiposToolStripMenuItem_Click);
            // 
            // registroDeUsuariosToolStripMenuItem
            // 
            this.registroDeUsuariosToolStripMenuItem.Name = "registroDeUsuariosToolStripMenuItem";
            this.registroDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.registroDeUsuariosToolStripMenuItem.Text = "Registro de Usuarios";
            this.registroDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.registroDeUsuariosToolStripMenuItem_Click);
            // 
            // registroDeTiposDeEquiposToolStripMenuItem
            // 
            this.registroDeTiposDeEquiposToolStripMenuItem.Name = "registroDeTiposDeEquiposToolStripMenuItem";
            this.registroDeTiposDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(278, 26);
            this.registroDeTiposDeEquiposToolStripMenuItem.Text = "Registro de Tipos de Equipos";
            this.registroDeTiposDeEquiposToolStripMenuItem.Click += new System.EventHandler(this.registroDeTiposDeEquiposToolStripMenuItem_Click);
            // 
            // consultasToolStripMenuItem
            // 
            this.consultasToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.consultaDeUsuariosToolStripMenuItem,
            this.consultaDeMensajerosToolStripMenuItem,
            this.consultaDeEquiposToolStripMenuItem,
            this.consultaDeBanquerasToolStripMenuItem});
            this.consultasToolStripMenuItem.Name = "consultasToolStripMenuItem";
            this.consultasToolStripMenuItem.Size = new System.Drawing.Size(84, 24);
            this.consultasToolStripMenuItem.Text = "Consultas";
            // 
            // consultaDeUsuariosToolStripMenuItem
            // 
            this.consultaDeUsuariosToolStripMenuItem.Name = "consultaDeUsuariosToolStripMenuItem";
            this.consultaDeUsuariosToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.consultaDeUsuariosToolStripMenuItem.Text = "Consulta de Usuarios";
            this.consultaDeUsuariosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeUsuariosToolStripMenuItem_Click);
            // 
            // consultaDeMensajerosToolStripMenuItem
            // 
            this.consultaDeMensajerosToolStripMenuItem.Name = "consultaDeMensajerosToolStripMenuItem";
            this.consultaDeMensajerosToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.consultaDeMensajerosToolStripMenuItem.Text = "Consulta de Mensajeros";
            this.consultaDeMensajerosToolStripMenuItem.Click += new System.EventHandler(this.consultaDeMensajerosToolStripMenuItem_Click);
            // 
            // consultaDeEquiposToolStripMenuItem
            // 
            this.consultaDeEquiposToolStripMenuItem.Name = "consultaDeEquiposToolStripMenuItem";
            this.consultaDeEquiposToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.consultaDeEquiposToolStripMenuItem.Text = "Consulta de Equipos";
            this.consultaDeEquiposToolStripMenuItem.Click += new System.EventHandler(this.consultaDeEquiposToolStripMenuItem_Click);
            // 
            // consultaDeBanquerasToolStripMenuItem
            // 
            this.consultaDeBanquerasToolStripMenuItem.Name = "consultaDeBanquerasToolStripMenuItem";
            this.consultaDeBanquerasToolStripMenuItem.Size = new System.Drawing.Size(241, 26);
            this.consultaDeBanquerasToolStripMenuItem.Text = "Consulta de Banqueras";
            this.consultaDeBanquerasToolStripMenuItem.Click += new System.EventHandler(this.consultaDeBanquerasToolStripMenuItem_Click);
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
        private System.Windows.Forms.ToolStripMenuItem registroDeTiposDeEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultasToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeUsuariosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeMensajerosToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeEquiposToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem consultaDeBanquerasToolStripMenuItem;
    }
}