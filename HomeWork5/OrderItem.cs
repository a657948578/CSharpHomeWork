using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class OrderItem
    {
        public string pName{ get; set;}
        public int num { get; set; }
        public double price { get; set; }

        public OrderItem(string pName, int num)
        {
            this.pName = pName;
            this.num = num;
            this.price = Price.getPrice(pName);
        }

        public override string ToString()
        {
            return "商品名:"+pName+" 数量："+num+" 单价：￥"+price;
        }

    }
}
