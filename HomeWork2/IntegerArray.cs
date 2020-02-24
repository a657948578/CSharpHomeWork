using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace IntegerArray
{
    class Program
    {
        static void Main(string[] args)
        {
            //获取数组元素
            Console.Write("请输入数组元素个数：");
            int n = Convert.ToInt32(Console.ReadLine());
            int[] nums = new int[n];
            Console.Write("请输入数组元素并用空格分隔：");
            string str = Console.ReadLine();
            string[] numsStr = str.Split(' ');
            if (numsStr.Count() < n)
            {
                Console.WriteLine("你输入的数字不足{n}个");
                n = numsStr.Count();
            }
            for (int i = 0; i < n; i++)
            {
                nums[i] = Convert.ToInt32(numsStr[i]);
            }
            //计算
            int max = nums[0];
            int min = nums[0];
            int sum = nums[0];
            for(int i=1; i<nums.Length; i++)
            {
                max = max > nums[i] ? max : nums[i];
                min = min > nums[i] ? nums[i] : min;
                sum += nums[i];
            }
            int avg = sum / nums.Length;
            Console.WriteLine($"max:{max} min:{min} sum:{sum} avg:{avg}");
        }
    }
}
