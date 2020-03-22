using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class OrderService
    {
        List<Order> orderList = new List<Order>();

        public void addOrder(int oId, string cName, string addr, string note, List<OrderItem> list)
        {
            orderList.Add(new Order(oId, cName, addr, note, list));
        }
        public void delOrder(int id)
        {
            var query = orderList.Where(o => o.oId == id);
            foreach (Order o in query.ToArray())
            {
                orderList.Remove(o);
                Console.WriteLine("订单" + id + "删除成功！");
            }
        }
    }
}
