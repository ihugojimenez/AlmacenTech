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
    public partial class RegistroBanquerasForm : Form
    {
        public RegistroBanquerasForm()
        {
            InitializeComponent();
        }

    

        private void RegistroBanquerasForm_Load(object sender, EventArgs e)
        {
           

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(banqueraIdTextBox.Text))
            {
                BuscarerrorProvider.SetError(banqueraIdTextBox, "Favor digitar el ID de la banquera que desea buscar");
            }
            else
            {
                LLenar(BanquerasBLL.Buscar(Convert.ToInt32(banqueraIdTextBox.Text)));

            }
        }

        private void LLenar(Banqueras banquera)
        {
            banqueraIdTextBox.Text = banquera.BanqueraId.ToString();
            nombresTextBox.Text = banquera.Nombres;
            cedulaMaskedTextBox.Text = banquera.Cedula;
            celularMaskedTextBox.Text = banquera.Celular;
            telefonoMaskedTextBox.Text = banquera.Telefono;
            direccionTextBox.Text = banquera.Direccion;

        }

        private void limpiar()
        {
            banqueraIdTextBox.Text ="";
            nombresTextBox.Text = "";
            cedulaMaskedTextBox.Text ="";
            celularMaskedTextBox.Text = "";
            telefonoMaskedTextBox.Text = "";
            direccionTextBox.Text = "";
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(banqueraIdTextBox.Text))
            {
                BuscarerrorProvider.SetError(banqueraIdTextBox, "Favor digitar el ID de la banquera que desea eliminar");
            }
            else
            {
                BuscarerrorProvider.Clear();
                BanquerasBLL.EliminarBanqueras(Convert.ToInt32(banqueraIdTextBox.Text));
                limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Banqueras b = new Banqueras();

            b.Nombres = nombresTextBox.Text;
            b.Direccion = direccionTextBox.Text;
            b.Cedula = cedulaMaskedTextBox.Text;
            b.Celular = celularMaskedTextBox.Text;
            b.Telefono = telefonoMaskedTextBox.Text;
            b.Sexo = true;
            b.Fecha = fechaDateTimePicker.Value;

            if (nombresTextBox.Text == "" || direccionTextBox.Text == " " || cedulaMaskedTextBox.Text == " " || celularMaskedTextBox.Text == " " || telefonoMaskedTextBox.Text == " ")
            {
                MessageBox.Show("Favor llenar todos los campos");
            }
            else
            {
                BanquerasBLL.AgregarBanqueras(b);
                limpiar();
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(banqueraIdTextBox.Text))
            {
                BuscarerrorProvider.SetError(banqueraIdTextBox, "Favor buscar el ID de la banquera que desea modificar");
            }
            else
            {
                BuscarerrorProvider.Clear();
                if (nombresTextBox.Text == "" || direccionTextBox.Text == " " || cedulaMaskedTextBox.Text == " " || celularMaskedTextBox.Text == " " || telefonoMaskedTextBox.Text == " ")
                {
                    MessageBox.Show("Favor llenar todos los campos");
                }
                else
                {
                    bool sex = true;
                    BanquerasBLL.ActualizarBanqueras(Convert.ToInt32(banqueraIdTextBox.Text), nombresTextBox.Text, direccionTextBox.Text, celularMaskedTextBox.Text, telefonoMaskedTextBox.Text, fechaDateTimePicker.Value, sex);
                    limpiar();
                }

            }
        }
    }
}
