using System;

namespace RVezyTest.Domain
{
    public class Review
    {
        public int Id { get; set; }
        public DateTime ReviewDate { get; set; }
        public Reviewer Reviewer { get; set; }
        public int ReviewerId { get; set; }
        public string Comments { get; set; }
        public Listing Listing { get; set; }
        public int ListingId { get; set; }
    }
}
