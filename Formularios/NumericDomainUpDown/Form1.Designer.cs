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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
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
            menu = new MenuStrip();
            miArchivo = new ToolStripMenuItem();
            nuevoToolStripMenuItem = new ToolStripMenuItem();
            abrirToolStripMenuItem = new ToolStripMenuItem();
            cerrarToolStripMenuItem = new ToolStripMenuItem();
            miEditar = new ToolStripMenuItem();
            button1 = new Button();
            contextMenuStrip1 = new ContextMenuStrip(components);
            toolStripMenuItem1 = new ToolStripMenuItem();
            opcion2ToolStripMenuItem = new ToolStripMenuItem();
            toolTip1 = new ToolTip(components);
            toolStrip1 = new ToolStrip();
            toolStripButton1 = new ToolStripButton();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            menu.SuspendLayout();
            contextMenuStrip1.SuspendLayout();
            toolStrip1.SuspendLayout();
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
            dSemana.Location = new Point(160, 99);
            dSemana.Name = "dSemana";
            dSemana.Size = new Size(120, 23);
            dSemana.TabIndex = 0;
            dSemana.Text = "Selecciona Dia";
            dSemana.SelectedItemChanged += dSemana_SelectedItemChanged;
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(20, 99);
            numericUpDown1.Maximum = new decimal(new int[] { 6, 0, 0, 0 });
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 1;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(20, 66);
            label1.Name = "label1";
            label1.Size = new Size(99, 15);
            label1.TabIndex = 2;
            label1.Text = "NumericUpDown";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(160, 66);
            label2.Name = "label2";
            label2.Size = new Size(95, 15);
            label2.TabIndex = 3;
            label2.Text = "DomainUpDown";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(20, 137);
            label3.Name = "label3";
            label3.Size = new Size(37, 15);
            label3.TabIndex = 4;
            label3.Text = "Timer";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(19, 165);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(100, 23);
            textBox1.TabIndex = 5;
            // 
            // progressBar1
            // 
            progressBar1.Location = new Point(160, 164);
            progressBar1.Name = "progressBar1";
            progressBar1.Size = new Size(100, 24);
            progressBar1.TabIndex = 6;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(160, 137);
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
            sbRojo.Location = new Point(160, 299);
            sbRojo.Maximum = 255;
            sbRojo.Name = "sbRojo";
            sbRojo.Size = new Size(24, 176);
            sbRojo.TabIndex = 8;
            sbRojo.ValueChanged += sbRojo_ValueChanged;
            // 
            // sbVerde
            // 
            sbVerde.Location = new Point(208, 299);
            sbVerde.Maximum = 255;
            sbVerde.Name = "sbVerde";
            sbVerde.Size = new Size(24, 176);
            sbVerde.TabIndex = 9;
            sbVerde.ValueChanged += sbVerde_ValueChanged;
            // 
            // sbAzul
            // 
            sbAzul.Location = new Point(252, 299);
            sbAzul.Maximum = 255;
            sbAzul.Name = "sbAzul";
            sbAzul.Size = new Size(28, 176);
            sbAzul.TabIndex = 10;
            sbAzul.ValueChanged += sbAzul_ValueChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(160, 235);
            label5.Name = "label5";
            label5.Size = new Size(31, 15);
            label5.TabIndex = 11;
            label5.Text = "Rojo";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(208, 235);
            label6.Name = "label6";
            label6.Size = new Size(36, 15);
            label6.TabIndex = 12;
            label6.Text = "Verde";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(249, 235);
            label7.Name = "label7";
            label7.Size = new Size(30, 15);
            label7.TabIndex = 13;
            label7.Text = "Azul";
            // 
            // lRojo
            // 
            lRojo.AutoSize = true;
            lRojo.Location = new Point(160, 265);
            lRojo.Name = "lRojo";
            lRojo.Size = new Size(13, 15);
            lRojo.TabIndex = 14;
            lRojo.Text = "0";
            // 
            // lVerde
            // 
            lVerde.AutoSize = true;
            lVerde.Location = new Point(208, 265);
            lVerde.Name = "lVerde";
            lVerde.Size = new Size(13, 15);
            lVerde.TabIndex = 15;
            lVerde.Text = "0";
            // 
            // lAzul
            // 
            lAzul.AutoSize = true;
            lAzul.Location = new Point(252, 265);
            lAzul.Name = "lAzul";
            lAzul.Size = new Size(13, 15);
            lAzul.TabIndex = 16;
            lAzul.Text = "0";
            lAzul.Click += label10_Click;
            // 
            // pColor
            // 
            pColor.Location = new Point(25, 246);
            pColor.Name = "pColor";
            pColor.Size = new Size(115, 229);
            pColor.TabIndex = 17;
            // 
            // bColorea
            // 
            bColorea.Location = new Point(44, 217);
            bColorea.Name = "bColorea";
            bColorea.Size = new Size(75, 23);
            bColorea.TabIndex = 18;
            bColorea.Text = "Colorea";
            bColorea.UseVisualStyleBackColor = true;
            bColorea.Click += bColorea_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Location = new Point(295, 99);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(106, 89);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 19;
            pictureBox1.TabStop = false;
            pictureBox1.Click += pictureBox1_Click;
            // 
            // menu
            // 
            menu.Items.AddRange(new ToolStripItem[] { miArchivo, miEditar });
            menu.Location = new Point(0, 0);
            menu.Name = "menu";
            menu.Size = new Size(472, 24);
            menu.TabIndex = 20;
            menu.Text = "menuStrip1";
            // 
            // miArchivo
            // 
            miArchivo.DropDownItems.AddRange(new ToolStripItem[] { nuevoToolStripMenuItem, abrirToolStripMenuItem, cerrarToolStripMenuItem });
            miArchivo.Name = "miArchivo";
            miArchivo.ShortcutKeys = Keys.Alt | Keys.A;
            miArchivo.Size = new Size(60, 20);
            miArchivo.Text = "Archivo";
            // 
            // nuevoToolStripMenuItem
            // 
            nuevoToolStripMenuItem.Name = "nuevoToolStripMenuItem";
            nuevoToolStripMenuItem.Size = new Size(109, 22);
            nuevoToolStripMenuItem.Text = "Nuevo";
            // 
            // abrirToolStripMenuItem
            // 
            abrirToolStripMenuItem.Name = "abrirToolStripMenuItem";
            abrirToolStripMenuItem.Size = new Size(109, 22);
            abrirToolStripMenuItem.Text = "Abrir";
            abrirToolStripMenuItem.Click += abrirToolStripMenuItem_Click;
            // 
            // cerrarToolStripMenuItem
            // 
            cerrarToolStripMenuItem.Name = "cerrarToolStripMenuItem";
            cerrarToolStripMenuItem.Size = new Size(109, 22);
            cerrarToolStripMenuItem.Text = "Cerrar";
            // 
            // miEditar
            // 
            miEditar.Name = "miEditar";
            miEditar.Size = new Size(49, 20);
            miEditar.Text = "Editar";
            miEditar.Click += toolStripMenuItem1_Click;
            // 
            // button1
            // 
            button1.ContextMenuStrip = contextMenuStrip1;
            button1.Location = new Point(307, 27);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 21;
            button1.Text = "Boton";
            toolTip1.SetToolTip(button1, "Hola");
            button1.UseVisualStyleBackColor = true;
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.Items.AddRange(new ToolStripItem[] { toolStripMenuItem1, opcion2ToolStripMenuItem });
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(123, 48);
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(122, 22);
            toolStripMenuItem1.Text = "Opcion 1";
            // 
            // opcion2ToolStripMenuItem
            // 
            opcion2ToolStripMenuItem.Name = "opcion2ToolStripMenuItem";
            opcion2ToolStripMenuItem.Size = new Size(122, 22);
            opcion2ToolStripMenuItem.Text = "Opcion 2";
            // 
            // toolTip1
            // 
            toolTip1.ToolTipTitle = "Titulo";
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripButton1 });
            toolStrip1.Location = new Point(0, 24);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(472, 25);
            toolStrip1.TabIndex = 22;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripButton1
            // 
            toolStripButton1.BackgroundImage = UpDownTimersBarColors.Properties.Resources.user;
            toolStripButton1.DisplayStyle = ToolStripItemDisplayStyle.Image;
            toolStripButton1.Image = (Image)resources.GetObject("toolStripButton1.Image");
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(23, 22);
            toolStripButton1.Text = "toolStripButton1";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(472, 508);
            ContextMenuStrip = contextMenuStrip1;
            Controls.Add(toolStrip1);
            Controls.Add(button1);
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
            Controls.Add(menu);
            MainMenuStrip = menu;
            Name = "Form1";
            Text = "S";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            menu.ResumeLayout(false);
            menu.PerformLayout();
            contextMenuStrip1.ResumeLayout(false);
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
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
        private MenuStrip menu;
        private ToolStripMenuItem miArchivo;
        private ToolStripMenuItem miEditar;
        private ToolStripMenuItem nuevoToolStripMenuItem;
        private ToolStripMenuItem abrirToolStripMenuItem;
        private ToolStripMenuItem cerrarToolStripMenuItem;
        private Button button1;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem opcion2ToolStripMenuItem;
        private ToolTip toolTip1;
        private ToolStrip toolStrip1;
        private ToolStripButton toolStripButton1;
    }
}
