using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ProyectoArkanoid.Controladores
{
    public class BlocksRemove : PictureBox
    {
        public int contador { get; set; }

        public BlocksRemove(int contador) : base()
        {
            this.contador = contador;
        }

        public int setContador()
        {
            return contador++;
        }

        public void BorrarBloque()
        {
            if (setContador() == 2)
                this.Visible = false;
            else
                setContador();
        }
    }
}
