using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoNet.Domain.Interfaces
{
    /// <summary>
    /// Repositorio generico, Tentity se define como clase genérica < T > del tipo Entidad donde T es la clase derivada de entityclass ej: 
    /// clase customer en la app
    /// (yo me entiendo)
    /// </summary>
 
    public interface IRepository<TEntity> : IDisposable where TEntity : class
    {
        void Add(TEntity obj);
        TEntity GetById(Guid id);
        IQueryable<TEntity> GetAll();
        void Update(TEntity obj);
        void Remove(Guid id);
        int SaveChanges();
    }
}
