using Microsoft.EntityFrameworkCore;
using NeoNet.Domain.Interfaces;
using NeoNet.Infra.Data.Context;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace NeoNet.Infra.Data.Repository
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        protected readonly NeoNetContext Db;
        protected readonly DbSet<TEntity> DbSet;

        public Repository(NeoNetContext context)
        {
            Db = context;
            DbSet = Db.Set<TEntity>();
        }
        public void Add(TEntity obj)
        {
            DbSet.Add(obj);
        }

        public void Dispose()
        {
            Db.Dispose();
            GC.SuppressFinalize(this);
        }

        public IQueryable<TEntity> GetAll()
        {
            throw new NotImplementedException();
        }

        public TEntity GetById(Guid id)
        {
            return DbSet.Find(id);
        }

        public void Remove(Guid id)
        {
            throw new NotImplementedException();
        }

        public int SaveChanges()
        {
            return Db.SaveChanges();
        }

        public void Update(TEntity obj)
        {
            throw new NotImplementedException();
        }
    }
}
