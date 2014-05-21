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
    public partial class Main : Form
    {
        Util util = new Util();
        public Main()
        {
            InitializeComponent();
            reloj.Start();
            textBoxMensaje.Text = ultimaLinea("MENS_ELYON.elyon");
            textBoxAvisos.Text = ultimaLinea("AVI_ELYON.elyon");
            
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

        private void Fondo_Load(object sender, EventArgs e)
        {

        }

        private void buttonAceptar_Click(object sender, EventArgs e)
        {

            if (!string.IsNullOrWhiteSpace(textBoxContraseña.Text) && !string.IsNullOrWhiteSpace(textBoxUsuario.Text))
            {
                // ENTRADA COMO ADMINISTRADOR.
                if (textBoxUsuario.Text == "Administrador" && textBoxContraseña.Text == "28072807")
                {
                    PanelSeguridad3 panel = new PanelSeguridad3(textBoxUsuario.Text);
                    panel.Show();
                    textBoxContraseña.Text = "";
                    textBoxUsuario.Text = "";
                    return;
                }
                                
                string usuarioNum = textBoxUsuario.Text.ToString();
                string contraseñaNum = textBoxContraseña.Text.ToString();


                string[] x = util.textoDeArchivoConSplit("USU_ELYON.elyon", '\n');
                bool ok = false;

                if (radioButtonComidaEntrada.Checked == false && radioButtonComidaSalida.Checked == false && radioButtonEntrada.Checked == false && radioButtonSalida.Checked == false && radioButtonInformacion.Checked == false)
                    MessageBox.Show("Seleccione una opción");


                for (int i = 0; i < x.Length; i++)
                {
                    string[] y = x[i].Split('|');
                    if (usuarioNum == y[0] && contraseñaNum == y[1])
                    {
                        ok = true;
                        string[] lineas = util.textoDeArchivoConSplit("ASIS_ELYON.elyon", '\n');

                        if (radioButtonEntrada.Checked == true)
                        {
                            bool okEntrada = util.validiarEntrada(lineas, textBoxUsuario.Text);

                            if (okEntrada)
                                MessageBox.Show("Ya estás registrado de entrada.");

                            if (!okEntrada)
                            {
                                MessageBox.Show("Bienvenido " + y[2] + ".");
                                util.escribirEnArchivo("ASIS_ELYON.elyon", DateTime.Now.ToString("dd/MM/yyyy") + "|" + textBoxUsuario.Text + "|" + DateTime.Now.ToString("HH:mm:ss") + "|" + "E" + "|");
                            }
                        }

                        if (radioButtonComidaSalida.Checked == true)
                        {
                            bool okEntrada = util.validiarEntrada(lineas, textBoxUsuario.Text);
                            bool okSalidaComer = util.validiarIrAComer(lineas, textBoxUsuario.Text);
                            bool okSalida = util.validiarSalida(lineas, textBoxUsuario.Text);

                            if (okEntrada == true && okSalidaComer == false && !okSalida)
                            {
                                MessageBox.Show("Provecho " + y[2] + ".");
                                util.escribirEnArchivo("ASIS_ELYON.elyon", DateTime.Now.ToString("dd/MM/yyyy") + "|" + textBoxUsuario.Text + "|" + DateTime.Now.ToString("HH:mm:ss") + "|" + "CS" + "|");
                            }

                            if (okSalidaComer) MessageBox.Show("Ya saliste a comer.");
                            if (!okEntrada) MessageBox.Show("No has entrado aun.");
                            if (okSalida && okEntrada) MessageBox.Show("Ya saliste hoy.");

                        }

                        if (radioButtonComidaEntrada.Checked == true)
                        {
                            bool okEntrada = util.validiarEntrada(lineas, textBoxUsuario.Text);
                            bool okEntradaComer = util.validiarRegresoComer(lineas, textBoxUsuario.Text);
                            bool okSalidaComer = util.validiarIrAComer(lineas, textBoxUsuario.Text);
                            bool okSalida = util.validiarSalida(lineas, textBoxUsuario.Text);


                            if (okSalidaComer && !okEntradaComer)
                            {
                                MessageBox.Show("Bienvenido " + y[2] + ".");
                                util.escribirEnArchivo("ASIS_ELYON.elyon", DateTime.Now.ToString("dd/MM/yyyy") + "|" + textBoxUsuario.Text + "|" + DateTime.Now.ToString("HH:mm:ss") + "|" + "CE" + "|");
                            }

                            if (okEntradaComer) MessageBox.Show("Ya regresaste de comer.");
                            if (!okSalidaComer && !okSalida) MessageBox.Show("No has ido a comer aun.");
                            if (okSalida && okEntrada) MessageBox.Show("Ya saliste hoy.");
                        }




                        if (radioButtonSalida.Checked == true)
                        {
                            bool okEntrada = util.validiarEntrada(lineas, textBoxUsuario.Text);
                            bool okEntradaComer = util.validiarRegresoComer(lineas, textBoxUsuario.Text);
                            bool okSalidaComer = util.validiarIrAComer(lineas, textBoxUsuario.Text);
                            bool okSalida = util.validiarSalida(lineas, textBoxUsuario.Text);


                            if (okEntrada)
                            {
                                if (okSalidaComer)
                                {
                                    if (!okEntradaComer) MessageBox.Show("No has regresado de comer.");
                                    if (okEntradaComer && !okSalida)
                                    {
                                        MessageBox.Show("Adios " + y[2] + ".");
                                        util.escribirEnArchivo("ASIS_ELYON.elyon", DateTime.Now.ToString("dd/MM/yyyy") + "|" + textBoxUsuario.Text + "|" + DateTime.Now.ToString("HH:mm:ss") + "|" + "S" + "|");
                                    }
                                }
                                else if (!okSalida)
                                {
                                    MessageBox.Show("Adios " + y[2] + ".");
                                    util.escribirEnArchivo("ASIS_ELYON.elyon", DateTime.Now.ToString("dd/MM/yyyy") + "|" + textBoxUsuario.Text + "|" + DateTime.Now.ToString("HH:mm:ss") + "|" + "S" + "|");
                                }
                            }
                            if (!okEntrada) MessageBox.Show("No has entrado aun.");
                        }

                        if (radioButtonInformacion.Checked == true)
                        {
                            if (y[3] == "Bajo")
                            {
                                PanelSeguridad1 panel = new PanelSeguridad1(textBoxUsuario.Text);
                                panel.Show();
                            }

                            if (y[3] == "Medio")
                            {
                                PanelSeguridad2 panel = new PanelSeguridad2(textBoxUsuario.Text);
                                panel.Show();
                            }

                            if (y[3] == "Alto")
                            {
                                PanelSeguridad3 panel = new PanelSeguridad3(textBoxUsuario.Text);
                                panel.Show();
                            }
                        }
                    }
                }                
                if (ok == false) MessageBox.Show("Usuario o Contraseña Incorrecta");
                /*textBoxContraseña.Text = "";
                textBoxUsuario.Text = "";*/
            }
            else MessageBox.Show("Ingrese Datos Completos");


        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {
            this.Close();
            Fondo.ActiveForm.Close();
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            Hora.Text = DateTime.Now.ToLongTimeString();
            Dia_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }




    




        
    }




    



}
