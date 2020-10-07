using System;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            //Insertar();
            Actualizacion2();
            Consultar();
        }

        static void Borrado()
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == 1).Single();
            ctx.Usuarios.Remove(usuario);
            ctx.SaveChanges();
        }
        static void Actualizacion2()
        {
            var ctx = new TareasDbContext();
            var usuario = ctx.Usuarios.Where(i => i.UsuarioPK == 1).Single();
            usuario.Nombre = "Facu";

            var usuario2 = ctx.Usuarios.Where(i => i.UsuarioPK == 3).FirstOrDefault();
            if (usuario2 != null)
            {
                usuario2.Nombre = "Prueba";
            }

            var usuario3 = ctx.Usuarios.Where(i => i.Nombre=="Gabriel" && i.UsuarioPK<4).FirstOrDefault();
            if (usuario3 != null)
            {
                usuario3.Nombre = "Francisco";
            }
            ctx.SaveChanges();
        }

        static void Actualizacion()
        {
            var ctx = new TareasDbContext();
            var lista = ctx.Usuarios.Where(i => i.UsuarioPK == 1).ToList();
            lista[0].Nombre = "Facu";
            ctx.SaveChanges();
        }

        static void Consultar()
        {
            var ctx = new TareasDbContext();

            var lista = ctx.Usuarios.ToList();
            foreach (var item in lista)
            {
                Console.WriteLine($"Nombre: {item.Nombre} ({item.UsuarioPK})");
            }
        }

        static void Insertar()
        {
            var ctx = new TareasDbContext();

            ctx.Usuarios.Add(new Usuario
            {
                UsuarioPK = 4,
                Nombre = "Gabriel",
                Clave = "1234"
            });

            ctx.SaveChanges();
        }
    }
}
