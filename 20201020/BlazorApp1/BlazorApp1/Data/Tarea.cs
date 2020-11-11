using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata.Ecma335;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Tarea
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int TipoId { get; set; }
        public TipoTarea Tipo { get; set; }
        public List<Detalle> Detalles { get; set; }
    }
}
