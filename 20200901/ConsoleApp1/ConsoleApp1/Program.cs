using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Random random = new Random();
            int secreto = random.Next(10);
            int numero = 0;
            for (int i = 0; i < 3; i++)
            {
                numero = IngreseElNumero("Ingrese el numero: ");
                if (numero == secreto) break;
            }

            if(2020 % 4 == 0)
            {

            }

            string resultado;
            if (numero == secreto)
            {
                resultado = Ganaste();
            }
            else
            {
                resultado = Perdiste(secreto);
            }
            Console.WriteLine(resultado);

        }

        static int IngreseElNumero(string mensaje)
        {
            Console.Write(mensaje);
            string valor = Console.ReadLine();
            return int.Parse(valor);

        }

        static string Ganaste()
        {
            string mensaje = "Ganaste";
            return mensaje;
        }

        static string Perdiste(int valor)
        {
            return "Perdiste el numero era " + valor;
        }
    }
}
