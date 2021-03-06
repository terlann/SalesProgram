using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SalesProgram.Models.Mapping
{
    public class SaleMap : EntityTypeConfiguration<Sale>
    {
        public SaleMap()
        {
            // Primary Key
            this.HasKey(t => t.SalesID);

            // Properties
            // Table & Column Mappings
            this.ToTable("Sales");
            this.Property(t => t.SalesID).HasColumnName("SalesID");
            this.Property(t => t.Categoriesid).HasColumnName("Categoriesid");
            this.Property(t => t.Companyid).HasColumnName("Companyid");
            this.Property(t => t.Userid).HasColumnName("Userid");
            this.Property(t => t.SalesDate).HasColumnName("SalesDate");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Sales)
                .HasForeignKey(d => d.Companyid);
            this.HasOptional(t => t.User)
                .WithMany(t => t.Sales)
                .HasForeignKey(d => d.Userid);

        }
    }
}
