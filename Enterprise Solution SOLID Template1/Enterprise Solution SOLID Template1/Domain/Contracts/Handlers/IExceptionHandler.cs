using System;
namespace Enterprise_Solution_SOLID_Template1.Domain.Contracts.Handlers
{
    public interface IExceptionHandler
    {
        T FromUnsafeFunction<T>(Func<T> unsafeFunction);
    }
}
