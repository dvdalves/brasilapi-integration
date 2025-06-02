using System.Text.Json.Serialization;

namespace BrasilApiIntegration.Models;

public class Bank
{
    [JsonPropertyName("ispb")]
    public string? Ispb { get; set; }

    [JsonPropertyName("name")]
    public string? BankName { get; set; }

    [JsonPropertyName("code")]
    public int? BankCode { get; set; }

    [JsonPropertyName("fullName")]
    public string? BankFullName { get; set; }
}
