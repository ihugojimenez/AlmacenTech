using BLL;
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

namespace AlmacenTech
{
    public partial class MensajerosForm : Form
    {
        public MensajerosForm()
        {
            InitializeComponent();
        }

        

        private void MensajerosForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mensajeroIdTextBox.Text))
            {
                BuscarerrorProvider.SetError(mensajeroIdTextBox, "Favor digitar el ID del Mensajero que desea buscar");
            }
            else
            {
                LLenar(MensajerosBLL.Buscar(Convert.ToInt32(mensajeroIdTextBox.Text)));

            }
        }

        private void LLenar(Mensajeros mensajero)
        {
            mensajeroIdTextBox.Text = mensajero.MensajeroId.ToString();
            nombreTextBox.Text = mensajero.Nombre;
            direccionTextBox.Text = mensajero.Direccion;
            cedulaMaskedTextBox.Text = mensajero.Cedula;
            celularMaskedTextBox.Text = mensajero.Celular;
            telefonoMaskedTextBox.Text = mensajero.Telefono;
            
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mensajeroIdTextBox.Text))
            {
                BuscarerrorProvider.SetError(mensajeroIdTextBox, "Favor digitar el ID del mensajero que desea eliminar");
            }
            else
            {
                BuscarerrorProvider.Clear();
                MensajerosBLL.EliminarMensajero(Convert.ToInt32(mensajeroIdTextBox.Text));
                limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }

        private void limpiar()
        {
            mensajeroIdTextBox.Text = "";
            nombreTextBox.Text = "";
            direccionTextBox.Text = "";
            cedulaMaskedTextBox.Text = "";
            celularMaskedTextBox.Text = "";
            telefonoMaskedTextBox.Text = "";
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(mensajeroIdTextBox.Text))
            {
                BuscarerrorProvider.SetError(mensajeroIdTextBox, "Favor buscar el ID del mensajero que desea actualizar");
            }
            else
            {
                BuscarerrorProvider.Clear();
                if (nombreTextBox.Text == "" || direccionTextBox.Text == " " || cedulaMaskedTextBox.Text == " " || celularMaskedTextBox.Text == " " || telefonoMaskedTextBox.Text == " ")
                {
                    MessageBox.Show("Buscar el ID del mensajero que desea Actualizar");
                }
                else
                {
                    bool sex = true;
                    MensajerosBLL.ActualizarMensajero(Convert.ToInt32(mensajeroIdTextBox.Text), nombreTextBox.Text, cedulaMaskedTextBox.Text, celularMaskedTextBox.Text, direccionTextBox.Text, fechaNacimientoDateTimePicker.Value, sex, telefonoMaskedTextBox.Text);
                    limpiar();
                }

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Mensajeros m = new Mensajeros();
            
            m.Nombre = nombreTextBox.Text;
            m.Direccion = direccionTextBox.Text;
            m.Cedula = cedulaMaskedTextBox.Text;
            m.Celular = celularMaskedTextBox.Text;
            m.Telefono = telefonoMaskedTextBox.Text;
            m.Sexo = true;
            m.FechaNacimiento = fechaNacimientoDateTimePicker.Value;

            if (nombreTextBox.Text == "" || direccionTextBox.Text == " " || cedulaMaskedTextBox.Text == " " || celularMaskedTextBox.Text == " " || telefonoMaskedTextBox.Text == " ")
            {
                MessageBox.Show("Favor llenar todos los campos");
            }
            else
            {
                MensajerosBLL.AgregarMensajero(m);
                limpiar();
            }
        }
    }
}
