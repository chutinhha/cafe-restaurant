//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CafeteriaAndRestaurant.DAL
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        public Bill()
        {
            this.BillDetails = new HashSet<BillDetail>();
        }
    
        public int BillId { get; set; }
        public System.DateTime CreatedDate { get; set; }
        public string BillDescription { get; set; }
        public Nullable<double> Total { get; set; }
    
        public virtual ICollection<BillDetail> BillDetails { get; set; }
    }
}