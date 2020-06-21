using System.Windows.Forms;

namespace ProyectoArkanoid.Controladores
{
    public class CustomPictureBox : PictureBox
    {
        public int Hits { get; set; }

        public CustomPictureBox() : base() { }
    }  
}
