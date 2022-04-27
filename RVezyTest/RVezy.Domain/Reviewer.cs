using System.Collections.Generic;

namespace RVezyTest.Domain
{
    public class Reviewer
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Review> Reviews { get; set; } = new List<Review>();
    }
}
