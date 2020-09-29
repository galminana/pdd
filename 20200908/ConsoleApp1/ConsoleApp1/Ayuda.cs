using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public static class Ayuda
    {
        public static int Resultado { get; set; }
        public static int Sumar(int valor1, int valor2)
        {
            Resultado = valor1 + valor2;
            return Resultado;
        }
    }
}
