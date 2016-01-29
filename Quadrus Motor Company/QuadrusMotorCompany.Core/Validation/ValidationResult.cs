using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Core.Validation
{
    public class ValidationResult
    {
        private readonly List<ValidationError> errors = new List<ValidationError>();

        public virtual bool IsValid
        {
            get { return errors.Count == 0; }
        }

        public ValidationResult(IEnumerable<ValidationError> failures)
        {
            errors.AddRange(failures.Where(error => error != null));
        }

        public IList<ValidationError> Errors
        {
            get { return errors; }
        }
    }
}
