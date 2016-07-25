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
    public partial class ConsultasBancasForm : Form
    {
        public ConsultasBancasForm()
        {
            InitializeComponent();
        }

        private void ConsultasBancasForm_Load(object sender, EventArgs e)
        {
            BancasdataGridView.DataSource = BancasBLL.GetLista();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            BancasdataGridView.DataSource = BancasBLL.GetListaId(Convert.ToInt32(FiltrotextBox.Text));
        }
    }
}
