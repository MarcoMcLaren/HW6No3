//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace HW6No3.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class stocks
    {
        public int store_id { get; set; }
        public int product_id { get; set; }
        public Nullable<int> quantity { get; set; }
    
        public virtual products products { get; set; }
        public virtual stores stores { get; set; }
    }
}