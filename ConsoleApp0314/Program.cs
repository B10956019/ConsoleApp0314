using System;

namespace ConsoleApp0314
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("請輸入一數字:");
            int i = Convert.ToInt32(Console.ReadLine());
            if (i % 2 != 0  )
            {
                Console.WriteLine("Weird");
            }
            else if(i / 2 >=2 && i/2<=5)
            {
                Console.WriteLine("Not Weird");
            }
            else if (i / 2 >= 6 && i / 2 <= 20)
            {
                Console.WriteLine("Weird");
            }
            else
            {
                Console.WriteLine("Not Weird");
            }
        }
    }
}
