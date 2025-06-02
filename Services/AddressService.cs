using AutoMapper;
using BrasilApiIntegration.DTOs;
using BrasilApiIntegration.Interfaces;

namespace BrasilApiIntegration.Services;

public class AddressService(IBrasilApi brasilApi, IMapper mapper) : IAddressService
{
    public async Task<ResponseGenericoDTO<AddressResponseDTO>> GetAddressByCep(string cep)
    {
        var endereco = await brasilApi.GetAddressByZipCode(cep);
        return mapper.Map<ResponseGenericoDTO<AddressResponseDTO>>(endereco);
    }
}
