using System;
using System.Collections.Generic;

namespace SalesProgram.Models
{
    public partial class Contact
    {
        public int ContactID { get; set; }
        public Nullable<int> Userid { get; set; }
        public Nullable<int> Companyid { get; set; }
        public string Address { get; set; }
        public string TelephoneNumber1 { get; set; }
        public string TelephoneNumber2 { get; set; }
        public string TelephoneNumber3 { get; set; }
        public string Mail { get; set; }
        public string Fax { get; set; }
        public virtual Company Company { get; set; }
        public virtual User User { get; set; }
    }
}
