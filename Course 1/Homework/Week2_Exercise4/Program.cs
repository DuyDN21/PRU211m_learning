﻿namespace Week2_Exercise4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.Write("Enter first altitude: ");
            int firstAltitude = int.Parse(Console.ReadLine());

            Console.Write("Enter second altitude: ");
            int secondAltitude = int.Parse(Console.ReadLine());

            Console.WriteLine("The altitude change: " + Math.Abs(firstAltitude - secondAltitude));
        }
    }
}