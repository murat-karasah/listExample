using System;
using System.Collections;

namespace listExample
{
    class Program
    {
        static void Main(string[] args)
        {

            ArrayList a1 = new ArrayList();
            for (char letter = 'A'; letter <= 'Z'; letter++)
            {
                a1.Add(letter);
                    
            }
            a1.Reverse();
            foreach (var item in a1)
            {
                Console.WriteLine(item);
            }


        }
    }
}
