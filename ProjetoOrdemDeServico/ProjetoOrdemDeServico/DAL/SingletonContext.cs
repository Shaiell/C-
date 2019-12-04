﻿using ProjetoOrdemDeServico.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjetoOrdemDeServico.DAL
{
    class SingletonContext
    {
        private SingletonContext() { }
        private static Context ctx;
        public static Context GetInstance()
        {
            if (ctx == null)
            {
                ctx = new Context();
            }
            return ctx;
        }
    }
}
