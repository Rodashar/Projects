using Microsoft.VisualStudio.TestTools.UnitTesting;
using Enterprise_Solution_SOLID_Template1.Business.Core.Managers;
using Enterprise_Solution_SOLID_Template1.CrossCutting.TestHelpers;
using Enterprise_Solution_SOLID_Template1.Domain.Contracts.Validators;
using Should;

namespace Business.Core.Tests.Managers
{
    [TestClass]
    public class ProductManagerTests : TestsFor<ProductManager>
    {
        [TestMethod, TestCategory(ProductTestCategories.Validators)]
        public void Add_ProductNameIsInvalid_ResultIsNull()
        {
            // Arrange
            GetMockFor<IProductValidator>()
                .Setup(o => o.IsValidName(AnyKindOf.String)).Returns(false);

            // Act            
            var result = Instance.Add("coca-cola");

            // Assert   
            result.ShouldBeNull();
        }
    }
}
