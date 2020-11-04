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

        public async Task<Usuario> Get(int id)
        {
            return await context.Usuarios.Where(i=>i.Id==id).SingleAsync();
        }

        public async Task<List<Usuario>> GetAll()
        {
            return await context.Usuarios.ToListAsync();
        }

        public async Task<Usuario> Save(Usuario value)
        {
            if (value.Id == 0)
            {
                await context.Usuarios.AddAsync(value);
            }
            else
            {
                context.Usuarios.Update(value);
            }
            await context.SaveChangesAsync();
            return value;
        }

        public async Task<bool> Remove(int id)
        {
            var entidad = await context.Usuarios.Where(i => i.Id == id).SingleAsync();
            context.Usuarios.Remove(entidad);
            await context.SaveChangesAsync();
            return true;
        }

        public async Task<List<Rol>> GetRoles()
        {
            return await context.Roles.ToListAsync();
        }




    }
}
