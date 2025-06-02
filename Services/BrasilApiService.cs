using BrasilApiIntegration.DTOs;
using BrasilApiIntegration.Interfaces;
using BrasilApiIntegration.Models;
using System.Dynamic;
using System.Text.Json;

namespace BrasilApiIntegration.Services;

public class BrasilApiService : IBrasilApi
{
    public async Task<ResponseGenericoDTO<Bank>> GetBankByCode(string bankCode)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1/{bankCode}");
        var response = new ResponseGenericoDTO<Bank>();
        using (var client = new HttpClient())
        {
            var responseBrasilApi = await client.SendAsync(request);
            var responseString = await responseBrasilApi.Content.ReadAsStringAsync();
            var objResponse = JsonSerializer.Deserialize<Bank>(responseString);

            if (responseBrasilApi.IsSuccessStatusCode)
            {
                response.HttpStatus = responseBrasilApi.StatusCode;
                response.ReturnData = objResponse;
            }
            else
            {
                response.HttpStatus = responseBrasilApi.StatusCode;
                response.ErrorDetails = JsonSerializer.Deserialize<ExpandoObject>(responseString);
            }
        }
        return response;
    }

    public async Task<ResponseGenericoDTO<Address>> GetAddressByZipCode(string cep)
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/cep/v1/{cep}");
        var response = new ResponseGenericoDTO<Address>();
        using (var client = new HttpClient())
        {
            var responseBrasilApi = await client.SendAsync(request);
            var responseString = await responseBrasilApi.Content.ReadAsStringAsync();
            var objResponse = JsonSerializer.Deserialize<Address>(responseString);

            if (responseBrasilApi.IsSuccessStatusCode)
            {
                response.HttpStatus = responseBrasilApi.StatusCode;
                response.ReturnData = objResponse;
            }
            else
            {
                response.HttpStatus = responseBrasilApi.StatusCode;
                response.ErrorDetails = JsonSerializer.Deserialize<ExpandoObject>(responseString);
            }
        }
        return response;
    }

    public async Task<ResponseGenericoDTO<List<Bank>>> GetAll()
    {
        var request = new HttpRequestMessage(HttpMethod.Get, $"https://brasilapi.com.br/api/banks/v1");
        var response = new ResponseGenericoDTO<List<Bank>>();
        using (var client = new HttpClient())
        {
            var responseBrasilApi = await client.SendAsync(request);
            var responseString = await responseBrasilApi.Content.ReadAsStringAsync();
            var objResponse = JsonSerializer.Deserialize<List<Bank>>(responseString);

            if (responseBrasilApi.IsSuccessStatusCode)
            {
                response.HttpStatus = responseBrasilApi.StatusCode;
                response.ReturnData = objResponse;
            }
            else
            {
                response.HttpStatus = responseBrasilApi.StatusCode;
                response.ErrorDetails = JsonSerializer.Deserialize<ExpandoObject>(responseString);
            }
        }
        return response;
    }
}
