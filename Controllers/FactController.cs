using FactsApi.Helpers;
using FactsApi.Models;
using FactsApi.Services;
using Microsoft.AspNetCore.Mvc;

namespace FactsApi.Controllers;

[ApiController]
[Route("api/[controller]")]
public class FactController : ControllerBase
{
    private readonly IFactService _factService;
    private readonly IFileWriter _fileWriter;

    public FactController(IFactService factService, IFileWriter fileWriter)
    {
        _factService = factService;
        _fileWriter = fileWriter;
    }

    [HttpGet]
    public async Task<ActionResult<Fact>> Get()
    {
        try
        {
            var fact = await _factService.GetFactAsync();
            await _fileWriter.AppendToFileAsync(fact.FactText);
            return Ok(fact);
        }
        
        catch (Exception ex)
        {
            return StatusCode(500, $"Błąd podczas pobierania: {ex.Message}");
        }
    }
}