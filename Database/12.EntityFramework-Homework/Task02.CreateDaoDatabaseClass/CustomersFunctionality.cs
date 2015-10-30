namespace Task02.CreateDaoDatabaseClass
{
    using System;
    using System.Linq;

    using Task01.CreateDbContextForNorthwind;

    public static class CustomersFunctionality
    {
        public static string InsertNewCustomer(Customer customer)
        {
            if (customer == null)
            {
                throw new ArgumentException("Customer can not be null");
            }

            using (var northwindEntities = new NorthwindEntities())
            {
                northwindEntities.Customers.Add(customer);
                northwindEntities.SaveChanges();
                return customer.CustomerID;
            }
        }

        public static void ModifyCustomerCompanyName(string customerId, string newCompanyName)
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                var customer = GetCustomerById(northwindEntities, customerId);
                customer.CompanyName = newCompanyName;
                northwindEntities.SaveChanges();
            }
        }

        public static void DeleteCustomer(string customerId)
        {
            using (var northwindEntities = new NorthwindEntities())
            {
                var customer = GetCustomerById(northwindEntities, customerId);
                northwindEntities.Customers.Remove(customer);
                northwindEntities.SaveChanges();
            }
        }

        public static Customer GetCustomerById(NorthwindEntities northwindEntities, string customerID)
        {
            var customer = northwindEntities.Customers
                .FirstOrDefault(c => c.CustomerID == customerID);

            return customer;
        }
    }
}
