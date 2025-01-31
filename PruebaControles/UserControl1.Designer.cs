namespace PruebaControles
{
    partial class UserControl1
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

        #region Component Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            miReloj1 = new Controles.MiReloj();
            SuspendLayout();
            // 
            // miReloj1
            // 
            miReloj1.AccessibleDescription = "";
            miReloj1.Location = new Point(24, 28);
            miReloj1.Name = "miReloj1";
            miReloj1.Size = new Size(207, 178);
            miReloj1.TabIndex = 0;
            // 
            // UserControl1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(miReloj1);
            Name = "UserControl1";
            Size = new Size(800, 450);
            ResumeLayout(false);
        }

        #endregion

        private Controles.MiReloj miReloj1;
    }
}
