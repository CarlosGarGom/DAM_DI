namespace Ejercicio01
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            lbIzquierda = new ListBox();
            lbDerecha = new ListBox();
            tbAñadirIzquierda = new TextBox();
            tbAñadirDerecha = new TextBox();
            bAñadirIzquierda = new Button();
            bAñadirDerecha = new Button();
            bMoverDerecha = new Button();
            bMoverDerechaTodos = new Button();
            bMoverIzquierdaTodos = new Button();
            bMoverIzquierda = new Button();
            bCerrar = new Button();
            SuspendLayout();
            // 
            // lbIzquierda
            // 
            lbIzquierda.FormattingEnabled = true;
            lbIzquierda.ItemHeight = 15;
            lbIzquierda.Location = new Point(208, 71);
            lbIzquierda.Name = "lbIzquierda";
            lbIzquierda.SelectionMode = SelectionMode.MultiExtended;
            lbIzquierda.Size = new Size(120, 199);
            lbIzquierda.TabIndex = 0;
            // 
            // lbDerecha
            // 
            lbDerecha.FormattingEnabled = true;
            lbDerecha.ItemHeight = 15;
            lbDerecha.Location = new Point(474, 71);
            lbDerecha.Name = "lbDerecha";
            lbDerecha.SelectionMode = SelectionMode.MultiExtended;
            lbDerecha.Size = new Size(120, 199);
            lbDerecha.TabIndex = 1;
            // 
            // tbAñadirIzquierda
            // 
            tbAñadirIzquierda.Location = new Point(208, 286);
            tbAñadirIzquierda.Name = "tbAñadirIzquierda";
            tbAñadirIzquierda.Size = new Size(120, 23);
            tbAñadirIzquierda.TabIndex = 2;
            // 
            // tbAñadirDerecha
            // 
            tbAñadirDerecha.Location = new Point(474, 286);
            tbAñadirDerecha.Name = "tbAñadirDerecha";
            tbAñadirDerecha.Size = new Size(120, 23);
            tbAñadirDerecha.TabIndex = 3;
            // 
            // bAñadirIzquierda
            // 
            bAñadirIzquierda.Location = new Point(208, 333);
            bAñadirIzquierda.Name = "bAñadirIzquierda";
            bAñadirIzquierda.Size = new Size(120, 33);
            bAñadirIzquierda.TabIndex = 4;
            bAñadirIzquierda.Text = "Añadir";
            bAñadirIzquierda.UseVisualStyleBackColor = true;
            bAñadirIzquierda.Click += bAñadirIzquierda_Click;
            // 
            // bAñadirDerecha
            // 
            bAñadirDerecha.Location = new Point(474, 333);
            bAñadirDerecha.Name = "bAñadirDerecha";
            bAñadirDerecha.Size = new Size(120, 33);
            bAñadirDerecha.TabIndex = 5;
            bAñadirDerecha.Text = "Añadir";
            bAñadirDerecha.UseVisualStyleBackColor = true;
            bAñadirDerecha.Click += bAñadirDerecha_Click;
            // 
            // bMoverDerecha
            // 
            bMoverDerecha.Location = new Point(373, 68);
            bMoverDerecha.Name = "bMoverDerecha";
            bMoverDerecha.Size = new Size(52, 46);
            bMoverDerecha.TabIndex = 6;
            bMoverDerecha.Text = ">";
            bMoverDerecha.UseVisualStyleBackColor = true;
            bMoverDerecha.Click += bMoverDerecha_Click;
            // 
            // bMoverDerechaTodos
            // 
            bMoverDerechaTodos.Location = new Point(373, 120);
            bMoverDerechaTodos.Name = "bMoverDerechaTodos";
            bMoverDerechaTodos.Size = new Size(52, 46);
            bMoverDerechaTodos.TabIndex = 7;
            bMoverDerechaTodos.Text = ">>";
            bMoverDerechaTodos.UseVisualStyleBackColor = true;
            bMoverDerechaTodos.Click += bMoverDerechaTodos_Click;
            // 
            // bMoverIzquierdaTodos
            // 
            bMoverIzquierdaTodos.Location = new Point(373, 172);
            bMoverIzquierdaTodos.Name = "bMoverIzquierdaTodos";
            bMoverIzquierdaTodos.Size = new Size(52, 46);
            bMoverIzquierdaTodos.TabIndex = 8;
            bMoverIzquierdaTodos.Text = "<<";
            bMoverIzquierdaTodos.UseVisualStyleBackColor = true;
            bMoverIzquierdaTodos.Click += bMoverIzquierdaTodos_Click;
            // 
            // bMoverIzquierda
            // 
            bMoverIzquierda.Location = new Point(373, 224);
            bMoverIzquierda.Name = "bMoverIzquierda";
            bMoverIzquierda.Size = new Size(52, 46);
            bMoverIzquierda.TabIndex = 9;
            bMoverIzquierda.Text = "<";
            bMoverIzquierda.UseVisualStyleBackColor = true;
            bMoverIzquierda.Click += bMoverIzquierda_Click;
            // 
            // bCerrar
            // 
            bCerrar.Location = new Point(355, 333);
            bCerrar.Name = "bCerrar";
            bCerrar.Size = new Size(92, 33);
            bCerrar.TabIndex = 10;
            bCerrar.Text = "Cerrar";
            bCerrar.UseVisualStyleBackColor = true;
            bCerrar.Click += bCerrar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bCerrar);
            Controls.Add(bMoverIzquierda);
            Controls.Add(bMoverIzquierdaTodos);
            Controls.Add(bMoverDerechaTodos);
            Controls.Add(bMoverDerecha);
            Controls.Add(bAñadirDerecha);
            Controls.Add(bAñadirIzquierda);
            Controls.Add(tbAñadirDerecha);
            Controls.Add(tbAñadirIzquierda);
            Controls.Add(lbDerecha);
            Controls.Add(lbIzquierda);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ListBox lbIzquierda;
        private ListBox lbDerecha;
        private TextBox tbAñadirIzquierda;
        private TextBox tbAñadirDerecha;
        private Button bAñadirIzquierda;
        private Button bAñadirDerecha;
        private Button bMoverDerecha;
        private Button bMoverDerechaTodos;
        private Button bMoverIzquierdaTodos;
        private Button bMoverIzquierda;
        private Button bCerrar;
    }
}
