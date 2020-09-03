using System;

namespace whatIsYourAge
{
    class Program
    {
        static void Main(string[] args)
        {
            var information = new string[5];

            for (int i = 0; i < information.Length; i++)
            {
                Console.WriteLine("what is person " + (i + 1) + "'s name?");
                information[i] = Console.ReadLine();

                while(true)//fråga hur gammla personen är tills användaren har skrivit en int
                {
                    string agesString;
                    Console.WriteLine("how old are they?");
                    agesString = Console.ReadLine();
                    if (int.TryParse(agesString, out int ageInt))
                    {
                        information[i] += (", age " + ageInt);// lägg till age i information
                        break;
                    }
                }

                while (true)//fråga om de lever tills användaren har skrivit "yes" eller "no"
                {
                    Console.WriteLine("are they alive? (yes/no)");
                    string alive;
                    alive = Console.ReadLine();
                    if(alive == "yes" || alive == "no")
                    {
                        switch (alive)//lägg till om de levde eller inte i information
                        {
                            case "yes"  : information[i] += ", alive"; break;
                            case "no"   : information[i] += ", dead"; break;
                            default     : information[i] += ", don't know"; break;//ifall nått weird händer
                        }
                        break;
                    }
                }
            }

            Console.WriteLine();

            for (int i = (information.Length - 1); i > -1; i--)//skriv ut alla namn i omvänd ordning
            {
                Console.WriteLine(information[i]);
            }
        }
    }
}
