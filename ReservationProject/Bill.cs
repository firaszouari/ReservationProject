//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ReservationProject
{
    using System;
    using System.Collections.Generic;
    
    public partial class Bill
    {
        public string Bill_id { get; set; }
        public int An { get; set; }
        public string Guest_id { get; set; }
        public Nullable<System.DateTime> DateBill { get; set; }
        public Nullable<decimal> TotalCost { get; set; }
    }
}