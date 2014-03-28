using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace Checador
{
    public partial class PanelAvisos : Form
    {
        private bool avisoNuevo = false;
        private bool avisoEditar = false;
        private bool mensajeNuevo = false;
        private bool mensajeEditar = false;


        public PanelAvisos()
        {
            InitializeComponent();
            textBoxAviso.Text = ultimaLinea("AVI_ELYON.elyon");
            textBoxMensaje.Text = ultimaLinea("MENS_ELYON.elyon");
        }

        private void buttonNuevoAviso_Click(object sender, EventArgs e)
        {
            textBoxAviso.Enabled = true;
            textBoxAviso.Text = "";
            avisoNuevo = true;
        }

        private void buttonEditarAviso_Click(object sender, EventArgs e)
        {
            textBoxAviso.Enabled = true;
            avisoEditar = true;
        }

        private void buttonNuevoMensaje_Click(object sender, EventArgs e)
        {
            textBoxMensaje.Enabled = true;
            textBoxMensaje.Text = "";
            mensajeNuevo = true;
        }

        private void buttonEditarMensaje_Click(object sender, EventArgs e)
        {
            textBoxMensaje.Enabled = true;
            mensajeEditar = true;
        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (avisoNuevo || avisoEditar)
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("AVI_ELYON.elyon", true))
                {
                    string text  = textBoxAviso.Text + "|";
                    file.WriteLine(text);
                }
            if (mensajeNuevo || mensajeEditar)
                using (System.IO.StreamWriter file = new System.IO.StreamWriter("MENS_ELYON.elyon", true))
                {
                    string text = textBoxMensaje.Text + "|";
                    file.WriteLine(text);
                }
            this.Close();
        }

        private void buttonCancelar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private string ultimaLinea(string archivo)
        {
            string texto = ""; 
            string textoCompleto = "";
            using (StreamReader sr = new StreamReader(archivo))    //CALCULA EL TAMAÑO DE LINEAS DEL ARCHIVO.
                textoCompleto = sr.ReadToEnd();
                 
            string[] textoLineas = textoCompleto.Split('\n');
            for (int i = 0; i < textoLineas.Length; i++) 
            {
                string[] textoSeparado = textoLineas[i].Split('|');
                if (!string.IsNullOrWhiteSpace(textoSeparado[0])) texto = textoSeparado[0];
            }
            return texto;
        }
        
    }
}
