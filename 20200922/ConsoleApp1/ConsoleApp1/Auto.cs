using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Auto : Vehiculo
    {
        public int Puertas { get; set; }

        protected override void Detener()
        {
            throw new NotImplementedException();
        }
    }
}
