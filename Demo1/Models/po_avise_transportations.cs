//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo1.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class po_avise_transportations
    {
        public System.Guid uid { get; set; }
        public Nullable<System.Guid> po_avise_request_uid { get; set; }
        public string transportation_id { get; set; }
        public Nullable<System.DateTime> delivery_date { get; set; }
        public string clock_timing { get; set; }
        public string number { get; set; }
        public string means_of_transportation { get; set; }
        public string material { get; set; }
        public string state { get; set; }
    }
}