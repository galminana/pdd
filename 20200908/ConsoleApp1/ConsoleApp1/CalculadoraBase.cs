using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public abstract class CalculadoraBase
    {
        public virtual int Restar(int valor1, int valor2)
        {
            return valor1 - valor1;
        }

        public abstract int Division(int valor1, int valor2);

    }
}
