using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> baselist = new List<int> { 12, 35, 10, 250, 12, 77, 35, 7, 9, 10 };


            Console.WriteLine("---------------  Question 1.1  ------------\n");


            int total = baselist.Sum();
            Console.WriteLine("Total: " + total);
            Console.WriteLine();



            Console.WriteLine("---------------  Question 1.2  ------------\n");


            double average = baselist.Average();
            Console.WriteLine("Average: " + average);
            Console.WriteLine();


            Console.WriteLine("---------------  Question 1.3  ------------\n");


            var greaterThan30Method = baselist.Where(num => num > 30).OrderBy(num => num).ToList();
            Console.WriteLine("Items greater than 30 (Method Syntax): " + string.Join(", ", greaterThan30Method));
            Console.WriteLine();


            Console.WriteLine("---------------  Question 1.4  ------------\n");


            var greaterThan30Query = (from num in baselist
                                      where num > 30
                                      orderby num
                                      select num).ToList();
            Console.WriteLine("Items greater than 30 (Query Syntax): " + string.Join(", ", greaterThan30Query));
            Console.WriteLine();



            Console.WriteLine("---------------  Question 1.5  ------------\n");


            var distinctNumbers = baselist.Distinct().ToList();
            Console.WriteLine("Distinct Numbers: " + string.Join(", ", distinctNumbers));
            Console.WriteLine();
        }
    }
}
