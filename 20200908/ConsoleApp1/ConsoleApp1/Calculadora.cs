using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    /*
     * public
     * private
     * Protected
     * internal
     * intenal protected
     * private proctected
     */
    public class Calculadora : CalculadoraBase
    {
        
        public override int Division(int valor1, int valor2)
        {
            base.Indice
            return valor1 / valor1;
        }

        public sealed override int Restar(int valor1, int valor2)
        {
            return  valor2-valor1;
        }

        public int Sumar(int numero1, int numero2)
        {
            return numero1+numero2;
        }

        //public int Metodo(int valor)
        //{
        //    return 0;
        //}

        //public int Metodo(int valor, int valor2)
        //{
        //    return 0;
        //}

        //public int Metodo()
        //{
        //    if (Numero1 == Numero2)
        //    {
        //        return 0;
        //    }
        //    return 1;
        //}

        //protected class Operacion
        //{

        //}
    }
}
