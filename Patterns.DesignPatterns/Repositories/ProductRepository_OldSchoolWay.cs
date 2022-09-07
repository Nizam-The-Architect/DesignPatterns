using Patterns.NullDesignPattern.Contracts.Interfaces;
using Patterns.NullDesignPattern.DbContext.Interfaces;
using Patterns.NullDesignPattern.Repositories.Interfaces;
namespace Patterns.NullDesignPattern.Repositories
{
    public class ProductRepository_OldSchoolWay : IProductRepository_OldSchoolWay
    {
        private readonly IContext _context;
        public ProductRepository_OldSchoolWay(IContext context)
        {
            _context = context;
        }
        public IProduct? GetProductById(int ProductId)
        {
            IProduct? product = _context.GetProducts().FirstOrDefault(p => p.ProductId == ProductId);
            return product;
        }
    }

}
