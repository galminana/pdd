using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public interface IAcuatico
    {
        int Velocidad { get; set; }

        void Navegar(string destino);
    }
}
