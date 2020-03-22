using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWork4
{
    class Order
    {
        private List<OrderItem> list;
        public int oId { get; set; }
        public string cName { get; set; }
        public string addr { get; set; }
        public string note { get; set; }
        public Order(int oId, string cName, string addr, string note, List<OrderItem> list)
        {

            this.oId = oId;
            this.cName = cName;
            this.addr = addr;
            this.note = note;
            this.list = list;
        }

        public override bool Equals(object obj)
        {
            var item = obj as Order;
            return item != null &&
                   oId == item.oId &&
                   cName == item.cName &&
                   addr == item.addr &&
                   note == item.note;
        }

        public override int GetHashCode()
        {
            var hashCode = 1731059410;
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(cName);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(addr);
            hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(note);
            return hashCode;
        }
    }
}
