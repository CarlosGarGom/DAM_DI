namespace Ejercicio04_toolstripConBotonesImagenes
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
            toolStrip1 = new ToolStrip();
            tsbUsuario = new ToolStripButton();
            tsbCamara = new ToolStripButton();
            tsbLlaves = new ToolStripButton();
            tsComboBox = new ToolStripComboBox();
            tsbError = new ToolStripSplitButton();
            tsbBuscar = new ToolStripButton();
            tsbUsuarios = new ToolStripButton();
            toolStripButton1 = new ToolStripButton();
            tsLlaves = new ToolStripSplitButton();
            toolStripMenuItem1 = new ToolStripMenuItem();
            toolStripMenuItem2 = new ToolStripMenuItem();
            toolStripMenuItem3 = new ToolStripMenuItem();
            label1 = new Label();
            listPulsado = new ListBox();
            toolStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // toolStrip1
            // 
            toolStrip1.Items.AddRange(new ToolStripItem[] { tsbUsuario, tsbCamara, tsbLlaves, tsLlaves, tsComboBox, tsbError, tsbBuscar, tsbUsuarios, toolStripButton1 });
            toolStrip1.Location = new Point(0, 0);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(800, 74);
            toolStrip1.TabIndex = 0;
            toolStrip1.Text = "toolStrip1";
            toolStrip1.ItemClicked += toolStrip1_ItemClicked;
            // 
            // tsbUsuario
            // 
            tsbUsuario.Image = Properties.Resources.user;
            tsbUsuario.ImageTransparentColor = Color.Magenta;
            tsbUsuario.Name = "tsbUsuario";
            tsbUsuario.Size = new Size(51, 71);
            tsbUsuario.Text = "Usuario";
            tsbUsuario.TextAlign = ContentAlignment.BottomCenter;
            tsbUsuario.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbUsuario.Click += tsbUsuario_Click;
            // 
            // tsbCamara
            // 
            tsbCamara.Image = Properties.Resources.camera;
            tsbCamara.ImageScaling = ToolStripItemImageScaling.None;
            tsbCamara.ImageTransparentColor = Color.Magenta;
            tsbCamara.Name = "tsbCamara";
            tsbCamara.Size = new Size(51, 71);
            tsbCamara.Text = "Usuario";
            tsbCamara.TextAlign = ContentAlignment.BottomCenter;
            tsbCamara.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbCamara.Click += tsbCamara_Click;
            // 
            // tsbLlaves
            // 
            tsbLlaves.Image = Properties.Resources.keys;
            tsbLlaves.ImageScaling = ToolStripItemImageScaling.None;
            tsbLlaves.ImageTransparentColor = Color.Magenta;
            tsbLlaves.Name = "tsbLlaves";
            tsbLlaves.Padding = new Padding(10);
            tsbLlaves.Size = new Size(63, 71);
            tsbLlaves.Text = "Llaves";
            tsbLlaves.TextAlign = ContentAlignment.BottomCenter;
            tsbLlaves.TextDirection = ToolStripTextDirection.Horizontal;
            tsbLlaves.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbLlaves.Click += tsbLlaves_Click;
            // 
            // tsComboBox
            // 
            tsComboBox.Name = "tsComboBox";
            tsComboBox.Size = new Size(121, 74);
            // 
            // tsbError
            // 
            tsbError.Image = Properties.Resources.noresults;
            tsbError.ImageScaling = ToolStripItemImageScaling.None;
            tsbError.ImageTransparentColor = Color.Magenta;
            tsbError.Name = "tsbError";
            tsbError.Size = new Size(48, 71);
            tsbError.Text = "Error";
            tsbError.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbError.ButtonClick += tsbError_ButtonClick;
            // 
            // tsbBuscar
            // 
            tsbBuscar.Image = Properties.Resources.lupa;
            tsbBuscar.ImageScaling = ToolStripItemImageScaling.None;
            tsbBuscar.ImageTransparentColor = Color.Magenta;
            tsbBuscar.Name = "tsbBuscar";
            tsbBuscar.Size = new Size(46, 71);
            tsbBuscar.Text = "Buscar";
            tsbBuscar.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbBuscar.Click += tsbBuscar_Click;
            // 
            // tsbUsuarios
            // 
            tsbUsuarios.Image = Properties.Resources.users;
            tsbUsuarios.ImageScaling = ToolStripItemImageScaling.None;
            tsbUsuarios.ImageTransparentColor = Color.Magenta;
            tsbUsuarios.Name = "tsbUsuarios";
            tsbUsuarios.Size = new Size(56, 71);
            tsbUsuarios.Text = "Usuarios";
            tsbUsuarios.TextImageRelation = TextImageRelation.ImageAboveText;
            tsbUsuarios.Click += tsbUsuarios_Click;
            // 
            // toolStripButton1
            // 
            toolStripButton1.Image = Properties.Resources.otheroptions;
            toolStripButton1.ImageScaling = ToolStripItemImageScaling.None;
            toolStripButton1.ImageTransparentColor = Color.Magenta;
            toolStripButton1.Name = "toolStripButton1";
            toolStripButton1.Size = new Size(53, 71);
            toolStripButton1.Text = "Proceso";
            toolStripButton1.TextImageRelation = TextImageRelation.ImageAboveText;
            toolStripButton1.Click += toolStripButton1_Click;
            // 
            // tsLlaves
            // 
            tsLlaves.DropDownItems.AddRange(new ToolStripItem[] { toolStripMenuItem1, toolStripMenuItem2, toolStripMenuItem3 });
            tsLlaves.Image = Properties.Resources.keys;
            tsLlaves.ImageScaling = ToolStripItemImageScaling.None;
            tsLlaves.ImageTransparentColor = Color.Magenta;
            tsLlaves.Name = "tsLlaves";
            tsLlaves.Size = new Size(55, 71);
            tsLlaves.Text = "Llaves";
            tsLlaves.TextImageRelation = TextImageRelation.ImageAboveText;
            tsLlaves.ButtonClick += tsLlaves_ButtonClick;
            // 
            // toolStripMenuItem1
            // 
            toolStripMenuItem1.Name = "toolStripMenuItem1";
            toolStripMenuItem1.Size = new Size(119, 22);
            toolStripMenuItem1.Text = "Opcion1";
            // 
            // toolStripMenuItem2
            // 
            toolStripMenuItem2.Name = "toolStripMenuItem2";
            toolStripMenuItem2.Size = new Size(119, 22);
            toolStripMenuItem2.Text = "Opcion2";
            // 
            // toolStripMenuItem3
            // 
            toolStripMenuItem3.Name = "toolStripMenuItem3";
            toolStripMenuItem3.Size = new Size(119, 22);
            toolStripMenuItem3.Text = "Opcion3";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(24, 87);
            label1.Name = "label1";
            label1.Size = new Size(83, 15);
            label1.TabIndex = 1;
            label1.Text = "Se ha pulsado:";
            // 
            // listPulsado
            // 
            listPulsado.FormattingEnabled = true;
            listPulsado.ItemHeight = 15;
            listPulsado.Location = new Point(140, 87);
            listPulsado.Name = "listPulsado";
            listPulsado.Size = new Size(370, 124);
            listPulsado.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(listPulsado);
            Controls.Add(label1);
            Controls.Add(toolStrip1);
            Name = "Form1";
            Text = "Form1";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ToolStrip toolStrip1;
        private ToolStripButton tsbUsuario;
        private ToolStripButton tsbCamara;
        private ToolStripButton tsbLlaves;
        private ToolStripSplitButton tsbError;
        private ToolStripComboBox tsComboBox;
        private ToolStripButton tsbBuscar;
        private ToolStripButton tsbUsuarios;
        private ToolStripButton toolStripButton1;
        private ToolStripSplitButton tsLlaves;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private Label label1;
        private ListBox listPulsado;
    }
}
