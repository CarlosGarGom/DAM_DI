using System.Windows.Forms;

namespace Ejercicio01
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }



        private void bA�adirIzquierda_Click(object sender, EventArgs e)
        {
            //lbIzquierda.Items.Contains(tbA�adirIzquierda.Text)
            if (tbA�adirIzquierda.Text != null)
            {
                lbIzquierda.Items.Add(tbA�adirIzquierda.Text);
            }
        }

        private void bA�adirDerecha_Click(object sender, EventArgs e)
        {
            if (tbA�adirDerecha.Text != null)
            {
                lbDerecha.Items.Add(tbA�adirDerecha.Text);
            }
        }

        private void bMoverIzquierda_Click(object sender, EventArgs e)
        {
            if (lbDerecha.SelectedItems.Count > 0)
            {
                // Crear una lista temporal para almacenar los elementos seleccionados
                var selectedItems = lbDerecha.SelectedItems.Cast<object>().ToList();

                // Agregar cada elemento seleccionado a lbIzquierda y eliminarlo de lbDerecha
                foreach (var item in selectedItems)
                {
                    lbIzquierda.Items.Add(item);
                    lbDerecha.Items.Remove(item);
                }
            }
        }

        private void bMoverIzquierdaTodos_Click(object sender, EventArgs e)
        {
            if (lbDerecha.Items.Count > 0)
            {

                foreach (var item in lbDerecha.Items)
                {
                    lbIzquierda.Items.Add(item);


                }

                lbDerecha.Items.Clear();
            }
        }
        private void bMoverDerecha_Click(object sender, EventArgs e)
        {

            if (lbIzquierda.SelectedItems.Count > 0)
            {
                // Crear una lista temporal para almacenar los elementos seleccionados
                var selectedItems = lbIzquierda.SelectedItems.Cast<object>().ToList();

                // Agregar cada elemento seleccionado a lbIzquierda y eliminarlo de lbDerecha
                foreach (var item in selectedItems)
                {
                    lbDerecha.Items.Add(item);
                    lbIzquierda.Items.Remove(item);
                }
            }
        }
        private void bMoverDerechaTodos_Click(object sender, EventArgs e)
        {
            if (lbIzquierda.Items.Count > 0)
            {

                foreach (var item in lbIzquierda.Items)
                {
                    lbDerecha.Items.Add(item);


                }

                lbIzquierda.Items.Clear();
            }
        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
