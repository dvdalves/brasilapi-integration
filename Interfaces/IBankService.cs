using BrasilApiIntegration.DTOs;
using BrasilApiIntegration.Models;

namespace BrasilApiIntegration.Interfaces;

public interface IBankService
{
    Task<ResponseGenericoDTO<List<Bank>>> GetAll();
    Task<ResponseGenericoDTO<Bank>> GetBankByCode(string bankCode);
}
