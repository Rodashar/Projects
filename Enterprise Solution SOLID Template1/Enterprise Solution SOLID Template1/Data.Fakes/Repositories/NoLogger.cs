using System;
using Enterprise_Solution_SOLID_Template1.Domain.Contracts.Repositories;
#if DEBUG
using System.Diagnostics;
#endif

namespace Data.Fakes.Repositories
{
    public class NoLogger : ILogger
    {
        public void LogException(Exception ex)
        {
#if DEBUG
            Debug.WriteLine(ex.Message);
#endif
        }

    }
}
