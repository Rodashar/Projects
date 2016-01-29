using System;

namespace Enterprise_Solution_SOLID_Template1.Domain.Contracts.Repositories
{
    public interface ILogger
    {
        void LogException(Exception ex);
    }
}
