using System;

namespace surpo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Введите Hi или Bye:");
            string userInput = Console.ReadLine();
            int i = 100;

            Console.WriteLine(userInput);

            if(userInput == "Bye")
            {
                SayBye();
                i++;
                Console.WriteLine(i);
            }
            else if(userInput == "Hi")
            {
                SayHi();
                i--;
                Console.WriteLine(i);

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

        public static void Sleep()
        {
            Console.WriteLine("Going to sleep");
        }

    }
}
