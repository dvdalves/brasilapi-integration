﻿using BrasilApiIntegration.DTOs;
using BrasilApiIntegration.Models;

namespace BrasilApiIntegration.Interfaces;

public interface IBrasilApi
{
    Task<ResponseGenericoDTO<List<Bank>>> GetAll();
    Task<ResponseGenericoDTO<Address>> GetAddressByZipCode(string cep);
    Task<ResponseGenericoDTO<Bank>> GetBankByCode(string bankCode);
}