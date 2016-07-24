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

        private void bancasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.bancasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.almacenTechDataSet);

        }

        private void RegistroBancasForm_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'almacenTechDataSet.Bancas' table. You can move, or remove it, as needed.
            this.bancasTableAdapter.Fill(this.almacenTechDataSet.Bancas);
            // TODO: This line of code loads data into the 'almacenTechDataSet.Bancas' table. You can move, or remove it, as needed.
            this.bancasTableAdapter.Fill(this.almacenTechDataSet.Bancas);

        }

        private void bancasBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.bancasBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.almacenTechDataSet);

        }
    }
}
