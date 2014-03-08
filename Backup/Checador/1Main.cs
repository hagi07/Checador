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
    public partial class Checador : Form
    {
        private Fondo panel = new Fondo();
        public Checador()
        {
            InitializeComponent();
            timer1.Start();
            panel.Show();
        }      

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            //Timer.Text = DateTime.Now.ToLongTimeString();
            Hora.Text = DateTime.Now.ToLongTimeString();
            Dia_Fecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void Checador_Load(object sender, EventArgs e)
        {
            
        }


        private void buttonAceptar_Click(object sender, EventArgs e)
        {
            if (!string.IsNullOrWhiteSpace(textBoxContraseña.Text) && !string.IsNullOrWhiteSpace(textBoxUsuario.Text))
            {
                string usuarioNum = textBoxUsuario.Text.ToString();
                string contraseñaNum = textBoxContraseña.Text.ToString();

                System.IO.StreamReader fileReader = new System.IO.StreamReader("USU_ELYON.elyon");
                string espacios = fileReader.ReadToEnd();
                fileReader.Close();
                
                string[] x = espacios.Split('\n');
                bool ok = false;

                if (radioButtonComidaEntrada.Checked == false && radioButtonComidaSalida.Checked == false && radioButtonEntrada.Checked == false && radioButtonSalida.Checked == false && radioButtonInformacion.Checked == false)
                    labelAdvertencia.Text = "Seleccione una opción";
                                    for (int i = 0; i < x.Length; i++)
                    {
                        string[] y = x[i].Split('|');
                        if (usuarioNum == y[0])
                        {
                            if (contraseñaNum == y[1])
                            {
                                ok = true;
                               
                                if (radioButtonEntrada.Checked == true)
                                {
                                    labelAdvertencia.Text = "Registo Correcto.";
                                    System.IO.StreamWriter file = new System.IO.StreamWriter("ASIS_ELYON.elyon", true);
                                    string text = textBoxUsuario.Text + "|" + DateTime.Now.ToString("HH:mm:ss") + "|" + "E";
                                    file.WriteLine(text);
                                    file.Flush();
                                    file.Close();
                                }


                                if (radioButtonComidaSalida.Checked == true)
                                {
                                    labelAdvertencia.Text = "Registo Correcto.";
                                    System.IO.StreamWriter file = new System.IO.StreamWriter("ASIS_ELYON.elyon", true);
                                    string text = textBoxUsuario.Text + "|" + DateTime.Now.ToString("HH:mm:ss") + "|" + "CS";
                                    file.WriteLine(text);
                                    file.Flush();
                                    file.Close();
                                }


                                if (radioButtonComidaEntrada.Checked == true)
                                {
                                    labelAdvertencia.Text = "Registo Correcto.";
                                    System.IO.StreamWriter file = new System.IO.StreamWriter("ASIS_ELYON.elyon", true);
                                    string text = textBoxUsuario.Text + "|" + DateTime.Now.ToString("HH:mm:ss") + "|" + "CE";
                                    file.WriteLine(text);
                                    file.Flush();
                                    file.Close();
                                }

                                if (radioButtonComidaEntrada.Checked == true)
                                {
                                    labelAdvertencia.Text = "Registo Correcto.";
                                    System.IO.StreamWriter file = new System.IO.StreamWriter("ASIS_ELYON.elyon", true);
                                    string text = textBoxUsuario.Text + "|" + DateTime.Now.ToString("HH:mm:ss") + "|" + "S";
                                    file.WriteLine(text);
                                    file.Flush();
                                    file.Close();
                                }

                                if (radioButtonInformacion.Checked == true)
                                {
                                    labelAdvertencia.Text = y[3].ToString();
                                    if (y[3] == "Bajo") {
                                        PanelSeguridad1 panel = new PanelSeguridad1();
                                        panel.Show();
                                    }

                                    if (y[3] == "Medio")
                                    {
                                        PanelSeguridad2 panel = new PanelSeguridad2();
                                        panel.Show();
                                    }

                                    if (y[3] == "Alto")
                                    {

                                        PanelSeguridad3 panel = new PanelSeguridad3();
                                        panel.Show();
                                        labelAdvertencia.Text = "Adios";
                                    }
                                }


                            }
                        }
                    }
                if (ok == false) labelAdvertencia.Text = "Usuario o Contraseña Incorrecta";

                /* if (usuarioNum == "123456")
                    {
                        if (contraseñaNum == "ElGm4987")
                        {
                            System.IO.StreamWriter file = new System.IO.StreamWriter("ASIS_ELYON.elyon", true);
                            string text = textBoxUsuario.Text + "," + DateTime.Now.ToLongTimeString();
                            file.WriteLine (text);
                            file.Flush();
                            file.Close();
                            labelAdvertencia.Text = "Registo Correcto.";
                        }
                        else labelAdvertencia.Text = "Contraseña Incorrecta.";
                    }
                    else labelAdvertencia.Text = "Usuario Incorrecto.";
                }
                else labelAdvertencia.Text = "Datos Incompletos.";
                */
            }
        }

        private void buttonSalida_Click(object sender, EventArgs e)
        {
            panel.Close();
            this.Close();
        }













    }
}
