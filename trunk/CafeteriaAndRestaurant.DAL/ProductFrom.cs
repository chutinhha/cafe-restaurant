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
    
    public partial class ProductFrom
    {
        public ProductFrom()
        {
            this.Categories = new HashSet<Category>();
        }
    
        public int ProductFromId { get; set; }
        public string ProductFromName { get; set; }
        public string ProductFromDescription { get; set; }
    
        public virtual ICollection<Category> Categories { get; set; }
    }
}