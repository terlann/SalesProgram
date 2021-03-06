using System;
using System.Collections.Generic;

namespace SalesProgram.Models
{
    public partial class Sale
    {
        public Sale()
        {
            this.SalesDetails = new List<SalesDetail>();
        }

        public int SalesID { get; set; }
        public Nullable<int> Categoriesid { get; set; }
        public Nullable<int> Companyid { get; set; }
        public Nullable<int> Userid { get; set; }
        public System.DateTime SalesDate { get; set; }
        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
        public virtual ICollection<SalesDetail> SalesDetails { get; set; }
    }
}
