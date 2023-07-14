using System;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayListExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Collection!!!!");
            //ClassName objectName = new ClassName();
            //objectName.MemberName;
            //objectName.PropertName;
            //objectName.MethodName;


            //ArrayList arrayList = new ArrayList()
            //{
            //    "Sam",
            //    "Ravi",
            //    "Amit"
            //};
            //Console.WriteLine("Number of elements in Array List are:\t" + arrayList.Count);
            //Console.WriteLine("Capacity of Array List is: \t" + arrayList.Capacity);
            //foreach(var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n\n");
            //arrayList.Add("Amit");
            //arrayList.Add("Sumita");
            //Console.WriteLine("After adding 2 more elements in the Array List");
            //Console.WriteLine("Number of elements in Array List are:\t" + arrayList.Count);
            //Console.WriteLine("Capacity of Array List is: \t" + arrayList.Capacity);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n\n");
            //arrayList.Add("A");
            //arrayList.Add("Raghu");
            //arrayList.Add("Prash");
            //Console.WriteLine("After adding 3 more elements in the Array List");
            //Console.WriteLine("Number of elements in Array List are:\t" + arrayList.Count);
            //Console.WriteLine("Capacity of Array List is: \t" + arrayList.Capacity);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("\n\n");
            //arrayList.Add("Zoe");
            //Console.WriteLine("After adding one more element in the Array List");
            //Console.WriteLine("Number of elements in Array List are:\t" + arrayList.Count);
            //Console.WriteLine("Capacity of Array List is: \t" + arrayList.Capacity);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n\n");
            //arrayList.Sort();
            //Console.WriteLine("**** Sorted Array List ****");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n\n");
            //Console.WriteLine("Reverse the sorted list");
            //arrayList.Reverse();
            //Console.WriteLine("**** Sorted Array List in Descending ****");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine("\n\n");
            //ArrayList arrayList1 = new ArrayList();
            //Console.WriteLine("Capacity is: \t"+arrayList1.Capacity);
            //arrayList1.Add("Ram");
            //arrayList1.Add("Ravi");
            //arrayList1.Add("Amit");
            //arrayList1.Add("Sumita");
            //Console.WriteLine("Capacity is: \t" + arrayList1.Capacity);
            //ArrayList myList = new ArrayList { 12, 45, 30, 11 };
            //Console.WriteLine("Number List");
            //foreach (int i in myList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("\n\n");

            //Console.WriteLine("Reverse Number List");
            //myList.Reverse();
            //foreach (int i in myList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("\n\n");

            //Console.WriteLine("Sorted Number List");
            //myList.Sort();
            //foreach (int i in myList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("\n\n");

            //Console.WriteLine("Sorted Number List in descending order");
            //myList.Reverse();
            //foreach (int i in myList)
            //{
            //    Console.WriteLine(i);
            //}

            //myList.RemoveAt(3);
            //Console.WriteLine("After removing data from index 3");
            //foreach (int i in myList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("\n\n");

            //myList.Remove(45);
            //Console.WriteLine("After removing the number 45 from list");
            //foreach (int i in myList)
            //{
            //    Console.WriteLine(i);
            //}
            //Console.WriteLine("\n\n");

            ArrayList hardwareList = new ArrayList();
            hardwareList.Add("CD");
            hardwareList.Add("Printer");
            hardwareList.Add("Key Board");
            hardwareList.Add("Mouse");
            hardwareList.Add("Network Card");
            Console.WriteLine("Initial Hardware List");
            for(int i=0; i < hardwareList.Count; i++)
            {
                Console.WriteLine(hardwareList[i]);
            }
            Console.WriteLine("Enter item to search and update");
            string searchItem = Console.ReadLine();
            int index = hardwareList.IndexOf(searchItem);
            if (index == -1)
            {
                Console.WriteLine($"No such item {searchItem} exists in Hardware List");
            }
            else
            {
                Console.WriteLine("Enter Item to be updated");
                hardwareList[index] = Console.ReadLine();
                Console.WriteLine("Updated Hardware List is as follows: ");
                for (int i = 0; i < hardwareList.Count; i++)
                {
                    Console.WriteLine(hardwareList[i]);
                }
            }

            Console.ReadKey();
        }
    }
}
