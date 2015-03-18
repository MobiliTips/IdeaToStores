using Motip.Resources.Model.Enums;

namespace Motip.Resources.Model
{
    public abstract class PlaceData : AddressData
    {
        public virtual string Name { get; set; }
        public virtual PlaceType Type { get; set; }
        public virtual double? Score { get; set; }
    }
}
