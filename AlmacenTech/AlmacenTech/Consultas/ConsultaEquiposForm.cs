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
                EquiposdataGridView.DataSource = EquiposBLL.GetListaId(StringToInt(FiltrotextBox.Text));
            if (FiltrocomboBox.SelectedIndex == 1)
                EquiposdataGridView.DataSource = EquiposBLL.GetListaMarca(FiltrotextBox.Text);
            if (FiltrocomboBox.SelectedIndex == 2)
                EquiposdataGridView.DataSource = EquiposBLL.GetListaTipo(StringToInt(FiltrotextBox.Text));

        }

        private int StringToInt(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }

        private bool validar()
        {
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }
            BuscarerrorProvider.Clear();

            return true;
        }

        
    }
}
