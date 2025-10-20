using System;
using System.IO;

string filePath = "mdFile.md";

public class Program
{
    public static void Main(string[] args)
    {
        try
        {
            string markdownContent = File.ReadAllText(filePath);
            Console.WriteLine(markdownContent);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Filen hittades inte: {filePath}");
        }
    }
}

public class MarkdownReader
{
    public static void Main(string[] args)
    {

        try
        {
            // Läs alla rader från filen
            string[] rader = File.ReadAllLines(filePath);

            Console.WriteLine($"Filen '{filePath}' innehåller {rader.Length} rader:");
            // Skriv ut varje rad
            foreach (string rad in rader)
            {
                Console.WriteLine(rad);
            }
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Fel: Filen '{filePath}' hittades inte.");
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Ett fel uppstod: {ex.Message}");
        }
    }
}