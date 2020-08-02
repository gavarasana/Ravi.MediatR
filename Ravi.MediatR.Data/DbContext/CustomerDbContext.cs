using Microsoft.EntityFrameworkCore;
using Ravi.MediatR.Data.Abstractions.Entities;
using Ravi.MediatR.Data.Extensions;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Ravi.MediatR.Data.DbContext
{
    public class CustomerDbContext : Microsoft.EntityFrameworkCore.DbContext
    {
        public DbSet<CustomerEntity>    Customers { get; set; }
        public CustomerDbContext(DbContextOptions<CustomerDbContext> dbContextOptions) : base(dbContextOptions)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
        }

        public override int SaveChanges()
        {
            this.AddAuditInfo();
            return base.SaveChanges();
        }

        public override Task<int> SaveChangesAsync(CancellationToken cancellationToken = default)
        {
            this.AddAuditInfo();
            return base.SaveChangesAsync(cancellationToken);
        }
    }
}
