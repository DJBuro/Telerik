using System;
using System.Collections.Generic;
using System.Linq;
using Task01.CreateDbContextForNorthwind;

namespace Task03_05.NorthwindMethods
{
    class StartUp
    {
        static void Main()
        {
            // Task 03. Write a method that finds all customers who have orders made in 1997 and shipped to Canada.
            MakeASeparationLine(" Task 03 ");

            FindCustomersWithOrdersByCountryAndYear("Canada", 1997);

            // Task 04. Implement previous by using native SQL query and executing it through the DbContext.
            MakeASeparationLine(" Task 04 ");

            FindCustomersWithNativeQUery("Canada", 1997);

            // Task 05. Write a method that finds all the sales by specified region and period (start / end dates).
            MakeASeparationLine(" Task 05 ");

            FindAllOrders("SP", new DateTime(1998, 01, 01), DateTime.Now);
        }

        private static void FindCustomersWithOrdersByCountryAndYear(string country, int year)
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                var customers = northwindEntities.Orders
                    .Where(o => o.ShipCountry == country && o.ShippedDate.Value.Year == year)
                    .Select(c => c.Customer.ContactName)
                    .Distinct()
                    .ToList();

                DisplayResultsFromQuery(customers, country, year);
            }
        }

        private static void DisplayResultsFromQuery(List<string> customers, string country, int year)
        {
            int counter = 1;
            foreach (var customer in customers)
            {
                Console.WriteLine("{0}. {1} made a order to {2} in {3}")
            }
        }

        private static void MakeASeparationLine(string v)
        {
            Console.WriteLine(new string('=', 25) + task + new string('=', 25));
        }
    }
}
