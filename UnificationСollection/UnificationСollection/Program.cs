using System;
using System.Collections.Generic;

namespace UnificationСollection
{
    class Program
    {
        static void Main(string[] args)
        {
            string[] array1 = { "1", "2", "1" };
            string[] array2 = { "3", "2" };

            List<string> collection = new List<string>();

            Unification(array1, collection);
            Unification(array2, collection);

            Print(collection);
        }

        private static void Unification(string[] array, List<string> collection)
        {
            for (int i = 0; i < array.Length; i++)
            {
                if (collection.Contains(array[i]) == false)
                {
                    collection.Add(array[i]);
                }
            }
        }

        private static void Print(List<string> collection)
        {
            foreach (var number in collection)
            {
                Console.Write($"{number}");
            }
        }
    }
}
