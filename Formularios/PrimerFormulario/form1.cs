using System.Windows.Forms;
public class Form1:Form{
    Button boton = new Button();
    TextBox caja = new TextBox();
    Form1(){
        boton.text="Boton";
        boton.Click += new EventHandler(this.BotonClick);
        boton.MouseEnter += new EventHandler(this.RatonIn);
        boton.MouseLeave += new EventHandler(this.RatonOut);
        Controls.Add(boton);
        Controls.Add(caja);
        caja.Top=20;
        caja.left=20;
        caja.Text="Fuera"

    }
    private void BotonClick(object sender, EventArgs e){
        MessageBox.Show("Has hecho click");
    }
    private void RatonIn(object sender, EventArgs e){
        caja.Text="Dentro";
    }
        private void RatonOut(object sender, EventArgs e){
        caja.Text="Fuera";
    }
    static void Main(){
        Application.Run(new Form1());
    }
}