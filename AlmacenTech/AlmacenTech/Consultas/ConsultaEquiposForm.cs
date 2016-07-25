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
            EquiposdataGridView.DataSource = EquiposBLL.GetLista();
            
        }
    }
}
