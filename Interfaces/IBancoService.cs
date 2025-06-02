using BrasilApiIntegration.DTOs;
using BrasilApiIntegration.Models;

namespace BrasilApiIntegration.Interfaces
{
    public interface IBancoService
    {
        Task<ResponseGenericoDTO<List<Banco>>> BuscarTodosBancos();
        Task<ResponseGenericoDTO<Banco>> BuscarBancoPorCodigo(string codigo);
    }
}
