﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProyectoArkanoid.Controladores
{
    public class User
    {
        public string nickname { get; }

        public User(string nickname)
        {
            this.nickname = nickname;
        }
    }
}