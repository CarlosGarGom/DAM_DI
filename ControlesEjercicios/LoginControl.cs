using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ControlesEjercicios
{
    public partial class LoginControl : UserControl
    {
        private ErrorProvider errorProvider;
        private string user = "carlos";
        private string password = "1234";
        public event EventHandler LoginCorrecto;
        public event EventHandler LoginIncorrecto;

        public LoginControl()
        {
            InitializeComponent();
            errorProvider = new ErrorProvider();
        }

        private void btnValidar_Click(object sender, EventArgs e)
        {
            errorProvider.Clear();

            // Comprobar si los campos están vacíos
            if (tbUser.Text.Length == 0)
            {
                errorProvider.SetError(tbUser, "El campo de usuario no puede estar vacío.");
            }
            else if (tbPassword.Text.Length == 0)
            {
                errorProvider.SetError(tbPassword, "El campo de contraseña no puede estar vacío.");
            }
            else
            {
                // Verificar si el usuario y la contraseña son correctos
                if (tbUser.Text.Equals(user) && tbPassword.Text.Equals(password))
                {
                    // Si la validación es correcta, mostramos el mensaje y limpiamos el error
                    lblUserData.Text = "Login Correcto!";
                    lblUserData.ForeColor = System.Drawing.Color.Green;

                    // Limpiar los errores
                    errorProvider.Clear();

                    // Quitar el UserControl del formulario (lo eliminamos)
                    this.Parent.Controls.Remove(this);  // Elimina el control UserControl1 del formulario
                }
                else
                {
                    // Si es incorrecto, mostrar el mensaje y resaltar el error
                    lblUserData.Text = "Login Incorrecto!";
                    lblUserData.ForeColor = System.Drawing.Color.Red;

                    // Mostrar mensaje de error
                    errorProvider.SetError(tbUser, "Usuario o contraseña incorrectos.");
                }
                /*if (ValidarUsuario(tbPassword.Text))
                {
                }*/

            }
               /*  bool ValidarUsuario(string usuario, string contraseña)
            {
                if (usuario == "carlos" && contraseña = "1234")
                {
                    return true;

                }
                else
                {
                    return false;
                }*/

        }
    }
}
