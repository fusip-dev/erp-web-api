using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ORG.FSIP.ERP.Core.DAL.Entities;

namespace ORG.FSIP.ERP.Core.DAL.Providers.SqlServer.EntityTypeConfiguration
{
    public class CustomFields : IEntityTypeConfiguration<CustomField>
    {
        public void Configure(EntityTypeBuilder<CustomField> builder)
        {
            builder.Property(e => e.Id).HasDefaultValueSql("(newsequentialid())");

            builder.Property(e => e.CustomFieldValidationRules).HasColumnType("text");

            builder.Property(e => e.CustomFieldDefaultValue)
                .HasColumnType("text")
                .HasDefaultValueSql("('')");

            builder.Property(e => e.CustomFieldDescription)
                .HasColumnType("text");

            builder.Property(e => e.Created)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");

            builder.Property(e => e.Modified)
                .HasColumnType("datetime")
                .HasDefaultValueSql("(getdate())");
        }
    }
}
