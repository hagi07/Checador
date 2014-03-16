namespace Checador
{
    partial class PanelReportes
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
            this.buttonDatos = new System.Windows.Forms.Button();
            this.buttonQuincena = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // buttonDatos
            // 
            this.buttonDatos.Location = new System.Drawing.Point(44, 57);
            this.buttonDatos.Name = "buttonDatos";
            this.buttonDatos.Size = new System.Drawing.Size(75, 23);
            this.buttonDatos.TabIndex = 0;
            this.buttonDatos.Text = "Personal";
            this.buttonDatos.UseVisualStyleBackColor = true;
            this.buttonDatos.Click += new System.EventHandler(this.buttonDatos_Click);
            // 
            // buttonQuincena
            // 
            this.buttonQuincena.Location = new System.Drawing.Point(44, 86);
            this.buttonQuincena.Name = "buttonQuincena";
            this.buttonQuincena.Size = new System.Drawing.Size(75, 23);
            this.buttonQuincena.TabIndex = 1;
            this.buttonQuincena.Text = "Quincena";
            this.buttonQuincena.UseVisualStyleBackColor = true;
            this.buttonQuincena.Click += new System.EventHandler(this.buttonQuincena_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // PanelReportes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(170, 173);
            this.Controls.Add(this.buttonQuincena);
            this.Controls.Add(this.buttonDatos);
            this.Name = "PanelReportes";
            this.Text = "Reportes";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonDatos;
        private System.Windows.Forms.Button buttonQuincena;
        private System.Windows.Forms.Timer timer1;
    }
}