namespace VariosFormularios
{
    partial class Form2
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
            rbMasculino = new RadioButton();
            rbFemenino = new RadioButton();
            bAceptar = new Button();
            bCancelar = new Button();
            SuspendLayout();
            // 
            // rbMasculino
            // 
            rbMasculino.AutoSize = true;
            rbMasculino.Location = new Point(88, 67);
            rbMasculino.Name = "rbMasculino";
            rbMasculino.Size = new Size(80, 19);
            rbMasculino.TabIndex = 0;
            rbMasculino.TabStop = true;
            rbMasculino.Text = "Masculino";
            rbMasculino.UseVisualStyleBackColor = true;
            // 
            // rbFemenino
            // 
            rbFemenino.AutoSize = true;
            rbFemenino.Location = new Point(218, 67);
            rbFemenino.Name = "rbFemenino";
            rbFemenino.Size = new Size(78, 19);
            rbFemenino.TabIndex = 1;
            rbFemenino.TabStop = true;
            rbFemenino.Text = "Femenino";
            rbFemenino.UseVisualStyleBackColor = true;
            // 
            // bAceptar
            // 
            bAceptar.Location = new Point(88, 116);
            bAceptar.Name = "bAceptar";
            bAceptar.Size = new Size(75, 23);
            bAceptar.TabIndex = 2;
            bAceptar.Text = "Aceptar";
            bAceptar.UseVisualStyleBackColor = true;
            bAceptar.Click += bAceptar_Click;
            // 
            // bCancelar
            // 
            bCancelar.Location = new Point(218, 116);
            bCancelar.Name = "bCancelar";
            bCancelar.Size = new Size(75, 23);
            bCancelar.TabIndex = 3;
            bCancelar.Text = "Cancelar";
            bCancelar.UseVisualStyleBackColor = true;
            bCancelar.Click += bCancelar_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(733, 339);
            Controls.Add(bCancelar);
            Controls.Add(bAceptar);
            Controls.Add(rbFemenino);
            Controls.Add(rbMasculino);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        public RadioButton rbMasculino;
        public RadioButton rbFemenino;
        private Button bAceptar;
        private Button bCancelar;
    }
}