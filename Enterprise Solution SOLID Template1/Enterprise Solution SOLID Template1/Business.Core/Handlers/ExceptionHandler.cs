using Enterprise_Solution_SOLID_Template1.Domain.Contracts.Handlers;
using Enterprise_Solution_SOLID_Template1.Domain.Contracts.Repositories;
using System;

namespace Enterprise_Solution_SOLID_Template1.Business.Core.Handlers
{
    public class ExceptionHandler : IExceptionHandler
    {
        private readonly ILogger _logger;

        public ExceptionHandler(ILogger logger)
        {
            _logger = logger;
        }

        public T FromUnsafeFunction<T>(Func<T> unsafeFunction)
        {
            try
            {
                return unsafeFunction.Invoke();
            }
            catch (Exception ex)
            {
                _logger.LogException(ex);
            }
            return default(T);
        }
    }
}
