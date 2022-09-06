using Patterns.NullDesignPattern.Contracts.Interfaces;
using Patterns.NullDesignPattern.Contracts.Models;
using Patterns.NullDesignPattern.DbContext.Interfaces;
using Patterns.NullDesignPattern.Repositories.Interfaces;
namespace Patterns.NullDesignPattern.Repositories
{
    public class ProductRepository : IProductRepository
    {
        private readonly IContext _context;
        public ProductRepository(IContext context)
        {
            _context = context;
        }
        public IProduct GetProductById(int ProductId)
        {
            IProduct product = _context.GetProducts().FirstOrDefault(p => p.ProductId == ProductId);
            product ??= new NullProduct();
            return product;
        }
    }

}
