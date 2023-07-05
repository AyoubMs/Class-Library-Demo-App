
using StandardLibrary;
using System;

namespace ConsoleApp2
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
