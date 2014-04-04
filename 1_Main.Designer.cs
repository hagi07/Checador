namespace Checador
{
    partial class Main
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.reloj = new System.Windows.Forms.Timer(this.components);
            this.radioButtonInformacion = new System.Windows.Forms.RadioButton();
            this.buttonSalida = new System.Windows.Forms.Button();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelAvisoTexto = new System.Windows.Forms.Label();
            this.labelTituloAvisos = new System.Windows.Forms.Label();
            this.radioButtonComidaSalida = new System.Windows.Forms.RadioButton();
            this.radioButtonComidaEntrada = new System.Windows.Forms.RadioButton();
            this.radioButtonSalida = new System.Windows.Forms.RadioButton();
            this.radioButtonEntrada = new System.Windows.Forms.RadioButton();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.Dia_Fecha = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.Hora = new System.Windows.Forms.Label();
            this.textBoxAvisos = new System.Windows.Forms.TextBox();
            this.textBoxMensaje = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // reloj
            // 
            this.reloj.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radioButtonInformacion
            // 
            this.radioButtonInformacion.AutoSize = true;
            this.radioButtonInformacion.Location = new System.Drawing.Point(220, 270);
            this.radioButtonInformacion.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonInformacion.Name = "radioButtonInformacion";
            this.radioButtonInformacion.Size = new System.Drawing.Size(102, 21);
            this.radioButtonInformacion.TabIndex = 50;
            this.radioButtonInformacion.TabStop = true;
            this.radioButtonInformacion.Text = "Información";
            this.radioButtonInformacion.UseVisualStyleBackColor = true;
            // 
            // buttonSalida
            // 
            this.buttonSalida.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonSalida.Location = new System.Drawing.Point(49, 242);
            this.buttonSalida.Margin = new System.Windows.Forms.Padding(4);
            this.buttonSalida.Name = "buttonSalida";
            this.buttonSalida.Size = new System.Drawing.Size(100, 28);
            this.buttonSalida.TabIndex = 49;
            this.buttonSalida.Text = "Salida";
            this.buttonSalida.UseVisualStyleBackColor = true;
            this.buttonSalida.Click += new System.EventHandler(this.buttonSalida_Click);
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(65, 166);
            this.labelContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(81, 17);
            this.labelContraseña.TabIndex = 47;
            this.labelContraseña.Text = "Contraseña";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(65, 129);
            this.labelUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(57, 17);
            this.labelUsuario.TabIndex = 46;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelAvisoTexto
            // 
            this.labelAvisoTexto.AutoSize = true;
            this.labelAvisoTexto.Location = new System.Drawing.Point(107, 300);
            this.labelAvisoTexto.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelAvisoTexto.Name = "labelAvisoTexto";
            this.labelAvisoTexto.Size = new System.Drawing.Size(0, 17);
            this.labelAvisoTexto.TabIndex = 44;
            // 
            // labelTituloAvisos
            // 
            this.labelTituloAvisos.AutoSize = true;
            this.labelTituloAvisos.Location = new System.Drawing.Point(57, 308);
            this.labelTituloAvisos.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTituloAvisos.Name = "labelTituloAvisos";
            this.labelTituloAvisos.Size = new System.Drawing.Size(53, 17);
            this.labelTituloAvisos.TabIndex = 43;
            this.labelTituloAvisos.Text = "Avisos:";
            // 
            // radioButtonComidaSalida
            // 
            this.radioButtonComidaSalida.AutoSize = true;
            this.radioButtonComidaSalida.Location = new System.Drawing.Point(266, 243);
            this.radioButtonComidaSalida.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonComidaSalida.Name = "radioButtonComidaSalida";
            this.radioButtonComidaSalida.Size = new System.Drawing.Size(105, 21);
            this.radioButtonComidaSalida.TabIndex = 42;
            this.radioButtonComidaSalida.TabStop = true;
            this.radioButtonComidaSalida.Text = "Ida a Comer";
            this.radioButtonComidaSalida.UseVisualStyleBackColor = true;
            // 
            // radioButtonComidaEntrada
            // 
            this.radioButtonComidaEntrada.AutoSize = true;
            this.radioButtonComidaEntrada.Location = new System.Drawing.Point(266, 214);
            this.radioButtonComidaEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonComidaEntrada.Name = "radioButtonComidaEntrada";
            this.radioButtonComidaEntrada.Size = new System.Drawing.Size(148, 21);
            this.radioButtonComidaEntrada.TabIndex = 41;
            this.radioButtonComidaEntrada.TabStop = true;
            this.radioButtonComidaEntrada.Text = "Regreso de Comer";
            this.radioButtonComidaEntrada.UseVisualStyleBackColor = true;
            // 
            // radioButtonSalida
            // 
            this.radioButtonSalida.AutoSize = true;
            this.radioButtonSalida.Location = new System.Drawing.Point(179, 242);
            this.radioButtonSalida.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonSalida.Name = "radioButtonSalida";
            this.radioButtonSalida.Size = new System.Drawing.Size(68, 21);
            this.radioButtonSalida.TabIndex = 40;
            this.radioButtonSalida.TabStop = true;
            this.radioButtonSalida.Text = "Salida";
            this.radioButtonSalida.UseVisualStyleBackColor = true;
            // 
            // radioButtonEntrada
            // 
            this.radioButtonEntrada.AutoSize = true;
            this.radioButtonEntrada.Location = new System.Drawing.Point(179, 214);
            this.radioButtonEntrada.Margin = new System.Windows.Forms.Padding(4);
            this.radioButtonEntrada.Name = "radioButtonEntrada";
            this.radioButtonEntrada.Size = new System.Drawing.Size(79, 21);
            this.radioButtonEntrada.TabIndex = 39;
            this.radioButtonEntrada.TabStop = true;
            this.radioButtonEntrada.Text = "Entrada";
            this.radioButtonEntrada.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.buttonAceptar.Location = new System.Drawing.Point(49, 206);
            this.buttonAceptar.Margin = new System.Windows.Forms.Padding(4);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(100, 28);
            this.buttonAceptar.TabIndex = 38;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // Dia_Fecha
            // 
            this.Dia_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dia_Fecha.Location = new System.Drawing.Point(44, 19);
            this.Dia_Fecha.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Dia_Fecha.Name = "Dia_Fecha";
            this.Dia_Fecha.Size = new System.Drawing.Size(120, 34);
            this.Dia_Fecha.TabIndex = 37;
            this.Dia_Fecha.Text = "12/12/12";
            this.Dia_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(155, 157);
            this.textBoxContraseña.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '•';
            this.textBoxContraseña.Size = new System.Drawing.Size(208, 22);
            this.textBoxContraseña.TabIndex = 36;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(155, 120);
            this.textBoxUsuario.Margin = new System.Windows.Forms.Padding(4);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(208, 22);
            this.textBoxUsuario.TabIndex = 35;
            // 
            // Hora
            // 
            this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(303, 19);
            this.Hora.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(127, 33);
            this.Hora.TabIndex = 34;
            this.Hora.Text = "01:00:00";
            this.Hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxAvisos
            // 
            this.textBoxAvisos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxAvisos.Location = new System.Drawing.Point(88, 328);
            this.textBoxAvisos.Multiline = true;
            this.textBoxAvisos.Name = "textBoxAvisos";
            this.textBoxAvisos.Size = new System.Drawing.Size(295, 64);
            this.textBoxAvisos.TabIndex = 51;
            this.textBoxAvisos.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBoxMensaje
            // 
            this.textBoxMensaje.AccessibleDescription = "AccedeTextoMensaje";
            this.textBoxMensaje.AccessibleName = "TextoMensaje";
            this.textBoxMensaje.AccessibleRole = System.Windows.Forms.AccessibleRole.Text;
            this.textBoxMensaje.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.textBoxMensaje.Location = new System.Drawing.Point(73, 74);
            this.textBoxMensaje.Multiline = true;
            this.textBoxMensaje.Name = "textBoxMensaje";
            this.textBoxMensaje.Size = new System.Drawing.Size(334, 32);
            this.textBoxMensaje.TabIndex = 52;
            this.textBoxMensaje.Tag = "MensajeText";
            this.textBoxMensaje.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
//            this.BackgroundImage = global::Checador.Properties.Resources.ventanas_09;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.CancelButton = this.buttonSalida;
            this.ClientSize = new System.Drawing.Size(467, 411);
            this.ControlBox = false;
            this.Controls.Add(this.textBoxMensaje);
            this.Controls.Add(this.textBoxAvisos);
            this.Controls.Add(this.radioButtonInformacion);
            this.Controls.Add(this.buttonSalida);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelAvisoTexto);
            this.Controls.Add(this.labelTituloAvisos);
            this.Controls.Add(this.radioButtonComidaSalida);
            this.Controls.Add(this.radioButtonComidaEntrada);
            this.Controls.Add(this.radioButtonSalida);
            this.Controls.Add(this.radioButtonEntrada);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.Dia_Fecha);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.Hora);
            this.DoubleBuffered = true;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Main";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.Text = "Buga Buga";
            this.TopMost = true;
            this.TransparencyKey = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(255)))));
            this.Load += new System.EventHandler(this.Fondo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Timer reloj;
        private System.Windows.Forms.RadioButton radioButtonInformacion;
        private System.Windows.Forms.Button buttonSalida;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelAvisoTexto;
        private System.Windows.Forms.Label labelTituloAvisos;
        private System.Windows.Forms.RadioButton radioButtonComidaSalida;
        private System.Windows.Forms.RadioButton radioButtonComidaEntrada;
        private System.Windows.Forms.RadioButton radioButtonSalida;
        private System.Windows.Forms.RadioButton radioButtonEntrada;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label Dia_Fecha;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label Hora;
        private System.Windows.Forms.TextBox textBoxAvisos;
        private System.Windows.Forms.TextBox textBoxMensaje;
    }
}