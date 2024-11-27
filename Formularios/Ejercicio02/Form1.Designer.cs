namespace Ejercicio02
{
    partial class Form1
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            tbNombre = new TextBox();
            cbEstudia = new CheckBox();
            cbTrabaja = new CheckBox();
            gbTipoTrabajo = new GroupBox();
            rbJornadaCompleta = new RadioButton();
            rbJornadaParcial = new RadioButton();
            rbOtros = new RadioButton();
            gbActividades = new GroupBox();
            cbActMetalurgia = new CheckBox();
            cbActComercio = new CheckBox();
            cbActGanaderia = new CheckBox();
            cbActServicios = new CheckBox();
            cbActInformatica = new CheckBox();
            cbActSeguros = new CheckBox();
            cbActSanidad = new CheckBox();
            cbActEducacion = new CheckBox();
            cbActJusticia = new CheckBox();
            statusStrip = new StatusStrip();
            slNombre = new ToolStripStatusLabel();
            slOcupacion = new ToolStripStatusLabel();
            slTrabajo = new ToolStripStatusLabel();
            slActividad = new ToolStripStatusLabel();
            gbTipoTrabajo.SuspendLayout();
            gbActividades.SuspendLayout();
            statusStrip.SuspendLayout();
            SuspendLayout();
            // 
            // tbNombre
            // 
            tbNombre.Location = new Point(20, 20);
            tbNombre.Name = "tbNombre";
            tbNombre.Size = new Size(200, 23);
            tbNombre.TabIndex = 0;
            // 
            // cbEstudia
            // 
            cbEstudia.Location = new Point(20, 60);
            cbEstudia.Name = "cbEstudia";
            cbEstudia.Size = new Size(100, 20);
            cbEstudia.TabIndex = 1;
            cbEstudia.Text = "Estudia";
            // 
            // cbTrabaja
            // 
            cbTrabaja.Location = new Point(20, 90);
            cbTrabaja.Name = "cbTrabaja";
            cbTrabaja.Size = new Size(100, 20);
            cbTrabaja.TabIndex = 2;
            cbTrabaja.Text = "Trabaja";
            // 
            // gbTipoTrabajo
            // 
            gbTipoTrabajo.Controls.Add(rbJornadaCompleta);
            gbTipoTrabajo.Controls.Add(rbJornadaParcial);
            gbTipoTrabajo.Controls.Add(rbOtros);
            gbTipoTrabajo.Location = new Point(20, 120);
            gbTipoTrabajo.Name = "gbTipoTrabajo";
            gbTipoTrabajo.Size = new Size(200, 100);
            gbTipoTrabajo.TabIndex = 3;
            gbTipoTrabajo.TabStop = false;
            gbTipoTrabajo.Text = "Tipo de Trabajo";
            // 
            // rbJornadaCompleta
            // 
            rbJornadaCompleta.Location = new Point(10, 20);
            rbJornadaCompleta.Name = "rbJornadaCompleta";
            rbJornadaCompleta.Size = new Size(120, 20);
            rbJornadaCompleta.TabIndex = 0;
            rbJornadaCompleta.Text = "Jornada Completa";
            // 
            // rbJornadaParcial
            // 
            rbJornadaParcial.Location = new Point(10, 40);
            rbJornadaParcial.Name = "rbJornadaParcial";
            rbJornadaParcial.Size = new Size(120, 20);
            rbJornadaParcial.TabIndex = 1;
            rbJornadaParcial.Text = "Jornada Parcial";
            // 
            // rbOtros
            // 
            rbOtros.Location = new Point(10, 60);
            rbOtros.Name = "rbOtros";
            rbOtros.Size = new Size(120, 20);
            rbOtros.TabIndex = 2;
            rbOtros.Text = "Otros";
            // 
            // gbActividades
            // 
            gbActividades.Controls.Add(cbActMetalurgia);
            gbActividades.Controls.Add(cbActComercio);
            gbActividades.Controls.Add(cbActGanaderia);
            gbActividades.Controls.Add(cbActServicios);
            gbActividades.Controls.Add(cbActInformatica);
            gbActividades.Controls.Add(cbActSeguros);
            gbActividades.Controls.Add(cbActSanidad);
            gbActividades.Controls.Add(cbActEducacion);
            gbActividades.Controls.Add(cbActJusticia);
            gbActividades.Location = new Point(250, 20);
            gbActividades.Name = "gbActividades";
            gbActividades.Size = new Size(200, 200);
            gbActividades.TabIndex = 4;
            gbActividades.TabStop = false;
            gbActividades.Text = "Actividades";
            // 
            // cbActMetalurgia
            // 
            cbActMetalurgia.Location = new Point(0, 0);
            cbActMetalurgia.Name = "cbActMetalurgia";
            cbActMetalurgia.Size = new Size(104, 24);
            cbActMetalurgia.TabIndex = 0;
            cbActMetalurgia.Text = "Metalurgia";
            // 
            // cbActComercio
            // 
            cbActComercio.Location = new Point(0, 0);
            cbActComercio.Name = "cbActComercio";
            cbActComercio.Size = new Size(104, 24);
            cbActComercio.TabIndex = 1;
            cbActComercio.Text = "Comercio";
            // 
            // cbActGanaderia
            // 
            cbActGanaderia.Location = new Point(0, 0);
            cbActGanaderia.Name = "cbActGanaderia";
            cbActGanaderia.Size = new Size(104, 24);
            cbActGanaderia.TabIndex = 2;
            cbActGanaderia.Text = "Ganadería";
            // 
            // cbActServicios
            // 
            cbActServicios.Location = new Point(0, 0);
            cbActServicios.Name = "cbActServicios";
            cbActServicios.Size = new Size(104, 24);
            cbActServicios.TabIndex = 3;
            cbActServicios.Text = "Servicios";
            // 
            // cbActInformatica
            // 
            cbActInformatica.Location = new Point(0, 0);
            cbActInformatica.Name = "cbActInformatica";
            cbActInformatica.Size = new Size(104, 24);
            cbActInformatica.TabIndex = 4;
            cbActInformatica.Text = "Informática";
            // 
            // cbActSeguros
            // 
            cbActSeguros.Location = new Point(0, 0);
            cbActSeguros.Name = "cbActSeguros";
            cbActSeguros.Size = new Size(104, 24);
            cbActSeguros.TabIndex = 5;
            cbActSeguros.Text = "Seguros";
            // 
            // cbActSanidad
            // 
            cbActSanidad.Location = new Point(0, 0);
            cbActSanidad.Name = "cbActSanidad";
            cbActSanidad.Size = new Size(104, 24);
            cbActSanidad.TabIndex = 6;
            cbActSanidad.Text = "Sanidad";
            // 
            // cbActEducacion
            // 
            cbActEducacion.Location = new Point(0, 0);
            cbActEducacion.Name = "cbActEducacion";
            cbActEducacion.Size = new Size(104, 24);
            cbActEducacion.TabIndex = 7;
            cbActEducacion.Text = "Educación";
            // 
            // cbActJusticia
            // 
            cbActJusticia.Location = new Point(0, 0);
            cbActJusticia.Name = "cbActJusticia";
            cbActJusticia.Size = new Size(104, 24);
            cbActJusticia.TabIndex = 8;
            cbActJusticia.Text = "Justicia";
            // 
            // statusStrip
            // 
            statusStrip.Items.AddRange(new ToolStripItem[] { slNombre, slOcupacion, slTrabajo, slActividad });
            statusStrip.Location = new Point(0, 278);
            statusStrip.Name = "statusStrip";
            statusStrip.Size = new Size(480, 22);
            statusStrip.TabIndex = 5;
            statusStrip.Text = "statusStrip";
            // 
            // slNombre
            // 
            slNombre.Name = "slNombre";
            slNombre.Size = new Size(51, 17);
            slNombre.Text = "Nombre";
            // 
            // slOcupacion
            // 
            slOcupacion.Name = "slOcupacion";
            slOcupacion.Size = new Size(65, 17);
            slOcupacion.Text = "Ocupación";
            // 
            // slTrabajo
            // 
            slTrabajo.Name = "slTrabajo";
            slTrabajo.Size = new Size(45, 17);
            slTrabajo.Text = "Trabajo";
            // 
            // slActividad
            // 
            slActividad.Name = "slActividad";
            slActividad.Size = new Size(57, 17);
            slActividad.Text = "Actividad";
            // 
            // Form1
            // 
            ClientSize = new Size(480, 300);
            Controls.Add(tbNombre);
            Controls.Add(cbEstudia);
            Controls.Add(cbTrabaja);
            Controls.Add(gbTipoTrabajo);
            Controls.Add(gbActividades);
            Controls.Add(statusStrip);
            Name = "Form1";
            Text = "Formulario de Información";
            gbTipoTrabajo.ResumeLayout(false);
            gbActividades.ResumeLayout(false);
            statusStrip.ResumeLayout(false);
            statusStrip.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private System.Windows.Forms.TextBox tbNombre;
        private System.Windows.Forms.CheckBox cbEstudia;
        private System.Windows.Forms.CheckBox cbTrabaja;
        private System.Windows.Forms.GroupBox gbTipoTrabajo;
        private System.Windows.Forms.RadioButton rbJornadaCompleta;
        private System.Windows.Forms.RadioButton rbJornadaParcial;
        private System.Windows.Forms.RadioButton rbOtros;
        private System.Windows.Forms.GroupBox gbActividades;
        private System.Windows.Forms.CheckBox cbActMetalurgia;
        private System.Windows.Forms.CheckBox cbActComercio;
        private System.Windows.Forms.CheckBox cbActGanaderia;
        private System.Windows.Forms.CheckBox cbActServicios;
        private System.Windows.Forms.CheckBox cbActInformatica;
        private System.Windows.Forms.CheckBox cbActSeguros;
        private System.Windows.Forms.CheckBox cbActSanidad;
        private System.Windows.Forms.CheckBox cbActEducacion;
        private System.Windows.Forms.CheckBox cbActJusticia;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel slNombre;
        private System.Windows.Forms.ToolStripStatusLabel slOcupacion;
        private System.Windows.Forms.ToolStripStatusLabel slTrabajo;
        private System.Windows.Forms.ToolStripStatusLabel slActividad;
    }
}
