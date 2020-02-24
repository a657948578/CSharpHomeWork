using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                double a = 0;
                double b = 0;
                double c = 0;
                Int32 error = 0;
                string operate = "";
                string s = "";
                while (true)
                {
                    Console.Write("请输入第一个操作数：");
                    if (double.TryParse(Console.ReadLine(), out a)) { break; }
                    else
                    {
                        Console.WriteLine("请输入第一个数字");
                        continue;
                    }
                }
                while (true)
                {
                    Console.Write("请输入第二个操作数：");
                    if (double.TryParse(Console.ReadLine(), out b)) { break; }
                    else
                    {
                        Console.WriteLine("请输入第二个数字");
                        continue;
                    }
                }
                Console.Write("请输入运算符(+ - * / %)：");
                operate = Console.ReadLine();

                switch (operate)
                {
                    case "+":
                        c = a + b;
                        break;
                    case "-":
                        c = a - b;
                        break;
                    case "*":
                        c = a * b;
                        break;
                    case "/":
                        if (b == 0) { Console.WriteLine("被除数不能为0 请重新输入"); }
                        else c = a / b;
                        break;
                    case "%":
                        c = a % b;
                        break;
                    default:
                        Console.WriteLine("符号输入有误");
                        error = 1;
                        break;
                }
                if (b == 0 && operate == "/") { }
                else if(error == 1) { }
                else Console.WriteLine("{0} {1} {2} = {3}", a, operate, b, c);              
                Console.WriteLine("输入esc退出本程序 回车继续运算");
                s = Console.ReadLine();
                if (s == "esc") break;
            }
            
        }

    }
}
