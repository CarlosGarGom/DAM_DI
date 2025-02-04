namespace Ejercicio3
{
    partial class Form1
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
            this.dtFecha = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.rbPrestamo = new System.Windows.Forms.RadioButton();
            this.rbDevolucion = new System.Windows.Forms.RadioButton();
            this.bBuscar = new System.Windows.Forms.Button();
            this.lbResultados = new System.Windows.Forms.ListBox();
            this.SuspendLayout();
            // 
            // dtFecha
            // 
            this.dtFecha.Location = new System.Drawing.Point(94, 61);
            this.dtFecha.Name = "dtFecha";
            this.dtFecha.Size = new System.Drawing.Size(200, 20);
            this.dtFecha.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(37, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Fecha";
            // 
            // rbPrestamo
            // 
            this.rbPrestamo.AutoSize = true;
            this.rbPrestamo.Location = new System.Drawing.Point(94, 113);
            this.rbPrestamo.Name = "rbPrestamo";
            this.rbPrestamo.Size = new System.Drawing.Size(69, 17);
            this.rbPrestamo.TabIndex = 2;
            this.rbPrestamo.TabStop = true;
            this.rbPrestamo.Text = "Prestamo";
            this.rbPrestamo.UseVisualStyleBackColor = true;
            // 
            // rbDevolucion
            // 
            this.rbDevolucion.AutoSize = true;
            this.rbDevolucion.Location = new System.Drawing.Point(209, 113);
            this.rbDevolucion.Name = "rbDevolucion";
            this.rbDevolucion.Size = new System.Drawing.Size(79, 17);
            this.rbDevolucion.TabIndex = 3;
            this.rbDevolucion.TabStop = true;
            this.rbDevolucion.Text = "Devolucion";
            this.rbDevolucion.UseVisualStyleBackColor = true;
            // 
            // bBuscar
            // 
            this.bBuscar.Location = new System.Drawing.Point(219, 153);
            this.bBuscar.Name = "bBuscar";
            this.bBuscar.Size = new System.Drawing.Size(75, 28);
            this.bBuscar.TabIndex = 4;
            this.bBuscar.Text = "Buscar";
            this.bBuscar.UseVisualStyleBackColor = true;
            this.bBuscar.Click += new System.EventHandler(this.bBuscar_Click);
            // 
            // lbResultados
            // 
            this.lbResultados.FormattingEnabled = true;
            this.lbResultados.Location = new System.Drawing.Point(326, 61);
            this.lbResultados.Name = "lbResultados";
            this.lbResultados.Size = new System.Drawing.Size(238, 238);
            this.lbResultados.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lbResultados);
            this.Controls.Add(this.bBuscar);
            this.Controls.Add(this.rbDevolucion);
            this.Controls.Add(this.rbPrestamo);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dtFecha);
            this.Name = "Form1";
            this.Text = "Buscar prestamos por fecha";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DateTimePicker dtFecha;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.RadioButton rbPrestamo;
        private System.Windows.Forms.RadioButton rbDevolucion;
        private System.Windows.Forms.Button bBuscar;
        private System.Windows.Forms.ListBox lbResultados;
    }
}

