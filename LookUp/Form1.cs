using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LookUp
{
    public partial class AñadirOrdenes : Form
    {
        public AñadirOrdenes()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientesDS);

        }

        private void AñadirOrdenes_Load(object sender, EventArgs e)
        {
            
            ordersBindingSource.AddNew();
            orderIDTextBox.ReadOnly = true;
            customerIDTextBox.ReadOnly = true;
            employeeIDTextBox.ReadOnly = true;

        }

        private void bAceptar_Click(object sender, EventArgs e)
        {

            try
            {
                ordersBindingSource.EndEdit();
                ordersTableAdapter.Update(ordersDS);
            }
            catch (Exception er)
            {
                MessageBox.Show("Erro" + er.Message);
            }
            this.Close();
        }

        private void bCancelar_Click(object sender, EventArgs e)
        {
            this.Close();

        }

        private void bLookUpCustomers_Click(object sender, EventArgs e)
        {
            LookUpClientes lc = new LookUpClientes();
            lc.ShowDialog();
            customerIDTextBox.Text = lc.ID;

        }

        private void bLookUpEmpleados2_Click(object sender, EventArgs e)
        {
            LookUpEmpleados le = new LookUpEmpleados();
            le.ShowDialog();
            employeeIDTextBox.Text = le.ID;
        }
    }
}
