namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Permission
    {
        public int ID { get; set; }

        [Required]
        [StringLength(20)]
        public string GroupID { get; set; }

        [Required]
        [StringLength(50)]
        public string RoleID { get; set; }

        [Required]
        [StringLength(50)]
        public string FunctionID { get; set; }
    }
}
