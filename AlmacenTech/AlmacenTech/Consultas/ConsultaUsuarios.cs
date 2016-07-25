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
            UsuariosdataGridView.DataSource = UsuariosBLL.GetLista();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            UsuariosdataGridView.DataSource = UsuariosBLL.GetListaId(Convert.ToInt32(FiltrotextBox.Text));
        }
    }
}
