using AutoMapper;
using BrasilApiIntegration.DTOs;
using BrasilApiIntegration.Models;

namespace BrasilApiIntegration.Configurations
{
    public class AutoMapper : Profile
    {
        public AutoMapper()
        {
            CreateMap<Endereco, EnderecoResponseDTO>().ReverseMap();
            CreateMap<ResponseGenericoDTO<Endereco>, ResponseGenericoDTO<EnderecoResponseDTO>>().ReverseMap();
            CreateMap<ResponseGenericoDTO<EnderecoResponseDTO>, ResponseGenericoDTO<Endereco>>().ReverseMap();
        }
    }
}