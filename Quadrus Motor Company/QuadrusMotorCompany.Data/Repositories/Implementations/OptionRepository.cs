using QuadrusMotorCompany.Data.Repositories.Generics;
using QuadrusMotorCompany.Data.Repositories.Interfaces;
using QuadrusMotorCompany.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Data.Repositories.Implementations
{
    public class OptionRepository : GenericRepository<Option>, IOptionRepository
    {
        public Option GetById(Guid id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Option> GetOptions()
        {
            throw new NotImplementedException();
        }

        public Option CreateOption(Option optionToCreate)
        {
            throw new NotImplementedException();
        }

        public Option UpdateOption(Option optionToUpdate)
        {
            throw new NotImplementedException();
        }
    }
}
