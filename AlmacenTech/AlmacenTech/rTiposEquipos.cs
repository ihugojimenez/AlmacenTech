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
    public partial class rTiposEquipos : Form
    {
        public rTiposEquipos()
        {
            InitializeComponent();
        }

        private void UpdateButton_Click(object sender, EventArgs e)
        {

        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            TiposEquipos TE = new TiposEquipos();

            TE.Detalle = DetalletextBox.Text;
            TiposEquiposBLL.AgregarTipoEquipo(TE);
        }
    }
}
