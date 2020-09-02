using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            int intentos = 1;
            string clave = "";
            while (clave!="secreto" && intentos<4)
            {
                Console.Write($"Ingrese la contrasena:{clave} ");
                clave = Console.ReadLine();
                int valor = int.Parse(clave);
                intentos++;
            }

            //do
            //{
            //    Console.WriteLine(numero);
            //} while (numero < 10);


            Console.WriteLine("Hello World!");
        }
    }
}

