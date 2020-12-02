using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
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

        [HttpGet("{id}")]
        public TipoTarea Get(int id)
        {
            return _context.TipoTareas.Where(i=>i.Id==id).Single();
        }

        [HttpPost]
        public IActionResult Post(TipoTarea valor)
        {
            var local = _context.TipoTareas.Local.FirstOrDefault(e => e.Id.Equals(valor.Id));

            if (local != null)
                _context.Entry(local).State = EntityState.Detached;

            if (valor.Id == 0)
            {
                _context.Entry(valor).State = EntityState.Added;
            }
            else
            {
                _context.Entry(valor).State = EntityState.Modified;
            }
            _context.SaveChanges();
            return Ok(valor);
        }
    }
}