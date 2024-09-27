using System;
using System.Collections.Generic;

namespace GenericsInto
{
    class Program
    {
        static void Main(string[] args)
        {
            List<int> sayılar = new List<int> { 1, 2, 3, 4 };
            foreach (var item in sayılar)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("/////////");

            MyList<int> sayılar2 = new MyList<int> {  };

            Console.WriteLine(sayılar2.Length);

            sayılar2.Add(6);

            Console.WriteLine(sayılar2.Length);

            sayılar2.Add(8);
            sayılar2.Add(15);
            sayılar2.Add(30);
	    sayılar2.Add(67);
            sayılar2.Add(98);
            sayılar2.Add(45);
            foreach (var item in sayılar2.Items)
            {
                Console.WriteLine(item);

            }




        }
    }
}
