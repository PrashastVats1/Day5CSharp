using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JaggedArray
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int noc, nos;
            //Console.WriteLine("Enter the number of classes");
            //noc = int.Parse(Console.ReadLine());
            //string[][] students = new string [noc][];
            //for(int i = 0; i < noc; i++) {
            //    Console.WriteLine("Enter the number of students in Class " + (i+1));
            //    nos = int.Parse(Console.ReadLine());
            //    students[i] = new string[nos];
            //    for(int j=0; j < nos; j++)
            //    {
            //        Console.WriteLine($"Enter Student {j+1}\'s name: ");
            //        students[i][j] = Console.ReadLine();
            //    }
            //}
            //for(int i = 0;i < students.Length; i++)
            //{
            //    Console.WriteLine($"Students List of Class {i+1}");
            //    Console.WriteLine("******************************");
            //    for(int j=0;j< students[i].Length; j++)
            //    {
            //        Console.WriteLine(students[i][j] );
            //    }
            //    Console.WriteLine("******************************\n");
            //}
            int[][,] myJArray = new int[4][,];
            myJArray[0] = new int[2, 2] { { 2, 4 }, { 1, 3 } };
            myJArray[1] = new int[3, 2] { { 1, 2 }, { 3, 4 }, { 5, 6 } };
            myJArray[2] = new int[2, 3] { { 7, 8, 9 }, { 10, 11, 12 } };
            myJArray[3] = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Stored Values are: \n");
            for(int i = 0; i < myJArray.Length; i++)
            {
                for(int j = 0; j < myJArray[i].GetLength(0); j++)
                {
                    for(int k = 0; k < myJArray[i].GetLength(1); k++)
                    {
                        Console.Write(myJArray[i][j, k]+"\t");
                    }
                    Console.WriteLine("\n");
                }
                Console.WriteLine("*********************");
            }
            Console.ReadKey();
        }
    }
}
