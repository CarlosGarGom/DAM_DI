﻿namespace EventoTecladoRaton
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
            richTextBox1 = new RichTextBox();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(37, 30);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(386, 134);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(37, 196);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(386, 23);
            textBox1.TabIndex = 1;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(37, 260);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(386, 23);
            textBox2.TabIndex = 2;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(richTextBox1);
            Name = "Form1";
            Text = "Form1";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private TextBox textBox1;
        private TextBox textBox2;
    }
}
