namespace Controles
{
    public partial class MiReloj : UserControl
    {
        public MiReloj()
        {
            InitializeComponent();
        }
        private Color colorFondo;
        private Color color;
        public Color ColorFondo 
        { 
            get { return colorFondo; } 
            set { colorFondo = value; lDisplay.BackColor = colorFondo; } 
        }
        public Color Color 
        { 
            get { return color; } 
            set 
            { 
                color = value; 
                lDisplay.ForeColor = color;
            } 
        }

        protected virtual void timer1_Tick(object sender, EventArgs e)
        {
            lDisplay.Text = string.Format("{0,2:00}:{1,2:00}:{2,2:00}", DateTime.Now.Hour, DateTime.Now.Minute, DateTime.Now.Second);
        }
    }
}
