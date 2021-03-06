﻿using AlmacenTech.Consultas;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmacenTech
{
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
    
            InitializeComponent();
            this.FormClosing += MainForm_FormClosing;
            
        }

        private void registrarMensajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MensajerosForm MF = new MensajerosForm();
            MF.MdiParent = this;
            MF.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            this.Location = Screen.PrimaryScreen.WorkingArea.Location;
            this.Size = Screen.PrimaryScreen.WorkingArea.Size;
        }

        private void registrarBanqueraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroBanquerasForm Rb = new RegistroBanquerasForm();
            Rb.MdiParent = this;
            Rb.Show();
        }

        private void registrarBancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            /*RegistroBancasForm RB = new RegistroBancasForm();
            RB.MdiParent = this;
            RB.Show();*/
        }

        private void registrarEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEquiposForm EF = new rEquiposForm();
            EF.MdiParent = this;
            EF.Show();
        }

        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterUsersForm Ru = new RegisterUsersForm();
            Ru.MdiParent = this;
            Ru.Show();
        }

        private void registroDeTiposDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rTiposEquipos rte = new rTiposEquipos();
            rte.MdiParent = this;
            rte.Show();
        }

        private void consultaDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaUsuarios cu = new ConsultaUsuarios();
            cu.MdiParent = this;
            cu.Show();
        }

        private void consultaDeMensajerosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaMensajerosForm cm = new ConsultaMensajerosForm();
            cm.MdiParent = this;
            cm.Show();
        }

        private void consultaDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ConsultaEquiposForm CE = new ConsultaEquiposForm();
            ReportingViewerEquipos rpt = new ReportingViewerEquipos();
            rpt.MdiParent = this; 
            CE.MdiParent = this;
            CE.Show();
        }

        private void consultaDeBanquerasToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Consultas.ConsultaBanquerasForm cb = new Consultas.ConsultaBanquerasForm();
            cb.MdiParent = this;
            cb.Show();
        }

        private void archivoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void registroDePaquetesDeEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            rEquiposAsignadossForm PF = new rEquiposAsignadossForm();
            PF.MdiParent = this;
            PF.Show();
        }

        private void MainForm_FormClosing(Object sender, FormClosingEventArgs e)
        {
            //In case windows is trying to shut down, don't hold the process up
            if (e.CloseReason == CloseReason.UserClosing)
                Application.Exit();

            
        }

    }
}
