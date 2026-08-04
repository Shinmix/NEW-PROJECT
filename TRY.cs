using System;

namespace NewProject
{
    class Program
    {
        static void Main()
        {
            Console.WriteLine("Hello from TRY.cs!");
            Console.WriteLine("This is a simple generated C# program.");
            Console.WriteLine();
            ShowMenu();
        }

        static void ShowMenu()
        {
            Console.WriteLine("Choose an option:");
            Console.WriteLine("1. Add numbers");
            Console.WriteLine("2. Reverse text");
            Console.WriteLine("3. Exit");

            string choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    AddNumbers();
                    break;
                case "2":
                    ReverseText();
                    break;
                default:
                    Console.WriteLine("Goodbye!");
                    return;
            }

            Console.WriteLine();
            ShowMenu();
        }

        static void AddNumbers()
        {
            Console.Write("Enter first number: ");
            if (!int.TryParse(Console.ReadLine(), out int a))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            Console.Write("Enter second number: ");
            if (!int.TryParse(Console.ReadLine(), out int b))
            {
                Console.WriteLine("Invalid number.");
                return;
            }

            Console.WriteLine($"Result: {a + b}");
        }

        static void ReverseText()
        {
            Console.Write("Enter text: ");
            string text = Console.ReadLine() ?? string.Empty;
            char[] chars = text.ToCharArray();
            Array.Reverse(chars);
            Console.WriteLine($"Reversed: {new string(chars)}");
        }
    }
}
