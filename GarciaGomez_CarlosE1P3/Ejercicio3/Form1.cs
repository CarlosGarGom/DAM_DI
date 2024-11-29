using System.ComponentModel;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        private BindingList<string> diccionarioSource;
        public Form1()
        {

            InitializeComponent();
            diccionarioSource = new BindingList<string>();
            lbDiccionario.DataSource = diccionarioSource;
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void bA�adir_Click(object sender, EventArgs e)
        {
            if (tbEspa�ol.Text == "" || tbIngles.Text == "")
            {
                MessageBox.Show("Uno de los campos est� vac�o", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            var palabra = $"{tbEspa�ol.Text} - {tbIngles.Text}";
            if (diccionarioSource.Any(x => x.Equals(palabra, StringComparison.OrdinalIgnoreCase)))
            {
                MessageBox.Show($"Las palabras '{tbEspa�ol.Text} - {tbIngles.Text}' ya existe en el diccionario", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            string nuevaPalabra = $"{tbEspa�ol.Text} - {tbIngles.Text}";
            diccionarioSource.Add(nuevaPalabra);

 

            tbEspa�ol.Clear();
            tbIngles.Clear();
        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            if (lbDiccionario.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una palabra para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string palabraSeleccionada = lbDiccionario.SelectedItem as string;
            if (palabraSeleccionada != null)
            {
                diccionarioSource.Remove(palabraSeleccionada);
            }
        }

        private void bEditar_Click(object sender, EventArgs e)
        {
            if (lbDiccionario.SelectedIndex == -1)
            {
                MessageBox.Show("Por favor, selecciona una palabra para borrar.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;

            }
            string palabraSeleccionada = lbDiccionario.SelectedItem as string;
            string palabraEspa�ol= palabraSeleccionada.Split("-")[0];
            string palabraIngles = palabraSeleccionada.Split("-")[1];
            tbEspa�ol.Text = palabraEspa�ol;
            tbIngles.Text = palabraIngles;
            diccionarioSource.Remove(palabraSeleccionada);
        }

        private void bGuardar_Click(object sender, EventArgs e)
        {
            if (diccionarioSource.Count == 0)
            {
                MessageBox.Show("No hay palabras para guardar.", "Informaci�n", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string directorio = Path.Combine(AppDomain.CurrentDomain.BaseDirectory, "Diccionario");
            Directory.CreateDirectory(directorio);

            string rutaArchivo = Path.Combine(directorio, "diccionario.txt");
            File.WriteAllLines(rutaArchivo, diccionarioSource.Cast<string>());
            MessageBox.Show($"Diccionario guardado correctamente en:\n{rutaArchivo}", "Guardado", MessageBoxButtons.OK, MessageBoxIcon.Information);

            diccionarioSource.Clear();
        }

        private void bCargar_Click(object sender, EventArgs e)
        {

        }

    }
}
