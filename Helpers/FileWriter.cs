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
            
            using FileStream stream = new FileStream(_filePath, FileMode.Append, FileAccess.Write, FileShare.None);
            using StreamWriter writer = new StreamWriter(stream, Encoding.UTF8);

            await writer.WriteLineAsync(text);
        }
        catch (IOException ex)
        {
            Console.WriteLine($"Błąd podczas zapisu do pliku: {ex.Message}");
        }
    }
}