﻿using Assignment.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Assignment.Domain.Abstract
{
    public interface ICustomerRepository
    {
        void SaveCustomer(Customer customer);
    }
}
