using System;

namespace GitExercise
{
    public class Startup
    {
        public static void Main()
        {
            Console.WriteLine("Console Calculator App");
            Console.WriteLine(new string('-', 15));

            Console.Write("a = ");
            double a = double.Parse(Console.ReadLine() ?? 
                throw new InvalidOperationException());

            Console.Write("b = ");
            double b = double.Parse(Console.ReadLine() ?? throw new InvalidOperationException());

            Console.WriteLine("Choose one from the listed options:");
            foreach (string option in OptionsManager.OptionsList)
            {
                Console.WriteLine($"\t{option}");
            }

            Console.WriteLine("Option: ");
            string choice = Console.ReadLine();

            if (choice == "a")
            {
                OptionsManager.Add(a, b);
            }
            else if (choice == "b")
            {
                OptionsManager.Subtract(a, b);
            }
            else if (choice == "m")
                OptionsManager.Multiply(a, b);
                

            Console.WriteLine("Pres any key to close the app...");
            Console.ReadKey(true);
        }
    }
}
