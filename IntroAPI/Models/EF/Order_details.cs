//------------------------------------------------------------------------------
// <auto-generated>
//    This code was generated from a template.
//
//    Manual changes to this file may cause unexpected behavior in your application.
//    Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace IntroAPI.Models.EF
{
    using System;
    using System.Collections.Generic;
    
    public partial class Order_details
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public int ProductId { get; set; }
        public int Quantity { get; set; }
        public int Unitprice { get; set; }
    
        public virtual Order Order { get; set; }
        public virtual Product Product { get; set; }
    }
}
