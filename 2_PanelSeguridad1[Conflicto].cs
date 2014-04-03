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
    public partial class PanelSeguridad1 : Form
    {
        public PanelSeguridad1()
        {
            InitializeComponent();
        }

        private void buttonHoras_Click(object sender, EventArgs e)
        {
            PanelFechaQuincenas panel = new PanelFechaQuincenas();
            panel.Show();
            this.Close();
        }
    }
}
