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
        //"Z:\BackendTestCoolshop\file.csv" percorso file variabile

        
        public static List<Order> Parse(string filepath)
        {
            //Creazione lista per contenere gli ordini
            var orders = new List<Order>();
            //Lettura delle righe nel file
            var lines = File.ReadAllLines(filepath);

            //ciclo per dividere i vari record
            for (int i = 1; i < lines.Length; i++) {
                //funzione split per dividere con l'operatore inserito  
                var columns = lines[i].Split(",");
                
                var order = new Order
                {
                    //suddivisione dei vari record
                    id = int.Parse(columns[0]),
                    article = columns[1],
                    quantity = int.Parse(columns[2]),
                    unitprice = decimal.Parse(columns[3], CultureInfo.InvariantCulture),
                    percentagediscount = decimal.Parse(columns[4], CultureInfo.InvariantCulture),
                    buyer = columns[5],
                };
                //Aggiunta dell'ordine nella lista deglio ordini
                orders.Add(order);
            }
            //Restituzione della lista completa dopo il completamneto della suddivisione degli ordini
            return orders;
        }

    }
}
