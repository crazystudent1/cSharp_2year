using System;
using System.IO;
using System.Linq;

namespace Modular1pd22
{
   
    public delegate string TextOperation(string input);

    internal class Program
    {
        static void Main(string[] args)
        {
           
            string inputPath = "inputPD22.txt";
            string outputPath = "outputPD22.txt";           
            string initialText = "Hello world!";
            File.WriteAllText(inputPath, initialText);
            File.WriteAllText(outputPath, string.Empty);
         
            ProcessFile(inputPath, outputPath, ToUpperOp);
            ProcessFile(inputPath, outputPath, CountCharsOp);
            ProcessFile(inputPath, outputPath, CountWordsOp);

            Console.WriteLine("All done! Check the file outputPD22.txt in the program folder.");
        }


        
        static string ToUpperOp(string text) => text.ToUpper();
       
        static string CountCharsOp(string text) => $"Number of characters in the text: {text.Length}";
        
        static string CountWordsOp(string text)
        {
            int count = text.Split(new[] { ' ', '\n', '\r', '\t' }, StringSplitOptions.RemoveEmptyEntries).Length;
            return $"Number of words in the text: {count}";
        }

        static void ProcessFile(string source, string destination, TextOperation op)
        {
         
            string content = File.ReadAllText(source);

       
            string result = op(content);

            File.AppendAllText(destination, result + Environment.NewLine + "---" + Environment.NewLine);
        }
    }
}