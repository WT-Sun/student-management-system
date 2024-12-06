using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Question_3._4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("-------------  QUESTION 3.4 Entity Framework--------------\n");


            using (emp2Entities db = new emp2Entities())
            {
                try
                {
                    var employees = db.Employees.ToList();
                    foreach (var employee in employees)
                    {
                        Console.WriteLine("Id = {0} ; Name = {1}", employee.Id, employee.Name);
                        Console.WriteLine("Age = {0}", employee.Age);
                        Console.WriteLine("Address = {0}", employee.Address);
                        Console.WriteLine("Salary = {0:N2}", employee.Salary);
                    }
                }
                catch (Exception ex)
                {
                    Console.WriteLine("An error occurred : " + ex.Message);
                }
            }
            Console.ReadKey();
        }
    }
}
