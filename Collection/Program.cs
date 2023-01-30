using Collections;
using System;

namespace Collection
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var collection = new Collection<int>(); 
            Console.WriteLine("Current collection: " + collection);

            Console.WriteLine("collection count: " + collection.Count);
            Console.WriteLine("collection capacity: " + collection.Capacity);
            collection.Add(5);
            Console.WriteLine("current collection: " + collection);
            collection.AddRange(6, 7);
            Console.WriteLine("current collection: " + collection);

            Console.WriteLine("Print the first element: " + collection[0]);

            collection[0] = 55;
            Console.WriteLine("Print the first element: " + collection[0]);

            collection.InsertAt(2,666);
            Console.WriteLine("current collection: " + collection);

            collection.Exchange(1,2);
            Console.WriteLine("current collection: " + collection);

            collection.Clear();
            Console.WriteLine("current collection: " + collection);

        }
    }
}