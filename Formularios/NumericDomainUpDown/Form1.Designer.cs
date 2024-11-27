namespace NumericDomainUpDown
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
            components = new System.ComponentModel.Container();
            dSemana = new DomainUpDown();
            numericUpDown1 = new NumericUpDown();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            progressBar1 = new ProgressBar();
            label4 = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            sbRojo = new VScrollBar();
            sbVerde = new VScrollBar();
            sbAzul = new VScrollBar();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            lRojo = new Label();
            lVerde = new Label();
            lAzul = new Label();
            pColor = new Panel();
            bColorea = new Button();
            pictureBox1 = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // dSemana
            // 
            dSemana.Items.Add("Lunes");
            dSemana.Items.Add("Martes");
            dSemana.Items.Add("Miercoles");
            dSemana.Items.Add("Jueves");
            dSemana.Items.Add("Viernes");
            dSemana.Items.Add("Sabado");
            dSemana.Items.Add("Domingo");
            dSemana.Location = new Point(152, 42);
            dSemana.Name = "dSemana";
            dSemana.Size = new Size(120, 23);
            dSemana.TabIndex = 0;
            dSemana.Text = "Selecciona Dia";
            dSemana.SelectedItemChanged += dSemana_SelectedItemChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(12, 42);
            numericUpDown1.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 9);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 2;
            label1.Text = "NumericUpDown";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(152, 9);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 3;
            label2.Text = "DomainUpDown";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(12, 80);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 4;
            label3.Text = "Timer";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(11, 108);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(152, 107);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 24);
            progressBar1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(152, 80);
            label4.Name = "label4";
            label4.Size = new Size(72, 15);
            label4.TabIndex = 7;
            label4.Text = "Progress Bar";
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Tick += timer1_Tick_1;
            // 
            // sbRojo
            // 
            sbRojo.Location = new Point(152, 242);
            sbRojo.Maximum = 255;
            sbRojo.Name = "sbRojo";
            sbRojo.Size = new Size(24, 176);
            sbRojo.TabIndex = 8;
            sbRojo.ValueChanged += sbRojo_ValueChanged;
            // 
            // sbVerde
            // 
            sbVerde.Location = new Point(200, 242);
            sbVerde.Maximum = 255;
            sbVerde.Name = "sbVerde";
            sbVerde.Size = new Size(24, 176);
            sbVerde.TabIndex = 9;
            sbVerde.ValueChanged += sbVerde_ValueChanged;
            // 
            // sbAzul
            // 
            sbAzul.Location = new Point(244, 242);
            sbAzul.Maximum = 255;
            sbAzul.Name = "sbAzul";
            sbAzul.Size = new Size(28, 176);
            sbAzul.TabIndex = 10;
            sbAzul.ValueChanged += sbAzul_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(152, 178);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 11;
            label5.Text = "Rojo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(200, 178);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 12;
            label6.Text = "Verde";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(241, 178);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 13;
            label7.Text = "Azul";
            // 
            // lRojo
            // 
            lRojo.AutoSize = true;
            lRojo.Location = new Point(152, 208);
            lRojo.Name = "lRojo";
            lRojo.Size = new Size(13, 15);
            lRojo.TabIndex = 14;
            lRojo.Text = "0";
            // 
            // lVerde
            // 
            lVerde.AutoSize = true;
            lVerde.Location = new Point(200, 208);
            lVerde.Name = "lVerde";
            lVerde.Size = new Size(13, 15);
            lVerde.TabIndex = 15;
            lVerde.Text = "0";
            // 
            // lAzul
            // 
            lAzul.AutoSize = true;
            lAzul.Location = new Point(244, 208);
            lAzul.Name = "lAzul";
            lAzul.Size = new Size(13, 15);
            lAzul.TabIndex = 16;
            lAzul.Text = "0";
            lAzul.Click += label10_Click;
            // 
            // pColor
            // 
            pColor.Location = new Point(17, 189);
            pColor.Name = "pColor";
            pColor.Size = new Size(115, 229);
            pColor.TabIndex = 17;
            // 
            // bColorea
            // 
            bColorea.Location = new Point(36, 160);
            bColorea.Name = "bColorea";
            bColorea.Size = new Size(75, 23);
            bColorea.TabIndex = 18;
            bColorea.Text = "Colorea";
            bColorea.UseVisualStyleBackColor = true;
            bColorea.Click += bColorea_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(287, 42);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 427);
            Controls.Add(pictureBox1);
            Controls.Add(bColorea);
            Controls.Add(pColor);
            Controls.Add(lAzul);
            Controls.Add(lVerde);
            Controls.Add(lRojo);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(sbAzul);
            Controls.Add(sbVerde);
            Controls.Add(sbRojo);
            Controls.Add(label4);
            Controls.Add(progressBar1);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(numericUpDown1);
            Controls.Add(dSemana);
            Name = "Form1";
            Text = "S";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DomainUpDown dSemana;
        private NumericUpDown numericUpDown1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private ProgressBar progressBar1;
        private Label label4;
        private System.Windows.Forms.Timer timer1;
        private VScrollBar sbRojo;
        private VScrollBar sbVerde;
        private VScrollBar sbAzul;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label lRojo;
        private Label lVerde;
        private Label lAzul;
        private Panel pColor;
        private Button bColorea;
        private PictureBox pictureBox1;
    }
}
