using System.Dynamic;
using System.Net;

namespace BrasilApiIntegration.DTOs;

public class ResponseGenericoDTO<T> where T : class
{
    public HttpStatusCode HttpStatus { get; set; }
    public T? ReturnData { get; set; }
    public ExpandoObject? ErrorDetails { get; set; }
}