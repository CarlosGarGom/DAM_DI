using System.Xml.Linq;

namespace PrediccionTiempo
{
    public partial class Form1 : Form
    {
        private string xmlContent;
        private XDocument xmlDoc;

        public Form1()
        {
            InitializeComponent();
        }

        private async void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.Items.Clear();
            string ciudad = (string)comboBox1.SelectedItem;
            string url = ciudad switch
            {
                "Ávila" => "http://www.aemet.es/xml/municipios/localidad_05019.xml",
                "Burgos" => "http://www.aemet.es/xml/municipios/localidad_09059.xml",
                "León" => "http://www.aemet.es/xml/municipios/localidad_24089.xml",
                "Palencia" => "http://www.aemet.es/xml/municipios/localidad_34120.xml",
                "Salamanca" => "http://www.aemet.es/xml/municipios/localidad_37274.xml",
                "Segovia" => "http://www.aemet.es/xml/municipios/localidad_40194.xml",
                "Soria" => "http://www.aemet.es/xml/municipios/localidad_42173.xml",
                "Valladolid" => "http://www.aemet.es/xml/municipios/localidad_47186.xml",
                "Zamora" => "http://www.aemet.es/xml/municipios/localidad_49275.xml",
                _ => throw new ArgumentException("Ciudad no soportada")
            };

            await CargarFechasDesdeXml(url);
        }

        private async Task CargarFechasDesdeXml(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    xmlContent = await client.GetStringAsync(url);
                    xmlDoc = XDocument.Parse(xmlContent);
                    comboBox2.Items.Clear();
                    var fechas = xmlDoc.Descendants("dia")
                                      .Attributes("fecha")
                                      .Select(a => a.Value)
                                      .Distinct()
                                      .ToList();
                    foreach (var fecha in fechas)
                    {
                        comboBox2.Items.Add(fecha);
                    }

                    if (comboBox2.Items.Count > 0)
                    {
                        comboBox2.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los datos: {ex.Message}");
            }
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            string fechaSeleccionada = comboBox2.SelectedItem.ToString();
            ActualizarLabelsConDatos(fechaSeleccionada);
        }

        private void ActualizarLabelsConDatos(string fechaSeleccionada)
        {
            try
            {
                var diaSeleccionado = xmlDoc.Descendants("dia")
                                             .FirstOrDefault(d => (string)d.Attribute("fecha") == fechaSeleccionada);

                if (diaSeleccionado != null)
                {
                    var periodos = diaSeleccionado.Descendants("prob_precipitacion")
                               .Select(p => (string)p.Attribute("periodo") ?? "-")
                               .ToList();

                    var probabilidades = diaSeleccionado.Descendants("prob_precipitacion")
                                                  .Select(p => string.IsNullOrEmpty(p.Value) ? "0" : p.Value)
                                                  .ToList();

                    for (int i = 0; i < periodos.Count && i < 5; i++)
                    {
                        switch (i)
                        {
                            case 0: label5.Text = periodos[i]; break;
                            case 1: label6.Text = periodos[i]; break;
                            case 2: label7.Text = periodos[i]; break;
                            case 3: label8.Text = periodos[i]; break;
                            case 4: label9.Text = periodos[i]; break;
                        }
                    }

                    for (int i = 0; i < probabilidades.Count && i < 6; i++)
                    {
                        switch (i)
                        {
                            case 0: label10.Text = probabilidades[i] + "%"; break;
                            case 1: label11.Text = probabilidades[i] + "%"; break;
                            case 2: label12.Text = probabilidades[i] + "%"; break;
                            case 3: label13.Text = probabilidades[i] + "%"; break;
                            case 4: label14.Text = probabilidades[i] + "%"; break;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al actualizar los datos: {ex.Message}");
            }
        }
    }
}
