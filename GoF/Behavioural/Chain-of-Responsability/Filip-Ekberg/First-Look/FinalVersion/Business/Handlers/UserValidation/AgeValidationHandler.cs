using FinalVersion.Business.Exceptions;
using FinalVersion.Business.Models;

namespace FinalVersion.Business.Handlers.UserValidation {
    internal class AgeValidationHandler : Handler<User> {
        public override void Handle(User request) {
            if (request.Age < 18) {
                throw new UserValidationException("You have to be at least 18 years or older.");
            }

            base.Handle(request);
        }
    }
}