using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace PITP.Models
{
    [Table("Funder")]
    public partial class Funder
    {
        public int Id { get; set; }

        [Required]
        [StringLength(50)]
        public string transactionID { get; set; }

        [Column(TypeName = "money")]
        public decimal? sAmountPaid { get; set; }

        [StringLength(50)]
        public string deviceID { get; set; }

        [Column(" payerEmail")]
        [StringLength(50)]
        public string C_payerEmail { get; set; }

        [StringLength(50)]
        public string Item { get; set; }

        public bool stayAnon { get; set; }
        [DataType(DataType.Time)]
        public DateTime submitTime { get; set; }
    }
}