//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace PSD_LabProject_GymMe.Model
{
    using System;
    using System.Collections.Generic;
    
    public partial class MsCart
    {
        public int CartId { get; set; }
        public int UserId { get; set; }
        public int SupplementId { get; set; }
        public int Quantity { get; set; }
    
        public virtual MsSupplement MsSupplement { get; set; }
        public virtual MsUser MsUser { get; set; }
    }
}
