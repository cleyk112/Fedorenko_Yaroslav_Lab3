using System;
using System.Linq;

namespace Lab33
{
    internal class Program
    {
        static void Main(string[] args)
        {
            
            string[] stringArray = { "Hello i am 17", "$20 is a price value" , "twenty two three five"  
                                                     , "44 years in custody"  , "random set of words " };

            Console.WriteLine(String.Join(Environment.NewLine, stringArray));

            var evenrow = stringArray.Where(x => x.Length % 2 == 0).Select(x => x.First()).ToArray();
            var oddrow = stringArray.Where(x => x.Length % 2 == 1).Select(x => x.Last()).ToArray();

            var result = evenrow.Concat(oddrow).ToArray();

            Console.WriteLine(" ");
            Console.WriteLine("Unsorted row: ");
            Console.WriteLine(String.Join(" ", result));
            Console.WriteLine(" ");
            //
            Array.Sort(result, StringComparer.Ordinal);

            Console.WriteLine("Sorted row: ");
            Console.WriteLine(String.Join(" ",result));

        }
    }
}