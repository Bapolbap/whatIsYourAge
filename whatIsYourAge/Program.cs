using System;

namespace whatIsYourAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Hello World" uppgiften gjorde jag som en WPF, så jag skapar ett nytt repo för den här

            var age = "0";
            String name;
            String alive = "";

            Console.WriteLine("what is your age? write an integer");
            age = Console.ReadLine();
            Console.WriteLine("what is your name?");
            name = Console.ReadLine();
            while(alive != "Yes" && alive != "No")
            {
                Console.WriteLine("are you alive? (Yes/No)");
                alive = Console.ReadLine();
            }
            Console.WriteLine("you are " + age + " years old");
            Console.WriteLine("your name is " + name);
            if(alive == "Yes")
            {
                Console.WriteLine("you live");
            } else
            {
                Console.WriteLine("you're dead");
            }
        }
    }
}
