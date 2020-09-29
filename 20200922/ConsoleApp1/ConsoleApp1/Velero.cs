using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Velero : Vehiculo, IAcuatico
    {
        public int Velocidad { get; set ; }

        public Velero()
        {

        }

        public void Navegar(string destino)
        {
            
        }

        protected override void Detener()
        {
            throw new NotImplementedException();
        }
    }
}
