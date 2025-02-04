using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Ejercicio1
{
    public partial class Form1 : Form
    {
        public class Cliente
        {
            public string ID { get; set; }
            public string Pais { get; set; }

            public Cliente(string id, string pais)
            {
                ID = id;
                Pais = pais;
            }
        }

        private List<Cliente> clientes; // Declaración de la colección

        public Form1()
        {
            InitializeComponent();
            clientes = new List<Cliente>(); // Inicialización de la colección
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            CargarDatosClientes();
            ActualizarTreeView();
        }

        private void CargarDatosClientes()
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Northwind;Integrated Security=True";
            string sql = "SELECT CustomerID, Country FROM Customers";

            try
            {
                using (SqlConnection con = new SqlConnection(connectionString))
                {
                    con.Open();
                    SqlCommand cmd = new SqlCommand(sql, con);
                    SqlDataReader reader = cmd.ExecuteReader();

                    while (reader.Read())
                    {
                        string id = reader["CustomerID"].ToString();
                        string pais = reader["Country"].ToString();

                        // Crear un nuevo cliente y añadirlo a la colección
                        clientes.Add(new Cliente(id, pais));
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al cargar los datos: {ex.Message}");
            }
        }

        private void ActualizarTreeView()
        {
            // Limpiar el TreeView antes de añadir datos
            treeViewClientes.Nodes.Clear();

            // Agrupar los clientes por país y ordenarlos alfabéticamente
            var clientesPorPais = clientes.GroupBy(c => c.Pais)
                                          .OrderBy(g => g.Key);

            // Añadir cada país como un nodo principal en el TreeView
            foreach (var grupo in clientesPorPais)
            {
                TreeNode nodoPais = new TreeNode(grupo.Key);

                // Añadir cada cliente como un nodo hijo del país correspondiente
                foreach (var cliente in grupo)
                {
                    nodoPais.Nodes.Add(new TreeNode(cliente.ID));
                }

                treeViewClientes.Nodes.Add(nodoPais);
            }
        }

        private void treeViewClientes_AfterSelect(object sender, TreeViewEventArgs e)
        {
            if (e.Node.Parent == null)
            {
                // Nodo principal seleccionado (País)
                MessageBox.Show($"País seleccionado: {e.Node.Text}");
            }
            else
            {
                // Nodo hijo seleccionado (Cliente)
                MessageBox.Show($"Cliente seleccionado: {e.Node.Text}");
            }
        }
    }
}
