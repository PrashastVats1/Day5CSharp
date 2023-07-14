using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;

namespace Employee_Exercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int numOfEmployees, numOfDays;
            Console.WriteLine("Enter the number of Employees: ");
            numOfEmployees = int.Parse(Console.ReadLine());
            Console.WriteLine("Enter the number of working days for Employees: ");
            numOfDays = int.Parse(Console.ReadLine());
            int[][] empSalary = new int[numOfEmployees][];
            for(int i = 0; i < numOfEmployees; i++)
            {
                empSalary[i] = new int[numOfDays];
                Console.WriteLine($"Enter the salary for each day of Employee {i+1}");
                for(int j=0; j < numOfDays; j++)
                {
                    Console.Write($"Day {j + 1}: ");
                    empSalary[i][j] = int.Parse(Console.ReadLine());
                }
            }
            Console.Write("\nDay\t");
            for(int i=0; i < numOfEmployees; i++)
            {
                Console.Write($"Employee {i + 1} \t");
            }
            Console.WriteLine("\n*******************************");
            for(int j=0;j<numOfDays; j++)
            {
                Console.Write($"Day {j + 1}\t");
                for(int i=0;i<numOfEmployees; i++)
                {
                    Console.Write(empSalary[i][j] +"\t\t");
                }
                Console.WriteLine("\n");
            }
            Console.WriteLine("Total Salary: \t");
            for(int i=0;i < numOfEmployees; i++)
            {
                int totalSal = 0;
                for(int j=0; j < numOfDays; j++)
                {
                    totalSal += empSalary[i][j];
                }
                Console.Write("\t"+ totalSal + "\t");
            }
            Console.ReadKey();
        }
    }
}
