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
        public PanelReportes()
        {
            InitializeComponent();
            timer1.Start();
        }

        private void buttonDatos_Click(object sender, EventArgs e)
        {

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
