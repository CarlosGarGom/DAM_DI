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

namespace Ejercicio8
{
    public partial class Form1 : Form
    {
        private string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=Biblioteca;Integrated Security=True";
        public Form1()
        {
            InitializeComponent();
        }

        private void librosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.libros' Puede moverla o quitarla según sea necesario.
            
        }
        private void CargarLibrosPrestados()
        {
            
        }
        private void ActualizarLectores(int idLibro)
        {
            
        }

        private void DgvLibros_SelectionChanged(object sender, EventArgs e)
        {
           
        }
        private void lectoresBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
          

        }
    }
}
