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
    public partial class LookUpClientes : Form
    {
        public string ID { get; set; }
        public LookUpClientes()
        {
            InitializeComponent();
        }

        private void customersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.customersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.clientesDS);

        }

        private void LookUpClientes_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientesDS.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.clientesDS.Customers);

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text != "")
                customersTableAdapter.FillByNombre(clientesDS.Customers, tbBuscar.Text);
        }

        private void customersDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int i = customersBindingSource.Position;
            ID = clientesDS.Customers[i].CustomerID;
            this.Close();

        }
    }
}
