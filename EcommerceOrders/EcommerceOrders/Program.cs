namespace EcommerceOrders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string filepath = "BackendTestCoolshop\file.csv";


            if (File.Exists(filepath)) { 
                
                Console.WriteLine("file specificato non esiste: " + filepath);
                return;
            
            }

            try
            {
                List<Order> orders = Csvcontroll.Parse(filepath);

                Order hightotal = Ordercontroll.GetHighestTotal(orders);

                Order highquantity = Ordercontroll.GetHighestQuantity(orders);

                Order maxdiscontdiff = Ordercontroll.GetMaxDiscountdifference(orders);

                // output 

                Console.WriteLine("Record con totale più alto: ");
                PrintOrder(hightotal);

                Console.WriteLine("\nRecord con quantità più alta:");
                PrintOrder(highquantity);

                Console.WriteLine("\nRecord con maggior differenza tra totale senza sconto e totale con sconto: ");
                PrintOrder(maxdiscontdiff);
            }
            catch (Exception ex) { 
                
                Console.WriteLine("Errore durante l'esecuzione"+ ex.Message);

            }

        }
        private static void PrintOrder(Order order)
        {
            Console.WriteLine($"Id: {order.id}, Articolo: {order.article}, Quantità: {order.quantity}, " +
                              $"Prezzo Unitario: {order.unitprice}, Sconto: {order.percentagediscount}%, Compratore: {order.buyer}");
        }
    }
}
