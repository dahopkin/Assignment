using Assignment.Domain.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Assignment.Domain.Entities;

namespace Assignment.Domain.Concrete
{
    public class EFCustomerRepository : ICustomerRepository
    {
        private WEBAPPS context = new WEBAPPS();
        public void SaveCustomer(Customer customer)
        {
            if (customer.CustomerID == 0)
            {
                context.Customers.Add(customer);
            }
            else {
                Customer dbEntry = context.Customers.Find(customer.CustomerID);
                if (dbEntry != null)
                {
                    dbEntry.FirstName = customer.FirstName;
                    dbEntry.LastName = customer.LastName;
                    dbEntry.BirthDate = customer.BirthDate;
                    dbEntry.EmailAddress = customer.EmailAddress;
                    dbEntry.NumberOfDependents = customer.NumberOfDependents;
                }
            }
            context.SaveChanges();
        }
    }
}
