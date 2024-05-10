using System.Runtime.ConstrainedExecution;

namespace Fimmtudagstilboð
{
    class Pizza
    {
        static void Main(string[] args)
        {

            int basePrice = 1000;
            int increase = 100;

            Console.WriteLine("What year is it?");
            int input = int.Parse(Console.ReadLine());

            if (input < 2021) {
                Console.WriteLine("Your pizza will cost you " + basePrice + " ISK, sir.");
            }
            else if (input > 2020)
            {
                int totalYears = input - 2020;
                int totalIncrease = totalYears * increase;
                int totalPrice = basePrice + totalIncrease;
                Console.WriteLine("Your pizza will cost you " + totalPrice + " ISK, sir.");
            }


            

            }

        }
    }
