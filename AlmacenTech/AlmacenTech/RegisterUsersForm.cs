using Entidades;
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
        public RegisterUsersForm()
        {
            InitializeComponent();
        }

        private void RegisterUsersForm_Load(object sender, EventArgs e)
        {

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDtextBox.Text))
            {
                BuscarerrorProvider.SetError(IDtextBox, "Favor digitar el ID del Usuario que desea buscar");
            }
            else
            {
                LLenar(UsuariosBLL.Buscar(Convert.ToInt32(IDtextBox.Text)));
                limpiar();
            }

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(IDtextBox.Text))
            {
                BuscarerrorProvider.SetError(IDtextBox, "Favor digitar el ID del Usuario que desea eliminar");
            }
            else
            {
                BuscarerrorProvider.Clear();
                UsuariosBLL.Eliminar(Convert.ToInt32(IDtextBox.Text));
                limpiar();
                MessageBox.Show("ELiminado con exito");
            }

        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

            //string aux = ConfPassTextBox.Text;
            if (string.IsNullOrEmpty(IDtextBox.Text))
            {
                BuscarerrorProvider.SetError(IDtextBox, "Favor buscar el ID del Usuario que desea actualizar");
            }
            else
            {
                BuscarerrorProvider.Clear();
                if (ConfPassTextBox.Text != PassTextBox.Text)
                {
                    PasworderrorProvider.SetError(ConfPassTextBox, "Las contraseñas no coinciden");
                }
                else
                {


                    if (PassTextBox.Text == "" || NameTextBox.Text == " " || ApellidoTextBox.Text == " " || UserNameTextBox.Text == " " || ConfPassTextBox.Text == "")
                    {
                        MessageBox.Show("Buscar el ID del usuario que desea Actualizar");
                    }
                    else
                    {
                        PasworderrorProvider.Clear();
                        UsuariosBLL.Actualizar(Convert.ToInt32(IDtextBox.Text), NameTextBox.Text, ApellidoTextBox.Text, UserNameTextBox.Text, PassTextBox.Text);
                        limpiar();
                    }


                }

            }

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            Usuarios us = new Usuarios();
            string aux = ConfPassTextBox.Text;
            us.Apellido = ApellidoTextBox.Text;
            us.Nombre = NameTextBox.Text;
            us.NombreUsuario = UserNameTextBox.Text;
            us.Contraseña = PassTextBox.Text;

            if(aux != PassTextBox.Text)
            {
                PasworderrorProvider.SetError(ConfPassTextBox, "Las contraseñas no coinciden");
            }
            else
            {
                PasworderrorProvider.Clear();
                if(PassTextBox.Text == "" || NameTextBox.Text == " " || ApellidoTextBox.Text == " " || UserNameTextBox.Text == " " ||ConfPassTextBox.Text == "" )
                {
                    MessageBox.Show("Favor llenar todos los campos");
                }
                else
                {
                    UsuariosBLL.AgregarUsuario(us);
                    limpiar();
                }
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
            IDtextBox.Text = "";
            PassTextBox.Text = "";
            ConfPassTextBox.Text = "";
            
        }


    }
}
