using System;
using Motip.Resources.Model.Enums;

namespace Motip.Resources.Model
{
    public abstract class UserData
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        public virtual string StreetNumber { get; set; }
        public virtual string StreetLine1 { get; set; }
        public virtual string StreetLine2 { get; set; }
        public virtual string StreetLine3 { get; set; }
        public virtual string StreetLine4 { get; set; }
        public virtual string PostalCode { get; set; }
        public virtual string City { get; set; }
        public virtual string State { get; set; }
        public virtual string Country { get; set; }
        public virtual GenderType Gender { get; set; }
        public virtual DateTimeOffset BirthDate { get; set; }
    }
}
