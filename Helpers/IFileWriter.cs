namespace FactsApi.Helpers;

public interface IFileWriter
{
    Task AppendToFileAsync(string text);
}