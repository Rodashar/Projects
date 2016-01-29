using Enterprise_Solution_SOLID_Template1.Domain.Contracts.Factories;
using Enterprise_Solution_SOLID_Template1.Domain.Contracts.Handlers;
using Enterprise_Solution_SOLID_Template1.Domain.Contracts.Managers;
using Enterprise_Solution_SOLID_Template1.Domain.Contracts.Repositories;
using Enterprise_Solution_SOLID_Template1.Domain.Contracts.Validators;
using Enterprise_Solution_SOLID_Template1.Domain.Entities;

namespace Enterprise_Solution_SOLID_Template1.Business.Core.Managers
{
    public class ProductManager : IProductManager
    {
        private readonly IExceptionHandler _exceptionHandler;
        private readonly IProductValidator _productValidator;
        private readonly IProductRepository _productRepository;
        private readonly IProductFactory _productFactory;


        public ProductManager(
            IExceptionHandler exceptionHandler,
            IProductValidator productValidator,
            IProductRepository productRepository,
            IProductFactory productFactory)
        {
            _exceptionHandler = exceptionHandler;
            _productValidator = productValidator;
            _productRepository = productRepository;
            _productFactory = productFactory;
        }

        public Product Add(string name)
        {
            if (_productValidator.IsValidName(name) == false)
                return null;

            var product = _productFactory.Create(name);

            return _exceptionHandler.FromUnsafeFunction(() =>
                _productRepository.Create(product));
        }
    }
}
