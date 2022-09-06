using Patterns.NullDesignPattern.Contracts.Models;
using Patterns.NullDesignPattern.DbContext.Interfaces;

namespace Patterns.NullDesignPattern.DbContext
{
    /// <summary>
    /// Dummy object used to represent the database.
    /// </summary>
    public class Context : IContext
    {
        /// <summary>
        /// Return static list of Products, mock the database.
        /// </summary>
        /// <returns></returns>
        public List<Product> GetProducts()
        {
            return new List<Product> {
            new Product(30000) { ProductId=1, ProductName="Mobile"},
            new Product(70000) { ProductId=2, ProductName="Tv"},
            new Product(90000) { ProductId=3, ProductName="Laptop"}
        };
        }
    }
}
