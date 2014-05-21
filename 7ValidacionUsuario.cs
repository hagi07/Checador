using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;

namespace Checador
{
    public partial class PanelValidacionUsuario : Form
    {
        private string opcion;
        private string usuario;
        private string nivel;
        Util util = new Util();
        public PanelValidacionUsuario(string opcion, string usuario,string nivel)
        {
            InitializeComponent();
            this.opcion = opcion;
            this.usuario = usuario;
            this.nivel = nivel;

            string[] x = util.textoDeArchivoConSplit("USU_ELYON.elyon", '\n');


            for (int i = 0; i < x.Length; i++)
            {
                string[] y = x[i].Split('|');
                if(!string.IsNullOrWhiteSpace(y[0])) listBox1.Items.Add(y[2]);
            }


        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            string[] x = util.textoDeArchivoConSplit("USU_ELYON.elyon", '\n');
            bool ok = false;

            for (int i = 0; i < x.Length; i++)
            {
                string[] y = x[i].Split('|');
                if(y.Length >= 2)
                    if (y[2] == listBox1.SelectedItem.ToString())
                        ok = true;
            }

            if (ok)
            {
                if (opcion == "Nuevo")
                {
                    PanelRegistroDatosLaboral panel = new PanelRegistroDatosLaboral("Nuevo", listBox1.SelectedItem.ToString(), nivel);
                    panel.Show();
                    this.Close();
                }

                if (opcion == "Editar")
                {
                    if (nivel == "Alto")
                    {
                        PanelRegistroDatosLaboral panel = new PanelRegistroDatosLaboral("Editar", listBox1.SelectedItem.ToString(), "Alto");
                        panel.Show();
                    }
                    if (nivel == "Medio")
                    {
                        MessageBox.Show(listBox1.SelectedItem.ToString());
                        PanelDatosPersonal panel = new PanelDatosPersonal("Editar", "Medio", usuario, listBox1.SelectedItem.ToString());
                        panel.Show();
                    }
                }
                if (opcion == "Informacion")
                {
                    if (nivel == "Alto") 
                    {
                        
                    }
                }
            }
            if (!ok) MessageBox.Show("Usuario No Encontrado.");


        }

        private void PanelValidacionUsuario_Load(object sender, EventArgs e)
        {

        }
    }
}
