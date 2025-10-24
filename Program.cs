using System;
using System.IO;

class Program
{
    static void Main()
    {
        string filepath = "mdFile.md";

        if (!File.Exists(filepath))
        {
            Console.WriteLine("Filen mdFile.md hittades inte!");
            return;
        }

        string[] contentArray = File.ReadAllLines(filepath);
        File.WriteAllText("index.html", "");

        foreach (var line in contentArray)
        {
            if (line.StartsWith("**") || line.StartsWith("__")) 
            {
                string boldStart = "**";
                string boldEnd = "**";

                int boldStartIndex = line.IndexOf(boldStart);
                int boldEndIndex = line.IndexOf(boldEnd, boldStartIndex + 1);
                if (boldStartIndex != -1 && boldEndIndex != -1)
                {
                    Console.WriteLine($"<strong>{line.Substring(boldStartIndex + 2, boldEndIndex - boldStartIndex - 2)}</strong>");
                    File.AppendAllText("index.html", $"<strong>{line.Substring(boldStartIndex + 2, boldEndIndex - boldStartIndex - 2)}</strong>\n");
                }
            }
            else if (line.StartsWith("###"))
            {
                string h3 = line.TrimStart('#', ' ');
                Console.WriteLine($"<h3>{h3}</h3>");
                File.AppendAllText("index.html", $"<h3>{h3}</h3>\n");
            }
            else if (line.StartsWith("##"))
            {
                string h2 = line.TrimStart('#', ' ');
                Console.WriteLine($"<h2>{h2}</h2>");
                File.AppendAllText("index.html", $"<h2>{h2}</h2>\n");
            }
            else if (line.StartsWith("#"))
            {
                string h1 = line.TrimStart('#', ' ');
                Console.WriteLine($"<h1>{h1}</h1>");
                File.AppendAllText("index.html", $"<h1>{h1}</h1>\n");
            }
            else
            {
                Console.WriteLine($"<p>{line}</p>");
                File.AppendAllText("index.html", $"<p>{line}</p>\n");
            }
        }
    }
}
