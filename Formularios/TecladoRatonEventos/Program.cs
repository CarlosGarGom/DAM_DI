using System;
using System.Drawing;
using System.Windows.Forms;

namespace EventCaptureApp
{
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
            richTextBox = new RichTextBox();
            textBoxKeyboardEvents = new TextBox();
            textBoxMouseCoordinates = new TextBox();
            SuspendLayout();
            // 
            // richTextBox
            // 
            richTextBox.Location = new Point(0, 0);
            richTextBox.Name = "richTextBox";
            richTextBox.Size = new Size(100, 96);
            richTextBox.TabIndex = 0;
            richTextBox.Text = "";
            richTextBox.KeyDown += RichTextBox_KeyDown;
            richTextBox.KeyPress += RichTextBox_KeyPress;
            richTextBox.KeyUp += RichTextBox_KeyUp;
            richTextBox.MouseMove += RichTextBox_MouseMove;
            // 
            // textBoxKeyboardEvents
            // 
            textBoxKeyboardEvents.Location = new Point(0, 0);
            textBoxKeyboardEvents.Name = "textBoxKeyboardEvents";
            textBoxKeyboardEvents.Size = new Size(100, 23);
            textBoxKeyboardEvents.TabIndex = 1;
            // 
            // textBoxMouseCoordinates
            // 
            textBoxMouseCoordinates.Location = new Point(0, 0);
            textBoxMouseCoordinates.Name = "textBoxMouseCoordinates";
            textBoxMouseCoordinates.Size = new Size(100, 23);
            textBoxMouseCoordinates.TabIndex = 2;
            // 
            // MainForm
            // 
            ClientSize = new Size(352, 313);
            Controls.Add(richTextBox);
            Controls.Add(textBoxKeyboardEvents);
            Controls.Add(textBoxMouseCoordinates);
            Name = "MainForm";
            Text = "Captura de Eventos de Teclado y Ratón";
            ResumeLayout(false);
            PerformLayout();
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

    // Programa principal
    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new MainForm());
        }
    }
}
