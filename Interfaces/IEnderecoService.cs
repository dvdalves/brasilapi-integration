using BrasilApiIntegration.DTOs;

namespace BrasilApiIntegration.Interfaces
{
    public interface IEnderecoService
    {
        Task<ResponseGenericoDTO<EnderecoResponseDTO>> BuscarEnderecoPorCep(string cep);
    }
}