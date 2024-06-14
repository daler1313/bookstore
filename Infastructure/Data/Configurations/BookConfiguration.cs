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
    public class BookConfiguration : IEntityTypeConfiguration<Book>
    {
        public void Configure(EntityTypeBuilder<Book> builder)
        {
            builder.HasKey(b => b.Id);
            builder.Property(b => b.Title)
                .IsRequired();
            builder.Property(b => b.Description)
                .IsRequired();
            builder.HasOne(a => a.Authors)
                .WithMany(b => b.Books)
                .HasForeignKey(a => a.AuthorId)
                .OnDelete(DeleteBehavior.Cascade);
            builder.HasOne(g => g.Genres)
                .WithMany(b => b.Books)
                .HasForeignKey(g => g.GenreId)
                .OnDelete(DeleteBehavior.Cascade);
        }
    }
}
