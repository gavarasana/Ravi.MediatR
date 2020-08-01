using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ravi.MediatR.Data.Abstractions.Entities;

namespace Ravi.MediatR.Data.EntityConfigurations
{
    public class CustomerConfiguration : IEntityTypeConfiguration<CustomerEntity>
    {
        public void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            builder.ToTable("Customer");
        }
    }
}
