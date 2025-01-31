using Controles;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MisControles
{
    public partial class MiAlarma2 : MiReloj
    {
        public MiAlarma2()
        {
            InitializeComponent();
        }
        [Category("Action")][Description("Se dispara cuando es la hora de la alarma")] public event Action AlarmaDisparada; public DateTime HoraAlarma { get; set; }
        public bool AlarmaActiva { get; set; }
        protected override void timer1_Tick(object sender, EventArgs e) {
            base.timer1_Tick(sender, e); 
            if (AlarmaActiva == false) return; 
            if (HoraAlarma.Date == DateTime.Now.Date && HoraAlarma.Hour == DateTime.Now.Hour && HoraAlarma.Minute == DateTime.Now.Minute) 
                AlarmaDisparada(); 
        }

        private void MiAlarma2_Load(object sender, EventArgs e)
        {

        }
    }
}
