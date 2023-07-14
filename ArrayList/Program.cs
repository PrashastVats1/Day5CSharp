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
            ArrayList arrayList = new ArrayList()
            {
                "Sam",
                "Ravi",
                "Amit"
            };
            Console.WriteLine("Number of elements in Array List are:\t" + arrayList.Count);
            Console.WriteLine("Capacity of Array List is: \t" + arrayList.Capacity);
            foreach(var item in arrayList)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("\n\n");
            arrayList.Add("Amit");
            arrayList.Add("Sumita");
            Console.WriteLine("Number of elements in Array List are:\t" + arrayList.Count);
            Console.WriteLine("Capacity of Array List is: \t" + arrayList.Capacity);
            foreach (var item in arrayList)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n\n");
            ArrayList arrayList1 = new ArrayList();
            Console.WriteLine("Capacity is: \t"+arrayList1.Capacity);
            arrayList1.Add("Ram");
            arrayList1.Add("Ravi");
            arrayList1.Add("Amit");
            arrayList1.Add("Sumita");
            Console.WriteLine("Capacity is: \t" + arrayList1.Capacity);
            Console.ReadKey();
        }
    }
}
