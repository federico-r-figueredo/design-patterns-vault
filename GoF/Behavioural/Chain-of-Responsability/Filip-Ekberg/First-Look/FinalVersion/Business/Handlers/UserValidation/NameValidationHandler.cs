using FinalVersion.Business.Exceptions;
using FinalVersion.Business.Models;

namespace FinalVersion.Business.Handlers.UserValidation {
    internal class NameValidationHandler : Handler<User> {
        public override void Handle(User request) {
            if (request.Name.Length <= 1) {
                throw new UserValidationException("Your name is unlikely this short.");
            }

            base.Handle(request);
        }
    }
}