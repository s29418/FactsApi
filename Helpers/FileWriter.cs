using System.Text;

namespace FactsApi.Helpers;

public class FileWriter : IFileWriter
{
    private readonly string _filePath = Path.Combine("Data", "facts.txt");

    public async Task AppendToFileAsync(string text)
    {
        try
        {
            Directory.CreateDirectory("Data");
            await File.AppendAllTextAsync(_filePath, text + Environment.NewLine, Encoding.UTF8);
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Błąd podczas zapisu do pliku: {ex.Message}");
        }
    }
}