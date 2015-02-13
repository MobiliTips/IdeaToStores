using Motip.Resources.Model.Enums;

namespace Motip.Resources.Model
{
    public abstract class PlaceData
    {
        public virtual string Name { get; set; }
        public virtual PlaceType Type { get; set; }
        public virtual double Latitude { get; set; }
        public virtual double Longitude { get; set; }
    }
}
