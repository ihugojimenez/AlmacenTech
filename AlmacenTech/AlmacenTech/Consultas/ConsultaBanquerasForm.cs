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
            BanquerasdataGridView.DataSource = BanquerasBLL.GetLista();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            BanquerasdataGridView.DataSource = BanquerasBLL.GetListaId(Convert.ToInt32(FiltrotextBox.Text));
        }
    }
}
