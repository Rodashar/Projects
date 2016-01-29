using Enterprise_Solution_SOLID_Template1.Domain.Entities;

namespace Enterprise_Solution_SOLID_Template1.Domain.Contracts.Factories
{
    public interface IProductFactory
    {
        Product Create(string name);
    }
}
