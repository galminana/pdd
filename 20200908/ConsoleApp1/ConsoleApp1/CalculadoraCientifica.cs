using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class CalculadoraCientifica : Calculadora
    {
        public double Potencia(int valor, int exponente)
        {
            return Math.Pow(valor, exponente);
        }
    }
}
