using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
                transactions.Add(("ps4", 399.99, 1));
                transactions.Add(("xbox", 199.99, 4));
                transactions.Add(("guitar", 249.99, 5));
                transactions.Add(("tv", 279.99, 3));
                transactions.Add(("computer", 1499.99, 2));

                
            
            
            

            

       

            int totalProduct = 0;
            double totalRevenue = 0;

            foreach ((string product, double amount, int quantity) transaction in transactions) {
           
                totalProduct += transaction.quantity;
                totalRevenue += transaction.amount;

                
            }
                Console.WriteLine($"total items sold today: {totalProduct}");
                Console.WriteLine($"total revenue sold today: {totalRevenue}");
        }
    }
}
