namespace EcommerceOrders
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Stringa del percorso file
            string filepath = @"Z:\BackendTestCoolshop\file.csv";

            //Controllo dell'effetiva esistenza del file csv
            if (!File.Exists(filepath)) { 
                
                Console.WriteLine("file specificato non esiste: " + filepath);
                return;
            
            }

            //Richiamo dei vari metodi delle classi
            try
            {
                //lettura e analisi del file
                List<Order> orders = Csvcontroll.Parse(filepath);
                //Restituisce il totale maggiore dell'ordine
                Order hightotal = Ordercontroll.GetHighestTotal(orders);
                //Quantita maggiore all'interno dell'ordine
                Order highquantity = Ordercontroll.GetHighestQuantity(orders);
                //Maggior differenza tra totale e totale senza sconto
                Order maxdiscontdiff = Ordercontroll.GetMaxDiscountdifference(orders);

                // output 
                //Stampa dei Record
                Console.WriteLine("Record con totale più alto: ");
                PrintOrder(hightotal);

                Console.WriteLine("\nRecord con quantità più alta:");
                PrintOrder(highquantity);

                Console.WriteLine("\nRecord con maggior differenza tra totale senza sconto e totale con sconto: ");
                PrintOrder(maxdiscontdiff);
            }
            catch (Exception ex) { 
                //Gestionde ll'ecezione generale
                Console.WriteLine("Errore durante l'esecuzione"+ ex.Message);

            }

        }
        //Funzione preint order per gestire l'output dato
        private static void PrintOrder(Order order)
        {
            Console.WriteLine($"Id: {order.id}, Articolo: {order.article}, Quantità: {order.quantity}, " +
                              $"Prezzo Unitario: {order.unitprice}, Sconto: {order.percentagediscount}%, Compratore: {order.buyer}");
        }
    }
}
