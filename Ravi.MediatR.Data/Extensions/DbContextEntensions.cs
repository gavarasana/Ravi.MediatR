using Ravi.MediatR.Data.Abstractions.Entities;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System;

namespace Ravi.MediatR.Data.Extensions
{
    public static class DbContextEntensions
    {
        public static void AddAuditInfo(this Microsoft.EntityFrameworkCore.DbContext dbContext)
        {
            var entries = dbContext.ChangeTracker.Entries().Where(e => e.Entity is BaseEntity && (e.State is EntityState.Added || e.State is EntityState.Modified));

            foreach(var entry in entries)
            {
                var currentUtcDateTime = DateTime.UtcNow;
                if (entry.State is EntityState.Added)
                {
                    ((BaseEntity)entry.Entity).CreatedAt = currentUtcDateTime;
                }
                ((BaseEntity)entry.Entity).UpdatedAt = currentUtcDateTime;
            }
        }
    }
}
