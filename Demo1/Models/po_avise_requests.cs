namespace Demo1.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class po_avise_requests
    {
        [Key]
        public Guid uid { get; set; }

  
        [Column(TypeName = "date")]
        public DateTime? point_in_time { get; set; }

        public string item_no { get; set; }

        public string item_description { get; set; }

        [StringLength(10)]
        public string off_loading_advise { get; set; }

        public string ordered_by { get; set; }

        public string state { get; set; }
    }
}
