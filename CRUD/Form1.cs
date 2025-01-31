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
    public partial class CRUDCliente : Form
    {
        public CRUDCliente()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'clientesDS.Customers' Puede moverla o quitarla según sea necesario.
            this.customersTableAdapter.Fill(this.clientesDS.Customers);

        }


        private void bInsertar_Click(object sender, EventArgs e)
        {
            DetalleCliente dc = new DetalleCliente();
            dc.ShowDialog();
            this.customersTableAdapter.FillDataGridView(this.clientesDS.Customers);

        }

        private void bCerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void customersDataGridView_DoubleClick(object sender, EventArgs e)
        {
            DetalleCliente dc = new DetalleCliente();
            int i = this.customersBindingSource.Position;
            dc.id = this.clientesDS.Customers[i].CustomerID;
            dc.ShowDialog();
            this.customersTableAdapter.FillDataGridView(this.clientesDS.Customers);
        }
    }
}
