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

        private void SaveButton_Click(object sender, EventArgs e)
        {
            Equipos E = new Equipos();
            E.MarcaEquipo = marcaEquipoTextBox.Text;
            E.SerialNum = serialNumTextBox.Text;
            E.TipoId = (int)tipoEquipoComboBox.SelectedValue;
            EquiposBLL.AgregarEquipo(E);
        }
    }
}
