using Domin.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Entity_Configuration_Fluent_API_
{
    public class PropertyConfiguration
    {
        public void Configure(EntityTypeBuilder<Property> builder)
        {
            builder.HasKey(p => p.Id);

            builder.Property(p => p.Title)
                   .IsRequired()
                   .HasMaxLength(200);

            builder.Property(p => p.Price)
                   .HasColumnType("decimal(18,2)");

            builder.HasOne(p => p.Landlord)
                   .WithMany(u => u.Properties)
                   .HasForeignKey(p => p.LandlordId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
