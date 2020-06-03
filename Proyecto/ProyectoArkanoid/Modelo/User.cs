using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArkanoid.Controladores
{
    public class User
    {
        public String nickname
        {
            get;
        }

        public User(string nickname)
        {
            this.nickname = nickname;
        }
    }
}
