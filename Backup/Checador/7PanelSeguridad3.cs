﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checador
{
    public partial class PanelSeguridad3 : Form
    {
        public PanelSeguridad3()
        {
            InitializeComponent();
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            PanelRegistroDatosLaboral panel = new PanelRegistroDatosLaboral();
            panel.Show();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            PanelRegistroDatosLaboral panel = new PanelRegistroDatosLaboral();
            panel.Show();
        }


    }
}