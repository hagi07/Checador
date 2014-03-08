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
    public partial class PanelAdministradorPassword : Form
    {
        public PanelAdministradorPassword()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxContraseña.Text))
            {

                string usuarioNum = textBoxUsuario.Text.ToString();
                string contraseñaNum = textBoxContraseña.Text.ToString();

                if (usuarioNum == "123456")
                {
                    if (contraseñaNum == "ElGm4987")
                    {

                        /*PanelDatosPersonal panel = new PanelDatosPersonal(text);
                        panel.Show();*
                        this.Close();*/
                    }
                    else labelAdvertencia.Text = "Contraseña Incorrecta.";
                }
                else labelAdvertencia.Text = "Usuario Incorrecto.";
            }
            else labelAdvertencia.Text = "Datos Incompletos.";

        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void PanelAdministradorPassword_Load(object sender, EventArgs e)
        {

        }
    }
}
