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
            this.labelMensaje = new System.Windows.Forms.Label();
            this.labelContraseña = new System.Windows.Forms.Label();
            this.labelUsuario = new System.Windows.Forms.Label();
            this.labelAvisoTexto = new System.Windows.Forms.Label();
            this.labelAvisosLabel = new System.Windows.Forms.Label();
            this.radioButtonComidaSalida = new System.Windows.Forms.RadioButton();
            this.radioButtonComidaEntrada = new System.Windows.Forms.RadioButton();
            this.radioButtonSalida = new System.Windows.Forms.RadioButton();
            this.radioButtonEntrada = new System.Windows.Forms.RadioButton();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.Dia_Fecha = new System.Windows.Forms.Label();
            this.textBoxContraseña = new System.Windows.Forms.TextBox();
            this.textBoxUsuario = new System.Windows.Forms.TextBox();
            this.Hora = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // reloj
            // 
            this.reloj.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // radioButtonInformacion
            // 
            this.radioButtonInformacion.AutoSize = true;
            this.radioButtonInformacion.Location = new System.Drawing.Point(144, 213);
            this.radioButtonInformacion.Name = "radioButtonInformacion";
            this.radioButtonInformacion.Size = new System.Drawing.Size(80, 17);
            this.radioButtonInformacion.TabIndex = 50;
            this.radioButtonInformacion.TabStop = true;
            this.radioButtonInformacion.Text = "Información";
            this.radioButtonInformacion.UseVisualStyleBackColor = true;
            // 
            // buttonSalida
            // 
            this.buttonSalida.Location = new System.Drawing.Point(16, 190);
            this.buttonSalida.Name = "buttonSalida";
            this.buttonSalida.Size = new System.Drawing.Size(75, 23);
            this.buttonSalida.TabIndex = 49;
            this.buttonSalida.Text = "Salida";
            this.buttonSalida.UseVisualStyleBackColor = true;
            this.buttonSalida.Click += new System.EventHandler(this.buttonSalida_Click);
            // 
            // labelMensaje
            // 
            this.labelMensaje.AutoSize = true;
            this.labelMensaje.Location = new System.Drawing.Point(132, 57);
            this.labelMensaje.Name = "labelMensaje";
            this.labelMensaje.Size = new System.Drawing.Size(47, 13);
            this.labelMensaje.TabIndex = 48;
            this.labelMensaje.Text = "Mensaje";
            // 
            // labelContraseña
            // 
            this.labelContraseña.AutoSize = true;
            this.labelContraseña.Location = new System.Drawing.Point(28, 128);
            this.labelContraseña.Name = "labelContraseña";
            this.labelContraseña.Size = new System.Drawing.Size(61, 13);
            this.labelContraseña.TabIndex = 47;
            this.labelContraseña.Text = "Contraseña";
            // 
            // labelUsuario
            // 
            this.labelUsuario.AutoSize = true;
            this.labelUsuario.Location = new System.Drawing.Point(28, 98);
            this.labelUsuario.Name = "labelUsuario";
            this.labelUsuario.Size = new System.Drawing.Size(43, 13);
            this.labelUsuario.TabIndex = 46;
            this.labelUsuario.Text = "Usuario";
            // 
            // labelAvisoTexto
            // 
            this.labelAvisoTexto.AutoSize = true;
            this.labelAvisoTexto.Location = new System.Drawing.Point(80, 244);
            this.labelAvisoTexto.Name = "labelAvisoTexto";
            this.labelAvisoTexto.Size = new System.Drawing.Size(0, 13);
            this.labelAvisoTexto.TabIndex = 44;
            // 
            // labelAvisosLabel
            // 
            this.labelAvisosLabel.AutoSize = true;
            this.labelAvisosLabel.Location = new System.Drawing.Point(22, 244);
            this.labelAvisosLabel.Name = "labelAvisosLabel";
            this.labelAvisosLabel.Size = new System.Drawing.Size(41, 13);
            this.labelAvisosLabel.TabIndex = 43;
            this.labelAvisosLabel.Text = "Avisos:";
            // 
            // radioButtonComidaSalida
            // 
            this.radioButtonComidaSalida.AutoSize = true;
            this.radioButtonComidaSalida.Location = new System.Drawing.Point(172, 190);
            this.radioButtonComidaSalida.Name = "radioButtonComidaSalida";
            this.radioButtonComidaSalida.Size = new System.Drawing.Size(92, 17);
            this.radioButtonComidaSalida.TabIndex = 42;
            this.radioButtonComidaSalida.TabStop = true;
            this.radioButtonComidaSalida.Text = "Comida Salida";
            this.radioButtonComidaSalida.UseVisualStyleBackColor = true;
            // 
            // radioButtonComidaEntrada
            // 
            this.radioButtonComidaEntrada.AutoSize = true;
            this.radioButtonComidaEntrada.Location = new System.Drawing.Point(172, 167);
            this.radioButtonComidaEntrada.Name = "radioButtonComidaEntrada";
            this.radioButtonComidaEntrada.Size = new System.Drawing.Size(100, 17);
            this.radioButtonComidaEntrada.TabIndex = 41;
            this.radioButtonComidaEntrada.TabStop = true;
            this.radioButtonComidaEntrada.Text = "Comida Entrada";
            this.radioButtonComidaEntrada.UseVisualStyleBackColor = true;
            // 
            // radioButtonSalida
            // 
            this.radioButtonSalida.AutoSize = true;
            this.radioButtonSalida.Location = new System.Drawing.Point(113, 190);
            this.radioButtonSalida.Name = "radioButtonSalida";
            this.radioButtonSalida.Size = new System.Drawing.Size(54, 17);
            this.radioButtonSalida.TabIndex = 40;
            this.radioButtonSalida.TabStop = true;
            this.radioButtonSalida.Text = "Salida";
            this.radioButtonSalida.UseVisualStyleBackColor = true;
            // 
            // radioButtonEntrada
            // 
            this.radioButtonEntrada.AutoSize = true;
            this.radioButtonEntrada.Location = new System.Drawing.Point(113, 167);
            this.radioButtonEntrada.Name = "radioButtonEntrada";
            this.radioButtonEntrada.Size = new System.Drawing.Size(62, 17);
            this.radioButtonEntrada.TabIndex = 39;
            this.radioButtonEntrada.TabStop = true;
            this.radioButtonEntrada.Text = "Entrada";
            this.radioButtonEntrada.UseVisualStyleBackColor = true;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(16, 161);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 38;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // Dia_Fecha
            // 
            this.Dia_Fecha.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Dia_Fecha.Location = new System.Drawing.Point(12, 9);
            this.Dia_Fecha.Name = "Dia_Fecha";
            this.Dia_Fecha.Size = new System.Drawing.Size(90, 28);
            this.Dia_Fecha.TabIndex = 37;
            this.Dia_Fecha.Text = "12/12/12";
            this.Dia_Fecha.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // textBoxContraseña
            // 
            this.textBoxContraseña.Location = new System.Drawing.Point(95, 121);
            this.textBoxContraseña.Name = "textBoxContraseña";
            this.textBoxContraseña.PasswordChar = '•';
            this.textBoxContraseña.Size = new System.Drawing.Size(157, 20);
            this.textBoxContraseña.TabIndex = 36;
            // 
            // textBoxUsuario
            // 
            this.textBoxUsuario.Location = new System.Drawing.Point(95, 91);
            this.textBoxUsuario.Name = "textBoxUsuario";
            this.textBoxUsuario.Size = new System.Drawing.Size(157, 20);
            this.textBoxUsuario.TabIndex = 35;
            // 
            // Hora
            // 
            this.Hora.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Hora.Location = new System.Drawing.Point(206, 9);
            this.Hora.Name = "Hora";
            this.Hora.Size = new System.Drawing.Size(95, 27);
            this.Hora.TabIndex = 34;
            this.Hora.Text = "01:00:00";
            this.Hora.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(309, 286);
            this.ControlBox = false;
            this.Controls.Add(this.radioButtonInformacion);
            this.Controls.Add(this.buttonSalida);
            this.Controls.Add(this.labelMensaje);
            this.Controls.Add(this.labelContraseña);
            this.Controls.Add(this.labelUsuario);
            this.Controls.Add(this.labelAvisoTexto);
            this.Controls.Add(this.labelAvisosLabel);
            this.Controls.Add(this.radioButtonComidaSalida);
            this.Controls.Add(this.radioButtonComidaEntrada);
            this.Controls.Add(this.radioButtonSalida);
            this.Controls.Add(this.radioButtonEntrada);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.Dia_Fecha);
            this.Controls.Add(this.textBoxContraseña);
            this.Controls.Add(this.textBoxUsuario);
            this.Controls.Add(this.Hora);
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
        private System.Windows.Forms.Label labelMensaje;
        private System.Windows.Forms.Label labelContraseña;
        private System.Windows.Forms.Label labelUsuario;
        private System.Windows.Forms.Label labelAvisoTexto;
        private System.Windows.Forms.Label labelAvisosLabel;
        private System.Windows.Forms.RadioButton radioButtonComidaSalida;
        private System.Windows.Forms.RadioButton radioButtonComidaEntrada;
        private System.Windows.Forms.RadioButton radioButtonSalida;
        private System.Windows.Forms.RadioButton radioButtonEntrada;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.Label Dia_Fecha;
        private System.Windows.Forms.TextBox textBoxContraseña;
        private System.Windows.Forms.TextBox textBoxUsuario;
        private System.Windows.Forms.Label Hora;
    }
}