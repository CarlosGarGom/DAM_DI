namespace MisControles
{
    partial class LoginControl
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            tbPassword = new TextBox();
            tbUser = new TextBox();
            button1 = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(13, 77);
            label1.Name = "label1";
            label1.Size = new Size(76, 15);
            label1.TabIndex = 0;
            label1.Text = "Contraseña : ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(24, 32);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 1;
            label2.Text = "Usuario :";
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(106, 74);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(118, 23);
            tbPassword.TabIndex = 2;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // tbUser
            // 
            tbUser.Location = new Point(106, 29);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(118, 23);
            tbUser.TabIndex = 3;
            // 
            // button1
            // 
            button1.Location = new Point(149, 116);
            button1.Name = "button1";
            button1.Size = new Size(75, 23);
            button1.TabIndex = 4;
            button1.Text = "Validar";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(button1);
            Controls.Add(tbUser);
            Controls.Add(tbPassword);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "LoginControl";
            Size = new Size(258, 158);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox tbPassword;
        private TextBox tbUser;
        private Button button1;
    }
}
