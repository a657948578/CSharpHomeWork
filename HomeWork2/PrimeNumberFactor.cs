using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumberFactor
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.Write("请输入一个大于1的整数：");
                string str = Console.ReadLine();
                if (int.TryParse(str, out int n) && n > 1)
                {
                    Console.Write($"{n}的素数因子有：");
                    for(int i=2; i<=n; i++)
                    {
                        int k = n % i;
                        if (Judgement(i) && k == 0) Console.Write($"{i} ");
                    }
                    return;

                }
                else Console.Write("输入错误，请重新输入：");
            }
        }

       //质数判断
        static bool Judgement(int n)
        {
            for (int i = 2; i < n-1; i++)
            {
                int k = n % i;
                if (k == 0) return false;
            }
            return true;
        }
    }
}
