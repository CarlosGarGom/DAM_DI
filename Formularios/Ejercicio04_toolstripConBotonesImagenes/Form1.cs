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
            listPulsado.Items.Add("Se ha pulsado el bot�n n�1 ");
        }

        private void tsbCamara_Click(object sender, EventArgs e)
        {
            listPulsado.Items.Add("Se ha pulsado el bot�n n�2 ");
        }
        
        private void tsLlaves_ButtonClick(object sender, EventArgs e)
        {
            listPulsado.Items.Add("Se ha pulsado el bot�n n�3 ");

        }
        private void tsbLlaves_Click(object sender, EventArgs e)
        {
            listPulsado.Items.Add("Se ha pulsado el bot�n n�4 ");
        }

        private void tsbError_ButtonClick(object sender, EventArgs e)
        {
            listPulsado.Items.Add("Se ha pulsado el bot�n n�5 ");
        }

        private void tsbBuscar_Click(object sender, EventArgs e)
        {
            listPulsado.Items.Add("Se ha pulsado el bot�n n�6 ");
        }

        private void tsbUsuarios_Click(object sender, EventArgs e)
        {
            listPulsado.Items.Add("Se ha pulsado el bot�n n�7 ");
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {

        }


    }
}
