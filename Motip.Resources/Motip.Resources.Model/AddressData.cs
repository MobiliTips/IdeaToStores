namespace Motip.Resources.Model
{
    public class AddressData
    {
        public virtual string StreetNumber { get; set; }
        public virtual string StreetLine1 { get; set; }
        public virtual string StreetLine2 { get; set; }
        public virtual string StreetLine3 { get; set; }
        public virtual string StreetLine4 { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Country { get; set; }
        public virtual double Latitude { get; set; }
        public virtual double Longitude { get; set; }
    }
}
