using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SalesProgram.Models.Mapping
{
    public class ProductMap : EntityTypeConfiguration<Product>
    {
        public ProductMap()
        {
            // Primary Key
            this.HasKey(t => t.ProductID);

            // Properties
            this.Property(t => t.Barcode)
                .HasMaxLength(50);

            this.Property(t => t.Name)
                .HasMaxLength(50);

            this.Property(t => t.Description)
                .HasMaxLength(2000);

            this.Property(t => t.Unit)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Products");
            this.Property(t => t.ProductID).HasColumnName("ProductID");
            this.Property(t => t.Barcode).HasColumnName("Barcode");
            this.Property(t => t.Name).HasColumnName("Name");
            this.Property(t => t.Description).HasColumnName("Description");
            this.Property(t => t.Categoryid).HasColumnName("Categoryid");
            this.Property(t => t.Companyid).HasColumnName("Companyid");
            this.Property(t => t.PurchasePrice).HasColumnName("PurchasePrice");
            this.Property(t => t.SalesPrice).HasColumnName("SalesPrice");
            this.Property(t => t.EDVRate).HasColumnName("EDVRate");
            this.Property(t => t.EDVAmount).HasColumnName("EDVAmount");
            this.Property(t => t.Unit).HasColumnName("Unit");
            this.Property(t => t.Stok).HasColumnName("Stok");
            this.Property(t => t.CreatedDate).HasColumnName("CreatedDate");
            this.Property(t => t.CreatedByUserid).HasColumnName("CreatedByUserid");
            this.Property(t => t.Status).HasColumnName("Status");

            // Relationships
            this.HasOptional(t => t.Category)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.Categoryid);
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.Companyid);
            this.HasOptional(t => t.User)
                .WithMany(t => t.Products)
                .HasForeignKey(d => d.CreatedByUserid);

        }
    }
}
