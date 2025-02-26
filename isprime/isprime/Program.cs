using System;
using System.Collections.Generic;
namespace isprime
{
    internal class Program
    {
        static bool IsPrime(int a)//用来判断一个数是否为素数的函数
        {
            if (a <= 1) return false;
            if (a == 2) return true;
            if (a%2 == 0) return false;
            for (int i = 3;i <=Math.Sqrt(a);i +=2)
            {
                if(a % i ==0)
                {
                    return false;
                }
            }
            return true;

        }
        static void Main(string[] args)
        {
            Console.Write("第一个数:");
            string s1 = Console.ReadLine() ?? "";//避免返回null
            int low = int.Parse(s1);
            Console.Write("第二个数:");
            string s2 = Console.ReadLine() ?? "";
            int high = int.Parse(s2);
            if (low > high)//如果输入的数大小与预期的不同，则进行交换
            {
                int temp = low;
                low = high;
                high = temp;
            }
            List<int> prime = new List<int>();
            for (int i = low; i <= high; i++) 
            {
                if(IsPrime(i))
                {
                    prime.Add(i);
                }
            }
            Console.WriteLine("\n两数之间的素数有:");
            for (int i = 0; i < prime.Count; i++)
            {
                Console.Write(prime[i].ToString().PadRight(4));//对齐输出素数
                if ((i + 1) % 10 == 0)//每行十个输出
                {
                    Console.WriteLine();
                }
            }



        }
    }
}