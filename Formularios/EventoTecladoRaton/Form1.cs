namespace EventoTecladoRaton
{
    public partial class Form1 : Form
    {
        private RichTextBox richTextBox;
        private TextBox textBoxKeyboardEvents;
        private TextBox textBoxMouseCoordinates;

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
        public Form1()
        {
            InitializeComponent();
        }
    }
}
