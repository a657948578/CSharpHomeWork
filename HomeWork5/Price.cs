using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Price
    {
        private static Dictionary<string, double> priceDic = new Dictionary<string, double> { 
            { "orange", 5 },{ "apple", 6 } ,{ "car", 1000000 },{"dictionary", 60 },{ "black-tea", 20} 
        };
        public static double getPrice(string pName)
        {
            return priceDic[pName];
        }

        public static void showProducts()
        {
            foreach(KeyValuePair<string, double> product in priceDic)
            {
                Console.WriteLine($"商品名：{product.Key} 单价：￥{product.Value}");
            }
        }

        public static void showOrderItemList(List<OrderItem> list)
        {
            foreach(OrderItem o in list)
            {
                Console.WriteLine(o.ToString());
            }
        }
    }
}
