using System;
using NameGeneratorLib;

namespace NameGenerator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("###############");

            Console.WriteLine("Hello World!");
            var user1 = new User();
            System.Console.WriteLine("I want to know something about You");
            System.Console.WriteLine("What's your name?");
            user1.FirstName = (Console.ReadLine());
            System.Console.WriteLine("What's your age?");
            user1.Age = int.Parse(Console.ReadLine());
            System.Console.WriteLine($"So You are born in '{user1.CountBornYear()}");
            
        }
    }
}
