using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lab2
{
    class Program
    {
        static void Main(string[] args)
        {
            bool repeat = true;

            while (repeat == true)
            {
                int x;
                bool oddOrEven;
                char doAgain;

                Console.WriteLine("Please enter a number between 1 and 100");
                x = Convert.ToInt32(Console.ReadLine());

                oddOrEven = x % 2 == 1;

                if (x < 1 || x > 100)
                {
                    Console.WriteLine("You have entered an invalid number.");
                }
                else if (oddOrEven == true && x > 60 )
                {
                    Console.WriteLine(x + " odd");
                }
                else if (oddOrEven == false && x > 60)
                {
                    Console.WriteLine(x + " even");
                }
                else if (oddOrEven == false && x < 60 && x > 25)
                {
                    Console.WriteLine("even");
                }
                else if (oddOrEven == false && x < 25)
                {
                    Console.WriteLine("even and less than 25");
                }
                else
                {
                    Console.WriteLine("odd");
                }

                Console.WriteLine("Would you like to run this program again? Y or N");
                doAgain = Convert.ToChar(Console.ReadLine());
                if (doAgain != 'y' && doAgain != 'Y')
                {
                    repeat = false;
                }
            }
            Console.WriteLine("Good Bye");
        }
    }
}
