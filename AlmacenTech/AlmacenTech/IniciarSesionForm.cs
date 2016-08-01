using BLL;
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
    public partial class IniciarSesionForm : Form
    {

        MainForm MF = new MainForm();
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

            
        }

        private void Loginbutton_Click(object sender, EventArgs e)
        {

            if (validarSesion() == DialogResult.OK)
            {
                this.Visible = false;
                
                MF.Show();
                
            }

        }

        public bool ValidarExiste()
        {
            if (UsuariosBLL.GetListaNombreUsuario(UserNametextBox.Text).Count() == 0)
            {
                MessageBox.Show("Usuario incorrecto o  no esta registrado, por favor verifique que este escrito correctamente, o registrese e intentelo de nuevo...");
                return false;
            }
           
            return true;
        }

        public bool ValidarPass()
        {
            if (UsuariosBLL.getPass(PasstextBox.Text).Count() == 0)
            {
                MessageBox.Show("Contraseña incorrecta");
                return false;
            }

            return true;
        }

        public bool ValidarTextbox()
        {

            if (string.IsNullOrEmpty(UserNametextBox.Text) && string.IsNullOrEmpty(PasstextBox.Text))
            {
                UsererrorProvider.SetError(UserNametextBox, "Favor ingresar el nombre de Usuario");
                PasserrorProvider.SetError(PasstextBox, "Favor ingresar la contraseña del usuario");
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(UserNametextBox.Text))
            {
                UsererrorProvider.SetError(UserNametextBox, "Favor ingresar el nombre de Usuario");
                return false;
            }

            if (string.IsNullOrEmpty(PasstextBox.Text))
            {
                UsererrorProvider.Clear();
                PasserrorProvider.SetError(PasstextBox, "Favor ingresar la contraseña del usuario");
                return false;
            }

            



            return true;




        }

        public DialogResult validarSesion()
        {
            if (ValidarTextbox() == true && ValidarExiste() == true && ValidarPass() == true)
            {

                return DialogResult.OK;
            }

            return DialogResult.Cancel;

        }

        public void UserNametextBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
