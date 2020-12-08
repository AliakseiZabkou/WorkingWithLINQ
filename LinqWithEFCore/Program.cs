using static System.Console;
using Packt.CS7;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace LinqWithEFCore
{
    class Program
    {
        static void Main(string[] args)
        {
            using (var db = new Northwind())
            {
                var query = db.Products
                    .Where(product => product.UnitPrice < 10M)
                    .OrderByDescending(product => product.UnitPrice);
                WriteLine("Products that cost less than $10:");
                foreach (var item in query)
                {
                    WriteLine($"{item.ProductID}: {item.ProductName} costs {item.UnitPrice:$#,##0.00}");
                }
                WriteLine();
            }
        }
    }
}
