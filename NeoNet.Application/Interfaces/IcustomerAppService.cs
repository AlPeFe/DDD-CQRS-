using NeoNet.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoNet.Application.Interfaces
{
    public interface ICustomerAppService : IDisposable
    {
        CustomerViewModel GetById(Guid id);

        void Update(CustomerViewModel customerViewModel);

        void Remove(Guid id);
    }
}
