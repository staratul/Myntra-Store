namespace Myntra.Models
{
    public class Shipment
    {
        public int Id { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }

        public string Awb { get; set; }
        public string Courier { get; set; }
        public string Status { get; set; }

        public string TrackingDataJson { get; set; }
        public string LabelUrl { get; set; }
    }
}
