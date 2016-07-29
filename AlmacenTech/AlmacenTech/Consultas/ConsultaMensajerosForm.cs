﻿using BLL;
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
    public partial class ConsultaMensajerosForm : Form
    {
        public ConsultaMensajerosForm()
        {
            InitializeComponent();
        }

        private void ConsultaMensajerosForm_Load(object sender, EventArgs e)
        {
            MensajerosdataGridView.DataSource = MensajerosBLL.GetLista();
        }

        private void Buscarbutton_Click(object sender, EventArgs e)
        {
            MensajerosdataGridView.DataSource = MensajerosBLL.GetListaId(Convert.ToInt32(FiltrotextBox.Text));
        }

        
    }
}
