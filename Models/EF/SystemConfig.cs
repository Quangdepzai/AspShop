namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class SystemConfig
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [Required]
        [StringLength(50)]
        public string UniqueKey { get; set; }

        [Required]
        [StringLength(250)]
        public string Value { get; set; }

        [Required]
        [StringLength(50)]
        public string Unit { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(20)]
        public string CreatedBy { get; set; }

        public DateTime UpdatedDate { get; set; }

        [Required]
        [StringLength(20)]
        public string UpdatedBy { get; set; }

        public bool IsDeleted { get; set; }
    }
}
