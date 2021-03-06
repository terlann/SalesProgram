using System;
using System.Collections.Generic;

namespace SalesProgram.Models
{
    public partial class SalesDetail
    {
        public int Salesid { get; set; }
        public int Productsid { get; set; }
        public Nullable<decimal> Amount { get; set; }
        public Nullable<decimal> Unit { get; set; }
        public virtual Product Product { get; set; }
        public virtual Sale Sale { get; set; }
    }
}
