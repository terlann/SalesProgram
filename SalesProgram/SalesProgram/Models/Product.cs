using System;
using System.Collections.Generic;

namespace SalesProgram.Models
{
    public partial class Product
    {
        public Product()
        {
            this.SalesDetails = new List<SalesDetail>();
        }

        public int ProductID { get; set; }
        public string Barcode { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<int> Categoryid { get; set; }
        public Nullable<int> Companyid { get; set; }
        public Nullable<decimal> PurchasePrice { get; set; }
        public Nullable<decimal> SalesPrice { get; set; }
        public Nullable<decimal> EDVRate { get; set; }
        public Nullable<decimal> EDVAmount { get; set; }
        public string Unit { get; set; }
        public Nullable<int> Stok { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<int> CreatedByUserid { get; set; }
        public Nullable<bool> Status { get; set; }
        public virtual Category Category { get; set; }
        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
