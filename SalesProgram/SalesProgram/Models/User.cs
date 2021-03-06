using System;
using System.Collections.Generic;

namespace SalesProgram.Models
{
    public partial class User
    {
        public User()
        {
            this.Contacts = new List<Contact>();
            this.Products = new List<Product>();
            this.Sales = new List<Sale>();
        }

        public int UserID { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string PIN { get; set; }
        public byte[] Picture { get; set; }
        public Nullable<System.DateTime> DateOfBirth { get; set; }
        public virtual ICollection<Contact> Contacts { get; set; }
        public virtual ICollection<Product> Products { get; set; }
        public virtual ICollection<Sale> Sales { get; set; }
    }
}
