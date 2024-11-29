namespace VariosFormularios
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
            bSexo = new Button();
            label1 = new Label();
            lResultado = new TextBox();
            SuspendLayout();
            // 
            // bSexo
            // 
            bSexo.Location = new Point(121, 63);
            bSexo.Name = "bSexo";
            bSexo.Size = new Size(157, 23);
            bSexo.TabIndex = 0;
            bSexo.Text = "Cuadro Sexo";
            bSexo.UseVisualStyleBackColor = true;
            bSexo.Click += bSexo_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 111);
            label1.Name = "label1";
            label1.Size = new Size(80, 15);
            label1.TabIndex = 1;
            label1.Text = "Se ha pulsado";
            // 
            // lResultado
            // 
            lResultado.Location = new Point(121, 108);
            lResultado.Name = "lResultado";
            lResultado.Size = new Size(157, 23);
            lResultado.TabIndex = 3;
            // 
            // Form1
            // 
            AccessibleName = "";
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(451, 265);
            Controls.Add(lResultado);
            Controls.Add(label1);
            Controls.Add(bSexo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button bSexo;
        private Label label1;
        private TextBox lResultado;
    }
}
