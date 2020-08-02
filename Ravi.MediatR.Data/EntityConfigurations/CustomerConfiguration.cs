using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Ravi.MediatR.Data.Abstractions.Entities;

namespace Ravi.MediatR.Data.EntityConfigurations
{
    public class CustomerConfiguration : BaseEntityConfiguration<CustomerEntity>
    {
        public CustomerConfiguration() : base("Customer")
        {

        }

        public override void Configure(EntityTypeBuilder<CustomerEntity> builder)
        {
            base.Configure(builder);
            
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Id).HasColumnName("Key").HasDefaultValueSql("newId()");
            builder.Property(b => b.Name).HasColumnName("Name").HasMaxLength(255)
                .IsRequired();
            builder.Property(b => b.Age).HasColumnName("Age").IsRequired();
            builder.Property(b => b.Address).HasColumnName("Address").HasMaxLength(255).IsRequired();
            builder.Property(b => b.Email).HasColumnName("Email").HasMaxLength(255).IsRequired();
            builder.Property(b => b.PhoneNumber).HasColumnName("PhoneNumber").HasMaxLength(20);            
        }
    }
}
