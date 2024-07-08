using Core.Entities.Concrete;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataAccess.Configs
{
    public class PersonConfig : IEntityTypeConfiguration<Person>
    {
        public void Configure(EntityTypeBuilder<Person> builder)
        {
            builder.ToTable("Person"); // Tablo ismi belirleme

            // Primary key
            builder.HasKey(p => p.Id);

            // Properties
            builder.Property(p => p.FirstName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.LastName)
                .IsRequired()
                .HasMaxLength(50);

            builder.Property(p => p.Age)
                .IsRequired()
                .HasDefaultValue(0)
                .HasMaxLength(120);

            builder.Property(p => p.Email)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.PhoneNumber)
                .HasMaxLength(15);

            builder.Property(p => p.Address)
                .IsRequired()
                .HasMaxLength(100);

            builder.Property(p => p.DateOfBirth)
                .IsRequired();

            builder.Property(p => p.Gender)
                .HasMaxLength(10);
        }
    }
}
