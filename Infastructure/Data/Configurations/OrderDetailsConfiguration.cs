using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infastructure.Data.Configurations
{
    public class OrderDetailsConfiguration : IEntityTypeConfiguration<OrderDetails>
    {
        public void Configure(EntityTypeBuilder<OrderDetails> builder)
        {
            builder.HasKey(o => o.Id);
            builder.Property(o => o.Quantity)
                .IsRequired();
            builder.Property(o => o.TotalPrice)
                .IsRequired();
            builder.HasOne(b => b.Books)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(b => b.BookId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(or => or.Orders)
                .WithMany(o => o.OrderDetails)
                .HasForeignKey(or => or.OrderId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
