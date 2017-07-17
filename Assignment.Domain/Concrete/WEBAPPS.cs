using Assignment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Domain.Concrete
{
    public class WEBAPPS : DbContext
    {
        public DbSet<Customer> Customers { get; set; }
    }
}
