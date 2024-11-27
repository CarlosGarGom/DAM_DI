namespace MonthCalendar
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        // Ratón
        private void Control_MouseMove(object sender, MouseEventArgs e)
        {
            // Mostrar coordenadas del mouse dentro del control
            Console.WriteLine($"Coordenadas: X={e.X}, Y={e.Y}");
        }
        //Teclado
        private void Control_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                MessageBox.Show("Se presionó Enter.");
            }
        }
        private void Control_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.ShiftKey)
            {
                MessageBox.Show("Shift soltado.");
            }
        }
        private void Control_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar))
            {
                e.Handled = true; // Bloquear entrada no numérica
            }
        }
        // Checkbox y Radio
        private void CheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                MessageBox.Show("Checkbox seleccionado.");
            }
            else
            {
                MessageBox.Show("Checkbox desmarcado.");
            }
        }

        //MonthCalendar
        private void MonthCalendar_DateChanged(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show($"Nueva fecha seleccionada: {e.Start.ToShortDateString()}");
        }
        private void MonthCalendar_DateSelected(object sender, DateRangeEventArgs e)
        {
            MessageBox.Show($"Fecha seleccionada: {e.Start.ToShortDateString()}");
        }

        //TextBox
        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            lblCaracteres.Text = $"Caracteres: {((TextBox)sender).Text.Length}";
        }
        private void Form_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Formulario cargado.");
        }

        //ComboBox
        public void RellenarComboBoxHoras(ComboBox comboBox)
        {
            for (int hour = 1; hour <= 12; hour++)
            {
                comboBox.Items.Add($"{hour:D2}:00");
                comboBox.Items.Add($"{hour:D2}:30");
            }
            comboBox.SelectedIndex = 0; // Seleccionar el primer elemento
        }

    }
}
