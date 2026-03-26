using System;
using task2;

namespace Modular1pd22
{
    internal class Program
    {
        static void Main(string[] args)
        {          
            MessagePublisher publisher = new MessagePublisher();
            FileLogger logger = new FileLogger();

           
            publisher.OnMessageSent += logger.LogToFile;

            Console.WriteLine("Enter 4 lines of text to log:");

            for (int i = 1; i <= 4; i++)
            {
                Console.Write($"Line {i}: ");
                string input = Console.ReadLine();     
                publisher.Send(input);
            }

            Console.WriteLine("\nDone!");
        }
    }
}