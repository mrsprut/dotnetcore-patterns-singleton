using System;

namespace org.tyaa.demo.cs.patterns.creational.singleton
{
    class Program
    {
        static void Main(string[] args)
        {
            // Forbidden!
            // King k1 = new King();
            King k1 = King.GetInstance();
            System.Console.WriteLine(k1.GetHashCode());

            King k2 = King.GetInstance();
            System.Console.WriteLine(k2.GetHashCode());
        }
    }
}
