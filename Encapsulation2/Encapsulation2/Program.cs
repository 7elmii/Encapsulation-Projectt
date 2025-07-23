using System;

namespace Encapsulation2
{
}

class Program
{
    static void Main()
    {
        Console.Write("Enter your name: ");
        string name = Console.ReadLine();

        Console.Write("Enter your age: ");
        string ageInput = Console.ReadLine();

        Console.Write("Enter your id: ");
        string idInput = Console.ReadLine();

        Console.Write("Enter your occupation: ");
        string occupation = Console.ReadLine();

        if (!int.TryParse(ageInput, out int age)
            || !int.TryParse(idInput, out int id))
        {
            Console.WriteLine("Invalid age format—using 0 by default.");
            age = 0;
            id = 0;
        }

        try
        {
            var person = new Encapsulation2.Person(name, age, id, occupation);
            person.Introduce();
        }
        catch (Exception ex)
        {
            Console.WriteLine($"Error: {ex.Message}");
        }

        Console.WriteLine("\nPress any key to exit...");
        Console.ReadKey();
    }
}
