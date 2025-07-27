using System;

namespace FinalVersion.Business.Exceptions {
    internal class UserValidationException : Exception {
        internal UserValidationException(string message) : base(message) { }
    }
}