namespace Myntra.Models
{
    public class Address
    {
        public int Id { get; set; }
        public string UserId { get; set; }

        public string Name { get; set; }
        public string Phone { get; set; }

        public string Line1 { get; set; }
        public string Line2 { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Country { get; set; } = "India";
        public string Pincode { get; set; }

        public double? Lat { get; set; }
        public double? Lng { get; set; }
        public bool IsDefault { get; set; }
    }
}
