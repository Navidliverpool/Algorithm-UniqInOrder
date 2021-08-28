using System;
using System.Collections.Generic;

namespace ConsoleApp8
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach(var i in UniqueInOrder("SAAALAM"))
            {
                Console.WriteLine(i + ",");
            }
        }

        public static IEnumerable<char> UniqueInOrder<T>(IEnumerable<T> iterable)
        {
          return MyMeth<T>(iterable);
           
        }

        private static IEnumerable<char> MyMeth<T>(IEnumerable<T> iterable)
        {
            var list = new List<char>();
           
               for(int i = 0; i < iterable.ToString().Length - 1; i++)
               {
                   var checker = true;
                   var t = iterable.ToString();

                    if (t[i] == t[i + 1])
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
