﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ORG.FSIP.ERP.Core.DAL.Entities;

namespace ORG.FSIP.ERP.Core.DAL.Providers.SqlServer.EntityTypeConfiguration
{
    public class PeriodStates : IEntityTypeConfiguration<PeriodState>
    {
        public void Configure(EntityTypeBuilder<PeriodState> builder)
        {
            builder.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            builder.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}
