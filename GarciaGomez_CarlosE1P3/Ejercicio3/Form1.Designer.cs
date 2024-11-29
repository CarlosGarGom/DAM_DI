namespace Ejercicio3
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
            bAñadir = new Button();
            bEditar = new Button();
            bEliminar = new Button();
            label1 = new Label();
            label2 = new Label();
            tbEspañol = new TextBox();
            tbIngles = new TextBox();
            lbDiccionario = new ListBox();
            bGuardar = new Button();
            bCargar = new Button();
            SuspendLayout();
            // 
            // bAñadir
            // 
            bAñadir.Location = new Point(78, 192);
            bAñadir.Name = "bAñadir";
            bAñadir.Size = new Size(75, 23);
            bAñadir.TabIndex = 0;
            bAñadir.Text = "Añadir";
            bAñadir.UseVisualStyleBackColor = true;
            bAñadir.Click += bAñadir_Click;
            // 
            // bEditar
            // 
            bEditar.Location = new Point(209, 192);
            bEditar.Name = "bEditar";
            bEditar.Size = new Size(75, 23);
            bEditar.TabIndex = 1;
            bEditar.Text = "Editar";
            bEditar.UseVisualStyleBackColor = true;
            bEditar.Click += bEditar_Click;
            // 
            // bEliminar
            // 
            bEliminar.Location = new Point(342, 192);
            bEliminar.Name = "bEliminar";
            bEliminar.Size = new Size(75, 23);
            bEliminar.TabIndex = 2;
            bEliminar.Text = "Eliminar";
            bEliminar.UseVisualStyleBackColor = true;
            bEliminar.Click += bEliminar_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(78, 84);
            label1.Name = "label1";
            label1.Size = new Size(48, 15);
            label1.TabIndex = 3;
            label1.Text = "Español";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(317, 84);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 4;
            label2.Text = "Inglés";
            label2.Click += label2_Click;
            // 
            // tbEspañol
            // 
            tbEspañol.Location = new Point(78, 112);
            tbEspañol.Name = "tbEspañol";
            tbEspañol.Size = new Size(100, 23);
            tbEspañol.TabIndex = 5;
            // 
            // tbIngles
            // 
            tbIngles.Location = new Point(317, 112);
            tbIngles.Name = "tbIngles";
            tbIngles.Size = new Size(100, 23);
            tbIngles.TabIndex = 6;
            // 
            // lbDiccionario
            // 
            lbDiccionario.FormattingEnabled = true;
            lbDiccionario.ItemHeight = 15;
            lbDiccionario.Location = new Point(78, 250);
            lbDiccionario.Name = "lbDiccionario";
            lbDiccionario.Size = new Size(339, 124);
            lbDiccionario.TabIndex = 7;
            // 
            // bGuardar
            // 
            bGuardar.Location = new Point(447, 270);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(75, 23);
            bGuardar.TabIndex = 8;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click;
            // 
            // bCargar
            // 
            bCargar.Location = new Point(447, 315);
            bCargar.Name = "bCargar";
            bCargar.Size = new Size(75, 23);
            bCargar.TabIndex = 9;
            bCargar.Text = "Cargar";
            bCargar.UseVisualStyleBackColor = true;
            bCargar.Click += bCargar_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(bCargar);
            Controls.Add(bGuardar);
            Controls.Add(lbDiccionario);
            Controls.Add(tbIngles);
            Controls.Add(tbEspañol);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(bEliminar);
            Controls.Add(bEditar);
            Controls.Add(bAñadir);
            Name = "Form1";
            Text = "Diccionario";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bAñadir;
        private Button bEditar;
        private Button bEliminar;
        private Label label1;
        private Label label2;
        private TextBox tbEspañol;
        private TextBox tbIngles;
        private ListBox lbDiccionario;
        private Button bGuardar;
        private Button bCargar;
    }
}
