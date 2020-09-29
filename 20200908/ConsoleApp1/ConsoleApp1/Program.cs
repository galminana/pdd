using System;
using ClassLibrary1;
using Mysql=ClassLibrary1.DAL.MySql;
using SQL=ClassLibrary1.DAL.SQLServer;
using ConsoleApp1.Componentes;
using System.Net.Http.Headers;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Calculadora calculadora = new Calculadora();
            Console.WriteLine(calculadora.Sumar(1, 2));

            CalculadoraCientifica cientifica = new CalculadoraCientifica();

            Ayuda.Sumar(1, 2);

            Ayuda.Sumar(1, 3);

            //Calculadora calculadora1 = new Calculadora(1,2);
            //Calculadora calculadora2;

            //calculadora2 = new Calculadora();

            //calculadora.Numero1 = 10;
            //Console.WriteLine(calculadora.Numero1);

            //calculadora.Numero2 = 32;
            //Console.WriteLine(calculadora.Numero2);

            //calculadora.Metodo(1);
            //calculadora.Metodo(1,2);
            //calculadora.Metodo();

            //calculadora2 = null;


            /**
             * */



        }
    }
}
