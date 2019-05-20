using Microsoft.EntityFrameworkCore;
using NeoNet.Domain.Interfaces;
using NeoNet.Domain.Models;
using NeoNet.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Text;
using System.Linq;

namespace NeoNet.Infra.Data.Repository
{
    public class CustomerRepository : Repository<Customer>, ICustomerRepository
    {
        public CustomerRepository(NeoNetContext context) 
            : base(context)
        {

        }

        public Customer GetByEmail(string email)
        {
            return DbSet.AsNoTracking().FirstOrDefault(c => c.Email == email);
        }

    }
}
