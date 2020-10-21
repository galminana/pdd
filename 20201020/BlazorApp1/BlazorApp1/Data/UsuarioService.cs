using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public class UsuarioService
    {
        private DataContext context;
        
        public UsuarioService(DataContext _context)
        {
            context = _context;
        }

        public async Task<List<Usuario>> GetAll()
        {
            return await context.Usuarios.ToListAsync();
        }
    }
}
