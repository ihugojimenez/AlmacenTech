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
    public partial class rEquiposAsignadossForm : Form
    {
        RegisterUsersForm RU = new RegisterUsersForm();
        EquiposAsignados paquete = new EquiposAsignados();
        public rEquiposAsignadossForm()
        {
            InitializeComponent();
        }

        private void rPaqueteEquiposForm_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor ingresar el id que desea buscar") && ValidarBuscar())
                LLenar(EquiposAsignadosBLL.Buscar(RU.StringToInt(equipoIdTextBox.Text)));
        }

        private void NewButton_Click(object sender, EventArgs e)
        {
            limpiar();
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            paquete.Equipos.Add(new Equipos((int)EquiposcomboBox.SelectedValue, EquiposcomboBox.Text));
            PaqueteEquiposdataGridView.AutoGenerateColumns = false;
            PaqueteEquiposdataGridView.DataSource = null;
            PaqueteEquiposdataGridView.DataSource = paquete.Equipos;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {

            BuscarerrorProvider.Clear();
            LlenarClase(paquete);
            if (ValidarTextbox() && ValidarExiste(DetalletextBox.Text))
            {
                EquiposAsignadosBLL.Insertar(paquete);
                limpiar();
                MessageBox.Show("Guardado con exito");
            }

            
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void Deletebutton_Click(object sender, EventArgs e)
        {
            if (validarId("Favor digitar el id  que desea eliminar") && ValidarBuscar())
            {
                EquiposAsignadosBLL.Eliminar(RU.StringToInt(equipoIdTextBox.Text));
                limpiarErrores();
                limpiar();
                MessageBox.Show("ELiminado con exito");
            }
        }

        public void Cargar()
        {
            EquiposcomboBox.DataSource = EquiposBLL.GetLista();
            EquiposcomboBox.ValueMember = "EquipoId";
            EquiposcomboBox.DisplayMember = "TiposEquipos";
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

        private void LLenar(EquiposAsignados equipoasignado)
        {
            equipoIdTextBox.Text = equipoasignado.IdEquiposAsignados.ToString();
            DetalletextBox.Text = equipoasignado.Detalle;
            PaqueteEquiposdataGridView.DataSource = EquiposAsignadosBLL.GetListaEquipos(RU.StringToInt(equipoIdTextBox.Text));
            


        }

        private bool ValidarBuscar()
        {
            if (EquiposAsignadosBLL.Buscar(RU.StringToInt(equipoIdTextBox.Text)) == null)
            {
                MessageBox.Show("Este registro no existe");
                return false;

            }

            return true;


        }

        private void limpiar()
        {
            DetalletextBox.Text = "";
            equipoIdTextBox.Text = "";
            EquiposcomboBox.SelectedValue = 1;
            PaqueteEquiposdataGridView.DataSource = null;
            

        }

        private void LlenarClase(EquiposAsignados u)
        {
            u.Detalle = DetalletextBox.Text;
            

        }

        private bool ValidarTextbox()
        {
            
            if (string.IsNullOrEmpty(DetalletextBox.Text) && PaqueteEquiposdataGridView.Rows.Count == 1)
            {
                DatagrilderrorProvider.SetError(PaqueteEquiposdataGridView, "Favor ingresar equipos");
                DetalleerrorProvider.SetError(DetalletextBox, "Favor ingresar detalle");
                MessageBox.Show("Favor llenar todos los campos obligatorios");
                return false;

            }
            if (string.IsNullOrEmpty(DetalletextBox.Text))
            {
                
                DetalleerrorProvider.SetError(DetalletextBox, "Ingresar detalle");
                MessageBox.Show("Favor ingresar el detalle de estos equipos");
                return false;

            }
            if (PaqueteEquiposdataGridView.Rows.Count == 1 && PaqueteEquiposdataGridView.Rows.Count < 3)
            {
                DetalleerrorProvider.Clear();
                DatagrilderrorProvider.SetError(PaqueteEquiposdataGridView, "Ingresar equipos");
                MessageBox.Show("Favor ingresar equipos para este registro");
                return false;

            }


            return true;




        }

        private bool ValidarExiste(string aux)
        {
            if (EquiposAsignadosBLL.GetListaDetalle(aux).Count() > 0)
            {
                MessageBox.Show("Este registro ya existe, favor intentar con otro detalle...");
                return false;
            }
            return true;
        }

        private void limpiarErrores()
        {
            DetalleerrorProvider.Clear();
            DatagrilderrorProvider.Clear();
            BuscarerrorProvider.Clear();
        }

    }
}
