using System.ComponentModel.DataAnnotations.Schema;
using System.Data.Entity.ModelConfiguration;

namespace SalesProgram.Models.Mapping
{
    public class ContactMap : EntityTypeConfiguration<Contact>
    {
        public ContactMap()
        {
            // Primary Key
            this.HasKey(t => t.ContactID);

            // Properties
            this.Property(t => t.Address)
                .HasMaxLength(1000);

            this.Property(t => t.TelephoneNumber1)
                .HasMaxLength(50);

            this.Property(t => t.TelephoneNumber2)
                .HasMaxLength(50);

            this.Property(t => t.TelephoneNumber3)
                .HasMaxLength(50);

            this.Property(t => t.Mail)
                .HasMaxLength(100);

            this.Property(t => t.Fax)
                .HasMaxLength(50);

            // Table & Column Mappings
            this.ToTable("Contacts");
            this.Property(t => t.ContactID).HasColumnName("ContactID");
            this.Property(t => t.Userid).HasColumnName("Userid");
            this.Property(t => t.Companyid).HasColumnName("Companyid");
            this.Property(t => t.Address).HasColumnName("Address");
            this.Property(t => t.TelephoneNumber1).HasColumnName("TelephoneNumber1");
            this.Property(t => t.TelephoneNumber2).HasColumnName("TelephoneNumber2");
            this.Property(t => t.TelephoneNumber3).HasColumnName("TelephoneNumber3");
            this.Property(t => t.Mail).HasColumnName("Mail");
            this.Property(t => t.Fax).HasColumnName("Fax");

            // Relationships
            this.HasOptional(t => t.Company)
                .WithMany(t => t.Contacts)
                .HasForeignKey(d => d.Companyid);
            this.HasOptional(t => t.User)
                .WithMany(t => t.Contacts)
                .HasForeignKey(d => d.Userid);

        }
    }
}
