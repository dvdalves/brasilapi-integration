using BrasilApiIntegration.DTOs;

namespace BrasilApiIntegration.Interfaces;

public interface IAddressService
{
    Task<ResponseGenericoDTO<AddressResponseDTO>> GetAddressByCep(string cep);
}