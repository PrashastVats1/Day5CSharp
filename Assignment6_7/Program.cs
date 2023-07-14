using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment6_7
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*Assignment 6 */
            //A jagged array called studentScores is created
            int[][] studentScores = new int[3][];
            //The array is given the values as per the question
            studentScores[0] = new int[] { 85, 92, 78 };
            studentScores[1] = new int[] { 90, 87, 93, 89 };
            studentScores[2] = new int[] { 76, 88 };
            //Scores of each student is printed
            Console.WriteLine("Student Scores:\n");
            for(int i = 0; i < studentScores.Length; i++)
            {
                Console.Write($"Score of Student {i+1}: ");
                for(int j = 0; j < studentScores[i].Length; j++)
                {
                    Console.Write(studentScores[i][j]+" ");
                }
                Console.WriteLine();
            }
            //Print the average score of each student
            Console.WriteLine();
            for (int i = 0; i < studentScores.Length; i++)
            {
                double sum = 0;
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    sum += studentScores[i][j];
                }
                double average = sum / studentScores[i].Length;
                Console.WriteLine($"Average of Student {i+1}: {average}");
            }
            //Print the average score for all students combined
            Console.WriteLine("\nAverage Score for all students combined");
            double totalSum = 0;
            double totalCount = 0;
            for (int i = 0; i < studentScores.Length; i++)
            {
                for (int j = 0; j < studentScores[i].Length; j++)
                {
                    totalSum += studentScores[i][j];
                    totalCount++;
                }
            }
            double totalAverage = totalSum / totalCount;
            Console.WriteLine($"Total Average of all Student: {totalAverage}");

            /*Assignment 7 */
            //An ArrayList fuitsList is created
            ArrayList fruitsList = new ArrayList();
            //Add elements to the list
            fruitsList.Add("apple");
            fruitsList.Add("banana");
            fruitsList.Add("cherry");
            fruitsList.Add("date");
            fruitsList.Add("elderberry");
            //The total elements in the array are printed
            Console.WriteLine("The total number of elements in the FruitsList:");
            for (int i = 0; i < fruitsList.Count; i++)
            {
                Console.WriteLine(fruitsList[i]);
            }
            Console.WriteLine("\n");
            //Get the element to be checked
            Console.WriteLine("Enter item to search and update");
            string searchItem = Console.ReadLine();
            int index = fruitsList.IndexOf(searchItem);
            if (index == -1)
            {
                Console.WriteLine($"No such item {searchItem} exists in Fruits List");
            }
            else
            {
                Console.WriteLine("\nEnter Item updating the searched item");
                fruitsList[index] = Console.ReadLine();
                Console.WriteLine("\nUpdated Hardware List is as follows: ");
                for (int i = 0; i < fruitsList.Count; i++)
                {
                    Console.WriteLine(fruitsList[i]);
                }
            }
            Console.WriteLine("\n");
            //Get the element to be inserted and the position where it is to be inserted
            Console.WriteLine("Enter element to insert:");
            string newItem = Console.ReadLine();
            Console.WriteLine("Enter the position to insert the element:");
            int insertPosition = int.Parse(Console.ReadLine());
            if (insertPosition >= 0 && insertPosition <= fruitsList.Count)
            {
                fruitsList.Insert(insertPosition, newItem);
                Console.WriteLine("\nList after inserting the new item:");
                for (int i = 0; i < fruitsList.Count; i++)
                {
                    Console.WriteLine(fruitsList[i]);
                }
            }
            else
            {
                Console.WriteLine("Invalid position. The item was not inserted.");
            }
            Console.WriteLine();
            //For removing an element from the Fruits List Array
            Console.WriteLine("Enter element to remove:");
            string removeItem = Console.ReadLine();

            if (fruitsList.Contains(removeItem))
            {
                fruitsList.Remove(removeItem);
                Console.WriteLine("\nList after removing the element:");
                for (int i = 0; i < fruitsList.Count; i++)
                {
                    Console.WriteLine(fruitsList[i]);
                }
            }
            else
            {
                Console.WriteLine("The item was not found in the list. No removal occurred.");
            }

            Console.ReadKey();
        }
    }
}
