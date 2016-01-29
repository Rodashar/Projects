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
            return FindFirstOrDefault(x => x.Id == id);
        }

        public IEnumerable<Option> GetOptions()
        {
            return GetAll();
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
