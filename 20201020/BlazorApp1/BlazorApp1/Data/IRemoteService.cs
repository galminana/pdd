using Refit;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorApp1.Data
{
    public interface IRemoteService
    {
        [Get("/TipoTarea")]
        Task<List<TipoTarea>> GetAllTipoTarea();

        [Get("/TipoTarea/{id}")]
        Task<TipoTarea> GetTipoTarea(int id);

        [Post("/TipoTarea")]
        Task<TipoTarea> CrearTipoTarea(TipoTarea valor);

        [Get("/Usuario")]
        Task<List<Usuario>> GetAllUsuario();

        [Get("/Usuario/{id}")]
        Task<Usuario> GetUsuario(int id);

        [Post("/Usuario")]
        Task<Usuario> GuardarUsuario(Usuario valor);

    }
}
