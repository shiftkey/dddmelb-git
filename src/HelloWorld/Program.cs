using System;

namespace HelloWorld
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Please enter a number which is greater than zero");
            var text = Console.ReadLine();

            int value;
            if (!int.TryParse(text, out value))
            {
                Console.WriteLine("Hey! That's not a number! Why do you hate me?");
                return;
            }

            Console.WriteLine("You entered '{0}' - let's do this!", value);
        }
    }
}
