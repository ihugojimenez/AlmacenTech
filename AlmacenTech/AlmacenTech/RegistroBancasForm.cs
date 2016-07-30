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
    public partial class RegistroBancasForm : Form
    {
        public RegistroBancasForm()
        {
            InitializeComponent();
        }

        private void RegistroBancasForm_Load(object sender, EventArgs e)
        {
            equipoIdComboBox.DataSource = EquiposBLL.GetLista();
            equipoIdComboBox.ValueMember = "EquipoId";
            equipoIdComboBox.DisplayMember = "MarcaEquipo";

            banqueraIdComboBox.DataSource = BanquerasBLL.GetLista();
            banqueraIdComboBox.ValueMember = "BanqueraId";
            banqueraIdComboBox.DisplayMember = "Nombres";

            /*rutaIdComboBox.DataSource = RutasBLL.GetLista();
            rutaIdComboBox.ValueMember = "RutaId";
            rutaIdComboBox.DisplayMember = "Direccion" + " / " + "Ciudad";*/
        }

        

        

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bancaIdTextBox.Text))
            {
                BuscarerrorProvider.SetError(bancaIdTextBox, "Favor digitar el ID de la banca que desea buscar");
            }
            else
            {
                LLenar(BancasBLL.Buscar(Convert.ToInt32(bancaIdTextBox.Text)));

            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(bancaIdTextBox.Text))
            {
                BuscarerrorProvider.SetError(bancaIdTextBox, "Favor buscar el ID de la banca que desea actualizar");
            }
            else
            {
                BuscarerrorProvider.Clear();
                
                BancasBLL.ActualizarBancas(Convert.ToInt32(bancaIdTextBox.Text), (int)banqueraIdComboBox.SelectedValue, (int)equipoIdComboBox.SelectedValue, (int)rutaIdComboBox.SelectedValue);
                bancaIdTextBox.Text = "";
                

            }
        }

        private void LLenar(Bancas banca)
        {
            bancaIdTextBox.Text = banca.BancaId.ToString();
            banqueraIdComboBox.SelectedValue = banca.BanqueraId;
            equipoIdComboBox.SelectedValue = banca.EquipoId;
            rutaIdComboBox.SelectedValue = banca.RutaId;


        }

        private void button1_Click(object sender, EventArgs e)
        {
            Bancas b = new Bancas();
            b.BanqueraId = (int)banqueraIdComboBox.SelectedValue;
            b.EquipoId = (int)equipoIdComboBox.SelectedValue;
            b.RutaId = (int)rutaIdComboBox.SelectedValue;

            BancasBLL.AgregarBancas(b);
            bancaIdTextBox.Text = "";

        }

        private void EliminarButton_Click(object sender, EventArgs e)
        {
           /* if (string.IsNullOrEmpty(bancaIdTextBox.Text))
            {
                BuscarerrorProvider.SetError(bancaIdTextBox, "Favor digitar el ID de la banca que desea eliminar");
            }
            else
            {
                BuscarerrorProvider.Clear();
                EquiposBLL.EliminarEquipo(Convert.ToInt32(bancaIdTextBox.Text));
                bancaIdTextBox.Text = "";
                MessageBox.Show("ELiminado con exito");
            }*/
        }
    }
}
