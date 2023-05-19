namespace Examen_3_Impares_y_Pares
{
    partial class ImparesPares
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
            this.label1 = new System.Windows.Forms.Label();
            this.ListImpares = new System.Windows.Forms.ListBox();
            this.Generar = new System.Windows.Forms.Button();
            this.ListTodos = new System.Windows.Forms.ListBox();
            this.todos = new System.Windows.Forms.Label();
            this.ListPares = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(40, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Impares";
            // 
            // ListImpares
            // 
            this.ListImpares.FormattingEnabled = true;
            this.ListImpares.Location = new System.Drawing.Point(12, 33);
            this.ListImpares.Name = "ListImpares";
            this.ListImpares.Size = new System.Drawing.Size(120, 160);
            this.ListImpares.TabIndex = 1;
            // 
            // Generar
            // 
            this.Generar.Location = new System.Drawing.Point(198, 210);
            this.Generar.Name = "Generar";
            this.Generar.Size = new System.Drawing.Size(75, 23);
            this.Generar.TabIndex = 2;
            this.Generar.Text = "Generar Numeros";
            this.Generar.UseVisualStyleBackColor = true;
            this.Generar.Click += new System.EventHandler(this.Generar_Click);
            // 
            // ListTodos
            // 
            this.ListTodos.FormattingEnabled = true;
            this.ListTodos.Location = new System.Drawing.Point(179, 33);
            this.ListTodos.Name = "ListTodos";
            this.ListTodos.Size = new System.Drawing.Size(120, 160);
            this.ListTodos.TabIndex = 4;
            // 
            // todos
            // 
            this.todos.AutoSize = true;
            this.todos.Location = new System.Drawing.Point(207, 9);
            this.todos.Name = "todos";
            this.todos.Size = new System.Drawing.Size(37, 13);
            this.todos.TabIndex = 3;
            this.todos.Text = "Todos";
            // 
            // ListPares
            // 
            this.ListPares.FormattingEnabled = true;
            this.ListPares.Location = new System.Drawing.Point(346, 33);
            this.ListPares.Name = "ListPares";
            this.ListPares.Size = new System.Drawing.Size(120, 160);
            this.ListPares.TabIndex = 6;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(374, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(79, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Numeros Pares";
            // 
            // ImparesPares
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 245);
            this.Controls.Add(this.ListPares);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.ListTodos);
            this.Controls.Add(this.todos);
            this.Controls.Add(this.Generar);
            this.Controls.Add(this.ListImpares);
            this.Controls.Add(this.label1);
            this.Name = "ImparesPares";
            this.Text = "lista de Impares y Pares";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox ListImpares;
        private System.Windows.Forms.Button Generar;
        private System.Windows.Forms.ListBox ListTodos;
        private System.Windows.Forms.Label todos;
        private System.Windows.Forms.ListBox ListPares;
        private System.Windows.Forms.Label label3;
    }
}

