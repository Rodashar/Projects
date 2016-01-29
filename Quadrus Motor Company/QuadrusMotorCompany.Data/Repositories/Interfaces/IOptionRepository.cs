using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Data.Repositories.Interfaces
{
    public interface IOptionRepository
    {
        Option GetById(Guid id);
        IEnumerable<Option> GetOptions();
        Option CreateOption(Option optionToCreate);
        Option UpdateOption(Option optionToUpdate);
    }
}
