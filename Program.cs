using System;
using System.Collections.Generic;

namespace tuples
{
    class Program
    {
        static void Main(string[] args)
        {
            List<(string product, double amount, int quantity)> transactions = new List<(string, double, int)>();
            transactions.Add(("potato", 1.01, 4));
            transactions.Add(("taco", 3.50, 10));
            transactions.Add(("pizza", 12.51, 1));
            transactions.Add(("ice cream", 4.00, 4));
            transactions.Add(("gum", 0.50, 4));
            int totalItems = 0;
            double totalSales = 0.0;

            foreach((string product, double amount, int quantity)t in transactions) {
                totalItems += t.quantity;
                totalSales += t.amount * (double) t.quantity;
            }

            Console.WriteLine($"total items: {totalItems}");
            Console.WriteLine($"total sales: {totalSales}");

        }
    }
}
