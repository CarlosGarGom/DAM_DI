namespace ControlesEjercicios
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
            tbUser = new TextBox();
            tbPassword = new TextBox();
            label1 = new Label();
            label2 = new Label();
            btnValidar = new Button();
            lblUserData = new Label();
            SuspendLayout();
            // 
            // tbUser
            // 
            tbUser.Location = new Point(86, 19);
            tbUser.Name = "tbUser";
            tbUser.Size = new Size(100, 23);
            tbUser.TabIndex = 0;
            // 
            // tbPassword
            // 
            tbPassword.Location = new Point(86, 65);
            tbPassword.Name = "tbPassword";
            tbPassword.Size = new Size(100, 23);
            tbPassword.TabIndex = 1;
            tbPassword.UseSystemPasswordChar = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 27);
            label1.Name = "label1";
            label1.Size = new Size(50, 15);
            label1.TabIndex = 2;
            label1.Text = "Usuario:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 68);
            label2.Name = "label2";
            label2.Size = new Size(70, 15);
            label2.TabIndex = 3;
            label2.Text = "Contraseña:";
            // 
            // btnValidar
            // 
            btnValidar.Location = new Point(111, 111);
            btnValidar.Name = "btnValidar";
            btnValidar.Size = new Size(75, 23);
            btnValidar.TabIndex = 4;
            btnValidar.Text = "Validar";
            btnValidar.UseVisualStyleBackColor = true;
            btnValidar.Click += btnValidar_Click;
            // 
            // lblUserData
            // 
            lblUserData.AutoSize = true;
            lblUserData.Location = new Point(12, 115);
            lblUserData.Name = "lblUserData";
            lblUserData.Size = new Size(0, 15);
            lblUserData.TabIndex = 5;
            // 
            // LoginControl
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(lblUserData);
            Controls.Add(btnValidar);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(tbPassword);
            Controls.Add(tbUser);
            Name = "LoginControl";
            Size = new Size(217, 150);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox tbUser;
        private TextBox tbPassword;
        private Label label1;
        private Label label2;
        private Button btnValidar;
        private Label lblUserData;
    }
}
