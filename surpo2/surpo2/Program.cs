using System;

namespace surpo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Hi или Bye:");
            string userInput = Console.ReadLine();

            Console.WriteLine(userInput);

            if(userInput == "Bye")
            {
                SayBye();
            }
        }

        public static void SayBye()
        {
            Console.WriteLine("Bye!!! -_-");
        }

        
        public static void SayHi()
        {
            Console.WriteLine("Hi!!! ^_^");
        }
    }
}
