using Enterprise_Solution_SOLID_Template1.Domain.Entities;
namespace Enterprise_Solution_SOLID_Template1.Domain.Contracts.Validators
{
    public interface IProductValidator : IValidator<Product>
    {
        bool IsValidName(string name);
    }
}
