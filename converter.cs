using System;
using System.IO;

public class Program
{
    public static void Main(string[] args)
    {
        string filePath = "din_fil.md";
        try
        {
            string markdownContent = File.ReadAllText(mdFile.md);
            Console.WriteLine(markdownContent);
        }
        catch (FileNotFoundException)
        {
            Console.WriteLine($"Filen hittades inte: {fmdFile.md}");
        }
    }
}