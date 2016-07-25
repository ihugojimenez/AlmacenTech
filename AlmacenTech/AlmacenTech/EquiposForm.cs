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
        public EquiposForm()
        {
            InitializeComponent();
        }

        

        private void EquiposForm_Load(object sender, EventArgs e)
        {
            tipoEquipoComboBox.DataSource = TiposEquiposBLL.GetLista();
            tipoEquipoComboBox.ValueMember = "TipoId";
            tipoEquipoComboBox.DisplayMember = "Detalle";

        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(equipoIdTextBox.Text))
            {
                BuscarerrorProvider.SetError(equipoIdTextBox, "Favor digitar el ID del Equipo que desea buscar");
            }
            else
            {
                LLenar(EquiposBLL.Buscar(Convert.ToInt32(equipoIdTextBox.Text)));

            }
        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(equipoIdTextBox.Text))
            {
                BuscarerrorProvider.SetError(equipoIdTextBox, "Favor digitar el ID del equipo que desea eliminar");
            }
            else
            {
                BuscarerrorProvider.Clear();
                EquiposBLL.EliminarEquipo(Convert.ToInt32(equipoIdTextBox.Text));
                limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(equipoIdTextBox.Text))
            {
                BuscarerrorProvider.SetError(equipoIdTextBox, "Favor buscar el ID del equipo que desea actualizar");
            }
            else
            {
                BuscarerrorProvider.Clear();
                if (marcaEquipoTextBox.Text == "" || serialNumTextBox.Text == " ")
                {
                    MessageBox.Show("Buscar el ID del usuario que desea Actualizar");
                }
                else
                {
                    EquiposBLL.ActualizarEquipo(Convert.ToInt32(equipoIdTextBox.Text), marcaEquipoTextBox.Text, serialNumTextBox.Text, (int)tipoEquipoComboBox.SelectedValue);
                    limpiar();
                }

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Equipos E = new Equipos();
            E.MarcaEquipo = marcaEquipoTextBox.Text;
            E.SerialNum = serialNumTextBox.Text;
            E.TipoId = (int)tipoEquipoComboBox.SelectedValue;
            

            if (marcaEquipoTextBox.Text == "" || serialNumTextBox.Text == " ")
            {
                MessageBox.Show("Favor llenar todos los campos");
            }
            else
            {
                EquiposBLL.AgregarEquipo(E);
                limpiar();
            }
         }

        private void limpiar()
        {
            marcaEquipoTextBox.Text = "";
            serialNumTextBox.Text = "";
            equipoIdTextBox.Text = "";
            

        }

        private void LLenar(Equipos equipo)
        {
            equipoIdTextBox.Text = equipo.EquipoId.ToString();
            marcaEquipoTextBox.Text = equipo.MarcaEquipo;
            serialNumTextBox.Text = equipo.SerialNum;
            tipoEquipoComboBox.SelectedValue = equipo.TipoId;
        }

       

       

        
    }
}
