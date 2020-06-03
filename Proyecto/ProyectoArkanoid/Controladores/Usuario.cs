using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArkanoid.Controladores
{
    public class Usuario
    {
        public String nickname
        {
            get;
        }

        public Usuario(string nickname)
        {
            this.nickname = nickname;
        }
    }
}
