using QuadrusMotorCompany.Core.Validation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace QuadrusMotorCompany.Business.Messages.Generics
{
    public class ServiceResponse<T>
    {
        public List<ValidationResult> ValidationResults { get; private set; }

        public ServiceResponse(ValidationResult validationResult)
        {
            if (ValidationResults == null)
            {
                ValidationResults = new List<ValidationResult>();
            }

            ValidationResults.Clear();
            ValidationResults.Add(validationResult);
        }

        public ServiceResponse(List<ValidationResult> validationResults)
        {
            ValidationResults = validationResults;
        }

        public bool IsResponseSuccessfull
        {
            get { return ValidationResults == null || (!ValidationResults.Exists(x => !x.IsValid)); }
        }

        public ServiceResponse(T item)
            : this(new ValidationResult(Enumerable.Empty<ValidationError>()))
        {
            Response = item;
        }

        public ServiceResponse(T item, ValidationSuccess successResult)
            : this(new ValidationResult(Enumerable.Empty<ValidationError>()))
        {
            SuccessResult = successResult;
            Response = item;
        }

        public ValidationSuccess SuccessResult { get; set; }

        public T Response
        {
            get;
            private set;
        }
    }
}
