using System;
using System.Collections.Generic;

namespace SalesProgram.Models
{
    public partial class Company
    {
        public Company()
        {
            this.Contacts = new List<Contact>();
            this.Products = new List<Product>();
            this.Sales = new List<Sale>();
        }

        public int CompanyID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
