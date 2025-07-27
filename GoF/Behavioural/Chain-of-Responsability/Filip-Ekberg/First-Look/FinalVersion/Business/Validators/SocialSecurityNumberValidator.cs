using System.Globalization;
using FinalVersion.Business.Exceptions;

namespace FinalVersion.Business.Validators {
    internal class SocialSecurityNumberValidator {
        internal bool Validate(string socialSecurityNumber, RegionInfo regionInfo) {
            switch (regionInfo.TwoLetterISORegionName) {
                case "SE": {
                        return ValidateSwedishSocialSecurityNumber(socialSecurityNumber);
                    }
                case "US": {
                        return ValidateUnitedStatesSocialSecurityNumber(socialSecurityNumber);
                    }
                default: {
                        throw new UnsupportedSocialSecurityNumberException();
                    }
            }
        }

        private bool ValidateSwedishSocialSecurityNumber(string socialSecurityNumber) {
            // Not actually how it's done...
            return socialSecurityNumber.Length > 1;
        }

        private bool ValidateUnitedStatesSocialSecurityNumber(string socialSecurityNumber) {
            // Not actually how it's done...
            return socialSecurityNumber.Length > 2;
        }
    }
}