using System;

namespace RVezyTest.Domain
{
    public class Calendar
    {
        public int Id { get; set; }
        public DateTime Date { get; set; }
        public bool Available { get; set; }
        public Decimal Price { get; set; }
        public Listing Listing { get; set; }
        public int ListingId { get; set; }
    }
}
