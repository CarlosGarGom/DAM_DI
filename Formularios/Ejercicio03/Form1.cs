using System.Windows.Forms;

namespace Ejercicio03
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            calendario.MaxSelectionCount=14;
            calendario.MaxDate = new DateTime(2024, 12, 31);
            calendario.MinDate = DateTime.Today;
            calendario.DateChanged+=calendario_DateChanged;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void calendario_DateChanged(object sender, DateRangeEventArgs e)
        {
            lbFechas.Items.Clear();

            // Obtener las fechas de inicio y fin del rango seleccionado
            DateTime startDate = e.Start;
            DateTime endDate = e.End;
            // Agregar cada fecha en el rango al ListBox
            for (DateTime date = startDate; date <= endDate; date = date.AddDays(1))
            {
                lbFechas.Items.Add(date.ToString("dddd, dd MMMM yyyy"));
            }
        }
    }
}
