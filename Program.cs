using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Star_Triangle
{
    class Program
    {
        static void Main(string[] args)
        {
            int stars = 1;
            int space = 0;
            bool flag = true;//The sign indicates that the programm has completed half the work.
                             //From this point, the number of stars in the line starts to decrease
                             // (sign = true (increase), sign = "false" (decrease)
            Console.WriteLine("Enter odd number of lines:");
            int lines = int.Parse(Console.ReadLine());
            for (int i=1; i<= lines;i++)
            {
                    space = (lines - stars)/2;
                    if (space < 0)
                        space *= -1;
                    for (int k = 0; k < space; k++)
                        Console.Write(" ");
                    for (int j = 0; j < stars; j++)
                        Console.Write("*");
                    Console.WriteLine();
                if (stars != lines && flag == true)
                    stars += 2;
                else
                {
                    stars -= 2;
                    flag = false;
                }
                    
            }

            Console.ReadKey();

        }
    
    }
}
