using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RVezyTest.WebAPI.Models
{
    public class Listing
    {
        public int id { get; set; }
        public string listing_url { get; set; }
        public string name { get; set; }
        public string description { get; set; }
        public string property_type { get; set; }
    }
}
