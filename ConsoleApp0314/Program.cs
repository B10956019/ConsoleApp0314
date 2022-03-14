using System;

namespace ConsoleApp0314
{
    class Program
    {
        static void Main(string[] args)
        {
            //練習一
            Console.WriteLine("請輸入一數字:");
            int n = Convert.ToInt32(Console.ReadLine());
            for (int f = 1; f <= n; f++)
            {
                for (int i = 0; i < f; i++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
            //練習二
            Console.WriteLine("請輸入一數字:");
            int n2 = Convert.ToInt32(Console.ReadLine());
            for(int i = 1; i <= n2; i++)
            {
                Console.WriteLine(n2+"*"+i+"="+n2*i);
            }
            //練習三
            for(int i = 1; i <= 9; i++)
            {
                for(int f = 1; f <= 9; f++)
                {
                    Console.Write(i+"*"+f+"="+i*f+" ");
                }
                Console.WriteLine();
            }
        }


        /*Console.WriteLine("請輸入一數字:");
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
        }*/
    }
}

