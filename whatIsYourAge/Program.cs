using System;

namespace whatIsYourAge
{
    class Program
    {
        static void Main(string[] args)
        {
            //"Hello World" uppgiften gjorde jag som en WPF, så jag skapar ett nytt repo för den här

            var age = "";
            String name;
            String alive = "";
            String goodbyeExcitement = "";

            Console.WriteLine("what is your age? please write an integer"); //fråga för ålder
            age = Console.ReadLine(); //både ålder och namn fär vara vad som helts
            Console.WriteLine("what is your name?"); //fråga för namn
            name = Console.ReadLine();

            while(alive != "Yes" && alive != "No") //användaren måste antingen svara "Yes" eller "No"
            {
                Console.WriteLine("are you alive? (Yes/No)");
                alive = Console.ReadLine();
            }

            Console.WriteLine(); //för spaceing

            if(int.TryParse(age, out int ageInt)) //kolla om användaren skrev en int
            {
                Console.WriteLine("you are " + ageInt + " years old");
            } else
            {
                Console.WriteLine("you can't be \"" + age + "\" years old, you fool");
            }

            if (name == "esteban julio ricardo montoya de la rosa ramirez") //olika specialfall för namn
            {
                Console.WriteLine("wow, your name is " + name + "? that's pretty cool");
            } else if(name == "\\(*-*)/")
            {
                Console.WriteLine(name + name + name + name + name + name + name + name);
            } else
            {
                Console.WriteLine("your name is " + name); //normalfall för namn
            }

            for(int i = 0; i < name.Length; i++) //längden på ens namn kontrollerar hur många "e" som finns i slutet av "bye"
            {
                goodbyeExcitement += "e";
            }


            switch (alive)
            {
                case ("Yes"): Console.WriteLine("you're alive"); break;
                case ("No") : Console.WriteLine("you're dead"); break;
                case null   : Console.WriteLine("what? how?"); break;
            }

            Console.WriteLine("Thank you for your time, by" + goodbyeExcitement);
        }
    }
}
