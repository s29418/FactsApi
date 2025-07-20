using FactsApi.Models;

namespace FactsApi.Services;

public class FactService : IFactService
{
    private readonly HttpClient _httpClient;

    public FactService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<Fact> GetFactAsync()
    {
        var result = await _httpClient.GetFromJsonAsync<Fact>("https://catfact.ninja/fact");
        return result!;
    }
}