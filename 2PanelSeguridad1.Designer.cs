namespace Checador
{
    partial class PanelSeguridad1
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
            this.buttonEditar = new System.Windows.Forms.Button();
            this.buttonHoras = new System.Windows.Forms.Button();
            this.buttonExcepciones = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonEditar
            // 
            this.buttonEditar.Location = new System.Drawing.Point(51, 34);
            this.buttonEditar.Name = "buttonEditar";
            this.buttonEditar.Size = new System.Drawing.Size(75, 23);
            this.buttonEditar.TabIndex = 3;
            this.buttonEditar.Text = "Editar";
            this.buttonEditar.UseVisualStyleBackColor = true;
            this.buttonEditar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // buttonHoras
            // 
            this.buttonHoras.Location = new System.Drawing.Point(51, 63);
            this.buttonHoras.Name = "buttonHoras";
            this.buttonHoras.Size = new System.Drawing.Size(75, 23);
            this.buttonHoras.TabIndex = 4;
            this.buttonHoras.Text = "Horas";
            this.buttonHoras.UseVisualStyleBackColor = true;
            // 
            // buttonExcepciones
            // 
            this.buttonExcepciones.Location = new System.Drawing.Point(41, 94);
            this.buttonExcepciones.Name = "buttonExcepciones";
            this.buttonExcepciones.Size = new System.Drawing.Size(94, 23);
            this.buttonExcepciones.TabIndex = 5;
            this.buttonExcepciones.Text = "Excepciones";
            this.buttonExcepciones.UseVisualStyleBackColor = true;
            // 
            // PanelSeguridad1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(188, 170);
            this.Controls.Add(this.buttonExcepciones);
            this.Controls.Add(this.buttonHoras);
            this.Controls.Add(this.buttonEditar);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PanelSeguridad1";
            this.Text = "Información";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonEditar;
        private System.Windows.Forms.Button buttonHoras;
        private System.Windows.Forms.Button buttonExcepciones;
    }
}