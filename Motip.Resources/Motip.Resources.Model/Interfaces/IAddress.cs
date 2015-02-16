namespace Motip.Resources.Model.Interfaces
{
    public interface IAddress
    {
        string StreetNumber { get; set; }
        string StreetLine1 { get; set; }
        string StreetLine2 { get; set; }
        string StreetLine3 { get; set; }
        string StreetLine4 { get; set; }
        string PostalCode { get; set; }
        string City { get; set; }
        string State { get; set; }
        string Country { get; set; }
    }
}
