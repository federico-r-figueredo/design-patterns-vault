using InitialVersion.Business.Models;
using InitialVersion.Business.Validators;

namespace InitialVersion.Business {
    internal class UserProcessor {
        private SocialSecurityNumberValidator socialSecurityNumberValidator;

        internal UserProcessor() {
            this.socialSecurityNumberValidator = new SocialSecurityNumberValidator();
        }

        internal bool Register(User user) {
            if (!this.socialSecurityNumberValidator.Validate(user.SocialSecurityNumber, user.CitizenshipRegion)) {
                return false;
            } else if (user.Age < 18) {
                return false;
            } else if (user.Name.Length <= 1) {
                return false;
            } else if (user.CitizenshipRegion.TwoLetterISORegionName == "NO") {
                return false;
            } else {
                return true;
            }
        }
    }
}