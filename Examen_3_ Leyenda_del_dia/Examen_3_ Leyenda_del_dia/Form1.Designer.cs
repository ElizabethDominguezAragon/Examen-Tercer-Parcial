namespace Examen_3__Leyenda_del_dia
{
    partial class LeyendaDia
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.DTP_fecha = new System.Windows.Forms.DateTimePicker();
            this.Generar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // DTP_fecha
            // 
            this.DTP_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.DTP_fecha.Location = new System.Drawing.Point(111, 27);
            this.DTP_fecha.Name = "DTP_fecha";
            this.DTP_fecha.Size = new System.Drawing.Size(111, 20);
            this.DTP_fecha.TabIndex = 0;
            this.DTP_fecha.ValueChanged += new System.EventHandler(this.DTP_fecha_ValueChanged);
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(126, 53);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(75, 23);
            this.Generar.TabIndex = 1;
            this.Generar.Text = "Generar";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.button1_Click);
            // 
            // LeyendaDia
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(323, 88);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.DTP_fecha);
            this.Name = "LeyendaDia";
            this.Text = "Leyenda del Dia";
            this.Load += new System.EventHandler(this.LeyendaDia_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DateTimePicker DTP_fecha;
        private System.Windows.Forms.Button Generar;
    }
}

