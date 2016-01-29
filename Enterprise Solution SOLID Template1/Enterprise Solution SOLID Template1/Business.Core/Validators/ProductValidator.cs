using Enterprise_Solution_SOLID_Template1.Domain.Contracts.Validators;
using Enterprise_Solution_SOLID_Template1.Domain.Entities;

namespace Enterprise_Solution_SOLID_Template1.Business.Core.Validators
{
    public class ProductValidator : IProductValidator
    {
        public bool IsValidName(string name)
        {
            if (string.IsNullOrEmpty(name)) return false;

            return true;
        }

        public bool IsValid(Product entity)
        {
            if (entity == null) return false;
            if (entity.Price != null && !IsValidName(entity.Name)) return false;

            return true;
        }
    }
}
