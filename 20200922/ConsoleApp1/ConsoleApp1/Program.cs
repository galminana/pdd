using System;
using System.Collections;
using System.Collections.Generic;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");

        }
        public static void Listas()
        {
            int[] numeros = new int[3];
            numeros[0] = 1;

            ArrayList lista = new ArrayList();
            lista.Add(1);
            lista.Add("");
            lista.Add(new Auto());

            List<int> listadenumeros = new List<int>();
            listadenumeros.Add(1);
            listadenumeros.Add(1);
            listadenumeros.Add(1);

            HashSet<int> numerosunicos = new HashSet<int>();
            numerosunicos.Add(1);
            numerosunicos.Add(1);
            numerosunicos.Add(1);
            numerosunicos.Add(1);

            Dictionary<int, string> personas = new Dictionary<int, string>();
            personas.Add(26994130, "Gabriel");
            personas.Add(5122111, "Facundo");

            personas.GetValueOrDefault(26994130);

            Dictionary<string, Vehiculo> Autos = new Dictionary<string, Vehiculo>();

            Autos.Add("aa123aa", new Auto());
            Autos.Add("ab123aa", new Auto());
            Autos.Add("ab122aa", new Auto());


            Autos.GetValueOrDefault("aa123aa");
            //Autos.TryGetValue()
            //Autos.TryAdd()


        }
        public static void Errores()
        {
            Vehiculo miauto = new Auto();
            Auto otroauto = new Auto();
            Vehiculo camion = new Camion();
            try
            {
                miauto.Marca = "Honda";
                miauto.Modelo = "Civic";
                //((Auto)camion).Puertas = 10;
                miauto.Motor = new CuatroCilindros();
                miauto.Arrancar();

            }
            catch (InvalidCastException ex)
            {
                Console.WriteLine("El valor no es del tipo auto");
            }
            catch (NullReferenceException ex)
            {
                Console.WriteLine("El valor no es del tipo auto");
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            {
                Console.WriteLine(miauto.Marca);
            }

            Console.ReadLine();
            if (camion is Auto)
            {

            }

        }
    }
}
