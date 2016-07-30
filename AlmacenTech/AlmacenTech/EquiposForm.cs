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
    public partial class EquiposForm : Form
    {
        Equipos equipo = new Equipos();
        RegisterUsersForm RU = new RegisterUsersForm();
        public EquiposForm()
        {
            InitializeComponent();
        }

        

        private void EquiposForm_Load(object sender, EventArgs e)
        {
            Cargar();

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id del usuario que desea buscar") && ValidarBuscar())
                LLenar(EquiposBLL.Buscar(RU.StringToInt(equipoIdTextBox.Text)));
     
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void SaveButton_Click_1(object sender, EventArgs e)
        {
            BuscarerrorProvider.Clear();
            LlenarClase(equipo);
            if (ValidarTextbox())
            {
                EquiposBLL.Insertar(equipo);
                limpiar();
                MessageBox.Show("Guardado con exito");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor Buscar el equipo que desea actualizar") && ValidarTextbox())
            {

                LlenarClase(equipo);
                EquiposBLL.Actualizar(RU.StringToInt(equipoIdTextBox.Text), equipo);
                limpiar();
                MessageBox.Show("Actualizado con exito");
            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id del equipo que desea eliminar") && ValidarBuscar())
            {
                EquiposBLL.Eliminar(RU.StringToInt(equipoIdTextBox.Text));
                limpiarErrores();
                limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }

        private void limpiar()
        {
            marcaEquipoTextBox.Text = "";
            serialNumTextBox.Text = "";
            equipoIdTextBox.Text = "";
            limpiarErrores();
            

        }

        private void LLenar(Equipos equipo)
        {
            equipoIdTextBox.Text = equipo.EquipoId.ToString();
            marcaEquipoTextBox.Text = equipo.MarcaEquipo;
            serialNumTextBox.Text = equipo.SerialNum;
            tipoEquipoComboBox.SelectedValue = equipo.TipoId;
        }

        private bool validarId(string message)
        {
            if (string.IsNullOrEmpty(equipoIdTextBox.Text))
            {
                BuscarerrorProvider.SetError(equipoIdTextBox, "Ingresar el ID");
                MessageBox.Show(message);
                return false;
            }
            else
            {

                return true;
            }
        }

        private void tipoEquipoComboBox_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void Cargar()
        {
            tipoEquipoComboBox.DataSource = TiposEquiposBLL.GetLista();
            tipoEquipoComboBox.ValueMember = "TipoId";
            tipoEquipoComboBox.DisplayMember = "Detalle";
        }

        private void LlenarClase(Equipos E)
        {
            E.MarcaEquipo = marcaEquipoTextBox.Text;
            E.SerialNum = serialNumTextBox.Text;
            E.TipoId = (int)tipoEquipoComboBox.SelectedValue;


        }

        private bool ValidarTextbox()
        {
            
            if (string.IsNullOrEmpty(marcaEquipoTextBox.Text) && string.IsNullOrEmpty(serialNumTextBox.Text))
            {
                MarcaerrorProvider.SetError(marcaEquipoTextBox, "Favor ingresar la marca del equipo");
                SerialerrorProvider.SetError(serialNumTextBox, "Favor ingresar el serial del equipo");
                MessageBox.Show("Favor llenar todos los campos obligatorios");

            }
            if (string.IsNullOrEmpty(marcaEquipoTextBox.Text))
            {
                MarcaerrorProvider.SetError(marcaEquipoTextBox, "Favor ingresar la marca del equipo");
                return false;
            }

            if (string.IsNullOrEmpty(serialNumTextBox.Text))
            {
                MarcaerrorProvider.Clear();
                SerialerrorProvider.SetError(serialNumTextBox, "Favor ingresar el serial del equipo");
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
            SerialerrorProvider.Clear();
            MarcaerrorProvider.Clear();
            
        }

        private bool ValidarBuscar()
        {
            if (EquiposBLL.Buscar(RU.StringToInt(equipoIdTextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;

            }

            return true;


        }

    }
}
