using Domin.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Infrastructure.Entity_Configuration_Fluent_API_
{
    internal class LeaseConfiguration
    {
    public void Configure(EntityTypeBuilder<Lease> builder)
        {
            builder.HasKey(l => l.Id);

            builder.HasOne(l => l.Property)
                   .WithMany(p => p.Leases)
                   .HasForeignKey(l => l.PropertyId);

            builder.HasOne(l => l.Tenant)
                   .WithMany(u => u.LeasesAsTenant)
                   .HasForeignKey(l => l.TenantId)
                   .OnDelete(DeleteBehavior.Restrict);
        }
    }
}
