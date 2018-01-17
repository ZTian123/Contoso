using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Contoso.Model.Common;

namespace Contoso.Model
{
    public class People: AuditableEntity
    {
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public DateTime? DateOfBirth { get; set; }
        //public Nullable<DateTime> DateOfBirth { get; set; }
        public string Email { get; set; }
        public string Phone { get; set; }
        public string AddressLine1 { get; set; }
        public string AddressLine2 { get; set; }
        public string UnitOrApartmentNumber { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public string ZipCode { get; set; }
        public string Password { get; set; }
        public string Salt { get; set; }
        public bool IsLocked { get; set; }
        public DateTime? LastLockedDateTime { get; set; }
        public int FailedAttempts { get; set; }


        //used for PersonRules table
        public ICollection<Role> Roles { get; set; }
    }
}
