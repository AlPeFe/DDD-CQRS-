using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using System;
using System.Collections.Generic;
using System.Text;

namespace NeoNet.Infra.Data.Context
{
    public class NeoNetContextFactory : IDesignTimeDbContextFactory<NeoNetContext>
    {
        public NeoNetContext CreateDbContext(string[] args)
        {
            var optionsBuilder = new DbContextOptionsBuilder<NeoNetContext>();
            optionsBuilder.UseSqlServer("Data Source=blog.db");

            return new NeoNetContext();
        }
    }
}
