using System;

namespace surpo2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true) 
            {
                Console.WriteLine("Введите Hi или Bye или Work:");
                string userInput = Console.ReadLine();
                int i = 100;
                
                if (userInput == "Bye")
                {
                    SayBye();
                    i++;
                    Console.WriteLine(i);
                }
                else if (userInput == "Hi")
                {
                    SayHi();
                    i--;
                    Console.WriteLine(i);

                }
                else if(userInput == "Work")
                {
                    Work();
                    i *= 2;
                    Console.WriteLine(i);
                }
                else
                {
                    Console.WriteLine("Введите одну из предложенных фраз.");
                }

                if(i == 200)
                {
                    Sleep(i);
                }
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

        public static void Sleep(int i)
        {
            Console.WriteLine($"Going to sleep for {i} minutes");
        }

    }
}
