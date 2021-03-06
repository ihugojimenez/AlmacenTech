﻿using Entidades;
using DALL;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;

namespace AlmacenTech
{
    public partial class RegisterUsersForm : Form
    {
        Usuarios usuario = new Usuarios();
        public RegisterUsersForm()
        {
            InitializeComponent();
        }

        private void RegisterUsersForm_Load(object sender, EventArgs e)
        {

            Cargar();
            
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del usuario que desea buscar") && ValidarBuscar())
                LLenar(UsuariosBLL.Buscar(StringToInt(IDtextBox.Text)));


        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            BuscarerrorProvider.Clear();
            LlenarClase(usuario);
            if (ValidarTextbox() && ValidarExiste(UserNameTextBox.Text))
            {
                UsuariosBLL.Insertar(usuario);
                limpiar();
                MessageBox.Show("Guardado con exito");
            }



        }

        private void UpdateButton_Click_1(object sender, EventArgs e)
        {
            if(validarId("Favor Buscar el Usuario que desea actualizar") && ValidarTextbox())
            {
                
                LlenarClase(usuario);
                if(ValidarExiste(UserNameTextBox.Text))
                {
                    UsuariosBLL.Actualizar(StringToInt(IDtextBox.Text), usuario);
                    limpiar();
                    MessageBox.Show("Actualizado con exito");
                }
                    
            }

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {

            if (validarId("Favor digitar el id del usuario que desea eliminar") && ValidarBuscar())
            {
                UsuariosBLL.Eliminar(StringToInt(IDtextBox.Text));
                limpiarErrores();
                limpiar();
                MessageBox.Show("ELiminado con exito");
            }


        }

        private void LLenar(Usuarios usuario)
        {
            IDtextBox.Text = usuario.UsuarioId.ToString();
            UserNameTextBox.Text = usuario.NombreUsuario;
            NameTextBox.Text = usuario.Nombre;
            ApellidoTextBox.Text = usuario.Apellido;
            PassTextBox.Text = usuario.Contraseña;
        }

        private void limpiar()
        {
            NameTextBox.Text = "";
            UserNameTextBox.Text = "";
            ApellidoTextBox.Text = "";
            IDtextBox.Text = "";
            PassTextBox.Text = "";
            ConfPassTextBox.Text = "";
            PermisocomboBox.SelectedValue = 1;
            limpiarErrores();

        }
             
        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(IDtextBox.Text))
            {
                BuscarerrorProvider.SetError(IDtextBox, "Ingresar el ID");
                MessageBox.Show(message);
                return false;
            }
            else
            {

                return true;
            }
        }

        public int StringToInt(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }

        private void LlenarClase(Usuarios u)
        {
            u.Nombre = NameTextBox.Text;
            u.Apellido = ApellidoTextBox.Text;
            u.NombreUsuario = UserNameTextBox.Text;
            u.IdPermiso = (int)PermisocomboBox.SelectedValue;
            u.Contraseña = PassTextBox.Text;

        }

        private void limpiarErrores()
        {
            NombreUsuarioerrorProvider.Clear();
            PasserrorProvider.Clear();
            ConfPassTextBox.Clear();
            BuscarerrorProvider.Clear();
        }

        private bool ValidarTextbox()
        {
            
            if (string.IsNullOrEmpty(UserNameTextBox.Text) && string.IsNullOrEmpty(PassTextBox.Text) && string.IsNullOrEmpty(ConfPassTextBox.Text))
            {
                NombreUsuarioerrorProvider.SetError(UserNameTextBox, "Favor ingresar el nombre de Usuario");
                PasserrorProvider.SetError(PassTextBox, "Favor ingresar la contraseña del usuario");
                ConfPasserrorProvider.SetError(ConfPassTextBox, "Favor confirmar comtraseña");
                MessageBox.Show("Favor llenar todos los campos obligatorios");
                
            }
            if (string.IsNullOrEmpty(UserNameTextBox.Text))
            {
                NombreUsuarioerrorProvider.SetError(UserNameTextBox, "Favor ingresar el nombre de Usuario");
                return false;
            }
                
            if (string.IsNullOrEmpty(PassTextBox.Text))
            {
                NombreUsuarioerrorProvider.Clear();
                PasserrorProvider.SetError(PassTextBox, "Favor ingresar la contraseña del usuario");
                return false;
            }
                
            if (string.IsNullOrEmpty(ConfPassTextBox.Text))
            {
                NombreUsuarioerrorProvider.Clear();
                PasserrorProvider.Clear();
                ConfPasserrorProvider.SetError(ConfPassTextBox, "Favor confirmar comtraseña");
                return false;
            }
                
            if (ConfPassTextBox.Text != PassTextBox.Text)
            {
                NombreUsuarioerrorProvider.Clear();
                PasserrorProvider.Clear();
                ConfPassTextBox.Clear();
                ConfPasserrorProvider.SetError(ConfPassTextBox, "La contraseña no coincide");
                return false;
            }

            

            return true;
                
                
            
           
        }
        

        private void Cargar()
        {
            PermisocomboBox.DataSource = PermisoUsuariosBLL.GetLista();
            PermisocomboBox.ValueMember = "IdPermiso";
            PermisocomboBox.DisplayMember = "Detalle";
        }

        private bool ValidarBuscar()
        {
            if (UsuariosBLL.Buscar(StringToInt(IDtextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;

            }

            return true;


        }

        private bool ValidarExiste(string aux)
        {
            if(UsuariosBLL.GetListaNombreUsuario(aux).Count() > 0) 
            {
                MessageBox.Show("Este nombre de Usuario ya existe, favor intentar con otro nombre de usario...");
                return false;
            }
            return true;
        }
    }
}
