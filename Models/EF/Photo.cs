namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Photo
    {
        public long ID { get; set; }

        [Required]
        [StringLength(250)]
        public string Title { get; set; }

        [StringLength(250)]
        public string Images { get; set; }

        public long AlbumID { get; set; }

        [StringLength(250)]
        public string Description { get; set; }

        public DateTime? CreatedDate { get; set; }

        [StringLength(50)]
        public string CreatedBy { get; set; }

        public bool? Status { get; set; }
    }
}
