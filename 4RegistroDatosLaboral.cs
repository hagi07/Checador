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
    public partial class PanelRegistroDatosLaboral : Form
    {
        private int opcion;
        private string usuario;

        public PanelRegistroDatosLaboral(int op, string usu)
        {
            InitializeComponent();
            opcion = op;
            usuario = usu;

            if (opcion == 1)
                reordenarDatos();
        }

        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (opcion == 0)
            {
                    System.IO.StreamWriter file = new System.IO.StreamWriter("BDL_ELYON.elyon", true);
                    file.WriteLine(obtenerDatos());
                    file.Flush();
                    file.Close();


                    string seguridad = "";
                    if (radioButtonSeguridadAlto.Checked == true) seguridad = "Alto";
                    if (radioButtonSeguridadMedio.Checked == true) seguridad = "Medio";
                    if (radioButtonSeguridadBajo.Checked == true) seguridad = "Bajo";
                    string text2 = textBoxUsuario.Text + "|" + textBoxContraseña.Text + "|" + textBoxNombre.Text + "|" + seguridad.ToString() + "|";

                    System.IO.StreamWriter file2 = new System.IO.StreamWriter("USU_ELYON.elyon", true);
                    file2.WriteLine(text2);
                    file2.Flush();
                    file2.Close();

                    PanelDatosPersonal panel = new PanelDatosPersonal(opcion,textBoxUsuario.Text, textBoxNombre.Text, textBoxEmailLaboral.Text, textBoxEmailPersonal.Text);
                    panel.Show();
                    this.Close();
                }

            if (opcion == 1)
            {
                editarArchivo(0, obtenerDatos());
                PanelDatosPersonal panel = new PanelDatosPersonal(opcion, textBoxUsuario.Text, textBoxNombre.Text, textBoxEmailLaboral.Text, textBoxEmailPersonal.Text);
                panel.Show();
                this.Close();
            }
        }

        private void reordenarDatos() {
            System.IO.StreamReader fileReader = new System.IO.StreamReader("BDL_ELYON.elyon");
            string espacios = fileReader.ReadToEnd();
            fileReader.Close();

            string[] x = espacios.Split('\n');

            for (int i = 0; i < x.Length; i++)
            {
                string[] y = x[i].Split('|');
                if (y[0] == usuario)
                {
                    textBoxUsuario.Text = usuario;
                    textBoxNombre.Text = y[1];
                    textBoxContraseña.Text = y[2];
                    if (y[3] == "Alto") radioButtonSeguridadAlto.Checked = true;
                    if (y[3] == "Medio") radioButtonSeguridadMedio.Checked = true;
                    if (y[3] == "Bajo") radioButtonSeguridadBajo.Checked = true;
                    textBoxBanco.Text = y[4];
                    textBoxClabe.Text = y[5];
                    textBoxCuenta.Text = y[6];
                    if (y[7] == "Elyon Games") radioButtonElyon.Checked = true;
                    if (y[7] == "Index Code") radioButtonIndex.Checked = true;
                    if (y[7] == "Geek Office") radioButtonGeek.Checked = true;
                    if (y[7] == "Protoware") radioButtonProto.Checked = true;
                    if (y[8] == "Asalariado") radioButtonAsalareado.Checked = true;
                    if (y[8] == "Asimilado") radioButtonAsimilado.Checked = true;
                    if (y[8] == "Honorarios") radioButtonHonorarios.Checked = true;
                    textBoxContratacion1.Text = y[9];
                    textBoxContratacion2.Text = y[10];
                    textBoxContratacion3.Text = y[11];
                    textBoxEmailLaboral.Text = y[12];
                    textBoxEmailPersonal.Text = y[13];
                    textBoxPuesto.Text = y[14];
                    textBoxSueldo.Text = y[15];
                    if (y[16] == "24") radioButtonTurno24.Checked = true;
                    if (y[16] == "48") radioButtonTurno48.Checked = true;
                    textBoxJefe.Text = y[17];
                    textBoxSubordinados.Text = y[18];
                    textBoxBonificaciones.Text = y[19];
                    if (y[20] == "Activo") radioButtonActivo.Checked = true;
                    if (y[20] == "Despedido") radioButtonDespedido.Checked = true;
                    if (y[20] == "Recontratable") radioButtonRecontratable.Checked = true;
                    textBoxIMSS.Text = y[21];
                    if (y[22] == "1") radioButtonActa1.Checked = true;
                    if (y[22] == "2") radioButtonActa2.Checked = true;
                    if (y[22] == "Plan") radioButtonActaPlan.Checked = true;
                    if (y[23] == "1") radioButtonAvisos1.Checked = true;
                    if (y[23] == "2") radioButtonAvisos2.Checked = true;
                    if (y[23] == "3") radioButtonAvisos3.Checked = true;
                }
            }
        }

        private string obtenerDatos(){
            if (textBoxNombre.Text == "" || textBoxUsuario.Text == "" || textBoxContraseña.Text == "" || (radioButtonSeguridadAlto.Checked == false && radioButtonSeguridadMedio.Checked == false && radioButtonSeguridadBajo.Checked == false))
            {
                MessageBox.Show("Es necesario llenar los campos de Nombre, Usuario, Contraseña y Nivel de Seguridad.");
                return "Error";
            }
            else
            {

                string seguridad = "";
                string empresa = "";
                string regimen = "";
                string turno = "";
                string actas = "";
                string avisos = "";
                string status = "";

                if (radioButtonSeguridadAlto.Checked == true) seguridad = "Alto";
                if (radioButtonSeguridadMedio.Checked == true) seguridad = "Medio";
                if (radioButtonSeguridadBajo.Checked == true) seguridad = "Bajo";
                if (radioButtonElyon.Checked == true) empresa = "Elyon Games";
                if (radioButtonIndex.Checked == true) empresa = "Index Code";
                if (radioButtonGeek.Checked == true) empresa = "Geek Office";
                if (radioButtonProto.Checked == true) empresa = "Protoware";
                if (radioButtonAsalareado.Checked == true) regimen = "Asalariado";
                if (radioButtonAsimilado.Checked == true) regimen = "Asimilado";
                if (radioButtonHonorarios.Checked == true) regimen = "Honorarios";
                if (radioButtonTurno24.Checked == true) turno = "24";
                if (radioButtonTurno48.Checked == true) turno = "48";
                if (radioButtonActa1.Checked == true) actas = "1";
                if (radioButtonActa2.Checked == true) actas = "2";
                if (radioButtonActaPlan.Checked == true) actas = "Plan";
                if (radioButtonAvisos1.Checked == true) avisos = "1";
                if (radioButtonAvisos2.Checked == true) avisos = "2";
                if (radioButtonAvisos3.Checked == true) avisos = "3";
                if (radioButtonActivo.Checked == true) status = "Activo";
                if (radioButtonDespedido.Checked == true) status = "Despedido";
                if (radioButtonRecontratable.Checked == true) status = "Recontratable";

                string text = textBoxUsuario.Text + "|" + textBoxNombre.Text + "|" + textBoxContraseña.Text + "|" + seguridad.ToString() + "|" + textBoxBanco.Text + "|" + textBoxClabe.Text + "|" + textBoxCuenta.Text + "|" + empresa.ToString() + "|" + regimen.ToString() + "|" + textBoxContratacion1.Text + "|" + textBoxContratacion2.Text + "|" + textBoxContratacion3.Text + "|" + textBoxEmailLaboral.Text + "|" + textBoxEmailPersonal.Text + "|" + textBoxPuesto.Text + "|" + textBoxSueldo.Text + "|" + turno.ToString() + "|" + textBoxJefe.Text + "|" + textBoxSubordinados.Text + "|" + textBoxBonificaciones.Text + "|" + status.ToString() + "|" + textBoxIMSS.Text + "|" + actas.ToString() + "|" + avisos.ToString() + "|";
                return text;
            }        
        }

        private void editarArchivo(int opcionArchivo, string textoCompleto) {

            string archivo = "" ;
            if (opcionArchivo == 0) archivo = "BDL_ELYON.elyon";
            if (opcionArchivo == 1) archivo = "BDP_ELYON.elyon";
            if (opcionArchivo == 2) archivo = "USU_ELYON.elyon";

            System.IO.StreamReader fileReader = new System.IO.StreamReader(archivo);
            string espacios = fileReader.ReadToEnd();
            fileReader.Close();

            string[] x = espacios.Split('\n');
            for (int i = 0; i < x.Length; i++)
            {
                string[] y = x[i].Split('|');
                if (y[0] == usuario)
                {
                    x[i] = textoCompleto;
                }
            }

            string textoFinal = "";

            for (int i = 0; i < x.Length; i++)
            {
                textoFinal = textoFinal + x[i];
                if (i < (x.Length - 2)) textoFinal += '\n';
            }

            System.IO.StreamWriter file = new System.IO.StreamWriter(archivo, false);
            file.WriteLine(textoFinal);
            file.Flush();
            file.Close();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonImagen_Click(object sender, EventArgs e)
        {
           /* OpenFileDialog ac = new OpenFileDialog();
            ac.Title = "Abrir";
            ac.Filter = "Bitmap files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|JGP files (*.jpg)|*.jpg|All (*.*)|*.* |PNG (*.patito)|*.png ";

            if (ac.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
                System.IO.File.Copy(ac.DefaultExt + ac.FileName, @"Hagi\", true);
            }*/
        }
    }
}
