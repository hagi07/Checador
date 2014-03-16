namespace Checador
{
    partial class PanelFechaQuincenas
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
            this.labelTexto = new System.Windows.Forms.Label();
            this.textBoxFechaInicioDia = new System.Windows.Forms.TextBox();
            this.buttonAceptar = new System.Windows.Forms.Button();
            this.textBoxFechaInicioMes = new System.Windows.Forms.TextBox();
            this.textBoxFechaInicioAño = new System.Windows.Forms.TextBox();
            this.textBoxFechaFinAño = new System.Windows.Forms.TextBox();
            this.textBoxFechaFinMes = new System.Windows.Forms.TextBox();
            this.textBoxFechaFinDia = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // labelTexto
            // 
            this.labelTexto.AutoSize = true;
            this.labelTexto.Location = new System.Drawing.Point(26, 33);
            this.labelTexto.Name = "labelTexto";
            this.labelTexto.Size = new System.Drawing.Size(65, 13);
            this.labelTexto.TabIndex = 0;
            this.labelTexto.Text = "Fecha Inicio";
            // 
            // textBoxFechaInicioDia
            // 
            this.textBoxFechaInicioDia.Location = new System.Drawing.Point(97, 26);
            this.textBoxFechaInicioDia.MaxLength = 2;
            this.textBoxFechaInicioDia.Name = "textBoxFechaInicioDia";
            this.textBoxFechaInicioDia.Size = new System.Drawing.Size(24, 20);
            this.textBoxFechaInicioDia.TabIndex = 1;
            // 
            // buttonAceptar
            // 
            this.buttonAceptar.Location = new System.Drawing.Point(70, 82);
            this.buttonAceptar.Name = "buttonAceptar";
            this.buttonAceptar.Size = new System.Drawing.Size(75, 23);
            this.buttonAceptar.TabIndex = 2;
            this.buttonAceptar.Text = "Aceptar";
            this.buttonAceptar.UseVisualStyleBackColor = true;
            this.buttonAceptar.Click += new System.EventHandler(this.buttonAceptar_Click);
            // 
            // textBoxFechaInicioMes
            // 
            this.textBoxFechaInicioMes.Location = new System.Drawing.Point(127, 26);
            this.textBoxFechaInicioMes.MaxLength = 2;
            this.textBoxFechaInicioMes.Name = "textBoxFechaInicioMes";
            this.textBoxFechaInicioMes.Size = new System.Drawing.Size(24, 20);
            this.textBoxFechaInicioMes.TabIndex = 3;
            // 
            // textBoxFechaInicioAño
            // 
            this.textBoxFechaInicioAño.Location = new System.Drawing.Point(157, 26);
            this.textBoxFechaInicioAño.MaxLength = 4;
            this.textBoxFechaInicioAño.Name = "textBoxFechaInicioAño";
            this.textBoxFechaInicioAño.Size = new System.Drawing.Size(39, 20);
            this.textBoxFechaInicioAño.TabIndex = 4;
            // 
            // textBoxFechaFinAño
            // 
            this.textBoxFechaFinAño.Location = new System.Drawing.Point(157, 52);
            this.textBoxFechaFinAño.MaxLength = 4;
            this.textBoxFechaFinAño.Name = "textBoxFechaFinAño";
            this.textBoxFechaFinAño.Size = new System.Drawing.Size(39, 20);
            this.textBoxFechaFinAño.TabIndex = 8;
            // 
            // textBoxFechaFinMes
            // 
            this.textBoxFechaFinMes.Location = new System.Drawing.Point(127, 52);
            this.textBoxFechaFinMes.MaxLength = 2;
            this.textBoxFechaFinMes.Name = "textBoxFechaFinMes";
            this.textBoxFechaFinMes.Size = new System.Drawing.Size(24, 20);
            this.textBoxFechaFinMes.TabIndex = 7;
            // 
            // textBoxFechaFinDia
            // 
            this.textBoxFechaFinDia.Location = new System.Drawing.Point(97, 52);
            this.textBoxFechaFinDia.MaxLength = 2;
            this.textBoxFechaFinDia.Name = "textBoxFechaFinDia";
            this.textBoxFechaFinDia.Size = new System.Drawing.Size(24, 20);
            this.textBoxFechaFinDia.TabIndex = 6;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(26, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(54, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Fecha Fin";
            // 
            // PanelFechaQuincenas
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(208, 117);
            this.Controls.Add(this.textBoxFechaFinAño);
            this.Controls.Add(this.textBoxFechaFinMes);
            this.Controls.Add(this.textBoxFechaFinDia);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBoxFechaInicioAño);
            this.Controls.Add(this.textBoxFechaInicioMes);
            this.Controls.Add(this.buttonAceptar);
            this.Controls.Add(this.textBoxFechaInicioDia);
            this.Controls.Add(this.labelTexto);
            this.Name = "PanelFechaQuincenas";
            this.Text = "Buga Buga";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label labelTexto;
        private System.Windows.Forms.TextBox textBoxFechaInicioDia;
        private System.Windows.Forms.Button buttonAceptar;
        private System.Windows.Forms.TextBox textBoxFechaInicioMes;
        private System.Windows.Forms.TextBox textBoxFechaInicioAño;
        private System.Windows.Forms.TextBox textBoxFechaFinAño;
        private System.Windows.Forms.TextBox textBoxFechaFinMes;
        private System.Windows.Forms.TextBox textBoxFechaFinDia;
        private System.Windows.Forms.Label label2;
    }
}