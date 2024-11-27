namespace Ejercicio03
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
            mcCalendario = new MonthCalendar();
            gbCita = new GroupBox();
            bGuardar = new Button();
            bBorrar = new Button();
            bAñadir = new Button();
            label2 = new Label();
            tbCitas = new TextBox();
            rbPM = new RadioButton();
            rbAM = new RadioButton();
            cbHora = new ComboBox();
            label1 = new Label();
            lbCitas = new ListBox();
            gbCita.SuspendLayout();
            SuspendLayout();
            // 
            // mcCalendario
            // 
            mcCalendario.Location = new Point(18, 41);
            mcCalendario.Name = "mcCalendario";
            mcCalendario.TabIndex = 0;
            // 
            // gbCita
            // 
            gbCita.Controls.Add(bGuardar);
            gbCita.Controls.Add(bBorrar);
            gbCita.Controls.Add(bAñadir);
            gbCita.Controls.Add(label2);
            gbCita.Controls.Add(tbCitas);
            gbCita.Controls.Add(rbPM);
            gbCita.Controls.Add(rbAM);
            gbCita.Controls.Add(cbHora);
            gbCita.Controls.Add(label1);
            gbCita.Location = new Point(244, 41);
            gbCita.Name = "gbCita";
            gbCita.Size = new Size(271, 162);
            gbCita.TabIndex = 1;
            gbCita.TabStop = false;
            gbCita.Text = "Cita";
            // 
            // bGuardar
            // 
            bGuardar.Location = new Point(190, 133);
            bGuardar.Name = "bGuardar";
            bGuardar.Size = new Size(75, 23);
            bGuardar.TabIndex = 10;
            bGuardar.Text = "Guardar";
            bGuardar.UseVisualStyleBackColor = true;
            bGuardar.Click += bGuardar_Click_1;
            // 
            // bBorrar
            // 
            bBorrar.Location = new Point(99, 133);
            bBorrar.Name = "bBorrar";
            bBorrar.Size = new Size(75, 23);
            bBorrar.TabIndex = 9;
            bBorrar.Text = "Borrar";
            bBorrar.UseVisualStyleBackColor = true;
            bBorrar.Click += bBorrar_Click_1;
            // 
            // bAñadir
            // 
            bAñadir.Location = new Point(6, 133);
            bAñadir.Name = "bAñadir";
            bAñadir.Size = new Size(75, 23);
            bAñadir.TabIndex = 8;
            bAñadir.Text = "Añadir";
            bAñadir.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(6, 75);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 7;
            label2.Text = "Texto:";
            // 
            // tbCitas
            // 
            tbCitas.Location = new Point(50, 72);
            tbCitas.Name = "tbCitas";
            tbCitas.Size = new Size(215, 23);
            tbCitas.TabIndex = 6;
            // 
            // rbPM
            // 
            rbPM.AutoSize = true;
            rbPM.Location = new Point(178, 35);
            rbPM.Name = "rbPM";
            rbPM.Size = new Size(43, 19);
            rbPM.TabIndex = 5;
            rbPM.TabStop = true;
            rbPM.Text = "PM";
            rbPM.UseVisualStyleBackColor = true;
            // 
            // rbAM
            // 
            rbAM.AutoSize = true;
            rbAM.Location = new Point(118, 35);
            rbAM.Name = "rbAM";
            rbAM.Size = new Size(44, 19);
            rbAM.TabIndex = 4;
            rbAM.TabStop = true;
            rbAM.Text = "AM";
            rbAM.UseVisualStyleBackColor = true;
            rbAM.CheckedChanged += rbAM_CheckedChanged;
            // 
            // cbHora
            // 
            cbHora.FormattingEnabled = true;
            cbHora.Location = new Point(48, 32);
            cbHora.Name = "cbHora";
            cbHora.Size = new Size(64, 23);
            cbHora.TabIndex = 2;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(6, 35);
            label1.Name = "label1";
            label1.Size = new Size(36, 15);
            label1.TabIndex = 3;
            label1.Text = "Hora:";
            // 
            // lbCitas
            // 
            lbCitas.FormattingEnabled = true;
            lbCitas.ItemHeight = 15;
            lbCitas.Location = new Point(244, 218);
            lbCitas.Name = "lbCitas";
            lbCitas.Size = new Size(271, 199);
            lbCitas.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(527, 443);
            Controls.Add(lbCitas);
            Controls.Add(gbCita);
            Controls.Add(mcCalendario);
            Name = "Form1";
            Text = "Agenda Organizador";
            gbCita.ResumeLayout(false);
            gbCita.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private MonthCalendar mcCalendario;
        private GroupBox gbCita;
        private RadioButton rbAM;
        private ComboBox cbHora;
        private Label label1;
        private RadioButton rbPM;
        private Button bGuardar;
        private Button bBorrar;
        private Button bAñadir;
        private Label label2;
        private TextBox tbCitas;
        private ListBox lbCitas;
    }
}
