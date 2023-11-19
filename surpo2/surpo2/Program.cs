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
            else if(userInput == "Hi")
            {
                SayHi();
            }
            else
            {
                Work();
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

        public static void Work()
        {
            Console.WriteLine("I'm working >_<");
        }

    }
}
