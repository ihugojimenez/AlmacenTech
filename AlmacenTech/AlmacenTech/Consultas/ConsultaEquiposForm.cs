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

namespace AlmacenTech.Consultas
{
    public partial class ConsultaEquiposForm : Form
    {
        Equipos equipo = new Equipos();
        RegisterUsersForm RU = new RegisterUsersForm();
        public ConsultaEquiposForm()
        {
            InitializeComponent();
        }

        private void ConsultaEquiposForm_Load(object sender, EventArgs e)
        {
            Cargar();
            
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            if (validar())
                BuscarSeleccion();
            
        }

        private void Cargar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "Marca");
            FiltrocomboBox.Items.Insert(2, "ID Tipo de equipo");
            FiltrocomboBox.DataSource = FiltrocomboBox.Items;
            FiltrocomboBox.DisplayMember = "ID";
            EquiposdataGridView.DataSource = EquiposBLL.GetLista();
        }

        private void BuscarSeleccion()
        {
            if (FiltrocomboBox.SelectedIndex == 0)
                EquiposdataGridView.DataSource = EquiposBLL.GetListaId(RU.StringToInt(FiltrotextBox.Text));
            if (FiltrocomboBox.SelectedIndex == 1)
                EquiposdataGridView.DataSource = EquiposBLL.GetListaMarca(FiltrotextBox.Text);
            if (FiltrocomboBox.SelectedIndex == 2)
                EquiposdataGridView.DataSource = EquiposBLL.GetListaTipo(RU.StringToInt(FiltrotextBox.Text));

        }


        private bool validar()
        {
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }

            if (EquiposBLL.GetListaMarca(FiltrotextBox.Text).Count == 0 || EquiposBLL.GetListaMarca(FiltrotextBox.Text).Count == 0 || EquiposBLL.GetListaTipo(RU.StringToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            BuscarerrorProvider.Clear();

            return true;
        }

        
    }
}
