using System;

namespace HGPS.Core.Models
{
    public class LocationModel
    {
        public int Id { get; set; }
        public System.Guid Guid { get; set; }
        public string LocationName { get; set; }
        public string Description { get; set; }
        public int Type { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string Zip { get; set; }
        public string Phone { get; set; }
        public string Website { get; set; }
        public string Email { get; set; }
        public string Facebook { get; set; }
        public string Twitter { get; set; }
        public string Coupon { get; set; }
        public string Latitude { get; set; }
        public string Longitude { get; set; }
        public int PremiumLevel { get; set; }
        public Nullable<int> CustomerId { get; set; }
        public int IsActive { get; set; }
    }
}