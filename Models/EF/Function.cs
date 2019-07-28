namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Function
    {
        [StringLength(50)]
        public string ID { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        [StringLength(50)]
        public string Description { get; set; }

        [Required]
        [StringLength(250)]
        public string Text { get; set; }

        [Required]
        [StringLength(250)]
        public string Link { get; set; }

        [Required]
        [StringLength(10)]
        public string Target { get; set; }

        public int Order { get; set; }

        [StringLength(50)]
        public string CssClass { get; set; }

        public bool IsLocked { get; set; }

        public bool IsDeleted { get; set; }

        [StringLength(50)]
        public string ParentID { get; set; }

        public DateTime CreatedDate { get; set; }

        [Required]
        [StringLength(20)]
        public string CreatedBy { get; set; }

        public DateTime? UpdatedDate { get; set; }

        [StringLength(20)]
        public string UpdatedBy { get; set; }
    }
}
