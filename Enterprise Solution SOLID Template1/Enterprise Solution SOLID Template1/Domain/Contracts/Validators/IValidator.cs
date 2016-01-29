using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enterprise_Solution_SOLID_Template1.Domain.Contracts.Validators
{
    public interface IValidator<T>
    {
        bool IsValid(T entity);
    }
}
