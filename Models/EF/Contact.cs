namespace Models.EF
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Contact
    {
        [Key]
        [Column(Order = 0)]
        [StringLength(50)]
        public string ID { get; set; }

        [Key]
        [Column(Order = 1)]
        [StringLength(250)]
        public string Title { get; set; }

        [Column(TypeName = "ntext")]
        public string ContentHtml { get; set; }

        [StringLength(10)]
        public string LanguageCode { get; set; }

        [Key]
        [Column(Order = 2)]
        public bool Status { get; set; }
    }
}
