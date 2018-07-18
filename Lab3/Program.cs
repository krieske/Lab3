using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab3
{
    class Program
    {
        static void Main(string[] args)
        {

            string letsPlay;
            string name;
            int answer;
            do
            {
                Console.WriteLine("What is your name?");
                name = Console.ReadLine();

                Console.WriteLine($"Hello {name}, nice to meet you! Want to play a game? (yes/no)");
                letsPlay = Console.ReadLine();

                while ((letsPlay == "y") || (letsPlay == "yes"))
                {

                    while (true)
                    {

                        try
                        {
                            Console.WriteLine("Please choose a number between 1 and 100.");
                            answer = int.Parse(Console.ReadLine());
                            break;
                        }
                        catch (FormatException e)
                        {
                            Console.WriteLine("Format error");
                        }
                        catch (Exception f)
                        {
                            Console.WriteLine(f.Message);
                        }
                    }

                    if ((answer <= 0) || (answer >= 101))
                    {
                        Console.WriteLine("Please choose a positive number between 1 and 100.");
                    }

                    else if ((answer % 2 == 0) && (answer >= 2) && (answer <= 25))
                    {
                        Console.WriteLine($"Thanks, {name}! Number is even and less than 25.");
                    }

                    else if ((answer % 2 == 0) && (answer >= 26) && (answer <= 60))
                    {
                        Console.WriteLine($"Awesome, {name}! That's even!");
                    }

                    else if ((answer % 2 == 0) && (answer >= 60))
                    {
                        Console.WriteLine($"{answer} is even, thanks {name}!");
                    }

                    else if ((answer % 2 != 0) && (answer >= 60))
                    {
                        Console.WriteLine($"{answer} is an odd number, {name}.");
                    }

                    else
                    {
                        Console.WriteLine($"{name}, you picked an odd number.");
                    }

                    Console.WriteLine($"Hey {name}, do you want to play again? y/n");
                    letsPlay = Console.ReadLine();

                }              

            }
            while ((letsPlay == "yes") || (letsPlay == "y"));
            Console.WriteLine($"Ok, {name}, goodbye!");
            

        }
        
    }
}
