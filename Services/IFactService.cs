using FactsApi.Models;

namespace FactsApi.Services;

public interface IFactService
{
    Task<Fact> GetFactAsync();
}
