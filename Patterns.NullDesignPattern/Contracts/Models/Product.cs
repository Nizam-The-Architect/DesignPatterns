using Patterns.NullDesignPattern.Contracts.Interfaces;
namespace Patterns.NullDesignPattern.Contracts.Models
{
    public class Product : IProduct
    {
        public Product(double price)
        {
            _price = price;
        }
        public int ProductId { get; set; }
        public string ProductName { get; set; } = String.Empty;
        double _price;
        public double GetPrice() => _price;
        /// <summary>
        /// Always false for a real product
        /// </summary>
        public bool IsNull => false;
    }
}