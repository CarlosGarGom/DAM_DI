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
    public partial class LookUpEmpleados : Form
    {
        public string ID { get; set; }
        public LookUpEmpleados()
        {
            InitializeComponent();
        }


        private void LookUpEmpleados_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'empleadosDS.Employees' Puede moverla o quitarla según sea necesario.
            this.employeesTableAdapter.Fill(this.empleadosDS.Employees);

        }

        private void bBuscar_Click(object sender, EventArgs e)
        {
            if (tbBuscar.Text != "")
                employeesTableAdapter.FillByPatron(empleadosDS.Employees, tbBuscar.Text);
        }

        private void employeesDataGridView_DoubleClick(object sender, EventArgs e)
        {
            int i = employeesBindingSource.Position;
            string ID = empleadosDS.Employees[i].EmployeeID.ToString();

            this.Close();
        }
    }
}
