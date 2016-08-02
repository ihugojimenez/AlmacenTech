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
        Mensajeros mensajero = new Mensajeros();
        RegisterUsersForm RU = new RegisterUsersForm();
        public MensajerosForm()
        {
            InitializeComponent();
        }

        

        private void MensajerosForm_Load(object sender, EventArgs e)
        {
            
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del mensajero que desea buscar") && ValidarBuscar())
                LLenar(MensajerosBLL.Buscar(RU.StringToInt(mensajeroIdTextBox.Text)));
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            limpiar();
            limpiarErrores();
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            BuscarerrorProvider.Clear();
            LlenarClase(mensajero);
            if (ValidarTextbox() && ValidarExiste(cedulaMaskedTextBox.Text))
            {
                MensajerosBLL.Insertar(mensajero);
                limpiar();
                limpiarErrores();
                MessageBox.Show("Guardado con exito");
            }
        }

        private void UpdateButton_Click_1(object sender, EventArgs e)
        {
            if (validarId("Favor Buscar el mensajero que desea actualizar") && ValidarTextbox())
            {

                LlenarClase(mensajero);
                if(ValidarExiste(cedulaMaskedTextBox.Text))
                {
                    MensajerosBLL.Actualizar(RU.StringToInt(mensajeroIdTextBox.Text), mensajero);
                    limpiar();
                    limpiarErrores();
                    MessageBox.Show("Actualizado con exito");
                }
                
            }
        }

        private void Deletebutton_Click_1(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del mensajero que desea eliminar") && ValidarBuscar())
            {
                MensajerosBLL.Eliminar(RU.StringToInt(mensajeroIdTextBox.Text));
                limpiarErrores();
                limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }

        private void LLenar(Mensajeros m)
        {
            mensajeroIdTextBox.Text = m.MensajeroId.ToString();
            nombresTextBox.Text = m.Nombre;
            ApellidotextBox.Text = m.Apellido;
            direccionTextBox.Text = m.Direccion;
            cedulaMaskedTextBox.Text = m.Cedula;
            celularMaskedTextBox.Text = m.Celular;
            telefonoMaskedTextBox.Text = m.Telefono;
            if (m.Sexo == "M")
                MasculinoradioButton.Checked = true;
            if (m.Sexo == "F")
                FemeninoradioButton.Checked = true;

        }

        private void limpiar()
        {
            DateTimePicker dp = new DateTimePicker();
            mensajeroIdTextBox.Text = "";
            nombresTextBox.Text = "";
            ApellidotextBox.Text = "";
            direccionTextBox.Text = "";
            cedulaMaskedTextBox.Text = "";
            celularMaskedTextBox.Text = "";
            telefonoMaskedTextBox.Text = "";
            MasculinoradioButton.Checked = false;
            FemeninoradioButton.Checked = false;
            fechaDateTimePicker.Value = dp.Value;
            limpiarErrores();
        }

        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(mensajeroIdTextBox.Text))
            {
                BuscarerrorProvider.SetError(mensajeroIdTextBox, "Ingresar el ID");
                MessageBox.Show(message);
                return false;
            }
            else
            {

                return true;
            }
        }

        private void LlenarClase(Mensajeros m)
        {
            m.Nombre = nombresTextBox.Text;
            m.Cedula = cedulaMaskedTextBox.Text;
            m.Direccion = direccionTextBox.Text;
            m.Telefono= telefonoMaskedTextBox.Text;
            m.Celular= celularMaskedTextBox.Text;
            m.Apellido = ApellidotextBox.Text;
            if (MasculinoradioButton.Checked == true)
            {
                m.Sexo = "M";
            }
            else
            {
                if (FemeninoradioButton.Checked == true)
                    m.Sexo = "F";
                else
                    m.Sexo = "i";
            }


            m.FechaNacimiento = fechaDateTimePicker.Value;

        }

        private bool ValidarTextbox()
        {
            //int n = UsuariosBLL.Cantidad();
            if (string.IsNullOrEmpty(nombresTextBox.Text) && cedulaMaskedTextBox.MaskFull != true && celularMaskedTextBox.MaskFull != true && string.IsNullOrEmpty(ApellidotextBox.Text))
            {
                NombreerrorProvider.SetError(nombresTextBox, "Favor ingresar el nombre del mensajero");
                CedulaerrorProvider.SetError(cedulaMaskedTextBox, "Favor ingresar la cedula del mensajero");
                CelularerrorProvider.SetError(celularMaskedTextBox, "Favor ingresar el numero de celular del mensajero");
                ApellidoerrorProvider.SetError(ApellidotextBox, "Favor ingresar el apellido del mensajero");
                MessageBox.Show("Favor llenar todos los campos obligatorios");


            }
            if (string.IsNullOrEmpty(nombresTextBox.Text))
            {
                NombreerrorProvider.SetError(nombresTextBox, "Favor ingresar el nombre del mensajero");
                return false;
            }

            if (celularMaskedTextBox.MaskFull == false)
            {
                NombreerrorProvider.Clear();                
                CelularerrorProvider.SetError(celularMaskedTextBox, "Favor ingresar el numero de celular del mensajero");                
                return false;
            }

            if (cedulaMaskedTextBox.MaskFull == false)
            {
                NombreerrorProvider.Clear();
                CelularerrorProvider.Clear();
                CedulaerrorProvider.SetError(cedulaMaskedTextBox, "Favor ingresar la cedula del mensajero");
                return false;
            }

            if (string.IsNullOrEmpty(ApellidotextBox.Text))
            {
                NombreerrorProvider.Clear();
                CelularerrorProvider.Clear();
                CedulaerrorProvider.Clear();
                ApellidoerrorProvider.SetError(ApellidotextBox, "Favor ingresar el apellido del mensajero");
                return false;
            }

            if(MasculinoradioButton.Checked == false && FemeninoradioButton.Checked == false)
            {
                SexoerrorProvider.SetError(SexogroupBox, "Seleccionar sexo");
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

        private void limpiarErrores()
        {
            NombreerrorProvider.Clear();
            ApellidoerrorProvider.Clear();
            CelularerrorProvider.Clear();
            CedulaerrorProvider.Clear();
        }

        private bool ValidarBuscar()
        {
            if (MensajerosBLL.Buscar(RU.StringToInt(mensajeroIdTextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;

            }

            return true;


        }

        private bool ValidarExiste(string aux)
        {
            if (MensajerosBLL.GetListaCedula(aux).Count() > 0)
            {
                MessageBox.Show("Este mensajero ya esta registrado." + "\n" + "\n" + "Verifique que todos los datos estan ingresados correcatamente..");
                return false;
            }
            return true;
        }


    }
}
