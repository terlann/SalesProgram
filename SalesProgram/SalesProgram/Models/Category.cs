using System;
using System.Collections.Generic;

namespace SalesProgram.Models
{
    public partial class Category
    {
        public Category()
        {
            this.Products = new List<Product>();
        }

        public int CategoryID { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public Nullable<bool> Status { get; set; }
        public virtual ICollection<Product> Products { get; set; }
    }
}
