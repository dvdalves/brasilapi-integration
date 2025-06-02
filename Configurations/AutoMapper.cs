using AutoMapper;
using BrasilApiIntegration.DTOs;
using BrasilApiIntegration.Models;

namespace BrasilApiIntegration.Configurations;

public class AutoMapper : Profile
{
    public AutoMapper()
    {
        CreateMap<Address, AddressResponseDTO>().ReverseMap();
        CreateMap<ResponseGenericoDTO<Address>, ResponseGenericoDTO<AddressResponseDTO>>().ReverseMap();
        CreateMap<ResponseGenericoDTO<AddressResponseDTO>, ResponseGenericoDTO<Address>>().ReverseMap();
    }
}