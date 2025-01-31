namespace LeerXML_Precipitaciones
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
            label1 = new Label();
            label2 = new Label();
            bVisualizar = new Button();
            cmbFechas = new ComboBox();
            cmbProvincias = new ComboBox();
            label3 = new Label();
            label4 = new Label();
            lblPeriodo1 = new Label();
            lblPeriodo2 = new Label();
            lblPeriodo3 = new Label();
            lblPeriodo4 = new Label();
            lblPeriodo5 = new Label();
            lblPrecipitacion1 = new Label();
            lblPrecipitacion2 = new Label();
            lblPrecipitacion3 = new Label();
            lblPrecipitacion4 = new Label();
            lblPrecipitacion5 = new Label();
            lblPeriodo6 = new Label();
            lblPrecipitacion6 = new Label();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(41, 30);
            label1.Name = "label1";
            label1.Size = new Size(131, 15);
            label1.TabIndex = 0;
            label1.Text = "Seleccionar la provincia";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(346, 33);
            label2.Name = "label2";
            label2.Size = new Size(111, 15);
            label2.TabIndex = 1;
            label2.Text = "Seleccionar la fecha";
            // 
            // bVisualizar
            // 
            bVisualizar.Location = new Point(631, 29);
            bVisualizar.Name = "bVisualizar";
            bVisualizar.Size = new Size(75, 23);
            bVisualizar.TabIndex = 2;
            bVisualizar.Text = "Visualizar";
            bVisualizar.UseVisualStyleBackColor = true;
            bVisualizar.Click += bVisualizar_Click;
            // 
            // cmbFechas
            // 
            cmbFechas.FormattingEnabled = true;
            cmbFechas.Location = new Point(484, 30);
            cmbFechas.Name = "cmbFechas";
            cmbFechas.Size = new Size(121, 23);
            cmbFechas.TabIndex = 3;
            // 
            // cmbProvincias
            // 
            cmbProvincias.FormattingEnabled = true;
            cmbProvincias.Location = new Point(191, 30);
            cmbProvincias.Name = "cmbProvincias";
            cmbProvincias.Size = new Size(121, 23);
            cmbProvincias.TabIndex = 4;
            cmbProvincias.SelectedIndexChanged += cmbProvincias_SelectedIndexChanged_1;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 116);
            label3.Name = "label3";
            label3.Size = new Size(89, 15);
            label3.TabIndex = 5;
            label3.Text = "Periodo horario";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(337, 116);
            label4.Name = "label4";
            label4.Size = new Size(191, 15);
            label4.TabIndex = 6;
            label4.Text = "Probabilidad de precipitación en %";
            // 
            // lblPeriodo1
            // 
            lblPeriodo1.AutoSize = true;
            lblPeriodo1.Location = new Point(222, 150);
            lblPeriodo1.Name = "lblPeriodo1";
            lblPeriodo1.Size = new Size(38, 15);
            lblPeriodo1.TabIndex = 7;
            lblPeriodo1.Text = "label5";
            // 
            // lblPeriodo2
            // 
            lblPeriodo2.AutoSize = true;
            lblPeriodo2.Location = new Point(222, 187);
            lblPeriodo2.Name = "lblPeriodo2";
            lblPeriodo2.Size = new Size(38, 15);
            lblPeriodo2.TabIndex = 8;
            lblPeriodo2.Text = "label6";
            // 
            // lblPeriodo3
            // 
            lblPeriodo3.AutoSize = true;
            lblPeriodo3.Location = new Point(222, 223);
            lblPeriodo3.Name = "lblPeriodo3";
            lblPeriodo3.Size = new Size(38, 15);
            lblPeriodo3.TabIndex = 9;
            lblPeriodo3.Text = "label7";
            // 
            // lblPeriodo4
            // 
            lblPeriodo4.AutoSize = true;
            lblPeriodo4.Location = new Point(222, 258);
            lblPeriodo4.Name = "lblPeriodo4";
            lblPeriodo4.Size = new Size(38, 15);
            lblPeriodo4.TabIndex = 10;
            lblPeriodo4.Text = "label8";
            // 
            // lblPeriodo5
            // 
            lblPeriodo5.AutoSize = true;
            lblPeriodo5.Location = new Point(222, 296);
            lblPeriodo5.Name = "lblPeriodo5";
            lblPeriodo5.Size = new Size(38, 15);
            lblPeriodo5.TabIndex = 11;
            lblPeriodo5.Text = "label9";
            // 
            // lblPrecipitacion1
            // 
            lblPrecipitacion1.AutoSize = true;
            lblPrecipitacion1.Location = new Point(400, 150);
            lblPrecipitacion1.Name = "lblPrecipitacion1";
            lblPrecipitacion1.Size = new Size(44, 15);
            lblPrecipitacion1.TabIndex = 12;
            lblPrecipitacion1.Text = "label10";
            // 
            // lblPrecipitacion2
            // 
            lblPrecipitacion2.AutoSize = true;
            lblPrecipitacion2.Location = new Point(400, 187);
            lblPrecipitacion2.Name = "lblPrecipitacion2";
            lblPrecipitacion2.Size = new Size(44, 15);
            lblPrecipitacion2.TabIndex = 13;
            lblPrecipitacion2.Text = "label11";
            // 
            // lblPrecipitacion3
            // 
            lblPrecipitacion3.AutoSize = true;
            lblPrecipitacion3.Location = new Point(400, 223);
            lblPrecipitacion3.Name = "lblPrecipitacion3";
            lblPrecipitacion3.Size = new Size(44, 15);
            lblPrecipitacion3.TabIndex = 14;
            lblPrecipitacion3.Text = "label12";
            // 
            // lblPrecipitacion4
            // 
            lblPrecipitacion4.AutoSize = true;
            lblPrecipitacion4.Location = new Point(400, 258);
            lblPrecipitacion4.Name = "lblPrecipitacion4";
            lblPrecipitacion4.Size = new Size(44, 15);
            lblPrecipitacion4.TabIndex = 15;
            lblPrecipitacion4.Text = "label13";
            // 
            // lblPrecipitacion5
            // 
            lblPrecipitacion5.AutoSize = true;
            lblPrecipitacion5.Location = new Point(400, 296);
            lblPrecipitacion5.Name = "lblPrecipitacion5";
            lblPrecipitacion5.Size = new Size(44, 15);
            lblPrecipitacion5.TabIndex = 16;
            lblPrecipitacion5.Text = "label14";
            // 
            // lblPeriodo6
            // 
            lblPeriodo6.AutoSize = true;
            lblPeriodo6.Location = new Point(222, 329);
            lblPeriodo6.Name = "lblPeriodo6";
            lblPeriodo6.Size = new Size(38, 15);
            lblPeriodo6.TabIndex = 17;
            lblPeriodo6.Text = "label9";
            lblPeriodo6.Click += label5_Click;
            // 
            // lblPrecipitacion6
            // 
            lblPrecipitacion6.AutoSize = true;
            lblPrecipitacion6.Location = new Point(400, 329);
            lblPrecipitacion6.Name = "lblPrecipitacion6";
            lblPrecipitacion6.Size = new Size(44, 15);
            lblPrecipitacion6.TabIndex = 18;
            lblPrecipitacion6.Text = "label14";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(lblPrecipitacion6);
            Controls.Add(lblPeriodo6);
            Controls.Add(lblPrecipitacion5);
            Controls.Add(lblPrecipitacion4);
            Controls.Add(lblPrecipitacion3);
            Controls.Add(lblPrecipitacion2);
            Controls.Add(lblPrecipitacion1);
            Controls.Add(lblPeriodo5);
            Controls.Add(lblPeriodo4);
            Controls.Add(lblPeriodo3);
            Controls.Add(lblPeriodo2);
            Controls.Add(lblPeriodo1);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(cmbProvincias);
            Controls.Add(cmbFechas);
            Controls.Add(bVisualizar);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Button bVisualizar;
        private ComboBox cmbFechas;
        private ComboBox cmbProvincias;
        private Label label3;
        private Label label4;
        private Label lblPeriodo1;
        private Label lblPeriodo2;
        private Label lblPeriodo3;
        private Label lblPeriodo4;
        private Label lblPeriodo5;
        private Label lblPrecipitacion1;
        private Label lblPrecipitacion2;
        private Label lblPrecipitacion3;
        private Label lblPrecipitacion4;
        private Label lblPrecipitacion5;
        private Label lblPeriodo6;
        private Label lblPrecipitacion6;
    }
}
