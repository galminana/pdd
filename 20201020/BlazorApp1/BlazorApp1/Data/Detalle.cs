using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class Detalle
    {
        public int Id { get; set; }
        public int TareaId { get; set; }
        public Tarea Tarea { get; set; }

        public DateTime Fecha { get; set; }
        public int RecursoId { get; set; }
        public int Tiempo { get; set; }

    }
}
