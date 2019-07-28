namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class UserActivityLog
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50)]
        public string ActionName { get; set; }

        public DateTime ActionDate { get; set; }

        [Required]
        [StringLength(50)]
        public string IPAddress { get; set; }

        [Required]
        [StringLength(50)]
        public string SessionID { get; set; }

        [Required]
        [StringLength(20)]
        public string UserName { get; set; }
    }
}
