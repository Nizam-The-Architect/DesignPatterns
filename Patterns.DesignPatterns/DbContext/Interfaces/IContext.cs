using Patterns.NullDesignPattern.Contracts.Models;

namespace Patterns.NullDesignPattern.DbContext.Interfaces
{
    public interface IContext
    {
        List<Product> GetProducts();
    }
}