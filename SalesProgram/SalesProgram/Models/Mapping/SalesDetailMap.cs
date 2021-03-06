using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SalesProgram.Models.Mapping
{
    public class SalesDetailMap : EntityTypeConfiguration<SalesDetail>
    {
        public SalesDetailMap()
        {
            // Primary Key
            this.HasKey(t => new { t.Salesid, t.Productsid });

            // Properties
            this.Property(t => t.Salesid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            this.Property(t => t.Productsid)
                .HasDatabaseGeneratedOption(DatabaseGeneratedOption.None);

            // Table & Column Mappings
            this.ToTable("SalesDetails");
            this.Property(t => t.Salesid).HasColumnName("Salesid");
            this.Property(t => t.Productsid).HasColumnName("Productsid");
            this.Property(t => t.Amount).HasColumnName("Amount");
            this.Property(t => t.Unit).HasColumnName("Unit");

            // Relationships
            this.HasRequired(t => t.Product)
                .WithMany(t => t.SalesDetails)
                .HasForeignKey(d => d.Productsid);
            this.HasRequired(t => t.Sale)
                .WithMany(t => t.SalesDetails)
                .HasForeignKey(d => d.Salesid);

        }
    }
}
