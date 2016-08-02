﻿using BLL;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AlmacenTech.Consultas
{
    public partial class ConsultaMensajerosForm : Form
    {
        Mensajeros mensajero = new Mensajeros();
        RegisterUsersForm RU = new RegisterUsersForm();
        public ConsultaMensajerosForm()
        {
            InitializeComponent();
        }

        private void ConsultaMensajerosForm_Load(object sender, EventArgs e)
        {
            Cargar();
        }

      

        private void Cargar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "Apellido");
            FiltrocomboBox.DataSource = FiltrocomboBox.Items;
            FiltrocomboBox.DisplayMember = "ID";
            MensajerosdataGridView.DataSource = MensajerosBLL.GetLista();
        }

        private void BuscarSeleccion()
        {
            if (FiltrocomboBox.SelectedIndex == 0)
                MensajerosdataGridView.DataSource = MensajerosBLL.GetListaId(RU.StringToInt(FiltrotextBox.Text));
            if (FiltrocomboBox.SelectedIndex == 1)
                MensajerosdataGridView.DataSource = MensajerosBLL.GetListaApellido(FiltrotextBox.Text);

        }


        private bool validar()
        {

            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }

            if (MensajerosBLL.GetListaId(RU.StringToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }

            if (MensajerosBLL.GetListaApellido(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            BuscarerrorProvider.Clear();

            return true;
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            if (validar())
                BuscarSeleccion();
        }
    }
}
