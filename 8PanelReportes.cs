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
    public partial class PanelReportes : Form
    {
        private string usuario;
        private string nivel;

        public PanelReportes(string usuario, string nivel)
        {
            InitializeComponent();
            timer1.Start();
            this.usuario = usuario;
            this.nivel = nivel;
        }

        private void buttonDatos_Click(object sender, EventArgs e)
        {
            PanelValidacionUsuario panel = new PanelValidacionUsuario("Informacion",usuario,nivel);
            panel.Show();
        }

        private void buttonQuincena_Click(object sender, EventArgs e)
        {
            PanelFechaQuincenas panel = new PanelFechaQuincenas();
            panel.Show();
            this.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {

        }
    }
}
