using Patterns.NullDesignPattern.Contracts.Interfaces;
namespace Patterns.NullDesignPattern.Repositories.Interfaces
{
    public interface IProductRepository
    {
        IProduct GetProductById(int ProductId);
    }
}
