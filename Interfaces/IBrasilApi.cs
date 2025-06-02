using BrasilApiIntegration.DTOs;
using BrasilApiIntegration.Models;

namespace BrasilApiIntegration.Interfaces
{
    public interface IBrasilApi
    {
        Task<ResponseGenericoDTO<Endereco>> BuscarEnderecoPorCep(string cep);
        Task<ResponseGenericoDTO<List<Banco>>> BuscarTodosBancos();
        Task<ResponseGenericoDTO<Banco>> BuscarBancoPorCodigo(string codigo);
    }
}