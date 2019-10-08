using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Project_Figuration
{
    class Program
    {
        static void Main(string[] args)
        {
            #region simple for loop
            Console.WriteLine("Simple for loop example");
            for (int i=0; i<5; i++)
            {
                Console.WriteLine(i);
            }
            Console.WriteLine();
            #endregion

            #region nest for loops
            Console.WriteLine("Nest for loops example");
            for (int i = 0; i < 3; i++)
            {
                for(int j=0; j<3; j++)
                {
                    Console.WriteLine("{0}, {1}", i, j);
                }
            }
            Console.WriteLine();
            #endregion

            #region foreach loop
            Console.WriteLine("Foreach loop example");
            int[] myInts = { 1, 2, 3, 4, 5 };

            for(int i=0; i<myInts.Length; i++)
            {
                myInts[i] = i + 10;
            }

            foreach(int element in myInts)
            {
                Console.WriteLine(element);
            }
            Console.WriteLine();
            #endregion

            #region while loop example
            Console.WriteLine("While loop example");
            int count = 0;
            while(count < myInts.Length)
            {
                Console.WriteLine("{0}", myInts[count]);
                count++;
            }
            #endregion

            #region do/while loop example
            Console.WriteLine("DO/while loop example");
            count = 0;
            do
            {
                Console.WriteLine(myInts[count]);
                count++;
            } while (count < myInts.Length);
            #endregion
        }
    }
}
