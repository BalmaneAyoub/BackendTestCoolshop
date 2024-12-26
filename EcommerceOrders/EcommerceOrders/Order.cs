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

        // totale calcolato con la quantita moltiplicato con il prezzo per la singola unita con  il calcolo dello sconto
        public decimal Total()
        {
            return quantity * unitprice * (1- percentagediscount/100);
        }

        //Calcolo del Totale senza sconto quindi quantità moltiplicata per il prezzo della singola unità
        public decimal Totalnodiscount() 
        {    
            return quantity * unitprice;
        }
    }
}
