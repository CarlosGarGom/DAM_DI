namespace EventosTecladoRaton
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new Form1());
        }
        public partial class MainForm : Form
        {
            private RichTextBox richTextBox;
            private TextBox textBoxKeyboardEvents;
            private TextBox textBoxMouseCoordinates;

            public MainForm()
            {
                InitializeComponent();
            }

            private void InitializeComponent()
            {
                // Inicialización del formulario
                this.Text = "Captura de Eventos de Teclado y Ratón";
                this.Size = new Size(500, 400);

                // RichTextBox para escritura del usuario
                richTextBox = new RichTextBox
                {
                    Location = new Point(20, 20),
                    Size = new Size(440, 150)
                };
                this.Controls.Add(richTextBox);

                // TextBox para mostrar eventos de teclado
                textBoxKeyboardEvents = new TextBox
                {
                    Location = new Point(20, 200),
                    Size = new Size(440, 30),
                    ReadOnly = true
                };
                this.Controls.Add(textBoxKeyboardEvents);

                // TextBox para mostrar coordenadas del ratón
                textBoxMouseCoordinates = new TextBox
                {
                    Location = new Point(20, 250),
                    Size = new Size(440, 30),
                    ReadOnly = true
                };
                this.Controls.Add(textBoxMouseCoordinates);

                // Asignar eventos
                richTextBox.KeyDown += RichTextBox_KeyDown;
                richTextBox.KeyUp += RichTextBox_KeyUp;
                richTextBox.KeyPress += RichTextBox_KeyPress;
                richTextBox.MouseMove += RichTextBox_MouseMove;
            }

            // Evento KeyDown
            private void RichTextBox_KeyDown(object sender, KeyEventArgs e)
            {
                textBoxKeyboardEvents.Text = $"KeyDown: {e.KeyCode}";
            }

            // Evento KeyUp
            private void RichTextBox_KeyUp(object sender, KeyEventArgs e)
            {
                textBoxKeyboardEvents.Text = $"KeyUp: {e.KeyCode}";
            }

            // Evento KeyPress
            private void RichTextBox_KeyPress(object sender, KeyPressEventArgs e)
            {
                textBoxKeyboardEvents.Text = $"KeyPress: {e.KeyChar}";
            }

            // Evento MouseMove
            private void RichTextBox_MouseMove(object sender, MouseEventArgs e)
            {
                textBoxMouseCoordinates.Text = $"Mouse Coordinates: X = {e.X}, Y = {e.Y}";
            }
        }
    }
}