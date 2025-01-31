
namespace MisControles
{
    public partial class LoginControl : UserControl
    {
        private ErrorProvider errorProvider;
        public event EventHandler LoginCorrecto;
        public event EventHandler LoginIncorrecto;
        public LoginControl()
        {
            InitializeComponent();
            //errorProvider = new ErrorProvider();

        }

        private void button1_Click(object sender, EventArgs e)
        {
           /* // Limpiar errores previos
            errorProvider.Clear();

            // Validar entradas de usuario y contraseña
            bool validacionExitosa = true;

            if (string.IsNullOrWhiteSpace(tbUser.Text))
            {
                errorProvider.SetError(tbUser, "El campo Usuario es obligatorio.");
                validacionExitosa = false;
            }

            if (string.IsNullOrWhiteSpace(tbPassword.Text))
            {
                errorProvider.SetError(tbPassword, "El campo Contraseña es obligatorio.");
                validacionExitosa = false;
            }

            if (validacionExitosa)
            {
                // Simulación de validación de credenciales
                if (tbUser.Text == "admin" && tbPassword.Text == "1234") // Aquí puedes integrar tu lógica real
                {
                    // Disparar evento LoginCorrecto
                    LoginCorrecto?.Invoke(this, EventArgs.Empty);
                }
                else
                {
                    // Disparar evento LoginIncorrecto
                    LoginIncorrecto?.Invoke(this, EventArgs.Empty);
                }
            }*/
        }
    }
}
