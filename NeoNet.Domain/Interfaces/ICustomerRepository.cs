using NeoNet.Domain.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoNet.Domain.Interfaces
{// aqui puedes añadir a parte de las búsquedas básicas por entity (id, etc.. ) pues controles custom, en este caso mail
    public interface ICustomerRepository : IRepository<Customer>
    {
        Customer GetByEmail(string email);
    }
}
