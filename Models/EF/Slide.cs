namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Slide
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [StringLength(250)]
        public string Link { get; set; }

        [Required]
        [StringLength(250)]
        public string Images { get; set; }

        public int Order { get; set; }

        [Required]
        [StringLength(50)]
        public string GroupID { get; set; }

        public bool Status { get; set; }
    }
}
