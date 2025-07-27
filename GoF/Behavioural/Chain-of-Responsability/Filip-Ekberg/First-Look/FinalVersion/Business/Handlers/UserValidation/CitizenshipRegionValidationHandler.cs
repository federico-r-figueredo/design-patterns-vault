using FinalVersion.Business.Exceptions;
using FinalVersion.Business.Models;

namespace FinalVersion.Business.Handlers.UserValidation {
    internal class CitizenshipRegionValidationHandler : Handler<User> {
        public override void Handle(User request) {
            if (request.CitizenshipRegion.TwoLetterISORegionName == "NO") {
                throw new UserValidationException("We currently don't support Norwegians.");
            }

            base.Handle(request);
        }
    }
}