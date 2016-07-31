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
        EquiposAsignados paquete = new EquiposAsignados();
        public rEquiposAsignadossForm()
        {
            InitializeComponent();
        }

        private void rPaqueteEquiposForm_Load(object sender, EventArgs e)
        {
            EquiposcomboBox.DataSource = EquiposBLL.GetLista();
            EquiposcomboBox.ValueMember = "EquipoId";
            EquiposcomboBox.DisplayMember = "TiposEquipos";
        }

        private void Agregarbutton_Click(object sender, EventArgs e)
        {
            paquete.Equipos.Add(new Equipos((int)EquiposcomboBox.SelectedValue, EquiposcomboBox.Text));
            PaqueteEquiposdataGridView.AutoGenerateColumns = false;
            PaqueteEquiposdataGridView.DataSource = paquete.Equipos;

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            EquiposAsignados EA = new EquiposAsignados();
            EA.Detalle = DetalletextBox.Text;
            EquiposAsignadosBLL.Insertar(EA); 
        }

        

    }
}
