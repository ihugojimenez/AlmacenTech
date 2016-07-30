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
        Banqueras banquera = new Banqueras();
        RegisterUsersForm RU = new RegisterUsersForm();
        public RegistroBanquerasForm()
        {
            InitializeComponent();
        }

    

        private void RegistroBanquerasForm_Load(object sender, EventArgs e)
        {
           

        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del usuario que desea buscar"))
                LLenar(BanquerasBLL.Buscar(RU.StringToInt(banqueraIdTextBox.Text)));
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            BuscarerrorProvider.Clear();
            LlenarClase(banquera);
            if (ValidarTextbox())
            {
                BanquerasBLL.Insertar(banquera);
                limpiar();
                limpiarErrores();
                MessageBox.Show("Guardado con exito");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor Buscar la banquera que desea actualizar") && ValidarTextbox())
            {

                LlenarClase(banquera);
                BanquerasBLL.Actualizar(RU.StringToInt(banqueraIdTextBox.Text), banquera);
                limpiar();
                limpiarErrores();
                MessageBox.Show("Actualizado con exito");
            }
        }

        private void Deletebutton_Click_1(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id de la banquera que desea eliminar"))
            {
                BanquerasBLL.Eliminar(RU.StringToInt(banqueraIdTextBox.Text));
                limpiarErrores();
                limpiar();
                MessageBox.Show("ELiminado con exito");
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
            ApellidotextBox.Text = banquera.Apellidos;

        }    

        private void limpiar()
        {
            DateTimePicker dp = new DateTimePicker();
            
            banqueraIdTextBox.Text ="";
            nombresTextBox.Text = "";
            cedulaMaskedTextBox.Text ="";
            celularMaskedTextBox.Text = "";
            telefonoMaskedTextBox.Text = "";
            direccionTextBox.Text = "";
            ApellidotextBox.Text = "";
            MasculinoradioButton.Checked = false;
            FemeninoradioButton.Checked = false;
            fechaDateTimePicker.Value = dp.Value;
        }

        private void fechaDateTimePicker_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LlenarClase(Banqueras b)
        {
            b.Nombres = nombresTextBox.Text;
            b.Cedula = cedulaMaskedTextBox.Text;
            b.Direccion = direccionTextBox.Text;
            b.Telefono = telefonoMaskedTextBox.Text;
            b.Celular = celularMaskedTextBox.Text;
            b.Apellidos = ApellidotextBox.Text;
            if (MasculinoradioButton.Checked == true)
            {
                b.Sexo = 'M';
            }
            else
            {
                if (FemeninoradioButton.Checked == true)
                    b.Sexo = 'F';
                else
                    b.Sexo = 'I';
            }
                
            
            b.Fecha = fechaDateTimePicker.Value;

        }
        //Tengo que arreglar la asignaciond de valor al sexo....
        private bool ValidarTextbox()
        {
            //int n = UsuariosBLL.Cantidad();
            if (string.IsNullOrEmpty(nombresTextBox.Text) && cedulaMaskedTextBox.MaskFull != true && celularMaskedTextBox.MaskFull != true && string.IsNullOrEmpty(ApellidotextBox.Text))
            {
                NombreerrorProvider.SetError(nombresTextBox, "Favor ingresar el nombre de la banquera");
                CedulaerrorProvider.SetError(cedulaMaskedTextBox, "Favor ingresar la cedula de la banquera");
                CelularerrorProvider.SetError(celularMaskedTextBox, "Favor ingresar el numero de celular de la banquera");               
                ApellidoerrorProvider.SetError(ApellidotextBox, "Favor ingresar el apellido de la banquera");
                MessageBox.Show("Favor llenar todos los campos obligatorios");
                

            }
            if (string.IsNullOrEmpty(nombresTextBox.Text))
            {
                NombreerrorProvider.SetError(nombresTextBox, "Favor ingresar el nombre de la banquera");
                return false;
            }

            if (celularMaskedTextBox.MaskFull == false)
            {
                NombreerrorProvider.Clear();
                CelularerrorProvider.SetError(celularMaskedTextBox, "Favor ingresar el numero de celular de la banquera");
                return false;
            }

            if (cedulaMaskedTextBox.MaskFull == false)
            {
                NombreerrorProvider.Clear();
                CelularerrorProvider.Clear();
                CedulaerrorProvider.SetError(cedulaMaskedTextBox, "Favor ingresar la cedula de la banquera");
                return false;
            }

            if (string.IsNullOrEmpty(ApellidotextBox.Text))
            {
                NombreerrorProvider.Clear();
                CelularerrorProvider.Clear();
                CedulaerrorProvider.Clear();
                ApellidoerrorProvider.SetError(ApellidotextBox, "Favor ingresar el apellido de la banquera");
                return false;
            }


            /*for (int aux = 4; aux <= n; aux++)
            {
                if (UserNameTextBox.Text == UsuariosBLL.Buscar(aux).NombreUsuario)
                {
                    MessageBox.Show("EL Nombre de usuario que intenta ingresar ya existe");
                    return false;
                }
            }*/

            return true;




        }

        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(banqueraIdTextBox.Text))
            {
                BuscarerrorProvider.SetError(banqueraIdTextBox, "Ingresar el ID");
                MessageBox.Show(message);
                return false;
            }
            else
            {

                return true;
            }
        }

        private void limpiarErrores()
        {
            NombreerrorProvider.Clear();
            ApellidoerrorProvider.Clear();
            CelularerrorProvider.Clear();
            CedulaerrorProvider.Clear();
        }

        private void banqueraIdTextBox_TextChanged(object sender, EventArgs e)
        {
            
            
        }
    }
}
