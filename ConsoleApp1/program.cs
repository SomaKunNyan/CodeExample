using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckSumTo30 CheckSum30 = new();
            Console.WriteLine("This program checking a sum of two numbers. " +
                              "\nEnter 1 if you want write numbers yourself \n" +
                              "or enter 2 to write random numbers.");
            int choice =  Int32.Parse(Console.ReadLine());
            if (choice < 2) CheckSum30.CheckSum();
            else CheckSum30.CheckSumOfRandom();
        }
    }
}