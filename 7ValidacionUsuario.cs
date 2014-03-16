using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Checador
{
    public partial class PanelValidacionUsuario : Form
    {

        public PanelValidacionUsuario()
        {
            InitializeComponent();
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            System.IO.StreamReader fileReader = new System.IO.StreamReader("USU_ELYON.elyon");
            string espacios = fileReader.ReadToEnd();
            fileReader.Close();

            string[] x = espacios.Split('\n');
            bool ok = false;

            for (int i = 0; i < x.Length; i++)
            {
                string[] y = x[i].Split('|');
                if (y[0] == textBoxUsuario.Text) {
                    ok = true;
                }
            }
            if (ok == true) 
            {
                PanelRegistroDatosLaboral panel = new PanelRegistroDatosLaboral(1, textBoxUsuario.Text);
                panel.Show();
                this.Close();
            }
            if (ok == false) MessageBox.Show("Usuario No Encontrado.");
        }

        private void PanelValidacionUsuario_Load(object sender, EventArgs e)
        {

        }


    }
}
