using System;

namespace MadLibs
{
    class Program
    {
        static void Main(string[] args)
        {
            /*
            This program is a mad libs game.
            Author: Shane Phillips
            */

            // Let the user know that the program is starting:
            Console.WriteLine("The programs starts now!");
            // Give the Mad Lib a title:
            string title = "C# Mad Libs Game: Cold New World";
            Console.WriteLine(title);
            // Define user input and variables:
            Console.WriteLine("Enter a name for the story's main character: ");
            string mainName = Console.ReadLine();

            Console.WriteLine("Enter an adjective: ");
            string adj1 = Console.ReadLine();

            Console.WriteLine("Enter another adjective: ");
            string adj2 = Console.ReadLine();

            Console.WriteLine("Enter a third adjective: ");
            string adj3 = Console.ReadLine();

            Console.WriteLine("Enter a verb: ");
            string verb = Console.ReadLine();

            Console.WriteLine("Enter a noun: ");
            string noun1 = Console.ReadLine();

            Console.WriteLine("Enter another noun: ");
            string noun2 = Console.ReadLine();

            Console.WriteLine("Enter an animal: ");
            string animal = Console.ReadLine();

            Console.WriteLine("Enter a food: ");
            string food = Console.ReadLine();

            Console.WriteLine("Enter a fruit: ");
            string fruit = Console.ReadLine();

            Console.WriteLine("Enter a superhero: ");
            string hero = Console.ReadLine();

            Console.WriteLine("Enter a country: ");
            string country = Console.ReadLine();

            Console.WriteLine("Enter a dessert: ");
            string dessert = Console.ReadLine();

            Console.WriteLine("Enter a year: ");
            string year = Console.ReadLine();

            // The template for the story:

            string story = $"This morning {mainName} woke up feeling {adj1}. 'It is going to be a {adj2} day!' Outside, a bunch of {animal}s were protesting to keep {food} in stores. They began to {verb} to the rhythm of the {noun1}, which made all the {fruit}s very {adj3}. Concerned, {mainName} texted {hero}, who flew {mainName} to {country} and dropped {mainName} in a puddle of frozen {dessert}. {mainName} woke up in the year {year}, in a world where {noun2}s ruled the world.";


            // Print the story:
            Console.WriteLine(story);
        }
    }
}
