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
    
    public partial class po_avise_requests
    {
        public System.Guid uid { get; set; }
        public string po_no { get; set; }
        public Nullable<System.DateTime> point_in_time { get; set; }
        public string item_no { get; set; }
        public string item_description { get; set; }
        public string off_loading_advise { get; set; }
        public string ordered_by { get; set; }
        public string state { get; set; }
    }
}