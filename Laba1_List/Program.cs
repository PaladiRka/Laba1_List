using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;

namespace Laba1_List
{
    internal static class Program
    {
        public static void Main(string[] args)
        {
            var list = new List<int>(new Node<int>(1)) {2, 3, 4, 5};

            var lastNode = list.Pop();
            foreach (Node<int> n in list)
            {
                Console.WriteLine(n.GetData());
            }
            Console.WriteLine("Point!");
            list.Push(new Node<int>(lastNode));
            list.Push(new Node<int>(lastNode));
            foreach (Node<int> n in list)
            {
                Console.WriteLine(n.GetData());
            }
        }
    }
}
