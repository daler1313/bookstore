using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infastructure.Data.Configurations
{
    public class OrderConfiguration : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Status)
                .IsRequired();
            builder.HasOne(u => u.Users)
                .WithMany(o => o.Orders)
                .HasForeignKey(u => u.UserId)
                .OnDelete(DeleteBehavior.Cascade);

        }
    }
}
