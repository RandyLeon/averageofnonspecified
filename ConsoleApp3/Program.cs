using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AverageNonSpecified
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Press enter to begin.\nType 101 when complete");
            Console.ReadLine();
            Console.WriteLine("Enter grade");
            double value = double.Parse(Console.ReadLine());
            double sum = 0;
            double totalNumbers = 0;


            while (value <= 100 && value >= 0)
            {

                sum += value;
                totalNumbers++;

                Console.WriteLine("Enter grade");
                value = double.Parse(Console.ReadLine());

            }    

            double average = sum / totalNumbers;
            double Grade = average;

            if (Grade > 89)
            {
                Console.WriteLine("Grade = A");
            }

            else if (Grade > 79)
            {
                Console.WriteLine("Grade = B");
            }

            else if (Grade > 69)
            {
                Console.WriteLine("Grade = C");
            }

            else if (Grade > 59)
            {
                Console.WriteLine("Grade = D");
            }

            else
            {
                Console.WriteLine("Grade = F");
            }

                 Console.WriteLine($"Average = {average}");
                 Console.WriteLine($"Total assignments graded = {totalNumbers}");

        }
    }
}
