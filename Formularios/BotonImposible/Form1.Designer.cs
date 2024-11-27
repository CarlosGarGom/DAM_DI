namespace BotonImposible
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
            btnEscurridizo = new Button();
            SuspendLayout();
            // 
            // btnEscurridizo
            // 
            btnEscurridizo.Location = new Point(185, 102);
            btnEscurridizo.Name = "btnEscurridizo";
            btnEscurridizo.Size = new Size(147, 43);
            btnEscurridizo.TabIndex = 0;
            btnEscurridizo.Text = "Haz Click";
            btnEscurridizo.UseVisualStyleBackColor = true;
            btnEscurridizo.Click += button1_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(513, 240);
            Controls.Add(btnEscurridizo);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion

        private Button btnEscurridizo;
    }
}
