using System;
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
        private string usuario;
        public PanelSeguridad3(string usuario)
        {
            InitializeComponent();
            this.usuario = usuario;
        }

        private void buttonCrear_Click(object sender, EventArgs e)
        {
            PanelRegistroDatosLaboral panel = new PanelRegistroDatosLaboral("Crear",usuario,"Alto");
            panel.Show();

        }

        private void buttonEditar_Click(object sender, EventArgs e)
        {
            PanelValidacionUsuario validation = new PanelValidacionUsuario("Editar",usuario,"Alto");
            validation.Show();

        }

        private void buttonReportes_Click(object sender, EventArgs e)
        {
            PanelReportes panel = new PanelReportes(usuario, "Alto");
            panel.Show();
        }

        private void buttonAvisos_Click(object sender, EventArgs e)
        {
            PanelAvisos panel = new PanelAvisos();
            panel.Show();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            PanelRegistroDatosLaboral panel = new PanelRegistroDatosLaboral("Editar", usuario, "Alto");
            panel.Show();
        }

    }
}
