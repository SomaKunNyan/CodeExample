using System;

namespace ConsoleApp1
{
    
    public class CheckSumTo30
    {
        public int firstNumber { private get; set; }
        public int secondNumber { private get; set; }

        public void CheckSum()
        {
            if (firstNumber < 1)
            {
                Console.WriteLine("Enter the first number");
                firstNumber = Int32.Parse(Console.ReadLine());
                Console.WriteLine("Enter the second number");
                secondNumber = Int32.Parse(Console.ReadLine());
            }

            Print((firstNumber == 30 || secondNumber == 30) 
                   || (firstNumber + secondNumber == 30));
        }
        
        public void CheckSumOfRandom()
        {
            Console.WriteLine("Enter count of couples numbers");
            int coplesCount = Int32.Parse(Console.ReadLine());
            Random random = new Random();
            for (int i = 0; i < coplesCount; i++)
            {
                firstNumber = random.Next(1, 30);
                secondNumber = random.Next(1, 30);
                CheckSum();
            }
        }

        private void Print(bool value)
        {
            if(value) Console.WriteLine(firstNumber + "+" + secondNumber
                                        + " Sum of numbers equal 30");
            else Console.WriteLine(firstNumber + "+" + secondNumber 
                                   + " Sum of numbers not equal 30");
        }
    }
}