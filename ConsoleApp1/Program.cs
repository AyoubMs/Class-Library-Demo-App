using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Generators generators = new Generators();
            PersonModel person = new PersonModel { Prefix = "Mr", FirstName = "Tim", LastName = "Corey" };

            string message = generators.WelcomeMessage(person.Prefix, person.LastName);

            Console.WriteLine(message);

            Console.ReadLine();
        }
    }
}
