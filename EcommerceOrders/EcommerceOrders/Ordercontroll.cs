using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceOrders
{
    public static class Ordercontroll
    {
        //Get dell'ordine con totale maggiore 
        public static Order GetHighestTotal(List<Order> orders)
        {
            return orders.OrderByDescending( o => o.Total()).First();
        }
        //Get dell'ordine con la quantità ordinata maggiore
        public static Order GetHighestQuantity(List<Order> orders)
        { 
            return orders.OrderByDescending(o => o.quantity).First();
        }
        //Get dell'ordine con la maggiore differenza tra il totale e il totale senza sconto 
        public static Order GetMaxDiscountdifference(List<Order> orders) 
        { 
            return orders.OrderByDescending(o => o.Totalnodiscount() - o.Total()).First();
        }
    }
}
