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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void registrarMensajeroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MensajerosForm MF = new MensajerosForm();
            MF.MdiParent = this;
            MF.Show();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void registrarBanqueraToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroBanquerasForm Rb = new RegistroBanquerasForm();
            Rb.MdiParent = this;
            Rb.Show();
        }

        private void registrarBancaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroBancasForm RB = new RegistroBancasForm();
            RB.MdiParent = this;
            RB.Show();
        }

        private void registrarEquiposToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EquiposForm EF = new EquiposForm();
            EF.MdiParent = this;
            EF.Show();
        }

        private void registroDeUsuariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegisterUsersForm Ru = new RegisterUsersForm();
            Ru.MdiParent = this;
            Ru.Show();
        }
    }
}
