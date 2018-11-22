namespace PITP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("formuser")]
    public partial class formuser
    {
        public int ID { get; set; }

        [StringLength(50)]
        public string Message { get; set; }

        [Required]
        [StringLength(50)]
        public string Name { get; set; }

        public DateTime SubmitTime { get; set; }

        public virtual ppal ppal { get; set; }
    }
}
