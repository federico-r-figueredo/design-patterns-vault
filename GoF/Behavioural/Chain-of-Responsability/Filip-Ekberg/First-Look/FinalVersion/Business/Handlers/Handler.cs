
namespace FinalVersion.Business.Handlers {
    internal abstract class Handler<T> : IHandler<T> where T : class {
        private IHandler<T> next;

        public virtual void Handle(T request) {
            next?.Handle(request);
        }

        public IHandler<T> SetNext(IHandler<T> next) {
            this.next = next;
            return this.next;
        }
    }
}