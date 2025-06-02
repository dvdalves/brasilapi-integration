using AutoMapper;
using BrasilApiIntegration.DTOs;
using BrasilApiIntegration.Interfaces;
using BrasilApiIntegration.Models;

namespace BrasilApiIntegration.Services;

public class BankService(IBrasilApi brasilApi, IMapper mapper) : IBankService
{
    public async Task<ResponseGenericoDTO<Bank>> GetBankByCode(string codigo)
    {
        var result = await brasilApi.GetBankByCode(codigo);
        return mapper.Map<ResponseGenericoDTO<Bank>>(result);
    }

    public async Task<ResponseGenericoDTO<List<Bank>>> GetAll()
    {
        var result = await brasilApi.GetAll();
        return mapper.Map<ResponseGenericoDTO<List<Bank>>>(result);
    }
}
