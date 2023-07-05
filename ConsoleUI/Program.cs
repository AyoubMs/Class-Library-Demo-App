using FrameworkLibrary;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generators generators = new Generators();

            string message = generators.WelcomeMessage("Mr.", "Corey");

            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
