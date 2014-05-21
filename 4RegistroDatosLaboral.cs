using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net.Mail;
using System.IO;
using System.Drawing.Imaging;

namespace Checador
{
    public partial class PanelRegistroDatosLaboral : Form
    {
        private string opcion;
        private string usuario;
        private string nivel;
        Util util = new Util();

        public PanelRegistroDatosLaboral(string op, string usu, string n)
        {
            InitializeComponent();
            opcion = op;
            usuario = usu;
            nivel = n;

            if (opcion == "Editar")
                reordenarDatos();
            if (!Directory.Exists(usuario))
                pictureBoxImagen.Image = Image.FromFile(@"NoProfile.jpg");
            else
                pictureBoxImagen.Image = Image.FromFile(@usuario + "/" + usuario + ".jpg");
        }


        private void buttonSiguiente_Click(object sender, EventArgs e)
        {
            if (textBoxNombre.Text == "" || textBoxUsuario.Text == "" || textBoxContraseña.Text == "" || (radioButtonSeguridadAlto.Checked == false && radioButtonSeguridadMedio.Checked == false && radioButtonSeguridadBajo.Checked == false))
            {
                MessageBox.Show("Es necesario llenar los campos de Nombre, Usuario, Contraseña y Nivel de Seguridad.");
            }
            else
            {
                if (opcion == "Crear")
                {
                    System.IO.StreamWriter file = new System.IO.StreamWriter("BDL_ELYON.elyon", true);
                    file.WriteLine(obtenerDatos());
                    file.Flush();
                    file.Close();

                    string seguridad = "";
                    if (radioButtonSeguridadAlto.Checked == true) seguridad = "Alto";
                    if (radioButtonSeguridadMedio.Checked == true) seguridad = "Medio";
                    if (radioButtonSeguridadBajo.Checked == true) seguridad = "Bajo";

                    System.IO.StreamWriter file2 = new System.IO.StreamWriter("USU_ELYON.elyon", true);
                    file2.WriteLine(textBoxUsuario.Text + "|" + textBoxContraseña.Text + "|" + textBoxNombre.Text + "|" + seguridad.ToString() + "|");
                    file2.Flush();
                    file2.Close();

                    PanelDatosPersonal panel = new PanelDatosPersonal(opcion, nivel, textBoxUsuario.Text, textBoxNombre.Text, textBoxEmailLaboral.Text, textBoxEmailPersonal.Text);
                    panel.Show();
                    this.Close();

                    if (nivel == "Medio")
                    {
                        util.SMTPMail("renehagi@gmail.com", "Actividades", "Se realizó la actividad de creación de usuario por " + usuario + ".");
                    }
                }

                if (opcion == "Editar")
                {
                    string seguridad = "";
                    if (radioButtonSeguridadAlto.Checked == true) seguridad = "Alto";
                    if (radioButtonSeguridadMedio.Checked == true) seguridad = "Medio";
                    if (radioButtonSeguridadBajo.Checked == true) seguridad = "Bajo";
                    editarArchivo(0, obtenerDatos());
                    editarArchivo(2, textBoxUsuario.Text + "|" + textBoxContraseña.Text + "|" + textBoxNombre.Text + "|" + seguridad + "|" + Environment.NewLine);
                    PanelDatosPersonal panel = new PanelDatosPersonal(opcion, nivel, textBoxUsuario.Text, textBoxNombre.Text, textBoxEmailLaboral.Text, textBoxEmailPersonal.Text);
                    panel.Show();
                    this.Close();
                }
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
                if (y.Length >= 2)
                {
                    if (y[1] == usuario)
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
                        if (y[22] == "0") radioButtonActa0.Checked = true;
                        if (y[22] == "1") radioButtonActa1.Checked = true;
                        if (y[22] == "2") radioButtonActa2.Checked = true;
                        if (y[22] == "Plan") radioButtonActaPlan.Checked = true;
                        if (y[23] == "0") radioButtonAvisos0.Checked = true;
                        if (y[23] == "1") radioButtonAvisos1.Checked = true;
                        if (y[23] == "2") radioButtonAvisos2.Checked = true;
                        if (y[23] == "3") radioButtonAvisos3.Checked = true;
                    }
                }
            }
        }

        private string obtenerDatos()
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
            if (radioButtonActa0.Checked == true) actas = "0";
            if (radioButtonActa1.Checked == true) actas = "1";
            if (radioButtonActa2.Checked == true) actas = "2";
            if (radioButtonActaPlan.Checked == true) actas = "Plan";
            if (radioButtonAvisos0.Checked == true) avisos = "0";
            if (radioButtonAvisos1.Checked == true) avisos = "1";
            if (radioButtonAvisos2.Checked == true) avisos = "2";
            if (radioButtonAvisos3.Checked == true) avisos = "3";
            if (radioButtonActivo.Checked == true) status = "Activo";
            if (radioButtonDespedido.Checked == true) status = "Despedido";
            if (radioButtonRecontratable.Checked == true) status = "Recontratable";

            string text = textBoxUsuario.Text + "|" + textBoxNombre.Text + "|" + textBoxContraseña.Text + "|" + seguridad.ToString() + "|" + textBoxBanco.Text + "|" + textBoxClabe.Text + "|" + textBoxCuenta.Text + "|" + empresa.ToString() + "|" + regimen.ToString() + "|" + textBoxContratacion1.Text + "|" + textBoxContratacion2.Text + "|" + textBoxContratacion3.Text + "|" + textBoxEmailLaboral.Text + "|" + textBoxEmailPersonal.Text + "|" + textBoxPuesto.Text + "|" + textBoxSueldo.Text + "|" + turno.ToString() + "|" + textBoxJefe.Text + "|" + textBoxSubordinados.Text + "|" + textBoxBonificaciones.Text + "|" + status.ToString() + "|" + textBoxIMSS.Text + "|" + actas.ToString() + "|" + avisos.ToString() + "|";
            return text;

        }

        private void editarArchivo(int opcionArchivo, string textoCompleto) {

            string archivo = "" ;
            if (opcionArchivo == 0) archivo = "BDL_ELYON.elyon";
            if (opcionArchivo == 1) archivo = "BDP_ELYON.elyon";
            if (opcionArchivo == 2) archivo = "USU_ELYON.elyon";

            string[] x = util.textoDeArchivoConSplit(archivo, '\n');
                
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
            OpenFileDialog openfiledlg1 = new OpenFileDialog();

            string archivo;
            //Definimos los filtros de archivos a permitir, en este caso imagenes
            openfiledlg1.Filter = "Bitmap files (*.bmp)|*.bmp|Gif files (*.gif)|*.gif|JGP files (*.jpg)|*.jpg|All (*.*)|*.* |PNG (*.patito)|*.png ";
            ///Establece que filtro se mostrará por deceto en este caso, 3=jpg
            openfiledlg1.FilterIndex = 3;

            //El titulo de la Ventana....
            openfiledlg1.Title = "Imagen";

            /// Evalúa que si al aparecer el cuadro de dialogo la persona presionó Ok
            if (openfiledlg1.ShowDialog() == DialogResult.OK)
            {
                // Si esto se cumple, capturamos la propiedad File Name y la guardamos en la variable
                archivo = openfiledlg1.FileName;
                //Por ultimo se la asignamos al PictureBox
                pictureBoxImagen.Image = Image.FromFile(@archivo);

                //Crea una carpeta para el usuario si no existe.
                if(!Directory.Exists(usuario))
                    Directory.CreateDirectory(usuario);
                //Guarda la imagen como jpg con el nombre del usuario.
                pictureBoxImagen.Image.Save(@usuario + "/" + usuario + ".jpg", ImageFormat.Jpeg);
            }          
        }

        

    }
}
