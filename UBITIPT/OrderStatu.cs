//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace UBITIPT
{
    using System;
    using System.Collections.Generic;
    
    public partial class OrderStatu
    {
        public int Id { get; set; }
        public string Status { get; set; }
        public int CustomerId { get; set; }
        public int ProductId { get; set; }
        public int BranchId { get; set; }
    
        public virtual Branch Branch { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Product Product { get; set; }
    }
}
