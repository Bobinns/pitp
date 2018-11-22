namespace PITP.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("ppal")]
    public partial class ppal
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int formuserid { get; set; }

        [StringLength(50)]
        public string transactionId { get; set; }

        [Column(TypeName = "money")]
        public decimal sAmountPaid { get; set; }

        public bool paid { get; set; }

        public virtual formuser formuser { get; set; }
    }
}
