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

namespace AlmacenTech.Consultas
{
    public partial class ConsultaBanquerasForm : Form
    {
        public ConsultaBanquerasForm()
        {
            InitializeComponent();
        }

        private void ConsultaBanquerasForm_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (validar())
                BuscarSeleccion();
        }

        private void Cargar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "Apellido");
            FiltrocomboBox.Items.Insert(2, "Fecha");
            FiltrocomboBox.DataSource = FiltrocomboBox.Items;
            FiltrocomboBox.DisplayMember = "ID";
            BanquerasdataGridView.DataSource = BanquerasBLL.GetLista();
        }

        private void BuscarSeleccion()
        {
            if (FiltrocomboBox.SelectedIndex == 0)
                BanquerasdataGridView.DataSource = BanquerasBLL.GetListaId(StringToInt(FiltrotextBox.Text));
            if (FiltrocomboBox.SelectedIndex == 1)
                BanquerasdataGridView.DataSource = BanquerasBLL.GetListaApellido(FiltrotextBox.Text);
           /* if (FiltrocomboBox.SelectedIndex == 2)
                BanquerasdataGridView.DataSource = EquiposBLL.GetListaTipo(StringToInt(FiltrotextBox.Text));*/

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
            if (BanquerasBLL.GetListaApellido(FiltrotextBox.Text).Count == 0 || BanquerasBLL.GetListaId(StringToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            BuscarerrorProvider.Clear();

            return true;
        }

    }
}
