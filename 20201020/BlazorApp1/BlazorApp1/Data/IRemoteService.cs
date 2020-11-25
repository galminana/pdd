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

        [Post("/TipoTarea")]
        Task<TipoTarea> CrearTipoTarea(TipoTarea valor);

        [Get("/Usuario")]
        Task<List<TipoTarea>> GetAllUsuario();

        [Post("/Usuario")]
        Task<Usuario> GuardarUsuario(Usuario valor);

    }
}
