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

            for (int i = 1; i < value; i++)
            {
                Console.Write("{0} ", i);

                var message = string.Empty;
                if (i % 3 == 0) message += "Fizz";
                if (i % 5 == 0) message += "Buzz";

                Console.WriteLine(message);
            }

            Console.WriteLine("Finished!");
            Console.ReadKey();
        }
    }
}
