using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArkanoid.Controladores
{
    public static class DatosJuego
    {
        public static bool juegoIniciado = false;
        //dirX ^ dirY establecen el movimiento de la pelota
        public static int dirX = 10, dirY = -dirX; 
    }
}
