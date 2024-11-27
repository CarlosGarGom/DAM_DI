using System.Security.Cryptography;
using System.Windows.Forms;

namespace NumericDomainUpDown
{
    public partial class Form1 : Form
    {
        Random rnd = new Random();
        string ruta = "C:\\Users\\admin\\Desktop\\CarlosGarcia\\DAM_DI\\Formularios\\Resources\\";
        string[] iconos = ["camera.ico", "users.ico", "otheroptions.ico", "user.ico", "users.ico", "keys.ico", "lupa.ico", "noresults.ico"];
        public Form1()
        {
            InitializeComponent();
            //string diasSemana[] = ["Lunes", "Martes"];
            //dSemana.Text = "Lunes";
            //dSemana.Items.Insert(0, "Lunes");
            //dSemana.Items.Insert(1, "Martes");
            //dSemana.Items.Insert(2, "Miercoles");
            //dSemana.Items.Insert(3, "Jueves");
            //dSemana.Items.Insert(4, "Viernes");
            //dSemana.Items.Insert(5, "Sabado");
            //dSemana.Items.Insert(6, "Domingo");


        }

        private void dSemana_SelectedItemChanged(object sender, EventArgs e)
        {
            numericUpDown1.Value = dSemana.SelectedIndex;
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dSemana.SelectedIndex = (int)numericUpDown1.Value;
        }
        private void timer1_Tick(object sender, EventArgs e)
        {

        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            progressBar1.Value++;
            if (progressBar1.Value == progressBar1.Maximum)
            {
                timer1.Stop();
                progressBar1.Value = 0;
            }
        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void sbRojo_ValueChanged(object sender, EventArgs e)
        {
            lRojo.Text = sbRojo.Value.ToString();
            pColor.BackColor = Color.FromArgb(sbRojo.Value, sbVerde.Value, sbAzul.Value);
        }

        private void sbVerde_ValueChanged(object sender, EventArgs e)
        {
            lVerde.Text = sbVerde.Value.ToString();
            pColor.BackColor = Color.FromArgb(sbRojo.Value, sbVerde.Value, sbAzul.Value);
        }

        private void sbAzul_ValueChanged(object sender, EventArgs e)
        {
            lAzul.Text = sbAzul.Value.ToString();
            pColor.BackColor = Color.FromArgb(sbRojo.Value, sbVerde.Value, sbAzul.Value);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            colorea();

            imagenAleatoria();
        }

        private void bColorea_Click(object sender, EventArgs e)
        {
            colorea();
        }
        private void colorea()
        {
            sbRojo.Value = rnd.Next(1, 255);
            sbVerde.Value = rnd.Next(1, 255);
            sbAzul.Value = rnd.Next(1, 255);
        }
        private void imagenAleatoria()
        {
            pictureBox1.ImageLocation = ruta + iconos[rnd.Next(iconos.Length)];
        }
        private void pictureBox1_Click(object sender, EventArgs e)
        {
            imagenAleatoria();
        }

    }
}
