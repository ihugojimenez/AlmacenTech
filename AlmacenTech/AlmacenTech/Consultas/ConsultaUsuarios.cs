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
    public partial class ConsultaUsuarios : Form
    {
        public ConsultaUsuarios()
        {
            InitializeComponent();
        }

        private void ConsultaUsuarios_Load(object sender, EventArgs e)
        {
            Cargar();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {

            if(validar())
                BuscarSeleccion();
        }

        private void BuscarSeleccion()
        {
            if (FiltrocomboBox.SelectedIndex == 0)
                UsuariosdataGridView.DataSource= UsuariosBLL.GetListaId(StringToInt(FiltrotextBox.Text));
            if (FiltrocomboBox.SelectedIndex == 1)
                UsuariosdataGridView.DataSource = UsuariosBLL.GetApellido(FiltrotextBox.Text);
            if (FiltrocomboBox.SelectedIndex == 2)
                UsuariosdataGridView.DataSource = UsuariosBLL.GetListaIdPermiso(StringToInt(FiltrotextBox.Text));

        }

        private bool validar()
        {
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }
            if(FiltrocomboBox.SelectedIndex == 0 && UsuariosBLL.GetListaId(StringToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;
                
            }
            if (FiltrocomboBox.SelectedIndex == 1 && UsuariosBLL.GetApellido(FiltrotextBox.Text).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            if (FiltrocomboBox.SelectedIndex == 2 && UsuariosBLL.GetListaIdPermiso(StringToInt(FiltrotextBox.Text)).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }


            return true;
        }

 

        public int StringToInt(string texto)
        {
            int numero = 0;

            int.TryParse(texto, out numero);

            return numero;
        }

        private void Cargar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "Apellido");
            FiltrocomboBox.Items.Insert(2, "ID Permiso de Usuario");
            FiltrocomboBox.DataSource = FiltrocomboBox.Items;
            FiltrocomboBox.DisplayMember = "ID";
            UsuariosdataGridView.DataSource = UsuariosBLL.GetLista();
        }


    }
}
