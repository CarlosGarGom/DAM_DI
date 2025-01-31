using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CRUD
{
    public partial class DetalleCliente : Form
    {
        public string id { get; set; }
        public DetalleCliente()
        {
            InitializeComponent();
        }

        private void DetalleCliente_Load(object sender, EventArgs e)
        {
            if (id == null) { bEliminar.Hide(); 
                customersBindingSource.AddNew(); } else { 
                customersTableAdapter.FillByID(this.clientesDS.Customers, id); 
                customerIDTextBox.ReadOnly = true; 
            }
          

        }

        private void bEliminar_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("¿Realmente desea eliminar los datos?", "Confirmación", MessageBoxButtons.YesNo); 
            if (dr == DialogResult.Yes) {
                customersBindingSource.RemoveCurrent(); 
                guardar(); 
            }
            this.Close();
        }

        private void bAceptar_Click(object sender, EventArgs e)
        {
            guardar();
        }
        private void guardar() { try { 
                customersBindingSource.EndEdit(); 
                customersTableAdapter.Update(this.clientesDS); 
                this.Close(); 
            } catch (Exception ex) {
                MessageBox.Show(ex.Message); 
            } 
        }
    }
}
