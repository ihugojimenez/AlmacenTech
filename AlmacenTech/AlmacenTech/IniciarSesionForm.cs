﻿using System;
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
    public partial class IniciarSesionForm : Form
    {
        public IniciarSesionForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void Registerbutton_Click(object sender, EventArgs e)
        {
            RegisterUsersForm Rf = new RegisterUsersForm();
            Rf.Show();

            RegistroBancasForm rf = new RegistroBancasForm();
            rf.Show();

            RegistroBanquerasForm rb = new RegistroBanquerasForm();
            rb.Show();

            MensajerosForm mf = new MensajerosForm();
            mf.Show();

            PrestamosForm pf = new PrestamosForm();
            pf.Show();

            RutasForm ruf = new RutasForm();
            ruf.Show();
           /* EquiposForm ef = new EquiposForm();
            ef.Show();*/
        }
    }
}