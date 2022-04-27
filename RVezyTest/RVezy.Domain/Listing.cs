using System.Collections.Generic;

namespace RVezyTest.Domain
{
    public class Listing
    {
        public int Id { get; set; }
        public string ListingUrl { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string PropertyType { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
        public List<Calendar> Calendars { get; set; } = new List<Calendar>();

    }
}
