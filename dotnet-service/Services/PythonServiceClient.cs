using System.Net.Http.Json;

namespace dotnet_service.Services;

public class PythonServiceClient
{
    private readonly HttpClient _httpClient;

    public PythonServiceClient(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<object?> GetPythonData()
    {
        return await _httpClient.GetFromJsonAsync<object>(
            "http://localhost:8000/process-data");
    }
}