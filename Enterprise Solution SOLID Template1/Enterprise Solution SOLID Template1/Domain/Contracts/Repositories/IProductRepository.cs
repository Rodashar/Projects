using Enterprise_Solution_SOLID_Template1.Domain.Entities;

namespace Enterprise_Solution_SOLID_Template1.Domain.Contracts.Repositories
{
    public interface IProductRepository
    {
        Product Create(Product demo);
    }
}
