using System.Windows.Forms;

namespace ProyectoArkanoid.Controladores
{
    public class CustomPictureBox : PictureBox
    {
        public int Golpes { get; set; }

        public CustomPictureBox() : base() { }
    }  
}
