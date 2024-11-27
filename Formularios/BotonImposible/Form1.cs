using System;
namespace BotonImposible
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btnEscurridizo.MouseEnter += new EventHandler(btnEscurridizo_MouseEnter);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            System.Windows.Forms.MessageBox.Show("Felicidades! Eres un robot");
        }
        private void btnEscurridizo_MouseEnter(object sender, EventArgs e)
        {
            // Generador de n�meros aleatorios
            Random random = new Random();

            // Obtiene el tama�o del formulario y del bot�n
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int buttonWidth = btnEscurridizo.Width;
            int buttonHeight = btnEscurridizo.Height;

            // Calcula una nueva posici�n aleatoria para el bot�n dentro de los l�mites del formulario
            int newX = random.Next(0, formWidth - buttonWidth);
            int newY = random.Next(0, formHeight - buttonHeight);

            // Establece la nueva posici�n del bot�n
            btnEscurridizo.Location = new Point(newX, newY);
        }

    }
}
