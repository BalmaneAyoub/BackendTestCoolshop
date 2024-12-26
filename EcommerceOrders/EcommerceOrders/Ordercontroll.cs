using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceOrders
{
    public static class Ordercontroll
    {
        public static Order GetHighestTotal(List<Order> orders)
        {
            return orders.OrderByDescending( o => o.Total()).First();
        }

        public static Order GetHighestQuantity(List<Order> orders)
        { 
            return orders.OrderByDescending(o => o.quantity).First();
        }

        public static Order GetMaxDiscountdifference(List<Order> orders) 
        { 
            return orders.OrderByDescending(o => o.Totalnodiscount() - o.Total()).First();
        }
    }
}
