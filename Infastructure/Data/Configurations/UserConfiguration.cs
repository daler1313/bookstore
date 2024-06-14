using Domain.Entity;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Infastructure.Data.Configurations
{
    public class UserConfiguration : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(u => u.Id);
            builder.Property(u => u.Name)
                .HasMaxLength(120)
                .IsRequired();
            builder.Property(u => u.Email)
                .HasMaxLength(120)
                .IsRequired();
            builder.Property(u => u.PhoneNumber)
                .HasMaxLength(120)
                .IsRequired();
        }
    }
}
