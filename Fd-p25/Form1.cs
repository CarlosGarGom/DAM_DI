﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Fd_p25
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void librosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.librosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.bibliotecaDataSet.libros);
            // TODO: esta línea de código carga datos en la tabla 'bibliotecaDataSet.libros' Puede moverla o quitarla según sea necesario.
            this.librosTableAdapter.Fill(this.bibliotecaDataSet.libros);

        }

        private void librosBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.librosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.bibliotecaDataSet);

        }
    }
}
