namespace Controles
{
    partial class MiReloj
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
            components = new System.ComponentModel.Container();
            lDisplay = new Label();
            timer1 = new System.Windows.Forms.Timer(components);
            SuspendLayout();
            // 
            // lDisplay
            // 
            lDisplay.Font = new Font("Segoe UI", 14F);
            lDisplay.Location = new Point(51, 84);
            lDisplay.Name = "lDisplay";
            lDisplay.Size = new Size(100, 23);
            lDisplay.TabIndex = 0;
            lDisplay.Text = "00:00:00";
            lDisplay.TextAlign = ContentAlignment.MiddleCenter;
            // 
            // timer1
            // 
            timer1.Enabled = true;
            timer1.Interval = 1000;
            timer1.Tick += timer1_Tick;
            // 
            // MiReloj
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lDisplay);
            Name = "MiReloj";
            Size = new Size(800, 450);
            ResumeLayout(false);
        }

        #endregion

        private Label lDisplay;
        private System.Windows.Forms.Timer timer1;
    }
}
