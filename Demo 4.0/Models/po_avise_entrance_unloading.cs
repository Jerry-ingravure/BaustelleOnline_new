//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace Demo_4._0.Models
{
    using System;
    using System.Collections.Generic;
    
    public partial class po_avise_entrance_unloading
    {
        public System.Guid uid { get; set; }
        public Nullable<System.Guid> fk_po_avise_request_uid { get; set; }
        public string ordered_by { get; set; }
        public string unloading_location { get; set; }
        public string type_of_verhicle { get; set; }
        public Nullable<System.DateTime> arrival_time { get; set; }
        public Nullable<double> dur { get; set; }
        public string status { get; set; }
    
        public virtual po_avise_requests po_avise_requests { get; set; }
    }
}