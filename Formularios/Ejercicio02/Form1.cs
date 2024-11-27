namespace Ejercicio02
{
    partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            // Configuración de eventos
            tbNombre.TextChanged += TbNombre_TextChanged;
            cbEstudia.CheckedChanged += CbEstudia_CheckedChanged;
            cbTrabaja.CheckedChanged += CbTrabaja_CheckedChanged;
            rbJornadaCompleta.CheckedChanged += RbTipoTrabajo_CheckedChanged;
            rbJornadaParcial.CheckedChanged += RbTipoTrabajo_CheckedChanged;
            rbOtros.CheckedChanged += RbTipoTrabajo_CheckedChanged;

            // Configuración inicial
            gbTipoTrabajo.Enabled = cbTrabaja.Checked;
            ActualizarBarraEstado();
            // Configura la posición de los CheckBox en el constructor (fuera de InitializeComponent)
            int posY = 20;
            foreach (CheckBox cb in new[] { cbActMetalurgia, cbActComercio, cbActGanaderia, cbActServicios, cbActInformatica, cbActSeguros, cbActSanidad, cbActEducacion, cbActJusticia })
            {
                cb.Location = new System.Drawing.Point(10, posY);
                cb.Size = new System.Drawing.Size(120, 20);
                this.gbActividades.Controls.Add(cb);
                posY += 20;
            }

            // Agrega el evento CheckedChanged a cada CheckBox de actividades
            foreach (var control in gbActividades.Controls.OfType<CheckBox>())
            {
                control.CheckedChanged += Actividades_CheckedChanged;
            }
        }
        private void Actividades_CheckedChanged(object sender, EventArgs e)
        {
            // Obtiene las actividades seleccionadas
            var actividadesSeleccionadas = gbActividades.Controls.OfType<CheckBox>()
                .Where(cb => cb.Checked)
                .Select(cb => cb.Text)
                .ToArray();

            // Actualiza el texto del ToolStripStatusLabel de actividades
            slActividad.Text = "Actividades: " + (actividadesSeleccionadas.Length > 0 ? string.Join(", ", actividadesSeleccionadas) : "Ninguna");
        }
        private void TbNombre_TextChanged(object sender, EventArgs e)
        {
            // Actualizar el nombre en la barra de estado
            slNombre.Text = tbNombre.Text;
        }

        private void CbEstudia_CheckedChanged(object sender, EventArgs e)
        {
            // Actualizar la ocupación en la barra de estado
            ActualizarBarraEstado();
        }

        private void CbTrabaja_CheckedChanged(object sender, EventArgs e)
        {
            // Habilitar o deshabilitar el grupo de tipo de trabajo
            gbTipoTrabajo.Enabled = cbTrabaja.Checked;
            ActualizarBarraEstado();
        }

        private void RbTipoTrabajo_CheckedChanged(object sender, EventArgs e)
        {
            // Actualizar el tipo de trabajo en la barra de estado
            ActualizarBarraEstado();
        }

        private void ActualizarBarraEstado()
        {
            // Actualizar estado del nombre
            slNombre.Text = tbNombre.Text;

            // Actualizar ocupación
            string ocupacion = "";
            if (cbEstudia.Checked)
                ocupacion += "Estudia ";
            if (cbTrabaja.Checked)
                ocupacion += "Trabaja";
            slOcupacion.Text = ocupacion;

            // Actualizar tipo de trabajo
            if (cbTrabaja.Checked)
            {
                if (rbJornadaCompleta.Checked)
                    slTrabajo.Text = "Jornada Completa";
                else if (rbJornadaParcial.Checked)
                    slTrabajo.Text = "Jornada Parcial";
                else if (rbOtros.Checked)
                    slTrabajo.Text = "Otros";
                else
                    slTrabajo.Text = "";
            }
            else
            {
                slTrabajo.Text = "";
            }

            // Actualizar actividad
            var actividades = new List<string>();
            if (cbActMetalurgia.Checked) actividades.Add("Metalurgia");
            if (cbActComercio.Checked) actividades.Add("Comercio");
            if (cbActGanaderia.Checked) actividades.Add("Ganadería");
            if (cbActServicios.Checked) actividades.Add("Servicios");
            if (cbActInformatica.Checked) actividades.Add("Informática");
            if (cbActSeguros.Checked) actividades.Add("Seguros");
            if (cbActSanidad.Checked) actividades.Add("Sanidad");
            if (cbActEducacion.Checked) actividades.Add("Educación");
            if (cbActJusticia.Checked) actividades.Add("Justicia");

            slActividad.Text = string.Join(", ", actividades);
        }
    }
}
