using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceOrders
{
    public class Order
    {
        public int id { get; set; }
        public string article { get; set; }
        public int quantity { get; set; }
        public decimal unitprice { get; set; }
        public decimal percentagediscount { get; set; }
        public string buyer { get; set; }

        public decimal Total()
        {
            return quantity * unitprice * (1- percentagediscount/100);
        }

        public decimal Totalnodiscount() 
        {    
            return quantity * unitprice;
        }
    }
}
