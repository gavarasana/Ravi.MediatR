using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ravi.MediatR.Data.Abstractions.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ravi.MediatR.Data.EntityConfigurations
{
    public abstract class BaseEntityConfiguration<TEntity> : IEntityTypeConfiguration<TEntity> where TEntity : BaseEntity
    {
        public BaseEntityConfiguration(string tableName, string schemaName = "dbo")
        {
            TableName = tableName;
            SchemaName = schemaName;
        }

        public string TableName { get; }
        public string SchemaName { get; }

        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.ToTable(TableName, SchemaName);
            builder.Property(b => b.CreatedAt).HasColumnName("CreatedAt").IsRequired();
            builder.Property(b => b.UpdatedAt).HasColumnName("UpdatedAt").IsRequired();
        }
    }
}
