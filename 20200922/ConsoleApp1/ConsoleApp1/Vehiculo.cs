using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace ConsoleApp1
{
    public abstract class Vehiculo
    {
        public string Marca { get; set; }
        public string Modelo { get; set; }
        public Motor Motor { get; set; }


        protected abstract void Detener();

        public void Arrancar()
        {
            try
            {
                this.Prueba(0);
                Console.WriteLine("El vehiculo arranco");
            }
            catch (InvalidOperationException ex)
            {
                Console.WriteLine(ex.Message);
            }
            catch (Exception ex)
            {
                throw new InvalidProgramException("No se que paso", ex);
            }
        }

        public void Prueba(int valor)
        {
            if (valor == 0)
                throw new InvalidDataException("El parametro valor no puede ser cero");
            int.Parse("re");
        }
    }
}
