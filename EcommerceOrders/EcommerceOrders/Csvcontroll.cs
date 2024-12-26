using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EcommerceOrders
{
    public static class Csvcontroll
    {
        //"Z:\BackendTestCoolshop\file.csv"
        public static List<Order> Parse(string filepath)
        {
            var orders = new List<Order>();
            var lines = File.ReadAllLines(filepath);

            for (int i = 1; i < lines.Length; i++) {
                
                var columns = lines[i].Split(",");
                
                var order = new Order
                {
                    id = int.Parse(columns[0]),
                    article = columns[1],
                    quantity = int.Parse(columns[2]),
                    unitprice = decimal.Parse(columns[3], CultureInfo.InvariantCulture),
                    percentagediscount = decimal.Parse(columns[4], CultureInfo.InvariantCulture),
                    buyer = columns[5],
                };
                orders.Add(order);
            }
            return orders;
        }

    }
}
