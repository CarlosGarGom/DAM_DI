using static System.Windows.Forms.VisualStyles.VisualStyleElement.Window;

namespace VariosFormularios
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void bSexo_Click(object sender, EventArgs e)
        {
            Form2 cdSexo = new Form2();
            if (cdSexo.ShowDialog() == DialogResult.Cancel)
            {
                lResultado.Text = "Cancelar";
            }
            else
            {
                 if (cdSexo.rbMasculino.Checked)
                     lResultado.Text = "Masculino";
                 else if (cdSexo.rbFemenino.Checked)
                     lResultado.Text = "Femenino";
                 else
                     lResultado.Text = "Sin selección";
            
            }
        }
    }
}
