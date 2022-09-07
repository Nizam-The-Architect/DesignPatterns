using Patterns.NullDesignPattern.Contracts.Interfaces;
namespace Patterns.NullDesignPattern.Repositories.Interfaces
{
    public interface IProductRepository_OldSchoolWay
    {
        IProduct? GetProductById(int ProductId);
    }
}
