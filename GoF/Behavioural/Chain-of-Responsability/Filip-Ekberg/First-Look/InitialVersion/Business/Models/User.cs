using System;
using System.Globalization;

namespace InitialVersion.Business.Models {
    internal class User {
        private string name;
        private string socialSecurityNumber;
        private DateTimeOffset dateOfBirth;
        private RegionInfo citizenshipRegion;

        internal User(string name, string socialSecurityNumber,
            DateTimeOffset dateOfBirth, RegionInfo citizenshipRegion) {
            this.name = name;
            this.socialSecurityNumber = socialSecurityNumber;
            this.dateOfBirth = dateOfBirth;
            this.citizenshipRegion = citizenshipRegion;
        }

        internal string Name {
            get { return this.name; }
        }

        internal string SocialSecurityNumber {
            get { return this.socialSecurityNumber; }
        }

        internal DateTimeOffset DateOfBirth {
            get { return this.dateOfBirth; }
        }

        internal RegionInfo CitizenshipRegion {
            get { return this.citizenshipRegion; }
        }

        // This will get the age right..most of the time!
        internal int Age {
            get { return (int)((DateTimeOffset.UtcNow - this.DateOfBirth.UtcDateTime).TotalDays / 365.2425); }
        }
    }
}