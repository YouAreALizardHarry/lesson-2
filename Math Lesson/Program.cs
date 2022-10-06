using System.Net.Security;

namespace Math_Lesson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello stranger! What is your name?");
            var name = Console.ReadLine();
            Console.WriteLine($"Hello {name}, enter x value");
            var xAsString = Console.ReadLine();
            int x;
            while (!int.TryParse(xAsString, out x))
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"{name}, {xAsString} is not a number. Please enter the correct option!");
                xAsString = Console.ReadLine();
            }
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("Congratulations, you do it right!");
            //-6 * x ^ 3 + 5 * x ^ 2 - 10 * x + 15
            var result1 = -6 * Math.Pow(x, 3) + 5 * Math.Pow(x, 2) - 10 * x + 15;
            var result2 = Math.Abs(x) * Math.Sin(x);
            var result3 = 2 * Math.PI * x;
            var result4 = Math.Max(x, 4);
            Console.WriteLine($"Congratulations! The result of this fanction -6*x^3+5*x^2-10*x+15 = {result1}");
            Console.WriteLine($"Congratulations! The result of this fanction abs(x)*sin(x) = {result2}");
            Console.WriteLine($"Congratulations! The result of this fanction 2*pi*x = {result3}");
            Console.WriteLine($"Congratulations! The result of this fanction max(x, y) = {result4}");
            Console.ReadLine();

        }
    }
}