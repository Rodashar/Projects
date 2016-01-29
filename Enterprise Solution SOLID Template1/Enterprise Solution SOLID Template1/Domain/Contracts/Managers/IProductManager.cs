using Enterprise_Solution_SOLID_Template1.Domain.Entities;
namespace Enterprise_Solution_SOLID_Template1.Domain.Contracts.Managers
{
    public interface IProductManager
    {
        Product Add(string name);
    }
}