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
    public partial class ReportingViewerMensajeros : Form
    {
        public ReportingViewerMensajeros()
        {
            InitializeComponent();
        }

        private void ReportingViewerMensajeros_Load(object sender, EventArgs e)
        {

            this.RptViewer.RefreshReport();
        }
    }
}
