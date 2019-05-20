using System;
using System.Collections.Generic;
using System.Text;

namespace NeoNet.Domain.Interfaces
{
    public interface IUnitOfWork : IDisposable
    {
        bool Commit();
    }
}
