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
    
    public partial class Product
    {
        public Product()
        {
            this.BillDetails = new HashSet<BillDetail>();
        }
    
        public int ProductId { get; set; }
        public string ProductName { get; set; }
        public string ProductUnit { get; set; }
        public double OriginalPrice { get; set; }
        public int CategoryId { get; set; }
        public string Description { get; set; }
    
        public virtual ICollection<BillDetail> BillDetails { get; set; }
        public virtual Category Category { get; set; }
    }
}