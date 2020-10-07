using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int TipoId { get; set; }
        public TipoTarea Tipo { get; set; }
    }
}
