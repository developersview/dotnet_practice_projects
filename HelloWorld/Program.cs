using System;
// using static HelloWorld.VariableTest;
// using static HelloWorld.AdventureTest;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            // Console.WriteLine("Hello World!");
            // Console.WriteLine("What is your name?");
            // string name = Console.ReadLine()!;
            // Console.WriteLine($"Hi, {name}, How old are you?");
            // string age = Console.ReadLine()!;
            // Console.WriteLine($"{name} is {age} years old.");
            // //VariableTest variableTest = new();
            // Dog([]);
            //AdventureTest adventureTest = new AdventureTest();
            //adventureTest.OwnAdventure();


            /* Star Simulations */
            Star sun = new Star("Sun", "G-Type");
            sun.Shine();
            sun.GrowOlder();
            sun.Shine();
            sun.Supernova();

            Star unknownStar = new Star("Mystery Star");
            unknownStar.Shine();
            unknownStar.GrowOlder();
        }
    }
}
