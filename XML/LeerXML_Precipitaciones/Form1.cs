using System.Net.Http;
using System.Threading.Tasks;
using System.Xml;
using System.Xml.Linq;

namespace LeerXML_Precipitaciones
{

    public partial class Form1 : Form
    {
        private string xmlContent;
        private XDocument xmlDoc;


        private Dictionary<string, string> provincias = new Dictionary<string, string>
        {
            { "Ávila", "http://www.aemet.es/xml/municipios/localidad_05019.xml" },
            { "Burgos", "http://www.aemet.es/xml/municipios/localidad_09059.xml" },
            { "León", "http://www.aemet.es/xml/municipios/localidad_24089.xml" },
            { "Palencia", "http://www.aemet.es/xml/municipios/localidad_34120.xml" },
            { "Salamanca", "http://www.aemet.es/xml/municipios/localidad_37274.xml" },
            { "Segovia", "http://www.aemet.es/xml/municipios/localidad_40194.xml" },
            { "Soria", "http://www.aemet.es/xml/municipios/localidad_42173.xml" },
            { "Valladolid", "http://www.aemet.es/xml/municipios/localidad_47186.xml" },
            { "Zamora", "http://www.aemet.es/xml/municipios/localidad_49275.xml" }
        };

        public Form1()
        {
            InitializeComponent();
            CargarProvincias();
        }

        private void CargarProvincias()
        {
            foreach (var provincia in provincias.Keys)
            {
                cmbProvincias.Items.Add(provincia);
            }
        }

        private async void cmbProvincias_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (cmbProvincias.SelectedItem != null)
            {
                string url = provincias[cmbProvincias.SelectedItem.ToString()];

                await CargarFechasDesdeXml(url);

            }
        }
        private async Task CargarFechasDesdeXml(string url)
        {
            try
            {
                using (HttpClient client = new HttpClient())
                {
                    xmlContent = await client.GetStringAsync(url);
                    xmlDoc = XDocument.Parse(xmlContent);
                    cmbFechas.Items.Clear();
                    var fechas = xmlDoc.Descendants("dia")
                                      .Attributes("fecha")
                                      .Select(a => a.Value)
                                      .Distinct()
                                      .ToList();
                    foreach (var fecha in fechas)
                    {
                        cmbFechas.Items.Add(fecha);
                    }

                    if (cmbFechas.Items.Count > 0)
                    {
                        cmbFechas.SelectedIndex = 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al obtener los datos: {ex.Message}");
            }
        }


        private void bVisualizar_Click(object sender, EventArgs e)
        {
            if (cmbProvincias.SelectedItem == null || cmbFechas.SelectedItem == null)
            {
                MessageBox.Show("Por favor, selecciona una provincia y una fecha.");
                return;
            }

            string url = provincias[cmbProvincias.SelectedItem.ToString()];
            string fechaSeleccionada = cmbFechas.SelectedItem.ToString();
            MostrarPrediccion(url, fechaSeleccionada);
        }

        private void MostrarPrediccion(string url, string fechaSeleccionada)
        {
            try
            {
                // Cargar el contenido XML descargado en un XmlDocument
                XmlDocument doc = new XmlDocument();
                doc.LoadXml(xmlContent); // Usar el contenido ya descargado en lugar de cargar desde la URL

                // Usar XPath para obtener los datos de la fecha seleccionada
                XmlNode nodoDia = doc.SelectSingleNode($"//prediccion/dia[@fecha='{fechaSeleccionada}']");
                if (nodoDia == null)
                {
                    MessageBox.Show("No se encontró información para la fecha seleccionada.");
                    return;
                }

                // Obtener los periodos horarios y probabilidades de precipitación
                XmlNodeList periodos = nodoDia.SelectNodes("prob_precipitacion");
                Label[] etiquetasPeriodo = { lblPeriodo1, lblPeriodo2, lblPeriodo3, lblPeriodo4, lblPeriodo5, lblPeriodo6 };
                Label[] etiquetasPrecipitacion = { lblPrecipitacion1, lblPrecipitacion2, lblPrecipitacion3, lblPrecipitacion4, lblPrecipitacion5, lblPrecipitacion6 };

                for (int i = 0; i < etiquetasPeriodo.Length; i++)
                {
                    if (i < periodos.Count)
                    {
                        string periodo = periodos[i].Attributes["periodo"]?.Value;
                        string probabilidad = periodos[i].InnerText;

                        etiquetasPeriodo[i].Text = !string.IsNullOrEmpty(periodo) ? $"{periodo} h" : "N/A";
                        etiquetasPrecipitacion[i].Text = !string.IsNullOrEmpty(probabilidad) ? $"{probabilidad} %" : "0 %";
                    }
                    else
                    {
                        etiquetasPeriodo[i].Text = "N/A";
                        etiquetasPrecipitacion[i].Text = "0 %";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al procesar la predicción: {ex.Message}");
            }
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
