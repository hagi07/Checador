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
            this.buttonReportes = new System.Windows.Forms.Button();
            this.buttonHoras = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonReportes
            // 
            this.buttonReportes.Location = new System.Drawing.Point(72, 123);
            this.buttonReportes.Name = "buttonReportes";
            this.buttonReportes.Size = new System.Drawing.Size(75, 23);
            this.buttonReportes.TabIndex = 6;
            this.buttonReportes.Text = "Reportes";
            this.buttonReportes.UseVisualStyleBackColor = true;
            // 
            // buttonHoras
            // 
            this.buttonHoras.Location = new System.Drawing.Point(72, 36);
            this.buttonHoras.Name = "buttonHoras";
            this.buttonHoras.Size = new System.Drawing.Size(75, 23);
            this.buttonHoras.TabIndex = 5;
            this.buttonHoras.Text = "Horas";
            this.buttonHoras.UseVisualStyleBackColor = true;
            this.buttonHoras.Click += new System.EventHandler(this.buttonHoras_Click);
            // 
            // PanelSeguridad1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(229, 196);
            this.Controls.Add(this.buttonReportes);
            this.Controls.Add(this.buttonHoras);
            this.Cursor = System.Windows.Forms.Cursors.PanSE;
            this.Name = "PanelSeguridad1";
            this.Text = "Usuario";
            this.TopMost = true;
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonReportes;
        private System.Windows.Forms.Button buttonHoras;
    }
}