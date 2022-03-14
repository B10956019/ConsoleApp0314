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
            //成績練習
            int[] number = { 1, 2, 3, 4, 5 };
            string[] name = { "Jack", "Mary", "Tom", "Grace", "Alice" };
            int[] comScore = { 80, 65, 100, 98, 83 };
            int[]proScore = { 75, 67, 93, 25, 82 };
            int[] aniScore = { 60, 62, 91, 50, 87 };
            while (true)
            {
                Console.WriteLine("請輸入座號(1~5):");
                var input = Console.ReadLine();
                int inputStudentNo = int.Parse(input);
                int arrayInder = Array.IndexOf(number, inputStudentNo);
                if (arrayInder > -1)
                {
                    Console.WriteLine("姓名:" + name[arrayInder]);
                    Console.WriteLine("電腦概論:" + comScore[arrayInder]);
                    Console.WriteLine("程式設計:" + proScore[arrayInder]);
                    Console.WriteLine("動畫設計:" + aniScore[arrayInder]);
                }
                else
                {
                    Console.WriteLine("查無座號..");
                }
              
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

