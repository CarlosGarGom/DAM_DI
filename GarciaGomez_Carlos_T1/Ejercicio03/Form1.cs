using System.ComponentModel;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        private BindingList<string> citasSource;

        public Form1()
        {
            InitializeComponent(); 

          
            citasSource = new BindingList<string>();
            lbCitas.DataSource = citasSource;

           
            Load += Form1_Load;

          
            bAñadir.Click += bAñadir_Click;
        }

        private void Form1_Load(object sender, EventArgs e)
        {
        
            for (int hour = 1; hour <= 12; hour++)
            {
                cbHora.Items.Add($"{hour:D2}:00");
                cbHora.Items.Add($"{hour:D2}:30");
            }

           
            cbHora.SelectedIndex = 0;

           
            mcCalendario.MinDate = DateTime.Today; 
            mcCalendario.MaxSelectionCount = 1;
        }

        private void bAñadir_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(tbCitas.Text))
            {
                MessageBox.Show("El texto de la cita no puede estar vacío.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            
            string hora = cbHora.SelectedItem?.ToString();
            if (hora == null)
            {
                MessageBox.Show("Por favor, selecciona una hora válida.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string amPm = rbAM.Checked ? "AM" : "PM";

 
            string nuevaCita = $"{hora} {amPm} {tbCitas.Text}";

            citasSource.Add(nuevaCita);

            tbCitas.Clear();
            rbAM.Checked = true;
            cbHora.SelectedIndex = 0;
        }


        private void rbAM_CheckedChanged(object sender, EventArgs e)
        {
        }

        private void bBorrar_Click_1(object sender, EventArgs e)
        {
            if (lbCitas.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una cita para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string citaSeleccionada = lbCitas.SelectedItem as string;
            if (citaSeleccionada != null)
            {
                citasSource.Remove(citaSeleccionada);
            }
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
           
        }

        private void bGuardar_Click_1(object sender, EventArgs e)
        {
            if (citasSource.Count == 0)
            {
                MessageBox.Show("No hay citas para guardar.", "Información", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            DateTime fechaSeleccionada = mcCalendario.SelectionRange.Start;
            string diaDelAño = fechaSeleccionada.DayOfYear.ToString();
            string año = fechaSeleccionada.Year.ToString();

            string directorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, año);
            Directory.CreateDirectory(directorio);

            string rutaArchivo = Path.Combine(directorio, $"{diaDelAño}.txt");
            File.WriteAllLines(rutaArchivo, citasSource.Cast<string>());

            
            MessageBox.Show($"Citas guardadas correctamente en:\n{rutaArchivo}", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
