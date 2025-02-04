using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Ejercicio3
{
    public partial class Form1 : Form
    {
        private DataSet dataSetBiblioteca;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatos();
        }

        private void CargarDatos()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=biblioteca;Integrated Security=True";
            string sql = @"
                SELECT 
                    libros.titulo_lib AS Titulo, 
                    lectores.nombre_lec AS NombreLector, 
                    prestamos.fecha_presta_pre AS FechaPrestamo, 
                    prestamos.fecha_devol_pre AS FechaDevolucion
                FROM 
                    prestamos
                INNER JOIN libros ON prestamos.id_lib_pre = libros.Id_lib
                INNER JOIN lectores ON prestamos.Id_lec_pre = lectores.Id_lec";

            try
            {
                using (SqlConnection connection = new SqlConnection(connectionString))
                {
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(sql, connection);

                    // Crear y llenar el DataSet
                    dataSetBiblioteca = new DataSet();
                    dataAdapter.Fill(dataSetBiblioteca, "prestamos");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            // Verificar que el DataSet esté inicializado
            if (dataSetBiblioteca == null || !dataSetBiblioteca.Tables.Contains("prestamos"))
            {
                MessageBox.Show("Los datos no se han cargado correctamente.");
                return;
            }

            // Limpiar los resultados anteriores
            lbResultados.Items.Clear();

            // Obtener la fecha seleccionada
            DateTime fechaSeleccionada = dtFecha.Value.Date;

            // Determinar el filtro según el RadioButton seleccionado
            string filtro = string.Empty;

            if (rbPrestamo.Checked)
            {
                filtro = $"FechaPrestamo = '{fechaSeleccionada.ToString("yyyy-MM-dd")}'";
            }
            else if (rbDevolucion.Checked)
            {
                filtro = $"FechaDevolucion = '{fechaSeleccionada.ToString("yyyy-MM-dd")}'";
            }
            else
            {
                MessageBox.Show("Por favor, selecciona una opción (Préstamo o Devolución).");
                return;
            }

            // Filtrar los datos en la tabla Prestamos del DataSet
            DataTable tablaPrestamos = dataSetBiblioteca.Tables["prestamos"];
            DataRow[] resultados = tablaPrestamos.Select(filtro);

            // Mostrar los resultados en el ListBox
            foreach (DataRow row in resultados)
            {
                string titulo = row["Titulo"].ToString();
                string nombreLector = row["NombreLector"].ToString();
                string fecha = rbPrestamo.Checked
                    ? Convert.ToDateTime(row["FechaPrestamo"]).ToString("dd/MM/yyyy")
                    : Convert.ToDateTime(row["FechaDevolucion"]).ToString("dd/MM/yyyy");
                string tipo = rbPrestamo.Checked ? "Préstamo" : "Devolución";

                lbResultados.Items.Add($"{titulo} – {nombreLector} – {tipo} {fecha}");
            }

            // Mostrar mensaje si no hay resultados
            if (resultados.Length == 0)
            {
                lbResultados.Items.Add("No se encontraron resultados.");
            }
        }
    }
}
