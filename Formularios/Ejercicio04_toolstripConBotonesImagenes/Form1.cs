namespace Ejercicio04_toolstripConBotonesImagenes
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void tsbUsuario_Click(object sender, EventArgs e)
        {
            listPulsado.Items.Add("Se ha pulsado el botón nº1 ");
        }

        private void tsbCamara_Click(object sender, EventArgs e)
        {
            listPulsado.Items.Add("Se ha pulsado el botón nº2 ");
        }
        
        private void tsLlaves_ButtonClick(object sender, EventArgs e)
        {
            listPulsado.Items.Add("Se ha pulsado el botón nº3 ");

        }
        private void tsbLlaves_Click(object sender, EventArgs e)
        {
            listPulsado.Items.Add("Se ha pulsado el botón nº4 ");
        }

        private void tsbError_ButtonClick(object sender, EventArgs e)
        {
            listPulsado.Items.Add("Se ha pulsado el botón nº5 ");
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            listPulsado.Items.Add("Se ha pulsado el botón nº6 ");
        }

        private void tsbUsuarios_Click(object sender, EventArgs e)
        {
            listPulsado.Items.Add("Se ha pulsado el botón nº7 ");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }


    }
}
