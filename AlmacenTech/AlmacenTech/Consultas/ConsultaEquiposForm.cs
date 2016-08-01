using BLL;
using Entidades;
using Microsoft.Reporting.WinForms;
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
        RegisterUsersForm RU = new RegisterUsersForm();
        public ConsultaEquiposForm()
        {
            InitializeComponent();
        }

        private void ConsultaEquiposForm_Load(object sender, EventArgs e)
        {
            Cargar();
            
        }

        private void Buscarbutton_Click_1(object sender, EventArgs e)
        {
            if (validar())
                BuscarSeleccion();
            
        }

        private void Cargar()
        {
            FiltrocomboBox.Items.Insert(0, "ID");
            FiltrocomboBox.Items.Insert(1, "Marca");
            FiltrocomboBox.Items.Insert(2, "ID Tipo de equipo");
            FiltrocomboBox.Items.Insert(3, "Fecha de ingreso");
            FiltrocomboBox.DataSource = FiltrocomboBox.Items;
            FiltrocomboBox.DisplayMember = "ID";
            EquiposdataGridView.DataSource = EquiposBLL.GetLista();
            EquiposdataGridView.Columns["EquiposAsignados"].Visible = false;
            EquiposdataGridView.Columns.Remove("EquiposAsignados");
            
            
            

        }

        private void BuscarSeleccion()
        {
            if (FiltrocomboBox.SelectedIndex == 0)
                EquiposdataGridView.DataSource = EquiposBLL.GetListaId(RU.StringToInt(FiltrotextBox.Text));
            if (FiltrocomboBox.SelectedIndex == 1)
                EquiposdataGridView.DataSource = EquiposBLL.GetListaMarca(FiltrotextBox.Text);
            if (FiltrocomboBox.SelectedIndex == 2)
                EquiposdataGridView.DataSource = EquiposBLL.GetListaTipo(RU.StringToInt(FiltrotextBox.Text));
            if (FiltrocomboBox.SelectedIndex == 3)
                EquiposdataGridView.DataSource = EquiposBLL.GetListaFecha(DesdeDateTimePicke.Value, HastadateTimePicker.Value);
        }


        private bool validar()
        {
            if(FiltrocomboBox.SelectedIndex == 3)
            {
                if (DesdeDateTimePicke.Value == HastadateTimePicker.Value)
                {
                    MessageBox.Show("Favor definir un intervalo diferente entre las dos fechas");
                    return false;
                }
                else
                {
                    return true;
                }
            }
            if (string.IsNullOrEmpty(FiltrotextBox.Text))
            {
                BuscarerrorProvider.SetError(FiltrotextBox, "Ingresar el campo que desea filtar");
                return false;
            }

            if (EquiposBLL.GetListaMarca(FiltrotextBox.Text).Count == 0 || EquiposBLL.GetListaMarca(FiltrotextBox.Text).Count == 0 || EquiposBLL.GetListaTipo(RU.StringToInt(FiltrotextBox.Text)).Count == 0 || EquiposBLL.GetListaFecha(DesdeDateTimePicke.Value, HastadateTimePicker.Value).Count == 0)
            {
                MessageBox.Show("No hay registros que coincidan con este campo de filtro..." + "\n" + "\n" + "Intente con otro campo");
                return false;

            }
            
            BuscarerrorProvider.Clear();

            return true;
        }

        private void Imprimebutton_Click(object sender, EventArgs e)
        {
            ReportingViewer viewer = new ReportingViewer();

            viewer.RptViewer.Reset();
            viewer.RptViewer.ProcessingMode = Microsoft.Reporting.WinForms.ProcessingMode.Local;

            viewer.RptViewer.LocalReport.ReportPath = @"C:\Users\Henry O\Source\Repos\AlmacenTech2\AlmacenTech\AlmacenTech\Reportes\ListadoEquipos.rdlc";

            viewer.RptViewer.LocalReport.DataSources.Clear();

            viewer.RptViewer.LocalReport.DataSources.Add(
                new ReportDataSource("DataSetEquipos",
                EquiposBLL.GetLista()));

            viewer.RptViewer.LocalReport.Refresh();

            viewer.Show();
        }
    }
}
