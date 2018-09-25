using System;
using System.Collections.Generic;

namespace ConsoleApp3
{
    class Program
    {
        static void Main(string[] args)
        {
            var que = new Queue<int>();

            que.Enqueue(1);
            que.Enqueue(2);
            que.Enqueue(3);
            que.Enqueue(4);

            var s = que.Dequeue();
            Console.WriteLine(s.ToString());

            var s1 = que.Dequeue();
            Console.WriteLine(s1.ToString());

            var s2 = que.Dequeue();
            Console.WriteLine(s2.ToString());

            Console.ReadKey();
        }
    }
}
