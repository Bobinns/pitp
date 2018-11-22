using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace PITP.Models
{
    public class ChartViewModel
    {
        public string totalAbove { get; set; }
        public string totalBelow { get; set; }
        public List<Sponsor> sponsorOver { get; set; }
    }
}