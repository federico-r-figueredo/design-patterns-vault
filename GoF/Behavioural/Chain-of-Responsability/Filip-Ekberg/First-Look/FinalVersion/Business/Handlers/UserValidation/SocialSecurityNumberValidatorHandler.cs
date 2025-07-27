using FinalVersion.Business.Exceptions;
using FinalVersion.Business.Models;
using FinalVersion.Business.Validators;

namespace FinalVersion.Business.Handlers.UserValidation {
    internal class SocialSecurityNumberValidatorHandler : Handler<User> {
        private SocialSecurityNumberValidator socialSecurityNumberValidator;

        internal SocialSecurityNumberValidatorHandler() {
            this.socialSecurityNumberValidator = new SocialSecurityNumberValidator();
        }

        public override void Handle(User request) {
            if (!this.socialSecurityNumberValidator.Validate(request.SocialSecurityNumber,
                request.CitizenshipRegion)) {
                throw new UserValidationException("Social Security Number couldn't be validated.");
            }

            base.Handle(request);
        }
    }
}