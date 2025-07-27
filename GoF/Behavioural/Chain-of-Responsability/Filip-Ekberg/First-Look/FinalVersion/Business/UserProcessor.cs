using FinalVersion.Business.Exceptions;
using FinalVersion.Business.Handlers.UserValidation;
using FinalVersion.Business.Models;

namespace FinalVersion.Business {
    internal class UserProcessor {
        internal bool Register(User user) {
            SocialSecurityNumberValidatorHandler handler =
                new SocialSecurityNumberValidatorHandler();
            handler.SetNext(new AgeValidationHandler())
                .SetNext(new NameValidationHandler())
                .SetNext(new CitizenshipRegionValidationHandler());

            try {
                handler.Handle(user);
            } catch (UserValidationException) {
                return false;
            }

            return true;
        }
    }
}