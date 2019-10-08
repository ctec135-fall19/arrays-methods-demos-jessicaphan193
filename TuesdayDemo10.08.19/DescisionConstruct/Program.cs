using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            //delcaring
            int[] myArray = new int[5];

            //initializing
            for (int i = 0; i < myArray.Length; i++)
            {
                myArray[i] = i + 10;
            }

            //traversing
            Console.WriteLine("print array elements");
            foreach(int elements in myArray)
            {
                Console.WriteLine(elements);
            }
            Console.WriteLine();
        }
    }
}
