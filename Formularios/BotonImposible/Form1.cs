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
            // Generador de números aleatorios
            Random random = new Random();

            // Obtiene el tamaño del formulario y del botón
            int formWidth = this.ClientSize.Width;
            int formHeight = this.ClientSize.Height;
            int buttonWidth = btnEscurridizo.Width;
            int buttonHeight = btnEscurridizo.Height;

            // Calcula una nueva posición aleatoria para el botón dentro de los límites del formulario
            int newX = random.Next(0, formWidth - buttonWidth);
            int newY = random.Next(0, formHeight - buttonHeight);

            // Establece la nueva posición del botón
            btnEscurridizo.Location = new Point(newX, newY);
        }

    }
}
