﻿using AutoMapper;
using BrasilApiIntegration.DTOs;
using BrasilApiIntegration.Interfaces;

namespace BrasilApiIntegration.Services
{
    public class EnderecoService : IEnderecoService
    {
        private readonly IBrasilApi _brasilApi;
        private readonly IMapper _mapper;

        public EnderecoService(IBrasilApi brasilApi, IMapper mapper)
        {
            _brasilApi = brasilApi;
            _mapper = mapper;
        }

        public async Task<ResponseGenericoDTO<EnderecoResponseDTO>> BuscarEnderecoPorCep(string cep)
        {
            var endereco = await _brasilApi.BuscarEnderecoPorCep(cep);
            return _mapper.Map<ResponseGenericoDTO<EnderecoResponseDTO>>(endereco);
        }
    }
}
