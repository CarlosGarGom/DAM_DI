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
            calendario = new MonthCalendar();
            lbFechas = new ListBox();
            label1 = new Label();
            SuspendLayout();
            // 
            // calendario
            // 
            calendario.Location = new Point(18, 61);
            calendario.Name = "calendario";
            calendario.TabIndex = 0;
            // 
            // lbFechas
            // 
            lbFechas.FormattingEnabled = true;
            lbFechas.ItemHeight = 15;
            lbFechas.Location = new Point(307, 93);
            lbFechas.Name = "lbFechas";
            lbFechas.Size = new Size(182, 154);
            lbFechas.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(307, 61);
            label1.Name = "label1";
            label1.Size = new Size(160, 15);
            label1.TabIndex = 2;
            label1.Text = "Lista de fechas seleccionadas";
            label1.Click += label1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(671, 450);
            Controls.Add(label1);
            Controls.Add(lbFechas);
            Controls.Add(calendario);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private MonthCalendar calendario;
        private ListBox lbFechas;
        private Label label1;
    }
}
