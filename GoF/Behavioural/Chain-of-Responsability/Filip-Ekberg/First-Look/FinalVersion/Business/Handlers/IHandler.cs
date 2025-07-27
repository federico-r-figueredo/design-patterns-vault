
namespace FinalVersion.Business.Handlers {
    internal interface IHandler<T> where T : class {
        IHandler<T> SetNext(IHandler<T> next);
        void Handle(T request);
    }
}