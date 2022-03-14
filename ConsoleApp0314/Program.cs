using System;

namespace ConsoleApp0314
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一數字:");
            int i = Convert.ToInt32(Console.ReadLine());
            if(i%2 != 0)
            {
                Console.WriteLine("這是奇數");
            }
            else
            {
                Console.WriteLine("這是偶數");
            }
        }
    }
}
