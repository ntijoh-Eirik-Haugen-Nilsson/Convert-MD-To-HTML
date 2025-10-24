using System;
using System.IO;
using System.Text.RegularExpressions;

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

        for (int i = 0; i < contentArray.Length; i++)

        {
            switch (true)
            {
                case true when Regex.IsMatch(contentArray[i], @"^###(?!#)"):
                    string h3 = contentArray[i].TrimStart('#', ' ');
                    File.AppendAllText("index.html", $"<h3>{h3}</h3>\n");
                    break;
                case true when Regex.IsMatch(contentArray[i], @"^##(?!#)"):
                    string h2 = contentArray[i].TrimStart('#', ' ');
                    File.AppendAllText("index.html", $"<h3>{h2}</h3>\n");
                    break;
                case true when Regex.IsMatch(contentArray[i], @"^#(?!#)"):
                    string h1 = contentArray[i].TrimStart('#', ' ');
                    File.AppendAllText("index.html", $"<h3>{h1}</h3>\n");
                    break;

            }
            
        }


    }
}
//         foreach (var line in contentArray)
//         {

//             if (line.StartsWith("###"))
//             {
//                 string h3 = line.TrimStart('#', ' ');
//                 Console.WriteLine($"<h3>{h3}</h3>");
//                 File.AppendAllText("index.html", $"<h3>{h3}</h3>\n");
//             }
//             else if (line.StartsWith("##"))
//             {
//                 string h2 = line.TrimStart('#', ' ');
//                 Console.WriteLine($"<h2>{h2}</h2>");
//                 File.AppendAllText("index.html", $"<h2>{h2}</h2>\n");
//             }
//             else if (line.StartsWith("#"))
//             {
//                 string h1 = line.TrimStart('#', ' ');
//                 Console.WriteLine($"<h1>{h1}</h1>");
//                 File.AppendAllText("index.html", $"<h1>{h1}</h1>\n");
//             }

//             else if (line.Length != 0)
//             {
//                 File.AppendAllText("index.html", $"<p>{line}</p>\n");
//             }
//             else 
//             {
//                 File.AppendAllText("index.html", $"\n");
//             }

//             if (contentArray[lineNumber] == ) {}
//             foreach (var letter in line)  // Ska ligga högre upp
//             {
//                 Console.WriteLine(letter);
//                 // if (letter == '*') 
//                 // { }
//                 //     string boldStart = "*";
//                 //     string boldEnd = "*";

//                 //     int boldStartIndex = line.IndexOf(boldStart);
//                 //     int boldEndIndex = line.IndexOf(boldEnd, boldStartIndex + 1);

//                 //     Console.WriteLine($"<em>{line.Substring(boldStartIndex + 1, boldEndIndex - boldStartIndex - 1)}</em>");
//                 //     File.AppendAllText("index.html", $"<em>{line.Substring(boldStartIndex + 1, boldEndIndex - boldStartIndex - 1)}</em>\n");
//                 // } 
//                 // else {
//                 //     Console.WriteLine($"<p>{line}</p>");
//                 //     File.AppendAllText("index.html", $"<p>{line}</p>\n");
//                 // }
//                     // else 
//                     // {
//                     //     string boldStart = "__";
//                     //     string boldEnd = "__";

//                     //     int boldStartIndex = line.IndexOf(boldStart);
//                     //     int boldEndIndex = line.IndexOf(boldEnd, boldStartIndex + 1);

//                     //     Console.WriteLine($"<strong>{line.Substring(boldStartIndex + 2, boldEndIndex - boldStartIndex - 2)}</strong>");
//                     //     File.AppendAllText("index.html", $"<strong>{line.Substring(boldStartIndex + 2, boldEndIndex - boldStartIndex - 2)}</strong>\n");
//                     // }


//             }
//             lineNumber++:
//         }
//     }
// }
