using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("求不大于n的所有素数，请输入n=");
            string str = Console.ReadLine();
            int n = int.Parse(str);
            int[] nums = new int[n+1];
            //赋值
            for(int i=2; i<n+1; i++)
            {
                nums[i] = i;
            }
            //非素数置零
            for (int i = 2; i<n+1; i++)
            {
                for (int j = 2; i * j < n+1; j++)
                {
                    nums[i * j] = 0;
                }
            }
            //输出
            for (int i=2; i<n+1; i++)
            {
                if(nums[i] != 0)
                {
                    Console.WriteLine(nums[i]);
                }
            }
            
        }
    }
}
