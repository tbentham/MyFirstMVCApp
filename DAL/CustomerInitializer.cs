using System.Collections.Generic;
using MyFirstMVCApp.Models;

namespace MyFirstMVCApp.DAL
{
    public class CustomerInitializer : System.Data.Entity. DropCreateDatabaseIfModelChanges<CustomerContext>
    {
        protected override void Seed(CustomerContext context)
        {
            var customers = new List<Customer>
            {
                new Customer
                {
                    Title = Title.Mr,
                    FirstName = "John",
                    LastName = "Smith",
                    Address1 = "32 Neighbourly Street",
                    PostCode = "CV6 7AL",
                    Telephone = "01234 567 890",
                    Age = 28,
                },
                new Customer
                {
                    Title = Title.Ms,
                    FirstName = "Jane",
                    LastName = "Doe",
                    Address1 = "153 Kirby Road",
                    Address2 = "Birmingham",
                    PostCode = "B4 2FR",
                    Telephone = "(09876) 543 210",
                    Age = 29,
                },
                new Customer
                {
                    FirstName = "Izzy",
                    LastName = "Gardener",
                    Address1 = "Flat E",
                    Address2 = "19 Friendly Square",
                    Address3 = "Nottingham",
                    PostCode = "NG1 5PY",
                    Telephone = "01212 436 888 ext 2468",
                    Age = 24,
                },
            };

            customers.ForEach(x => context.Customers.Add(x));

            context.SaveChanges();
        }
    }
}