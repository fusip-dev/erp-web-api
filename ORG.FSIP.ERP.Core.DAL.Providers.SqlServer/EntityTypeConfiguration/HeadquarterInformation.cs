using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ORG.FSIP.ERP.Core.DAL.Entities;

namespace ORG.FSIP.ERP.Core.DAL.Providers.SqlServer.EntityTypeConfiguration
{
    public class HeadquarterInformation : IEntityTypeConfiguration<Entities.HeadquarterInformation>
    {
        public void Configure(EntityTypeBuilder<Entities.HeadquarterInformation> builder)
        {
            builder.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            builder.Property(e => e.Value)
                .HasColumnType("text");

            builder.Property(e => e.StartDate)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.EndDate).HasColumnType("datetime");

            builder.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}
