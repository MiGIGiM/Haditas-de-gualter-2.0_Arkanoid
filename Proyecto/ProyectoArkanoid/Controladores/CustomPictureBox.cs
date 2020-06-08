using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoArkanoid.Controladores
{
    public class CustomPictureBox : PictureBox
    {
        public int Golpes { get; set; }

        public CustomPictureBox() : base() { }
    }
    
}
