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

namespace AlmacenTech
{
    public partial class RegisterUsersForm : Form
    {
        public RegisterUsersForm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {

        }

        private void RegisterButton_Click(object sender, EventArgs e)
        {
            Usuarios us = new Usuarios();
            string aux = ConfPassTextBox.Text;
            us.Apellido = ApellidoTextBox.Text;
            us.Nombre = NameTextBox.Text;
            us.NombreUsuario = UserNameTextBox.Text;
            us.Contraseña = PassTextBox.Text;

            
            /*us.Apellido = "Jimenez";
            us.Nombre = "Hugo";
            us.NombreUsuario = "Hugo5";
            us.Contraseña = "Pass22";*/
            /*Equipos eq = new Equipos();
            eq.MarcaEquipo = "Dell";
            eq.SerialNum = "12-56-89-74445";
            eq.TipoEquipo = "Cpu";*/

            using (var db = new AlmacenBancasDB())
            {
                db.usuario.Add(us);
                db.SaveChanges();
                db.Dispose();
            }
        }
    }
}
