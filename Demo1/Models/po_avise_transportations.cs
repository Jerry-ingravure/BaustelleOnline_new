namespace Demo1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class po_avise_transportations
    {
        [Key]
        public Guid uid { get; set; }

        public Guid? po_avise_request_uid { get; set; }

        public string transportation_id { get; set; }

        [Column(TypeName = "date")]
        public DateTime? delivery_date { get; set; }

        public string clock_timing { get; set; }

        public string number { get; set; }

        public string means_of_transportation { get; set; }

        public string material { get; set; }

        public string state { get; set; }
    }
}
