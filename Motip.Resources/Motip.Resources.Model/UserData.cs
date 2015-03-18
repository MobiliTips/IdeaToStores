using System;
using Motip.Resources.Model.Enums;

namespace Motip.Resources.Model
{
    public abstract class UserData : AddressData
    {
        public virtual string FirstName { get; set; }
        public virtual string LastName { get; set; }
        public virtual string Username { get; set; }
        public virtual string Email { get; set; }
        public virtual GenderType Gender { get; set; }
        public virtual DateTimeOffset BirthDate { get; set; }
    }
}
