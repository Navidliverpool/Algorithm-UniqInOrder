using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (var item in CheckMeth("HRR    RR    TTttMM"))
            {
                Console.WriteLine(item + ",");
            }
        }

        public static IEnumerable<char> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
            return CheckMeth<T>(iterable);
        }

        private static IEnumerable<char> CheckMeth<T>(IEnumerable<T> iterable)
        {
            var list = new List<char>();
            if (iterable == null)
                return list.ToString();

               for(int i = 0; i < iterable.ToString().Length; i++)
               {
                   var checker = true;
                   var t = iterable.ToString();

                    if (i != 0 && t[i - 1] == t[i])
                    {
                        checker = false;
                    }

                   if (checker)
                   {
                       list.Add(iterable.ToString()[i]);
                   }
               }          

            return list;
        }
    }
}
