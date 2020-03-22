using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Program
    {
        static void Main()
        {
            OrderService os = new OrderService();
            while (true)
            {
                int id = 1;
                List<OrderItem> list = new List<OrderItem>();
                while (true)
                {
                    Price.showProducts();
                    Console.WriteLine();
                    Console.WriteLine("请输入您需要的商品名称");
                    string pName = Console.ReadLine();
                    Console.WriteLine("请输入您需要的数量");
                    string strNum = Console.ReadLine();
                    int num = Convert.ToInt32(strNum);
                    OrderItem item = new OrderItem(pName, num);
                    list.Add(item);
                    Console.WriteLine("您的订单信息如下");
                    Price.showOrderItemList(list);
                    Console.WriteLine("还需要商品吗（Y/N）");
                    string flag = Console.ReadLine();
                    if (flag.Equals("N") || flag.Equals("n"))
                    {
                        break;
                    }
                }

                Console.WriteLine("请输入您的姓名");
                string cName = Console.ReadLine();
                Console.WriteLine("请输入您的地址");
                string addr = Console.ReadLine();
                Console.WriteLine("请输入备注");
                string note = Console.ReadLine();
                os.addOrder(id, cName, addr, note, list);
                id++;
            }
            
        }
    }
}
