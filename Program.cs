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
            int countSpace = 0;
            int countStares = 0;
            Console.WriteLine("Enter odd number of lines:");
            int numberLines = int.Parse(Console.ReadLine());
            int halfNumberLines = numberLines /2+1;
            for (int i=1; i<=numberLines;i++)
            {
                int count_halfNumberLines = halfNumberLines;
                countSpace = i - halfNumberLines;

                if (countSpace < 0)
                    countSpace *= -1;
                for (int j = 0; j < countSpace; j++)
                    Console.Write(" ");
                countStares = count_halfNumberLines - countSpace;
                for (int k = 0; k<countStares; k++)
                        Console.WriteLine("*");

                Console.WriteLine();
                if (count_halfNumberLines == numberLines)
                    count_halfNumberLines--;
                else
                    count_halfNumberLines++;  
            }

            Console.ReadKey();

        }
    }
}
