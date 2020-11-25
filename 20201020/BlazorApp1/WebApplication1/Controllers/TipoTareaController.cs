using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Model.Entidades;
using WebApplication1.Data;

namespace WebApplication1.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class TipoTareaController : ControllerBase
    {
        private readonly DataContext _context;
        public TipoTareaController(DataContext context)
        {
            _context = context;
        }

        [HttpGet]
        public List<TipoTarea> Get()
        {
            return _context.TipoTareas.ToList();
        }

        [HttpPost]
        public TipoTarea Post(TipoTarea valor)
        {
            if (valor.Id == 0)
            {
            _context.TipoTareas.Add(valor);
            }
            else
            {
                _context.TipoTareas.Attach(valor);
                _context.TipoTareas.Update(valor);
            }
            _context.SaveChanges();
            return valor;
        }
    }
}